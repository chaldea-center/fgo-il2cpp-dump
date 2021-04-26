import argparse
from pathlib import Path
from zipfile import ZipFile
from typing import Union


FILES_TO_EXTRACT = [
    "assets/bin/Data/Managed/Metadata/global-metadata.dat",
    "lib/arm64-v8a/libil2cpp.so",
]


def main(input_dump: Union[str, Path], output_folder: Union[str, Path]) -> None:
    output = Path(output_folder).resolve()
    output.mkdir(parents=True, exist_ok=True)

    with ZipFile(input_dump, "r") as apk:
        for extract_file in FILES_TO_EXTRACT:
            with apk.open(extract_file) as extract:
                with open(output / extract_file.split("/")[-1], "wb") as fp:
                    fp.write(extract.read())


if __name__ == "__main__":
    parser = argparse.ArgumentParser(
        description="Extract enums valus from the dump.cs file."
    )
    parser.add_argument("input", type=str, help="Path to the apk file")
    parser.add_argument("output", type=str, help="Path to the output folder")
    args = parser.parse_args()

    main(args.input, args.output)
