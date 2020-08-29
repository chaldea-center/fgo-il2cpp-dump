import argparse
import subprocess
from pathlib import Path


def main(input_folder: str, il2cppdumper: str) -> None:
    input_path = Path(input_folder).resolve()
    for folder in input_path.iterdir():
        if folder.is_dir():
            if (folder / "global-metadata.dat").exists() and (
                folder / "libil2cpp.so"
            ).exists():
                print(folder)
                p = subprocess.Popen(
                    [
                        il2cppdumper,
                        str(folder / "libil2cpp.so"),
                        str(folder / "global-metadata.dat"),
                        str(folder),
                    ],
                    stdin=subprocess.PIPE,
                    shell=True,
                )
                p.communicate(input=b"a\n")


if __name__ == "__main__":
    parser = argparse.ArgumentParser(
        description="Extract enums valus from the dump.cs file."
    )
    parser.add_argument("input", type=str, help="Path to the dumps folder")
    parser.add_argument(
        "il2cppdumper", type=str, help="Path to Il2CppDumper executable"
    )
    args = parser.parse_args()

    main(args.input, args.il2cppdumper)
