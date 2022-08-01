# client-kubectl

 Introduction
 ------------
 This folder contains the tools and artifacts needed to create the nuget package containing kubectl.
 Our `client` project has a dependency on this package and during the `setup` the dependencies of `client.csproj` are resolved and kubectl is downloaded from nuget.

 Developing
------------
To run the scripts it is necessary to have nuget installed: https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools

Running/Debugging
-------
To generate the Microsoft.Azure.DevSpaces.Client.Kubectl nuget package:
1. Make changes to the targets file, nuspec file or create-kubectl-package scripts as required. You can find the latest kubectl version [here](https://storage.googleapis.com/kubernetes-release/release/stable.txt).
2. Update the package version in nuspec file.
3. Run the create-kubectl-package script (either .sh or .ps1). This will download the kubectl executables and create the nuget package for you in this folder.
4. To upload the nuget package to Mindaro feed, run `nuget push -Source https://devdiv.pkgs.visualstudio.com/_packaging/Mindaro/nuget/v3/index.json -ApiKey VSTS <package name>` from this directory. When prompted for credentials you can use your microsoft email as user and for the password you can generate a token in: https://devdiv.visualstudio.com/_details/security/tokens
5. Verify that the package was updated here: https://devdiv.visualstudio.com/DevDiv/_packaging?_a=feed&feed=Mindaro
6. After the package is updated remember to update the depedency in `library.csproj` to start using the new package. Check also that any version check on kubectl in the client is up to date, see `common/Constants.cs`.
7. Kubectl is used, and can be updated, in our services as well. You can check all the places where it is used looking at the latest PR that updated the kubectl version: https://devdiv.visualstudio.com/DevDiv/_git/Mindaro-Connect/pullrequest/268924