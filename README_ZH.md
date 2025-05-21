# FBX Mesh Extractor for Unity

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## 概述

FBX Mesh Extractor 是一款 Unity 編輯器擴充工具，能夠快速從 FBX 檔案中提取所有 Mesh 資源，並將其儲存為獨立的資產檔案。這個工具對於需要單獨存取和操作模型網格的開發者特別有用。

![Screenshot 2025-05-21 155503](https://github.com/user-attachments/assets/5583421a-d5be-48f1-bdf5-59c0d0b18746)

## 功能特色

- 從任意 FBX 檔案中提取所有 Mesh 資源
- 簡單易用的編輯器介面操作
- 可自訂輸出資料夾位置
- 自動建立缺少的資料夾
- 支援批次提取並儲存所有 Mesh

## 安裝方式

### 方式一：使用 Unity 套件

1. 下載最新的 Unity 套件發行檔
2. 在 Unity 編輯器中，前往 Assets > Import Package > Custom Package
3. 選擇剛剛下載的套件檔案
4. 確認所有檔案都已勾選，然後點擊 Import

### 方式二：手動安裝

1. 複製或下載本專案
2. 將 `FbxMeshExtractor.cs` 檔案複製到你的 Unity 專案中的 `Assets/Editor` 資料夾
   （如果沒有 Editor 資料夾請自行建立）

## 使用方法

1. 在 Unity 編輯器中，前往 Tools > BY Utils > FBX Mesh Extractor
2. 在彈出的編輯器視窗中，將目標 FBX 檔案拖曳到 Target FBX 欄位
3. （可選）設定輸出資料夾路徑，或使用瀏覽按鈕選擇
4. 點擊「Extract All Meshes」按鈕
5. 所有 Mesh 資源將會被提取並儲存到指定的輸出資料夾

## 授權

本專案採用 MIT 授權條款，詳情請參閱 [LICENSE](LICENSE) 檔案

## 貢獻

歡迎提出 Issue 或 Pull Request，您的貢獻將讓這個工具更加完善！
