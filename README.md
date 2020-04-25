## EasyToml
dotNet lib for TOML

Current in development stage Do not use in production environment 
## Use in AspNotCore
```
    var conf = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddTomlFile("config.toml", true)
      .Build();
```
