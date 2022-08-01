####### Pre-requisites ###########
## 1. curl - sudo apt-get install curl
## 2. nuget - sudo apt-get install nuget
##################################

echo "Downloding kubectl for linux v1.21.2..."
mkdir linux
curl -o ./linux/kubectl -L https://storage.googleapis.com/kubernetes-release/release/v1.21.2/bin/linux/amd64/kubectl

echo "Downloding kubectl for mac v1.21.2..."
mkdir osx
curl -o ./osx/kubectl -L https://storage.googleapis.com/kubernetes-release/release/v1.21.2/bin/darwin/amd64/kubectl

echo "Downloading kubectl for windows v1.21.2..."
mkdir win
curl -o ./win/kubectl.exe -L https://storage.googleapis.com/kubernetes-release/release/v1.21.2/bin/windows/amd64/kubectl.exe

echo "Creating nuget package..."
nuget pack

echo "Cleaning up..."
rm -rf ./linux
rm -rf ./osx
rm -rf ./win

echo "Done"
