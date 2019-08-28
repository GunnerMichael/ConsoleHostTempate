# Console Host Template

dotnet core template for creating a console app that uses Microsoft.Extensions.Hosting

## Install the template

Clone the repository and then from a command prompt:-

```c#
dotnet new -i <pathtotemplate>
```

## Create a console app

First install the template.

When the template has been installed, use the following from a command prompt:-

```c#
dotnet new conhost -n <appname>
```

## Nuget

The Nuget package can be found at https://www.nuget.org/packages/ServantSoftware.ConsoleHost

To install the template from the command line

```c#
dotnet new -i ServantSoftware.ConsoleHost
```

## References

The following resources were used when creating this project

* [https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)
* [https://docs.microsoft.com/en-us/nuget/reference/msbuild-targets](https://docs.microsoft.com/en-us/nuget/reference/msbuild-targets)
* [https://docs.microsoft.com/en-gb/dotnet/core/tutorials/cli-templates-create-item-template](https://docs.microsoft.com/en-gb/dotnet/core/tutorials/cli-templates-create-item-template)
* [https://docs.microsoft.com/en-gb/dotnet/core/tutorials/cli-templates-create-project-template](https://docs.microsoft.com/en-gb/dotnet/core/tutorials/cli-templates-create-project-template)
* [https://docs.microsoft.com/en-gb/dotnet/core/tutorials/cli-templates-create-template-pack](https://docs.microsoft.com/en-gb/dotnet/core/tutorials/cli-templates-create-template-pack)

* [https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/](https://devblogs.microsoft.com/dotnet/how-to-create-your-own-templates-for-dotnet-new/)