#Numbers in words - Kata C#
>
> 1. Create .net solution file
> `dotnet new sln --name NumbersInWords`
> 
> 2. Create new class library 
> `dotnet new classlib -o NumbersInWords`
> 
> 3. Add class library in to solution
> `dotnet sln add NumbersInWords`
> 
> 4. Rename the default class file as 'NumbersInWordsExt' as this a string extention.
> `cd NumbersInWords`
> `ren Class1.cs NumbersInWordsExt.cs`
> `cd..`
> 
> 5. .gitignore file added to exclude obj folder from class library
> 6. Add Xunit project
> `dotnet new xunit -o NumbersInWords.Tests`
> 
> 7. Add Test project in to solution
> `dotnet sln add NumbersInWords.Tests`
> 
> 8. Rename the default test file 
> `cd NumbersInWords.Tests`
> `ren UnitTest1.cs NumbersInWordsTest.cs `
> `cd..`