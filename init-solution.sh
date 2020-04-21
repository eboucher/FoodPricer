mkdir $1
cd $1
git init
echo "bin" >> .gitignore
echo "obj" >> .gitignore
git config core.autocrlf false
git add -A && git commit -m "init repo with gitignore"
mkdir src
mkdir src/$1.App
mkdir src/$1.Core
mkdir src/$1.Tests
dotnet new sln
dotnet new console -o src/$1.App
dotnet new classlib -o src/$1.Core
dotnet new xunit -o src/$1.Tests
dotnet sln add src/$1.App/$1.App.csproj 
dotnet sln add src/$1.Core/$1.Core.csproj
dotnet sln add src/$1.Tests/$1.Tests.csproj
dotnet add src/$1.App reference src/$1.Core/$1.Core.csproj 
dotnet add src/$1.Tests reference src/$1.Core/$1.Core.csproj 
dotnet build
git add -A && git commit -m "initialized structure of the project"

