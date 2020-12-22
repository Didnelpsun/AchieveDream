# 项目规范文件

## 命名规范

camelCase：小驼峰式命名
PascalCase：帕斯卡式命名
kebab-case：短横线式命名
UnderScoreCase：下划线式命名
FUnderScorePascalCase：首字符为_的帕斯卡式命名
UnderScorePascalCase：以_连接的帕斯卡式命名
lowercase：全小写格式
UPCASE：全大写格式

### Files文件

+ Models层：PascalCase
+ Pages与Templates：PascalCase
+ 页面CSS样式表：PascalCase
+ 资源CSS样式表：camelCase
+ 资源图片：kebab-case

### C#文件

+ 类：PascalCase
+ 普通方法：PascalCase
+ ASP交互方法：UnderScorePascalCase（ASP元素_事件）
+ 变量：camelCase
+ 私有变量：FUnderScorePascalCase
+ 参数：camelCase
+ 常量：UPCASE

### ASP文件

+ 元素ID：PascalCase

### CSS文件

+ Class：camelCase
+ Class缩写：lowercase

### 数据库文件

+ 字段：PascalCase
+ C#保存SQL属性：PascalCase

## 格式规范

### C#文件

+ 字段之间不用空行
+ 字段和方法之间需要空行
+ 方法和方法之间需要空行

## SQL语句规范

+ SQL关键字全部大写
+ 字段按照SQL数据库大小写
+ SQL语句后以;结尾

