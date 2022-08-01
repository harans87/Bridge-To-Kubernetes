﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.BridgeToKubernetes.Library {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.BridgeToKubernetes.Library.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} can only be used on an {1}..
        /// </summary>
        internal static string BridgeToKubernetesIsAKSOnlyFormat {
            get {
                return ResourceManager.GetString("BridgeToKubernetesIsAKSOnlyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot determine active connections using &apos;netstat {0}&apos; command. Exit code {1}: {2}.
        /// </summary>
        internal static string CannotDetermineActiveConnectionsFormat {
            get {
                return ResourceManager.GetString("CannotDetermineActiveConnectionsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find free local ports to map remote service ports. Retry later..
        /// </summary>
        internal static string CannotObtainFreeLocalPorts {
            get {
                return ResourceManager.GetString("CannotObtainFreeLocalPorts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot obtain enough local IPs. Please kill &apos;{0}&apos; and try again..
        /// </summary>
        internal static string CannotObtainLocalIPsFormat {
            get {
                return ResourceManager.GetString("CannotObtainLocalIPsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running {0} {1} failed with exit code {2}: {3}.
        /// </summary>
        internal static string CommandFailedFormat {
            get {
                return ResourceManager.GetString("CommandFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container port {0} is available at localhost:{1}..
        /// </summary>
        internal static string ContainerPortAvailableFormat {
            get {
                return ResourceManager.GetString("ContainerPortAvailableFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ContainerSpec.Command is not empty: &apos;{0}&apos;. Overriding entrypoints is currently not supported..
        /// </summary>
        internal static string ContainerSpecCommandNotEmptyFormat {
            get {
                return ResourceManager.GetString("ContainerSpecCommandNotEmptyFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container status is not available..
        /// </summary>
        internal static string ContainerStatusUnavailableMessage {
            get {
                return ResourceManager.GetString("ContainerStatusUnavailableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copying &apos;{0}&apos; from container &apos;{1}&apos; to &apos;{2}&apos; failed with exit code {3}..
        /// </summary>
        internal static string CopyContainerFailedFormat {
            get {
                return ResourceManager.GetString("CopyContainerFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download completed..
        /// </summary>
        internal static string DownloadCompletedMessage {
            get {
                return ResourceManager.GetString("DownloadCompletedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download failed with error: {0}.
        /// </summary>
        internal static string DownloadFailed {
            get {
                return ResourceManager.GetString("DownloadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading from &apos;{0}&apos; ....
        /// </summary>
        internal static string DownloadingFromFormat {
            get {
                return ResourceManager.GetString("DownloadingFromFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading volume &apos;{0}&apos; from &apos;{1}&apos; ....
        /// </summary>
        internal static string DownloadingVolumeFormat {
            get {
                return ResourceManager.GetString("DownloadingVolumeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to configure local host..
        /// </summary>
        internal static string FailedToConfigureLocalHost {
            get {
                return ResourceManager.GetString("FailedToConfigureLocalHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to connect to the remote agent..
        /// </summary>
        internal static string FailedToConnectToRemoteAgent {
            get {
                return ResourceManager.GetString("FailedToConnectToRemoteAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete pod &apos;{0}&apos;..
        /// </summary>
        internal static string FailedToDeletePodFormat {
            get {
                return ResourceManager.GetString("FailedToDeletePodFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deploy a pod into the cluster..
        /// </summary>
        internal static string FailedToDeployPodMessage {
            get {
                return ResourceManager.GetString("FailedToDeployPodMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deploy remote restore job for pod deployment &apos;{0}/{1}&apos; with error: {2}.
        /// </summary>
        internal static string FailedToDeployRemoteRestoreJobFormat {
            get {
                return ResourceManager.GetString("FailedToDeployRemoteRestoreJobFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to determine the current user. Please try again..
        /// </summary>
        internal static string FailedToDetermineCurrentUser {
            get {
                return ResourceManager.GetString("FailedToDetermineCurrentUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find container &apos;{0}&apos;..
        /// </summary>
        internal static string FailedToFindContainerFormat {
            get {
                return ResourceManager.GetString("FailedToFindContainerFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find containers in deployment &apos;{0}&apos; in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToFindContainerInDeploymentFormat {
            get {
                return ResourceManager.GetString("FailedToFindContainerInDeploymentFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find container &apos;{0}&apos; in pod &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToFindContainerInPodFormat {
            get {
                return ResourceManager.GetString("FailedToFindContainerInPodFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find deployment &apos;{0}&apos; in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToFindDeploymentFormat {
            get {
                return ResourceManager.GetString("FailedToFindDeploymentFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find pod &apos;{0}&apos; hosting container &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToFindPodFormat {
            get {
                return ResourceManager.GetString("FailedToFindPodFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find &apos;{0}&apos; in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToFindPodInNamespaceFormat {
            get {
                return ResourceManager.GetString("FailedToFindPodInNamespaceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find pods in deployment &apos;{0}&apos; in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToFindPodsInDeploymentFormat {
            get {
                return ResourceManager.GetString("FailedToFindPodsInDeploymentFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get elevation requests..
        /// </summary>
        internal static string FailedToGetElevationRequests {
            get {
                return ResourceManager.GetString("FailedToGetElevationRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get routing manager deployment status: &apos;{0}&apos;.
        /// </summary>
        internal static string FailedToGetRoutingManagerDeploymentStatusFormat {
            get {
                return ResourceManager.GetString("FailedToGetRoutingManagerDeploymentStatusFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get running pod in the deployment &apos;{0}&apos; in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToGetRunningPodInDeploymentFormat {
            get {
                return ResourceManager.GetString("FailedToGetRunningPodInDeploymentFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get workload info..
        /// </summary>
        internal static string FailedToGetWorkloadInfo {
            get {
                return ResourceManager.GetString("FailedToGetWorkloadInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to identify the container to use in pod &apos;{0}&apos; from the container port information in the pod spec..
        /// </summary>
        internal static string FailedToIDContainerFormat {
            get {
                return ResourceManager.GetString("FailedToIDContainerFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to identify the container to use in pod &apos;{0}&apos;..
        /// </summary>
        internal static string FailedToIDContainerForPod {
            get {
                return ResourceManager.GetString("FailedToIDContainerForPod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to launch {0}..
        /// </summary>
        internal static string FailedToLaunchEndpointManagerFormat {
            get {
                return ResourceManager.GetString("FailedToLaunchEndpointManagerFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to list pods in namespace &apos;{0}&apos;....
        /// </summary>
        internal static string FailedToListPodsFormat {
            get {
                return ResourceManager.GetString("FailedToListPodsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load {0} environment file &apos;{1}&apos;: {2}.
        /// </summary>
        internal static string FailedToLoadBridgeToKubernetesEnvFileFormat {
            get {
                return ResourceManager.GetString("FailedToLoadBridgeToKubernetesEnvFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to map remote services to local ports and IPs.
        /// </summary>
        internal static string FailedToMapRemoteServices {
            get {
                return ResourceManager.GetString("FailedToMapRemoteServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to resolve the {0} backing the service &apos;{1}&apos;..
        /// </summary>
        internal static string FailedToResolveResourceBackingServiceFormat {
            get {
                return ResourceManager.GetString("FailedToResolveResourceBackingServiceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to restore original remote container..
        /// </summary>
        internal static string FailedToRestoreOriginalContainer {
            get {
                return ResourceManager.GetString("FailedToRestoreOriginalContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to restore service at &apos;{0}/{1}/{2}&apos;..
        /// </summary>
        internal static string FailedToRestoreServiceFormat {
            get {
                return ResourceManager.GetString("FailedToRestoreServiceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to run {0} with error: {1}.
        /// </summary>
        internal static string FailedToRunProcess {
            get {
                return ResourceManager.GetString("FailedToRunProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start local agent..
        /// </summary>
        internal static string FailedToStartLocalAgent {
            get {
                return ResourceManager.GetString("FailedToStartLocalAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start remote agent..
        /// </summary>
        internal static string FailedToStartRemoteAgent {
            get {
                return ResourceManager.GetString("FailedToStartRemoteAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to stop local agent..
        /// </summary>
        internal static string FailedToStopLocalAgent {
            get {
                return ResourceManager.GetString("FailedToStopLocalAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to stop local connection..
        /// </summary>
        internal static string FailedToStopLocalConnection {
            get {
                return ResourceManager.GetString("FailedToStopLocalConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to wait for remote agent to restart..
        /// </summary>
        internal static string FailedToWaitForRemoteAgent {
            get {
                return ResourceManager.GetString("FailedToWaitForRemoteAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hosts file updated..
        /// </summary>
        internal static string HostsFileUpdatedMessage {
            get {
                return ResourceManager.GetString("HostsFileUpdatedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Container &apos;{0}/{1}/{2}&apos; is not running image &apos;{3}&apos; after patching..
        /// </summary>
        internal static string ImageNotRunningAfterPatchFormat {
            get {
                return ResourceManager.GetString("ImageNotRunningAfterPatchFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ImagePullPolicy cannot be &apos;Never&apos;.  Please change it to a different value..
        /// </summary>
        internal static string ImagePullPolicyCannotBeNeverMessage {
            get {
                return ResourceManager.GetString("ImagePullPolicyCannotBeNeverMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected external endpoint entry &apos;{0}&apos; found in {1}. An external endpoint must be specified like &apos;DNS-name:port&apos;..
        /// </summary>
        internal static string InvalidExternalEndpointEntryFormat {
            get {
                return ResourceManager.GetString("InvalidExternalEndpointEntryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected port number entry &apos;{0}&apos; found in {1}. Port number must be an integer between 1 and 65535. Use comma &apos;,&apos; to separate multiple port numbers..
        /// </summary>
        internal static string InvalidPortEntryFormat {
            get {
                return ResourceManager.GetString("InvalidPortEntryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected service entry &apos;{0}&apos; found in {1}. A service entry must be &apos;service-name&apos; or &apos;service-name.namespace-name&apos;..
        /// </summary>
        internal static string InvalidServiceEntryFormat {
            get {
                return ResourceManager.GetString("InvalidServiceEntryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using isolation with Istio is not currently supported due to conflicts between Istio routing and Bridge isolation. We recommend using Bridge without isolation, deploying a copy of the application in a separate namespace..
        /// </summary>
        internal static string IsolationNotSupportedWithIstio {
            get {
                return ResourceManager.GetString("IsolationNotSupportedWithIstio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} launch process was cancelled..
        /// </summary>
        internal static string LaunchProcessCancelled {
            get {
                return ResourceManager.GetString("LaunchProcessCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded {0} environment file &apos;{1}&apos;..
        /// </summary>
        internal static string LoadedBridgeToKubernetesEnvFileFormat {
            get {
                return ResourceManager.GetString("LoadedBridgeToKubernetesEnvFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Moving contents from {0} to {1}..
        /// </summary>
        internal static string MovingContentsFromContainerToLocalPathFormat {
            get {
                return ResourceManager.GetString("MovingContentsFromContainerToLocalPathFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running {0} {1} failed with exit code {2} and error: {3}.
        /// </summary>
        internal static string NetStatCommandFailedFormat {
            get {
                return ResourceManager.GetString("NetStatCommandFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patch &apos;{0}/{1}/{2}&apos; to use &apos;{3}&apos; failed: with error: {4}.
        /// </summary>
        internal static string PatchingFailedFormat {
            get {
                return ResourceManager.GetString("PatchingFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patch {0} &apos;{1}/{2}&apos; failed. Patch is {3}: {4}.
        /// </summary>
        internal static string PatchResourceFailedFormat {
            get {
                return ResourceManager.GetString("PatchResourceFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}/{1}/{2}&apos; is already using &apos;{3&apos;}..
        /// </summary>
        internal static string PodAlreadyUsingAgentImageFormat {
            get {
                return ResourceManager.GetString("PodAlreadyUsingAgentImageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pod &apos;{0}/{1}&apos; created..
        /// </summary>
        internal static string PodCreatedFormat {
            get {
                return ResourceManager.GetString("PodCreatedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pod &apos;{0}&apos; created in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string PodCreatedInNamespaceFormat {
            get {
                return ResourceManager.GetString("PodCreatedInNamespaceFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}/{1}/{2}&apos; patched to use &apos;{3}&apos;..
        /// </summary>
        internal static string PodPatchedToAgentImageFormat {
            get {
                return ResourceManager.GetString("PodPatchedToAgentImageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you are using Windows please disable the BranchCache service to free port 80. Services such as IISAdmin, HTTP or World Wide Web Publishing Service could also use port 80. Please stop them..
        /// </summary>
        internal static string Port80WindowsServicesMessage {
            get {
                return ResourceManager.GetString("Port80WindowsServicesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port {0} is already in use on your machine. Please free this port and try again. {1}.
        /// </summary>
        internal static string PortInUseFormat {
            get {
                return ResourceManager.GetString("PortInUseFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port number must be specified for resource {0}..
        /// </summary>
        internal static string PortRequiredFormat {
            get {
                return ResourceManager.GetString("PortRequiredFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &apos;netstat -ano&apos; command to find which program is using this port..
        /// </summary>
        internal static string PortsInUseMessage {
            get {
                return ResourceManager.GetString("PortsInUseMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparing to run {0} configured as pod {1}/{2} ....
        /// </summary>
        internal static string PreparingToRunBridgeToKubernetesFormat {
            get {
                return ResourceManager.GetString("PreparingToRunBridgeToKubernetesFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process &apos;{0}&apos; binds to port &apos;{1}&apos; on all addresses. This will prevent &apos;{2}&apos; from forwarding network traffic on this port. Please stop this process or service and try again..
        /// </summary>
        internal static string ProcessBindsOnPortFormat {
            get {
                return ResourceManager.GetString("ProcessBindsOnPortFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remote agent deployed in container &apos;{0}&apos; in pod &apos;{1}&apos;..
        /// </summary>
        internal static string RemoteAgentDeployedInPod {
            get {
                return ResourceManager.GetString("RemoteAgentDeployedInPod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} currently only supports debugging services backed by Deployments and StatefulSets..
        /// </summary>
        internal static string ResourceNotSupportedFormat {
            get {
                return ResourceManager.GetString("ResourceNotSupportedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &apos;{1}/{2}&apos; patched to run agent..
        /// </summary>
        internal static string ResourcePatchedForAgentFormat {
            get {
                return ResourceManager.GetString("ResourcePatchedForAgentFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring pod deployment ....
        /// </summary>
        internal static string RestoringPodDeploymentMessage {
            get {
                return ResourceManager.GetString("RestoringPodDeploymentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring {0} patch ....
        /// </summary>
        internal static string RestoringResourcePatchMessage {
            get {
                return ResourceManager.GetString("RestoringResourcePatchMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrying ....
        /// </summary>
        internal static string RetryingMessage {
            get {
                return ResourceManager.GetString("RetryingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Routing successfully enabled for service through pod &apos;{0}&apos; in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string RoutingSuccessfullyEnabledFormat {
            get {
                return ResourceManager.GetString("RoutingSuccessfullyEnabledFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Running {0} {tarArguments} failed with exit code {exitCode}: {output}.
        /// </summary>
        internal static string RunningTarCommandFailed {
            get {
                return ResourceManager.GetString("RunningTarCommandFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{0}&apos; is available on {1}:{2}..
        /// </summary>
        internal static string ServiceAvailableOnPortFormat {
            get {
                return ResourceManager.GetString("ServiceAvailableOnPortFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service name not defined to support routing for &apos;{0}&apos; in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string ServiceNameNotDefinedForRoutingFormat {
            get {
                return ResourceManager.GetString("ServiceNameNotDefinedForRoutingFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified container &apos;{0}&apos; was not found in pod &apos;{1}&apos;..
        /// </summary>
        internal static string SpecifiedContainerNotFoundFormat {
            get {
                return ResourceManager.GetString("SpecifiedContainerNotFoundFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified service &apos;{0}&apos; is backed by {1} pods owned by different {2}. Unable to scale down to a single Pod..
        /// </summary>
        internal static string SpecifiedServiceBackedByManyPodsInDifferentResourcesFormat {
            get {
                return ResourceManager.GetString("SpecifiedServiceBackedByManyPodsInDifferentResourcesFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified service &apos;{0}&apos; is backed by {1} Remote Agent pod(s). Please try again later once the service is restored..
        /// </summary>
        internal static string SpecifiedServiceBackedByMultipleRemoteAgents {
            get {
                return ResourceManager.GetString("SpecifiedServiceBackedByMultipleRemoteAgents", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified service &apos;{0}&apos; could not be found in namespace &apos;{1}&apos;..
        /// </summary>
        internal static string SpecifiedServiceCouldNotBeFoundFormat {
            get {
                return ResourceManager.GetString("SpecifiedServiceCouldNotBeFoundFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified service &apos;{0}&apos; is not backed by a running pod. To check the status of your pods, you can run &apos;{1}&apos;..
        /// </summary>
        internal static string SpecifiedServiceNotBackedByRunningPodFormat {
            get {
                return ResourceManager.GetString("SpecifiedServiceNotBackedByRunningPodFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process &apos;{0}&apos; binds to port &apos;{1}&apos; on all addresses. This will prevent &apos;{2}&apos; from forwarding network traffic on this port. Please stop this process or service and try again..
        /// </summary>
        internal static string SystemProcessBindsOnPortFormat {
            get {
                return ResourceManager.GetString("SystemProcessBindsOnPortFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timed out waiting for pod &apos;{0}&apos; in namespace &apos;{1}&apos; to reach running state..
        /// </summary>
        internal static string TimedOutWaitingForPodFormat {
            get {
                return ResourceManager.GetString("TimedOutWaitingForPodFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve port {0} from container &apos;{1}&apos; spec..
        /// </summary>
        internal static string UnableToResolvePortFromContainer {
            get {
                return ResourceManager.GetString("UnableToResolvePortFromContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create a Unix Domain Socket. If you are running {0} on a version of Windows older than Windows 10 Version 1803 (10.0.17134), please consider upgrading your system..
        /// </summary>
        internal static string UnixDomainSocketsNotSupported {
            get {
                return ResourceManager.GetString("UnixDomainSocketsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Volume mount &apos;{0}&apos; referenced in {1} config file &apos;{2}&apos; does not exist in the remote container..
        /// </summary>
        internal static string VolumeMountCannotBeFoundFormat {
            get {
                return ResourceManager.GetString("VolumeMountCannotBeFoundFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for {0} to come up ....
        /// </summary>
        internal static string WaitingForEndpointManagerFormat {
            get {
                return ResourceManager.GetString("WaitingForEndpointManagerFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for &apos;{0}&apos; in namespace &apos;{1}&apos; to reach running state....
        /// </summary>
        internal static string WaitingForPodFormat {
            get {
                return ResourceManager.GetString("WaitingForPodFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target workload is running on a Windows node. This OS is currently not supported by {0}..
        /// </summary>
        internal static string WindowsContainersNotSupportedFormat {
            get {
                return ResourceManager.GetString("WindowsContainersNotSupportedFormat", resourceCulture);
            }
        }
    }
}
