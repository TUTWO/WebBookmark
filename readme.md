
#WebBookmark Commit log


##2016.5.31
1. 修复上传漏洞
2. 更改书签预览页面

##2016.5.7
1. 隐藏无用内容

##2016.5.5
1. 更改邮件发送为SSL
2. 更改系统邮件账号

##2016.4.28
1. 优化上次提交的性能

##2016.4.28
1. 修改推荐书签重复数据问题

##2016.4.27
1. 这次真的做了一点微小的工作而已
2. 修改推荐用户SQL，优化性能

##2016.4.26
1. 做了一点微小的事情
2. 完成了异步control，不知道之前的bug是什么缘故

##2016.4.26
1. 又做了一点微笑的工作
2. 新增书签推荐，书签信息页相关书签推荐
3. 新增异步control，但是在mono上无法正常运行

##2016.4.25
1. 新增点赞信息通知消息、动态

##2016.4.25
1. 新做了一点很微小的工作
2. 新增点赞书签功能，以便下一步的书签推荐
3. 下一步做书签推荐

##2016.4.24
1. 做了一点微小的工作
2. 修改书签在iframe的展示方式，如果主站允许在 frame中展示，则使用 frame展示，否则展示HTML

##2016.4.23
1. 通过导入根证书修复Mono请求HTTPS协议的网页异常的问题；
2. 修复展示书签HTML时，因为页面禁止iframe导致无法加载书签HTML的问题，采用直接获取HTML加载到srcdoc中；


##2016.4.23
1. 完成注册账号激活邮件验证，未激活用户不允许登录

##2016.4.22
1. 新增收藏其他用户书签功能，自动创建默认书签夹
2. 新增用户配置表，用于存放用户配置信息

##2016.4.21
1. 修复一个js Bug

##2016.4.21
1. 完成招呼密码功能限制：找回密码链接24小时内使用，否则失效； 找回密码链接只可使用一次，不可重复使用。
2. 招呼密码提示信息不弹框，使用label显示。

##2016.4.21
1. 完成找回密码功能
2. 完成发送邮件功能

##2016.4.20 
1. 修复获取不到HTTPS页面数据问题，获取不到直接取URL作为标签名
2. x-Frame-Options限制iframe网页嵌套 暂时无解

##2016.4.20 
1. 新增群组消息列表
2. 升级HTTPS，解决HTTPS无法使用快速书签工具问题

##2016.4.18 修复 bug
1. 修复书签首页无法显示书签夹的bug
2. 修复获取不到书签HTML无法显示的bug

##2016.4.17 修复 bug
1. 修复导入数据的bug
2. 修复不勾选用户协议可以注册的bug

##2016.4.17 bug汇集
1. 用户无任何的书签夹无法添加书签，添加书签异常
2. 用户不勾选用户协议同样可以注册成功，此处应修复
3. 显示文件夹数据错误


##2016.4.8
1. 修复添加标签权限问题
2. 隐藏标签列表，暂时没什么必要
3. 代码工作先停一阵了，写论文去了

##2016.4.7
1. 完成添加/删除书签标签功能
2. 添加标签交互有待改进

##2016.4.7
1. 修改网页展示页面标签，使得可直接显示网页
2. 有一次HTTP请求浪费了，考虑删除

##2016.4.7
1. 修改一个小的标签问题

##2016.4.7
1. 修复一个bug

##2016.4.7
1. 书签列表页新增小插件，可拖到浏览器收藏夹成为浏览器书签，用于快速往系统里面添加书签
2. 上面的功能还有点小问题，HTTPS页面添加书签时浏览器会提示运行未知脚本，chrome直接拦截，暂时没有解决方案
3. 下一步完善一下标签功能


##2016.4.6
1. 新增tagInfo两张表，用于记录网页标签
2. 还没完成记录标签，今晚效率有点低
3. 推荐功能基于上面的标签数据
4. 还要做一个小插件功能，尽快排期吧


##2016.4.5
1. 修复bug，之前一个版本的历史遗留
2. 还是修复bug.....


##2016.4.5
1. 新增用户推荐，此版本一次网络请求需要5秒以上，SQL需要优化
2. 推荐内容考虑引入推荐算法，简单实现“协同过滤”就算了（或者不做，优化上面的做法算了）。http://www.infoq.com/cn/articles/recommendation-algorithm-overview-part02
3. 书签推荐还没做，下次做吧。
4. 优化思路:提前生成数据，直接取数据就好

##2016.4.4
1. 修正主页没有消息的时候SQL报错的bug
2. 无动态提示可跳转到【探索/发现】

##2016.4.4
1. 修正主页消息bug
2. 新增主页动态消息类型


##2016.4.4
1. 修正程序集名称

##2016.4.4
1. 新增主页动态显示
2. 新增动态消息生成逻辑，还没完全完成

##2016.4.3
1. 修复Bokmark页面无法点击URL问题

##2016.4.3
1. 新增加入群组申请，新增对应的消息推送。
2. 消息类型：WelcomeToWebBookmark = 0,FollowUser = 1,NewBeFollow = 2,NewBookmarkComment = 3,JoinGroupSuccess = 4,QuitGroupSuccess =5,RemoveGroup = 6,ImportBookmarkSuccess = 7,ImportBookmarkFail = 8,ApplyJoinGroup = 9,RejecrApplyJoinGroup = 10,

##2016.4.3
1. 完成消息页面展示、消息内容展示
2. 新增消息推送来源，在之前的操作添加了对应的消息通知


##2016.4.3
1. 新增消息页面，数据展示还没做
2. 新增添加消息逻辑，修改消息结构



##2016.4.2
1. 修复上一次修改产生的bug（也可能是以前留下来的）


##2016.4.2
1. 修复书签管理页Bug
2. 优化书签管理页操作逻辑

##2016.4.2
1. 完成error页面，以用于收集程序错误信息
2. 完成拦截器逻辑，其中加入权限验证


##2016.4.2
1. 用户状态验证cookie session双保证，有限验证cookie，cookie无效验证session
2. 改代码改了N多...
3. 新加拦截器逻辑，还没做....


##2016.4.1
1. 用户群组、点评功能 基本完成、消息通知、主页推荐、还没开始
2. 优化用户加入群组申请操作，整理JS文件
3. 新增“我的申请”页面，完成数据显示
4. 修改群组页面，更方便使用


##2016.3.31
1. 完成在用户信息页显示群组信息
2. 完成群组信息的成员展示
3. 完成移除群组成员
4. 修复几个bug
5. 整理来一下JS

##2016.3.31
1. 完成加入群组
2. 完成审核成员
3. 修复几个bug
4. 好累.....

##2016.3.31
1. 编辑群组已完成，删除已完成
2. 新增群组信息页，其中群组成员显示已完成、
3. 新增我的群组，我加入的群组，群组消息
4. 我的群组，我加入的群组显示已完成，群组消息还没开始做
5. 好累....


##2016.3.30
1. 编辑群组完成，改了弹出层控件
2. 删除没有做，明天再整吧


##2016.3.30
1. 踩了一个大坑，导致今晚基本没撒工作量
2. 完成新增用户群组，以及用户群组的显示
3. 编辑用户群组功能还没做，UI的坑基本完成了



##2016.3.29
1. 测试一下能不能提交


##2016.3.28
1. 修复书签页评论列表不显示头像的bug
2. 去掉评论标题，感觉很麻烦
3. 书签页头像链接至个人信息页
4. MD，马上就四月了。


##2016.3.28
1. 完成书签评论功能
2. 添加了两张评论表，分别用于记录书签评论数据和书签夹评论数据


##2016.3.27
1. 完成书签页预览
2. 评论还没做.....
3. 晚上做评论功能

##2016.3.27
1. 修复CSSbug，更新Webfolder Grade字段
2. 先提交一次，以免丢失数据
3. 准备做预览HTML页面和评论
4. 希望今天能完成预览以及评论



##2016.3.27
1. 完成用户信息页显示 书签夹、关注者，被关注用户显示
2. 调整用户信息页CSS样式，更美观了
3. 看起来还有一个CSS的bug，明天再看
4. 屏蔽登陆用户信息页关注自己按钮，不允许自己关注自己

##2016.3.26
1. 修正用户书签页交互逻辑，异步加载数据，无需重新刷新页面
2. 修正layer的使用
3. 书签页、书签相关操作全部改成异步加载分部页面，以免重新加载页面

##2016.3.26
1. 修复中文搜索直接挂掉的bug，字段字符集没设置成UTF-8的锅.....
2. 修复书签夹列表页显示错误的bug，二维表组装成树算法有问题，活捉一只bug
3. 完成用户信息页数据显示，完成用户信息关注用户
4. 算法没学好，哭一会。


##2016.3.25
1. 完成在搜索结果列表关注用户
2. 完成用户信息显示


##2016.3.25
1. 完成搜索用户的分页视图大体框架
2. 加入新的显示模块，增加图片小图显示
3. 上班偷写了一点代码，好累
4. 感冒中，好难受....

##2016.3.24
1. 新增兴趣推荐页面，还没开始写代码
2. 新增搜索好友页面，准备完成 关注用户、浏览用户收藏夹功能
3. 推荐功能最后加入，暂时无计划
4. 用户关注模块分为：搜索用户，关注用户，浏览用户公开信息，主要为收藏夹以及个人资料，收藏用户收藏夹


##2016.3.23
1. 完成修改密码
2. 本来都不想做上面这个功能的
3. 接下来全攻地下的四个功能点了


##2016.3.23
1. 完成书签展现页，交互也完善，初步就这样了
2. 引入layer，展示弹出框，看起来不错，感谢作者。
3. 第一部分（注册登录、导入书签、管理书签）基本初步完成。
4. 其余部分：用户群组、消息通知、主页推荐、点评功能




##2016.3.22
1. 新增添加书签/书签夹，功能基本已完成
2. 正在做修改书签/书签夹，写了一点了
3. 把webfolder table 的修改/删除做完，这个页面就差不多了


##2016.3.21
1. webfolder信息也基本完工
2. 浮层代码还没开始写
3. webfolder table就这样吧。


##2016.3.21
1. 写了一点代码，有bug
2. 还没测试，回家倒腾


##2016.3.21
1. 写了一点代码，滚去做CR了。
2. 还没测试，回家倒腾


##2016.3.20
1. Webfolder UI部分已经完成一半，下一半也有基本思路
2. 分页不想做了，要不就内存分页算了，反正数据库分页是不做的
3. VS2015傻了，MVC5 降级到MVC4运行正常，但是没法给control添加View，遂弃用，改回13
4. 本来想休息一下，看了点《饥饿游戏：嘲笑鸟》实在看不下去了，看来没做完这活都没心情去玩
5. 好好学习。



##2016.3.20
1. 由表数据重建书签夹数据树
2. 后台已完成大体框架，前台交互还没开始 



##2016.3.20
1. 完成Log记录
2. 还没测试是否能正常记录日志



##2016.3.19
1. 更改注册页面UI和交互
2. 致谢Amaze UI（又偷了他们的注册页面和JS验证）
3. 再次感谢Amaze UI
4. 明天要把收藏夹页面做了

##2016.3.19
1. 修复上个版本的bug
2. 成功在linux上跑起来了
3. 感谢惊鸿的耐心帮助（昨天还和我一起去整MVC5）


##2016.3.19
1. 删除了MVC5的全部文件
2. MVC5降级到MVC4，以便在linux上跑
3. 有bug，正在解决
4. 文件已全部迁移到MVC上


##2016.3.19
1. 删除了MVC5的全部文件


##2016.3.17
1. 也没有写代码
2. 整理了一下control层代码，可以收到Bo层的意见扔到Bo取了。
3. 干干静静的Control就是舒服
4. 新建SystemLog表，打算用来记录异常的，懒得引入log4net之类的鬼了
5. 并没有开始做log日志，本王困了打算睡觉去。



##2016.3.17
1. 并没有写代码
2. 移除roslyn以便在linux上跑
3. 没有写代码.....



##2016.3.16
1. 基本完成数据导入，待更多用例测试（并不像测试，测试肯定出bug）
2. 修改hrefInfo表为bookmarkInfo，添加bookmarkName字段
3. 准备建立error表，记录系统异常，懒得引入log4之类的鬼了。


##2016.3.15
1. 完善完成导入数据方法
2. 并没有完成上面这个方案，算法还有bug
3. 修修补补小bug



##2016.3.14
1. 修改项目名为WebBookmark，修改数据库名为WebBookmark
2. 新增批量插入方法
3. 简单完成导入数据



##2016.3.13
1. 新建UploadWebfolderlog表，用于存储上传过的网页收藏夹文件
2. 完成导入网页收藏夹，引入AngleSharp处理浏览器导出的书签文件
3. 导入书签数据到系统已完成三分之一的工作量，算法难点基本已理清


##2016.3.12
1. 新增default、webfolder页面
2. 更换登陆页
3. 修改登陆跳转页面
4. 修改icon


##2016.3.10
1. 修正上图头像交互、修改BUG、删除用户之前上传过的个人头像文件
2. 引入jquerry-file-upload.js,感谢[https://github.com/blueimp/jQuery-File-Upload](https://github.com/blueimp/jQuery-File-Upload)
3. 去除无用jquery文件

##2016.3.9
1. 完成用户修改个人资料
2. 完成用户上传头像，交互有待提升



##2016.3.8
1. 添加用户信息页HTML；
2. 修改UserInfo表，加入用户头像URL
3. 修复bug


##2016.3.6
1. 完成注册/登陆功能
2. 增加加密解密类


##2016.3.5
finish register


##2016.3.2
modify UI，修改了一下UI

##2016.3.1
创建解决方案，导入codesmith生成的model/dal/bll







 