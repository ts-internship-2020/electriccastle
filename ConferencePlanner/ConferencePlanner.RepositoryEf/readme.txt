View->Terminal
dotnet tool install --global dotnet-ef
dotnet restore
dotnet ef dbcontext scaffold "Server=ts-internship-2019.database.windows.net;Database=electric-castle;User Id=usr2020;Password=n39fn0n2_j32-(#;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -o Entities -f --no-build