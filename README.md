# Learning TDD

This repo follows the Pluralsight tutorial: Test-driven Development: The Big Picture by Jason Olson
Jasons goes over developing a FizzBuzz program with TDD.

## Running Unit Tests

Go any of test the following directories and run:
-FizzBuzz.Tests
-Stacks.Tests
```
dotnet test
```

To avoid typing this command and have it reload any changes run:
```
dotnet watch test
```

## Setting up C# Projects

Set up a new solution folder with two sub directories for a source project and test project.
>For example e.g. folder **Stacks** (solution) with two sub directories, **Stacks.Library** (source) and **Stacks.Tests** (test)

In the top level directory run:
```
dotnet new sln
```

In the source directory run:
```
dotnet new classlib
```

In the test directory run:
```
dotnet new mstest
```

In the top level directory run:
```
dotnet sln add <path source .csproj file>
dotnet sln add <path to test .csproj file>
```

In the test directory run:
```
dotnet add reference <path to source .csproj file>
```