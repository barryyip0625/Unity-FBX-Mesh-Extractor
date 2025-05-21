# FBX Mesh Extractor for Unity

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) [![Readme_ZH](https://img.shields.io/badge/UnityFBXMeshExtractor-%E4%B8%AD%E6%96%87%E6%96%87%E6%AA%94-red)](https://github.com/barryyip0625/Unity-FBX-Mesh-Extractor/blob/main/README_ZH.md)

## Overview

FBX Mesh Extractor is a Unity editor extension tool that allows you to quickly extract all mesh assets from FBX files and save them as independent asset files. This tool is particularly useful for developers who need to access and manipulate model meshes individually.

![Screenshot 2025-05-21 155503](https://github.com/user-attachments/assets/5583421a-d5be-48f1-bdf5-59c0d0b18746)

## Features

- Extract all mesh assets from any FBX file
- Simple editor interface operation
- Customizable output folder location
- Automatic creation of missing folders
- Batch extraction and saving of all meshes

## Installation

### Option 1: Using Unity Package

1. Download the latest Unity Package release
2. In Unity Editor, go to Assets > Import Package > Custom Package
3. Select the downloaded package file
4. Make sure all files are selected and click Import

### Option 2: Manual Installation

1. Clone or download this repository
2. Copy the `FbxMeshExtractor.cs` file to the `Assets/Editor` folder in your Unity project
   (create the Editor folder if it doesn't exist)

## Usage

1. In Unity Editor, go to Tools > BY Utils > FBX Mesh Extractor
2. In the popup editor window, drag and drop your target FBX file to the Target FBX field
3. (Optional) Set the output folder path or use the browse button to select it
4. Click the "Extract All Meshes" button
5. All mesh assets will be extracted and saved to the specified output folder

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Contributing

Issues and pull requests are welcome. Your contributions will help make this tool better!
