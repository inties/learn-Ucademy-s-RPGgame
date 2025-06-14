# myRPG Unity项目

这是一个使用Unity 2022.3.51f1c1开发的RPG游戏项目。

## 系统要求

- Unity 2022.3.51f1c1 或更高版本
- Windows 10/11（推荐）
- 至少8GB RAM
- 2GB可用磁盘空间

## 如何开始

### 1. 克隆项目
```bash
git clone <项目地址>
cd myRPG
```

### 2. 安装Unity
- 下载并安装 [Unity Hub](https://unity3d.com/get-unity/download)
- 通过Unity Hub安装Unity 2022.3.51f1c1版本

### 3. 打开项目
- 打开Unity Hub
- 点击"添加"按钮
- 选择项目文件夹
- 确认Unity版本匹配后点击项目名称打开

### 4. 等待导入完成
- Unity会自动重新导入所有资源
- 这个过程可能需要几分钟，请耐心等待
- 导入完成后项目就可以正常使用了

## 项目结构

- `Assets/` - 游戏资源和脚本
- `ProjectSettings/` - Unity项目设置
- `Packages/` - 包管理器依赖

## 注意事项

- 首次打开项目时，Unity会重新生成Library文件夹，这是正常现象
- 如果遇到编译错误，请检查Unity版本是否正确
- 所有必要的包依赖都已配置在Packages/manifest.json中

## 故障排除

如果项目无法正常打开：
1. 确认Unity版本正确
2. 删除Library文件夹（如果存在）并重新打开项目
3. 检查Packages/manifest.json是否完整

## 开发环境

推荐使用以下工具进行开发：
- Visual Studio 2022 或 Visual Studio Code
- Git for Windows 