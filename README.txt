dotnet new webapp -o RazorPagesMusic
code -r RazorPagesMusic

dotnet dev-certs https --trust

dotnet tool install --global dotnet-ef --version 5.*
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

dotnet-aspnet-codegenerator razorpage -m Music -dc RazorPagesMusicContext -udl -outDir Pages/Music --referenceScriptLibraries -sqlite

dotnet-aspnet-codegenerator razorpage -h

dotnet ef migrations add InitialCreate
dotnet ef database update

