####### Pre-requisites ###########
## 1. nuget: https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools
##################################
echo "Downloding kubectl for linux v1.21.2..."
mkdir linux
curl https://storage.googleapis.com/kubernetes-release/release/v1.21.2/bin/linux/amd64/kubectl -OutFile .\linux\kubectl

echo "Downloding kubectl for mac v1.21.2..."
mkdir osx
curl https://storage.googleapis.com/kubernetes-release/release/v1.21.2/bin/darwin/amd64/kubectl -OutFile .\osx\kubectl

echo "Downloading kubectl for windows v1.21.2..."
mkdir win
curl https://storage.googleapis.com/kubernetes-release/release/v1.21.2/bin/windows/amd64/kubectl.exe -OutFile .\win\kubectl.exe

echo "Creating nuget package..."
nuget pack

echo "Cleaning up..."
rm .\linux -Force -Recurse
rm .\osx -Force -Recurse
rm .\win -Force -Recurse

echo "Done"