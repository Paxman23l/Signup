** setup
- Install .Net 5 (https://dotnet.microsoft.com/download/dotnet)
- add connection string to appsetttings.json to the ConnectionStrings => Default section
- run dotnet restore
- run dotnet ef database update

** Changes to Database
- If you've made changes to the model, run the following
- dotnet ef migrations add <INSERT SOME NAME WITHOUT SPACES HERE>
- dotnet ef database update