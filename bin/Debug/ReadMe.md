# 说明文档

## 简介

1. 本工具基于[subconverter](https://github.com/tindy2013/subconverter),用于订阅转换，实现托管订阅，上传到仓库的功能
2. 本质上就是一个拼接字符串的小工具

## 使用教程

### 基本操作

1. 将订阅地址或节点复制到框内，点击转换即可
2. 每个订阅链接（节点）一行

### 制作远程订阅链接（GIST仓库）

1. 首先需要有一个github账号，如何注册这里不阐述
2. 申请一个仓库的Token，点建[创建Token](https://github.com/settings/tokens/new?scopes=gist&description=Subconverter)
3. 申请Token，选择无期限，下拉选中gist，下拉到底点击Generate token
   ![img](https://raw.githubusercontent.com/vveg26/ImageHosting/master/BlogImg/202209102232287.png)
   ![img](https://raw.githubusercontent.com/vveg26/ImageHosting/master/BlogImg/202209102236306.png)

   ![img](https://raw.githubusercontent.com/vveg26/ImageHosting/master/BlogImg/202209102235348.png)
4. 复制这一串Token
   ![img](https://raw.githubusercontent.com/vveg26/ImageHosting/master/BlogImg/202209102237826.png)
5. 打开软件，点击左上角按钮打开配置文件，填入刚刚复制的Token
   ![img](https://raw.githubusercontent.com/vveg26/ImageHosting/master/BlogImg/202209102239972.png)
6. 勾选将文件上传至gist转换即可
