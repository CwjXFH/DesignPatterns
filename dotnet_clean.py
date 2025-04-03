# delete bin & obj

import subprocess
import os
import shutil

result = subprocess.run(
    ["dotnet", "clean"], shell=True, capture_output=True, text=True, encoding="utf8"
)

print("================================dotnet clean================================")
print(result.stdout)

print("================================delete================================")

for root, dirs, files in os.walk(".", topdown=False):
    if "bin" in dirs:
        bin_dir = os.path.join(root, "bin")
        print(f"delete dir: {bin_dir}")
        shutil.rmtree(bin_dir)
    if "obj" in dirs:
        obj_dir = os.path.join(root, "obj")
        print(f"delete dir: {obj_dir}")
        shutil.rmtree(obj_dir)
