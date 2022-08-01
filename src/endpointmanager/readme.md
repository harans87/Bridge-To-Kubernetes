# Endpoint Manager executable

Introduction
------------

Runs on client dev machines and manages the endpoints that local code needs to interact with as if it was running in a Kubernetes cluster. Also helps free up ports by stopping services and process that are running locally and occupying ports needed by the code under development.

Developing
----------
`// TODO:`

Building
--------
To build the project run the following command:
```
dotnet build endpointmanager.csproj
```

To publish EndpointManager.exe in the form it's consumed by the Bridge to Kubernetes VS Code extension: 
```
dotnet publish endpointmanager.csproj -r win-x64
```

To publish a fully self-contained EndpointManager.exe like the one included in the Microsoft.BridgeToKubernetes.EndpointManager NuGet package (for insertion into VS and the CLI), specify the PublishProfile like this:
```
dotnet publish endpointmanager.csproj -r win-x64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.pubxml
```

To build the Microsoft.BridgeToKubernetes.EndpointManager NuGet package, publish for all platforms and then run `dotnet pack`:
```
dotnet publish endpointmanager.csproj -r win-x64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.pubxml
dotnet publish endpointmanager.csproj -r osx-x64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.pubxml
dotnet publish endpointmanager.csproj -r linux-x64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.pubxml
dotnet pack endpointmanager.csproj -p:NuspecFile=EndpointManager.nuspec
```

Running/Debugging
-----------------
**Running:** Publish the `endpointmanager.csproj` project and run the `EndpointManager.exe` executable to test the your changes.
```
dotnet publish src\EndpointManager\endpointmanager.csproj -r win-x64
```

**Debugging:** In Visual Studio, right click the `endpointmanager.csproj` and choose "Set as Startup Project". In the project's `properties` > `Debug` tab change the "Launch" dropdown to "Executable" and enter the path to your local built copy of EndpointManager.exe like `C:\Mindaro\src\EndpointManager\bin\Debug\netcoreapp3.1\win-x64\EndpointManager.exe`.

Testing
-------
Manual testing instructions for the Bridge to Kubernetes experience: [BridgeToKubernetes.md](../../test/manual/BridgeToKubernetes.md)

Troubleshoot
------------
< Describe the trouble shooting steps which help to easily identify the problem. It would be helpful to list common error cases. >

Release Management
------------------
Build pipeline: [Mindaro-Connect-CLI](https://devdiv.visualstudio.com/DevDiv/_build?definitionId=13022)
- Produces the Microsoft.BridgeToKubernetes.EndpointManager NuGet package containing EndpointManager executables for Windows, OSX, and Linux. The executables are fully self-contained, meaning a single file that includes the core EndpointManager functionality plus the .NET Core runtime and all dependencies. Self-containing is necessary because EndpointManager is integrated into VS, and providing the necessary dependencies and runtime in the VS environment would add a lot of complexity that can be avoided by packaging the .exe with everything it needs.
- Produces lpk-win.zip, lpk-osx.zip, and lpk-linux.zip containing EndpointManager (and bridge) executables for integration into the Bridge to Kubernetes VS Code extension. The executables in the .zip files are not self-contained, meaning all the assemblies they depend on are also in the .zips. 

Release pipeline: [Mindaro-Connect-Nuget](https://devdiv.visualstudio.com/DevDiv/_release?_a=releases&view=mine&definitionId=2494)
- Pushes the Microsoft.BridgeToKubernetes.EndpointManager NuGet package to Mindaro feeds (see below), where it's consumed by the Kubernetes Tools extension for Visual Studio and the CLI.

Release pipeline: [Mindaro-Connect-Zip](https://devdiv.visualstudio.com/DevDiv/_release?_a=releases&view=mine&definitionId=2564)
- Copies the lpk-win.zip, lpk-osx.zip, and lpk-linux.zip files to the mindaromaster, mindarostaging, and mindaro Storage Accounts so the Bridge to Kubernetes VS Code extensions's vscode-file-downloader-api can download them.

NuGet Feeds
-----------
Available in Microsoft.BridgeToKubernetes.EndpointManager on:
- [Mindaro](https://dev.azure.com/devdiv/DevDiv/_packaging?_a=feed&feed=Mindaro)
- [Mindaro-Dev](https://dev.azure.com/devdiv/DevDiv/_packaging?_a=feed&feed=Mindaro-Dev)
- [Mindaro-Staging](https://dev.azure.com/devdiv/DevDiv/_packaging?_a=feed&feed=Mindaro-Staging)
