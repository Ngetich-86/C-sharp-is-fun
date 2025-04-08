# Create a new web API project using ASP.NET Core
```bash 
dotnet new webapi -o Backend
cd Backend
dotnet add package Microsoft.EntityFrameworkCore.InMemory
code -r ../Backend
```
# Create a new class library for the data access layer
```bash
dotnet new classlib -o DataAccess
cd DataAccess
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet add package Microsoft.Extensions.Configuration.Binder
dotnet add package Microsoft.Extensions.DependencyInjection
dotnet add package Microsoft.Extensions.Hosting
dotnet add package Microsoft.Extensions.Logging
dotnet add package Microsoft.Extensions.Logging.Console
dotnet add package Microsoft.Extensions.Logging.Debug
dotnet add package Microsoft.Extensions.Options
dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add package Microsoft.AspNetCore.Mvc
dotnet add package Microsoft.AspNetCore.Mvc.Core
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Json
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.SystemTextJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.NewtonsoftJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.SystemTextJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.NewtonsoftJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.SystemTextJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.NewtonsoftJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.SystemTextJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml.NewtonsoftJson
dotnet add package Microsoft.AspNetCore.Mvc.Formatters.Xml

