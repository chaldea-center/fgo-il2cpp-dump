import argparse
import json
import re
from pathlib import Path
from typing import Dict, Union


bad_line_starts = ("/*", "//", "|", "*/")
bad_line_contains = ("PrivateImplementationDetails", "{}")
enum_re = re.compile(r"\tpublic const [\w\.]+ (\w+) = (\d+);")


def main(input_dump: Union[str, Path], output_dump: Union[str, Path]) -> None:
    input_path = Path(input_dump).resolve()
    output_path = Path(output_dump).resolve()

    with open(input_path / "dump.cs", "r", encoding="utf-8") as fp:
        lines = fp.readlines()

    output_lines = []
    for line in lines:
        if not any(
            [line.strip().startswith(bad_start) for bad_start in bad_line_starts]
            + [bad_contain in line for bad_contain in bad_line_contains]
        ):
            cleaned_line = line.split("//")[0].split("/*")[0].rstrip()
            if not (
                cleaned_line.strip().startswith("[")
                and cleaned_line.strip().endswith("]")
            ):
                cleaned_line = (
                    cleaned_line if cleaned_line.endswith("\n") else cleaned_line + "\n"
                )
                output_lines.append(cleaned_line)

    with open(
        output_path / "01_clean_dump.cs", "w", encoding="utf-8", newline=""
    ) as fp:
        fp.writelines(output_lines)

    enum_lines = []
    is_enum_field = False
    for line in output_lines:
        if is_enum_field:
            if line.startswith("}"):
                enum_lines.append(line + "\n")
                is_enum_field = False
            elif line == "{\n":
                enum_lines.append("{\n")
            elif "public int value__;" not in line:
                matched = enum_re.match(line)
                if matched:
                    name, value = matched.groups()
                    enum_lines.append(f"\t{name} = {value},\n")
        elif " enum " in line:
            enum_lines.append(line)
            is_enum_field = True

    with open(
        output_path / "07_clean_dump_enum.cs", "w", encoding="utf-8", newline=""
    ) as fp:
        fp.writelines(enum_lines)

    with open(input_path / "stringliteral.json", "r", encoding="utf-8") as fp:
        literal_lines = json.load(fp)
    with open(
        output_path / "02_stringliteral.txt", "w", encoding="utf-8", newline=""
    ) as fp:
        fp.writelines(
            [
                item["value"] + "\n"
                for item in literal_lines
                if "\u0000" not in item["value"]
            ]
        )

    with open(input_path / "script.json", "r", encoding="utf-8") as fp:
        script = json.load(fp)

    def remove_address(input_dict: Dict[str, str]) -> Dict[str, str]:
        return {k: v for k, v in input_dict.items() if k != "Address"}

    BAD_METHOD_STARTS = {
        "UnityEngine",
        "System",
        "<>",
        "Firebase",
        "PlayMaker",
        "HutongGames",
        "CriStructMemory",
        "CriMana",
        "FingerEventDetector",
        "GestureRecognizerTS",
        "PlatformSupport",
        "JsonManager",
        "Org.BouncyCastle",
        "LitJson",
        "TweenFOV",
        "XWeaponTrail",
        "Xft",
        "WellFired",
        "UniWebView",
        "ContinuousGestureRecognizer",
        "CriAtom",
        "SimpleAnimation",
        "Mono",
        "Microsoft",
        "DiscreteGestureRecognizer",
        "FingerGestures",
        "TBQuickSetup",
        "CStateManager",
        "GameObjectExtensions",
        "BetterList",
        "NGUITools",
        "UITweener",
        "CFSM",
    }

    def bad_method(method: str) -> bool:
        return any([method.startswith(bad_start) for bad_start in BAD_METHOD_STARTS])

    ScriptMethod = [
        remove_address(item)
        for item in script["ScriptMethod"]
        if not bad_method(item["Name"])
    ]
    ScriptMetadata = [
        remove_address(item)
        for item in script["ScriptMethod"]
        if not bad_method(item["Name"])
    ]
    ScriptString = [
        item["Value"] + "\n"
        for item in script["ScriptString"]
        if "\u0000" not in item["Value"]
    ]
    ScriptMetadataMethod = [
        item["Name"].replace("Method$", "") + "\n"
        for item in script["ScriptMetadataMethod"]
    ]
    ScriptMetadataMethod = [
        item for item in ScriptMetadataMethod if not bad_method(item)
    ]

    for file_name, item in (
        ("04_ScriptMethod.json", ScriptMethod),
        ("05_ScriptMetadata.json", ScriptMetadata),
    ):
        with open(output_path / file_name, "w", encoding="utf-8") as fp:
            json.dump(item, fp, indent=2, ensure_ascii=False)

    for file_name, item in (
        ("03_ScriptString.txt", ScriptString),
        ("06_ScriptMetadataMethod.txt", ScriptMetadataMethod),
    ):
        with open(output_path / file_name, "w", encoding="utf-8", newline="") as fp:
            fp.writelines(item)


if __name__ == "__main__":
    parser = argparse.ArgumentParser(
        description="Extract enums valus from the dump.cs file."
    )
    parser.add_argument("input", type=str, help="Path to the dump.cs folder")
    parser.add_argument("output", type=str, help="Path to the output folder")
    args = parser.parse_args()

    main(args.input, args.output)
