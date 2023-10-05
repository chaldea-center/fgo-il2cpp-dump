import argparse
import re
import subprocess
import urllib.parse
from datetime import datetime
from pathlib import Path

import httpx
from git import Repo

import clean_dump
import extract_apk


def get_play_store_ver() -> str:
    return httpx.get(
        "https://gplay-ver.atlasacademy.workers.dev/?id=com.aniplex.fategrandorder"
    ).text


def get_literal_lines(code_folder: Path) -> set[str]:
    with open(code_folder / "02_stringliteral.txt", "r", encoding="utf-8") as fp:
        return {line.strip() for line in fp.readlines()}


def find_correct_verCode(code_folder: Path, old_literal_lines: set[str]) -> str:
    lines = get_literal_lines(code_folder)
    diff_lines = lines - old_literal_lines
    for line in diff_lines:
        if re.match(r"^[a-z0-9]{64}$", line) is not None:
            return line

    raise Exception("Can't find correct verCode")


def write_verCode(code_folder: Path, old_literal_lines: set[str]) -> None:
    current_version = get_play_store_ver()
    correct_verCode = find_correct_verCode(code_folder, old_literal_lines)
    with open(code_folder / "00_verCode.txt", "w", encoding="utf-8") as fp:
        data = {"appVer": current_version, "verCode": correct_verCode}
        urlencoded = urllib.parse.urlencode(data)
        fp.write(urlencoded)


def main(apk_path: str, il2cppdumper: str) -> None:
    parent_folder = Path(__file__).resolve().parent
    code_folder = parent_folder / "code"
    apk_folder = parent_folder / "play_fgo"

    old_literal_lines = get_literal_lines(code_folder)

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

    for line in string_literal:
        if line.startswith(str(datetime.now().year)) and ":" in line:
            date = line.strip()
            date = f"{date[:4]}_{date[4:6]}_{date[6:]}"
            break

    write_verCode(code_folder, old_literal_lines)

    if date is not None:
        repo = Repo(parent_folder)
        diff = repo.index.diff(None)

        if diff:
            repo.index.add([diff_file.a_path for diff_file in diff])
            commit_message = f"JP {date}"
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
