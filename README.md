# 
用法 引入T4CodeGnerator
写Models 每个Model要继承 BaseEntity<>
调用
WebApiGenerator.GenerateWebApi(typeof(BaseEntity<>));
生成的示例项目为 TestWebApi
只需要写一Models 就可以生成webapi接口
