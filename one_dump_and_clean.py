import argparse
import subprocess
from pathlib import Path

import extract_apk
import clean_dump

from git import Repo


def main(apk_path: str, il2cppdumper: str) -> None:
    parent_folder = Path(__file__).resolve().parent
    code_folder = parent_folder / "code"
    apk_folder = parent_folder / "play_fgo"

    extract_apk.main(apk_path, apk_folder)

    metadata = apk_folder / "global-metadata.dat"
    il2cpp = apk_folder / "libil2cpp.so"
    commands = [
        il2cppdumper,
        str(il2cpp),
        str(metadata),
        str(apk_folder),
    ]
    p = subprocess.Popen(" ".join(commands), stdin=subprocess.PIPE, shell=True)
    p.communicate(input=b"a\n")

    clean_dump.main(apk_folder, code_folder)

    with open(code_folder / "02_stringliteral.txt", encoding="utf-8") as fp:
        string_literal = fp.readlines()

    date = None
    version = None

    for i, line in enumerate(string_literal):
        if line.startswith("2022"):
            date = line.strip()
            date = f"{date[:4]}_{date[4:6]}_{date[6:]}"
            version = string_literal[i - 2].strip()
            break

    if date is not None and version is not None:
        repo = Repo(parent_folder)
        diff = repo.index.diff(None)

        if diff:
            repo.index.add([diff_file.a_path for diff_file in diff])
            commit_message = f"JP {version} {date}"
            print(commit_message)
            repo.index.commit(commit_message)
            repo.remotes[0].push()


if __name__ == "__main__":
    parser = argparse.ArgumentParser(
        description="Extract enums valus from the dump.cs file."
    )
    parser.add_argument("apk", type=str, help="Path to the apk file")
    parser.add_argument(
        "il2cppdumper", type=str, help="Path to Il2CppDumper executable"
    )
    args = parser.parse_args()

    main(args.apk, args.il2cppdumper)
