import argparse
from pathlib import Path

import extract_apk


def main(input_folder: str, output_folder: str) -> None:
    output = Path(output_folder).resolve()
    output.mkdir(parents=True, exist_ok=True)

    input_path = Path(input_folder).resolve()
    for apk in input_path.iterdir():
        if (
            apk.name.endswith(".apk")
            and apk.name.startswith("Fate Grand Order")
            and "English" not in apk.name
        ):
            version = apk.name.split("_")[-1].replace(".apk", "")[1:].strip()
            output_path = output / version
            print(apk)
            extract_apk.main(apk, output_path)


if __name__ == "__main__":
    parser = argparse.ArgumentParser(
        description="Extract enums valus from the dump.cs file."
    )
    parser.add_argument("input", type=str, help="Path to the apk folder")
    parser.add_argument("output", type=str, help="Path to the output folder")
    args = parser.parse_args()

    main(args.input, args.output)
