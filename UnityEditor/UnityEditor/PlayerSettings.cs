using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class PlayerSettings : Object
{
    static public int accelerometerFrequency { get; set; }
    static public UnityEditor.ActionOnDotNetUnhandledException actionOnDotNetUnhandledException { get; set; }
    static public bool advancedLicense { get; }
    static public bool allowedAutorotateToLandscapeLeft { get; set; }
    static public bool allowedAutorotateToLandscapeRight { get; set; }
    static public bool allowedAutorotateToPortrait { get; set; }
    static public bool allowedAutorotateToPortraitUpsideDown { get; set; }
    static public bool allowFullscreenSwitch { get; set; }
    static public bool allowUnsafeCode { get; set; }
    static public bool alwaysDisplayWatermark { get; set; }
    static public string aotOptions { get; set; }
    static public UnityEditor.ApiCompatibilityLevel apiCompatibilityLevel { get; set; }
    static public string applicationIdentifier { get; set; }
    static public bool bakeCollisionMeshes { get; set; }
    static public string bundleIdentifier { get; set; }
    static public string bundleVersion { get; set; }
    static public bool captureSingleScreen { get; set; }
    static public string cloudProjectId { get; }
    static public ColorSpace colorSpace { get; set; }
    static public string companyName { get; set; }
    static public Vector2 cursorHotspot { get; set; }
    static public UnityEditor.D3D11FullscreenMode d3d11FullscreenMode { get; set; }
    static public UnityEditor.D3D9FullscreenMode d3d9FullscreenMode { get; set; }
    static public D3DHDRDisplayBitDepth D3DHDRBitDepth { get; set; }
    static public Texture2D defaultCursor { get; set; }
    static public UnityEditor.UIOrientation defaultInterfaceOrientation { get; set; }
    static public bool defaultIsFullScreen { get; set; }
    static public bool defaultIsNativeResolution { get; set; }
    static public int defaultScreenHeight { get; set; }
    static public int defaultScreenWidth { get; set; }
    static public int defaultWebScreenHeight { get; set; }
    static public int defaultWebScreenWidth { get; set; }
    static public UnityEditor.ResolutionDialogSetting displayResolutionDialog { get; set; }
    static public bool enable360StereoCapture { get; set; }
    static public bool enableCrashReportAPI { get; set; }
    static public bool enableFrameTimingStats { get; set; }
    static public bool enableInternalProfiler { get; set; }
    static public bool enableMetalAPIValidation { get; set; }
    static public int firstStreamedLevelWithResources { get; set; }
    static public bool forceSingleInstance { get; set; }
    static public FullScreenMode fullScreenMode { get; set; }
    static public bool gcIncremental { get; set; }
    static public bool gpuSkinning { get; set; }
    static public UnityEditor.GraphicsJobMode graphicsJobMode { get; set; }
    static public bool graphicsJobs { get; set; }
    static public string iPhoneBundleIdentifier { get; set; }
    static public string keyaliasPass { get; set; }
    static public string keystorePass { get; set; }
    static public bool legacyClampBlendShapeWeights { get; set; }
    static public string locationUsageDescription { get; set; }
    static public bool logObjCUncaughtExceptions { get; set; }
    static public UnityEditor.MacFullscreenMode macFullscreenMode { get; set; }
    static public bool macRetinaSupport { get; set; }
    static public RenderingPath mobileRenderingPath { get; set; }
    static public bool MTRendering { get; set; }
    static public bool muteOtherAudioSources { get; set; }
    static public bool openGLRequireES31 { get; set; }
    static public bool openGLRequireES31AEP { get; set; }
    static public bool openGLRequireES32 { get; set; }
    static public bool preserveFramebufferAlpha { get; set; }
    static public Guid productGUID { get; }
    static public string productName { get; set; }
    static public bool protectGraphicsMemory { get; set; }
    static public RenderingPath renderingPath { get; set; }
    static public bool resizableWindow { get; set; }
    static public Texture2D resolutionDialogBanner { get; set; }
    static public bool runInBackground { get; set; }
    static public UnityEditor.ScriptingRuntimeVersion scriptingRuntimeVersion { get; set; }
    static public bool showUnitySplashScreen { get; set; }
    static public bool singlePassStereoRendering { get; set; }
    static public UnityEditor.SplashScreenStyle splashScreenStyle { get; set; }
    static public bool statusBarHidden { get; set; }
    static public UnityEditor.StereoRenderingPath stereoRenderingPath { get; set; }
    static public bool stereoscopic3D { get; set; }
    static public bool stripEngineCode { get; set; }
    static public UnityEditor.StrippingLevel strippingLevel { get; set; }
    static public bool stripUnusedMeshComponents { get; set; }
    static public UnityEditor.TargetGlesGraphics targetGlesGraphics { get; set; }
    static public UnityEditor.TargetIOSGraphics targetIOSGraphics { get; set; }
    static public bool use32BitDisplayBuffer { get; set; }
    static public bool useAnimatedAutorotation { get; set; }
    static public bool useDirect3D11 { get; set; }
    static public bool useFlipModelSwapchain { get; set; }
    static public bool useHDRDisplay { get; set; }
    static public bool useMacAppStoreValidation { get; set; }
    static public bool usePlayerLog { get; set; }
    static public Texture2D virtualRealitySplashScreen { get; set; }
    static public bool virtualRealitySupported { get; set; }
    static public bool visibleInBackground { get; set; }
    static public bool vulkanEnableSetSRGBWrite { get; set; }
    static public uint vulkanNumSwapchainBuffers { get; set; }
    static public bool vulkanUseSWCommandBuffers { get; set; }
    static public int xboxAdditionalTitleMemorySize { get; set; }
    static public bool xboxDeployKinectHeadOrientation { get; set; }
    static public bool xboxDeployKinectHeadPosition { get; set; }
    static public bool xboxDeployKinectResources { get; }
    static public bool xboxEnableAvatar { get; }
    static public bool xboxEnableGuest { get; }
    static public bool xboxEnableKinect { get; }
    static public bool xboxEnableKinectAutoTracking { get; }
    static public bool xboxEnableSpeech { get; }
    static public bool xboxGenerateSpa { get; }
    static public string xboxImageXexFilePath { get; }
    static public int xboxOneResolution { get; }
    static public bool xboxPIXTextureCapture { get; }
    static public string xboxSpaFilePath { get; }
    static public uint xboxSpeechDB { get; }
    static public Texture2D xboxSplashScreen { get; }
    static public string xboxTitleId { get; set; }

    static public string GetAdditionalIl2CppArgs();
    static public UnityEditor.ApiCompatibilityLevel GetApiCompatibilityLevel(UnityEditor.BuildTargetGroup buildTargetGroup);
    static public string GetApplicationIdentifier(UnityEditor.BuildTargetGroup targetGroup);
    static public int GetArchitecture(UnityEditor.BuildTargetGroup targetGroup);
    static public string[] GetAvailableVirtualRealitySDKs(UnityEditor.BuildTargetGroup targetGroup);
    static public UnityEditor.ScriptingImplementation GetDefaultScriptingBackend(UnityEditor.BuildTargetGroup targetGroup);
    static public Rendering.GraphicsDeviceType[] GetGraphicsAPIs(UnityEditor.BuildTarget platform);
    static public Texture2D[] GetIconsForTargetGroup(UnityEditor.BuildTargetGroup platform);
    static public Texture2D[] GetIconsForTargetGroup(UnityEditor.BuildTargetGroup platform, UnityEditor.IconKind kind);
    static public int[] GetIconSizesForTargetGroup(UnityEditor.BuildTargetGroup platform);
    static public int[] GetIconSizesForTargetGroup(UnityEditor.BuildTargetGroup platform, UnityEditor.IconKind kind);
    static public UnityEditor.Il2CppCompilerConfiguration GetIl2CppCompilerConfiguration(UnityEditor.BuildTargetGroup targetGroup);
    static public bool GetIncrementalIl2CppBuild(UnityEditor.BuildTargetGroup targetGroup);
    static public UnityEditor.ManagedStrippingLevel GetManagedStrippingLevel(UnityEditor.BuildTargetGroup targetGroup);
    static public bool GetMobileMTRendering(UnityEditor.BuildTargetGroup targetGroup);
    static public UnityEditor.PlatformIcon[] GetPlatformIcons(UnityEditor.BuildTargetGroup platform, UnityEditor.PlatformIconKind kind);
    static public Object[] GetPreloadedAssets();
    static public bool GetPropertyBool(string name);
    static public bool GetPropertyBool(string name, UnityEditor.BuildTargetGroup target);
    static public int GetPropertyInt(string name);
    static public int GetPropertyInt(string name, UnityEditor.BuildTargetGroup target);
    static public bool GetPropertyOptionalBool(string name, bool value);
    static public bool GetPropertyOptionalBool(string name, bool value, UnityEditor.BuildTargetGroup target);
    static public bool GetPropertyOptionalInt(string name, int value);
    static public bool GetPropertyOptionalInt(string name, int value, UnityEditor.BuildTargetGroup target);
    static public bool GetPropertyOptionalString(string name, string value);
    static public bool GetPropertyOptionalString(string name, string value, UnityEditor.BuildTargetGroup target);
    static public string GetPropertyString(string name);
    static public string GetPropertyString(string name, UnityEditor.BuildTargetGroup target);
    static public UnityEditor.ScriptingImplementation GetScriptingBackend(UnityEditor.BuildTargetGroup targetGroup);
    static public string GetScriptingDefineSymbolsForGroup(UnityEditor.BuildTargetGroup targetGroup);
    static public StackTraceLogType GetStackTraceLogType(LogType logType);
    static public UnityEditor.PlatformIconKind[] GetSupportedIconKindsForPlatform(UnityEditor.BuildTargetGroup platform);
    static public bool GetUseDefaultGraphicsAPIs(UnityEditor.BuildTarget platform);
    static public string[] GetVirtualRealitySDKs(UnityEditor.BuildTargetGroup targetGroup);
    static public bool GetVirtualRealitySupported(UnityEditor.BuildTargetGroup targetGroup);
    static public bool GetWsaHolographicRemotingEnabled();
    static public bool HasAspectRatio(UnityEditor.AspectRatio aspectRatio);
    static public void SetAdditionalIl2CppArgs(string additionalArgs);
    static public void SetApiCompatibilityLevel(UnityEditor.BuildTargetGroup buildTargetGroup, UnityEditor.ApiCompatibilityLevel value);
    static public void SetApplicationIdentifier(UnityEditor.BuildTargetGroup targetGroup, string identifier);
    static public void SetArchitecture(UnityEditor.BuildTargetGroup targetGroup, int architecture);
    static public void SetAspectRatio(UnityEditor.AspectRatio aspectRatio, bool enable);
    static public void SetGraphicsAPIs(UnityEditor.BuildTarget platform, Rendering.GraphicsDeviceType[] apis);
    static public void SetIconsForTargetGroup(UnityEditor.BuildTargetGroup platform, Texture2D[] icons);
    static public void SetIconsForTargetGroup(UnityEditor.BuildTargetGroup platform, Texture2D[] icons, UnityEditor.IconKind kind);
    static public void SetIl2CppCompilerConfiguration(UnityEditor.BuildTargetGroup targetGroup, UnityEditor.Il2CppCompilerConfiguration configuration);
    static public void SetIncrementalIl2CppBuild(UnityEditor.BuildTargetGroup targetGroup, bool enabled);
    static public void SetManagedStrippingLevel(UnityEditor.BuildTargetGroup targetGroup, UnityEditor.ManagedStrippingLevel level);
    static public void SetMobileMTRendering(UnityEditor.BuildTargetGroup targetGroup, bool enable);
    static public void SetPlatformIcons(UnityEditor.BuildTargetGroup platform, UnityEditor.PlatformIconKind kind, UnityEditor.PlatformIcon[] icons);
    static public void SetPreloadedAssets(Object[] assets);
    static public void SetPropertyBool(string name, bool value);
    static public void SetPropertyBool(string name, bool value, UnityEditor.BuildTarget target);
    static public void SetPropertyBool(string name, bool value, UnityEditor.BuildTargetGroup target);
    static public void SetPropertyInt(string name, int value);
    static public void SetPropertyInt(string name, int value, UnityEditor.BuildTarget target);
    static public void SetPropertyInt(string name, int value, UnityEditor.BuildTargetGroup target);
    static public void SetPropertyString(string name, string value);
    static public void SetPropertyString(string name, string value, UnityEditor.BuildTarget target);
    static public void SetPropertyString(string name, string value, UnityEditor.BuildTargetGroup target);
    static public void SetScriptingBackend(UnityEditor.BuildTargetGroup targetGroup, UnityEditor.ScriptingImplementation backend);
    static public void SetScriptingDefineSymbolsForGroup(UnityEditor.BuildTargetGroup targetGroup, string defines);
    static public void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType);
    static public void SetUseDefaultGraphicsAPIs(UnityEditor.BuildTarget platform, bool automatic);
    static public void SetVirtualRealitySDKs(UnityEditor.BuildTargetGroup targetGroup, string[] sdks);
    static public void SetVirtualRealitySupported(UnityEditor.BuildTargetGroup targetGroup, bool value);
    static public void SetWsaHolographicRemotingEnabled(bool enabled);

    public class Android
    {
        static public bool androidIsGame { get; set; }
        static public bool androidTVCompatibility { get; set; }
        static public bool ARCoreEnabled { get; set; }
        static public UnityEditor.AndroidBlitType blitType { get; set; }
        static public bool buildApkPerCpuArchitecture { get; set; }
        static public int bundleVersionCode { get; set; }
        static public bool disableDepthAndStencilBuffers { get; set; }
        static public bool forceInternetPermission { get; set; }
        static public bool forceSDCardPermission { get; set; }
        static public string keyaliasName { get; set; }
        static public string keyaliasPass { get; set; }
        static public string keystoreName { get; set; }
        static public string keystorePass { get; set; }
        static public bool licenseVerification { get; }
        static public float maxAspectRatio { get; set; }
        static public UnityEditor.AndroidSdkVersions minSdkVersion { get; set; }
        static public UnityEditor.AndroidPreferredInstallLocation preferredInstallLocation { get; set; }
        static public bool renderOutsideSafeArea { get; set; }
        static public UnityEditor.AndroidShowActivityIndicatorOnLoading showActivityIndicatorOnLoading { get; set; }
        static public UnityEditor.AndroidSplashScreenScale splashScreenScale { get; set; }
        static public bool startInFullscreen { get; set; }
        static public UnityEditor.AndroidArchitecture targetArchitectures { get; set; }
        static public UnityEditor.AndroidTargetDevice targetDevice { get; set; }
        static public UnityEditor.AndroidSdkVersions targetSdkVersion { get; set; }
        static public bool use24BitDepthBuffer { get; set; }
        static public bool useAPKExpansionFiles { get; set; }
        static public bool useCustomKeystore { get; set; }

        public Android();

    }

    public class Facebook
    {
        static public string appId { get; set; }
        static public string sdkVersion { get; set; }
        static public bool useCookies { get; set; }
        static public bool useFrictionlessRequests { get; set; }
        static public bool useStatus { get; set; }

        public Facebook();

    }

    public class iOS
    {
        static public bool allowHTTPDownload { get; set; }
        static public UnityEditor.iOSAppInBackgroundBehavior appInBackgroundBehavior { get; set; }
        static public string appleDeveloperTeamID { get; set; }
        static public bool appleEnableAutomaticSigning { get; set; }
        static public string applicationDisplayName { get; set; }
        static public UnityEditor.iOSBackgroundMode backgroundModes { get; set; }
        static public string buildNumber { get; set; }
        static public string cameraUsageDescription { get; set; }
        static public iOS.SystemGestureDeferMode deferSystemGesturesMode { get; set; }
        static public bool disableDepthAndStencilBuffers { get; set; }
        static public bool exitOnSuspend { get; set; }
        static public bool forceHardShadowsOnMetal { get; set; }
        static public bool hideHomeButton { get; set; }
        static public string iOSManualProvisioningProfileID { get; set; }
        static public UnityEditor.ProvisioningProfileType iOSManualProvisioningProfileType { get; set; }
        static public string[] iOSUrlSchemes { get; set; }
        static public string locationUsageDescription { get; set; }
        static public string microphoneUsageDescription { get; set; }
        static public bool overrideIPodMusic { get; set; }
        static public bool prerenderedIcon { get; set; }
        static public bool requiresFullScreen { get; set; }
        static public bool requiresPersistentWiFi { get; set; }
        static public UnityEditor.ScriptCallOptimizationLevel scriptCallOptimization { get; set; }
        static public UnityEditor.iOSSdkVersion sdkVersion { get; set; }
        static public UnityEditor.iOSShowActivityIndicatorOnLoading showActivityIndicatorOnLoading { get; set; }
        static public UnityEditor.iOSStatusBarStyle statusBarStyle { get; set; }
        static public UnityEditor.iOSTargetDevice targetDevice { get; set; }
        static public UnityEditor.iOSTargetOSVersion targetOSVersion { get; set; }
        static public string targetOSVersionString { get; set; }
        static public UnityEditor.iOSTargetResolution targetResolution { get; set; }
        static public string tvOSManualProvisioningProfileID { get; set; }
        static public UnityEditor.ProvisioningProfileType tvOSManualProvisioningProfileType { get; set; }
        static public bool useOnDemandResources { get; set; }

        static public void SetiPadLaunchScreenType(UnityEditor.iOSLaunchScreenType type);
        static public void SetiPhoneLaunchScreenType(UnityEditor.iOSLaunchScreenType type);
        static public void SetLaunchScreenImage(Texture2D image, UnityEditor.iOSLaunchScreenImageType type);

        public iOS();

    }

    public sealed class Lumin
    {
        static public string certificatePath { get; set; }
        static public string iconModelFolderPath { get; set; }
        static public string iconPortalFolderPath { get; set; }
        static public bool isChannelApp { get; set; }
        static public bool signPackage { get; set; }
        static public int versionCode { get; set; }
        static public string versionName { get; set; }

        public Lumin();

    }

    public class macOS
    {
        static public string buildNumber { get; set; }

        public macOS();

    }

    public sealed class PS4
    {
        static public int applicationParameter1 { get; set; }
        static public int applicationParameter2 { get; set; }
        static public int applicationParameter3 { get; set; }
        static public int applicationParameter4 { get; set; }
        static public int appType { get; set; }
        static public string appVersion { get; set; }
        static public bool attrib3DSupport { get; set; }
        static public int attribCpuUsage { get; set; }
        static public bool attribExclusiveVR { get; set; }
        static public PlayStationVREyeToEyeDistanceSettings attribEyeToEyeDistanceSettingVR { get; set; }
        static public bool attribMoveSupport { get; set; }
        static public bool attribShareSupport { get; set; }
        static public bool attribUserManagement { get; set; }
        static public bool attribVROutputEnabled { get; set; }
        static public int audio3dVirtualSpeakerCount { get; set; }
        static public string BackgroundImagePath { get; set; }
        static public string BGMPath { get; set; }
        static public PS4AppCategory category { get; set; }
        static public string contentID { get; set; }
        static public bool contentSearchFeaturesUsed { get; set; }
        static public bool disableAutoHideSplash { get; set; }
        static public int downloadDataSize { get; set; }
        static public bool enableApplicationExit { get; set; }
        static public PS4EnterButtonAssignment enterButtonAssignment { get; set; }
        static public int garlicHeapSize { get; set; }
        static public string iconImagesFolder { get; set; }
        static public string[] includedModules { get; set; }
        static public string masterVersion { get; set; }
        static public string monoEnv { get; set; }
        static public int npAgeRating { get; set; }
        static public string NPtitleDatPath { get; set; }
        static public string npTitleSecret { get; set; }
        static public string npTrophyPackPath { get; set; }
        static public string paramSfxPath { get; set; }
        static public int parentalLevel { get; set; }
        static public string passcode { get; set; }
        static public string PatchChangeinfoPath { get; set; }
        static public bool patchDayOne { get; set; }
        static public string PatchLatestPkgPath { get; set; }
        static public string PatchPkgPath { get; set; }
        static public int playerPrefsMaxSize { get; set; }
        static public bool playerPrefsSupport { get; set; }
        static public int playTogetherPlayerCount { get; set; }
        static public bool pnFriends { get; set; }
        static public bool pnGameCustomData { get; set; }
        static public bool pnPresence { get; set; }
        static public bool pnSessions { get; set; }
        static public string PrivacyGuardImagePath { get; set; }
        static public int proGarlicHeapSize { get; set; }
        static public string PronunciationSIGPath { get; set; }
        static public string PronunciationXMLPath { get; set; }
        static public PS4RemotePlayKeyAssignment remotePlayKeyAssignment { get; set; }
        static public string remotePlayKeyMappingDir { get; set; }
        static public bool reprojectionSupport { get; set; }
        static public bool resetTempFolder { get; set; }
        static public bool restrictedAudioUsageRights { get; set; }
        static public string SaveDataImagePath { get; set; }
        static public int scriptOptimizationLevel { get; set; }
        static public string SdkOverride { get; set; }
        static public string ShareFilePath { get; set; }
        static public string ShareOverlayImagePath { get; set; }
        static public int socialScreenEnabled { get; set; }
        static public string StartupImagePath { get; set; }
        static public string startupImagesFolder { get; set; }
        static public bool useAudio3dBackend { get; set; }
        static public bool useResolutionFallback { get; set; }
        static public int videoOutBaseModeInitialWidth { get; set; }
        static public int videoOutInitialWidth { get; set; }
        static public int videoOutPixelFormat { get; set; }
        static public int videoOutReprojectionRate { get; set; }
        static public int videoOutResolution { get; set; }
        static public bool videoRecordingFeaturesUsed { get; set; }

        public PS4();

        public enum PlayStationVREyeToEyeDistanceSettings
        {
            PerUser = 0,
            ForceDefault = 1,
            DynamicModeAtRuntime = 2,
        }

        public enum PS4AppCategory
        {
            Application = 0,
            Patch = 1,
            Remaster = 2,
        }

        public enum PS4EnterButtonAssignment
        {
            CircleButton = 0,
            CrossButton = 1,
            SystemDefined = 2,
        }

        public enum PS4RemotePlayKeyAssignment
        {
            None = -1,
            PatternA = 0,
            PatternB = 1,
            PatternC = 2,
            PatternD = 3,
            PatternE = 4,
            PatternF = 5,
            PatternG = 6,
            PatternH = 7,
        }

    }

    public class SplashScreen
    {
        static public float animationBackgroundZoom { get; set; }
        static public float animationLogoZoom { get; set; }
        static public AnimationMode animationMode { get; set; }
        static public Sprite background { get; set; }
        static public Color backgroundColor { get; set; }
        static public Sprite backgroundPortrait { get; set; }
        static public bool blurBackgroundImage { get; set; }
        static public DrawMode drawMode { get; set; }
        static public SplashScreenLogo[] logos { get; set; }
        static public float overlayOpacity { get; set; }
        static public bool show { get; set; }
        static public bool showUnityLogo { get; set; }
        static public UnityLogoStyle unityLogoStyle { get; set; }

        public SplashScreen();

        public enum AnimationMode
        {
            Static = 0,
            Dolly = 1,
            Custom = 2,
        }

        public enum DrawMode
        {
            UnityLogoBelow = 0,
            AllSequential = 1,
        }

        public enum UnityLogoStyle
        {
            DarkOnLight = 0,
            LightOnDark = 1,
        }

    }

    public struct SplashScreenLogo
    {
        static public Sprite unityLogo { get; }

        static public SplashScreenLogo Create();
        static public SplashScreenLogo Create(float duration);
        static public SplashScreenLogo Create(float duration, Sprite logo);
        static public SplashScreenLogo CreateWithUnityLogo();
        static public SplashScreenLogo CreateWithUnityLogo(float duration);

        public float duration { get; set; }
        public Sprite logo { get; set; }

    }

    public sealed class Switch
    {
        static public string accessibleURLPath { get; set; }
        static public ApplicationAttribute applicationAttribute { get; set; }
        static public string applicationErrorCodeCategory { get; set; }
        static public string applicationID { get; set; }
        static public int cardSpecClock { get; set; }
        static public int cardSpecSize { get; set; }
        static public int defaultSwitchQueueCommandMemory { get; }
        static public int defaultSwitchQueueComputeMemory { get; }
        static public int defaultSwitchQueueControlMemory { get; }
        static public string displayVersion { get; set; }
        static public Texture2D[] icons { get; set; }
        static public bool isAllowsScreenshot { get; set; }
        static public bool isDataLossConfirmation { get; set; }
        static public bool isDataLossConfirmationEnabled { get; set; }
        static public bool isHoldTypeHorizontal { get; set; }
        static public bool isRuntimeAddOnContentInstallEnabled { get; set; }
        static public bool isScreenshotEnabled { get; set; }
        static public bool isUnderParentalControl { get; set; }
        static public bool isUserAccountLockEnabled { get; set; }
        static public bool isVideoCapturingEnabled { get; set; }
        static public string legalInformationPath { get; set; }
        static public string[] localCommunicationIds { get; set; }
        static public LogoHandling logoHandling { get; set; }
        static public LogoType logoType { get; set; }
        static public int mainThreadStackSize { get; set; }
        static public string manualHTMLPath { get; set; }
        static public int minimumSwitchQueueCommandMemory { get; }
        static public int minimumSwitchQueueControlMemory { get; }
        static public int nativeFsCacheSize { get; set; }
        static public bool networkInterfaceManagerInitializeEnabled { get; set; }
        static public string nsoDependencies { get; set; }
        static public int NVNDefaultPoolsGranularity { get; set; }
        static public int NVNOtherPoolsGranularity { get; set; }
        static public int NVNShaderPoolsGranularity { get; set; }
        static public bool playerConnectionEnabled { get; set; }
        static public string presenceGroupId { get; set; }
        static public string[] publisherNames { get; set; }
        static public int queueCommandMemory { get; set; }
        static public int queueComputeMemory { get; set; }
        static public int queueControlMemory { get; set; }
        static public int[] ratingAgeArray { get; set; }
        static public int ratingsMask { get; set; }
        static public string releaseVersion { get; set; }
        static public ScreenResolutionBehavior screenResolutionBehavior { get; set; }
        static public Texture2D[] smallIcons { get; set; }
        static public int socketAllocatorPoolSize { get; set; }
        static public int socketBufferEfficiency { get; set; }
        static public int socketConcurrencyLimit { get; set; }
        static public bool socketConfigEnabled { get; set; }
        static public bool socketInitializeEnabled { get; set; }
        static public int socketMemoryPoolSize { get; set; }
        static public StartupUserAccount startupUserAccount { get; set; }
        static public int supportedLanguages { get; set; }
        static public int supportedNpadCount { get; set; }
        static public SupportedNpadStyle supportedNpadStyles { get; set; }
        static public int systemResourceMemory { get; set; }
        static public int tcpAutoReceiveBufferSizeMax { get; set; }
        static public int tcpAutoSendBufferSizeMax { get; set; }
        static public int tcpInitialReceiveBufferSize { get; set; }
        static public int tcpInitialSendBufferSize { get; set; }
        static public string[] titleNames { get; set; }
        static public TouchScreenUsage touchScreenUsage { get; set; }
        static public int udpReceiveBufferSize { get; set; }
        static public int udpSendBufferSize { get; set; }
        static public int userAccountSaveDataJournalSize { get; set; }
        static public int userAccountSaveDataSize { get; set; }
        static public bool useSwitchCPUProfiler { get; set; }

        static public int GetRatingAge(RatingCategories category);

        public Switch();

        public enum ApplicationAttribute
        {
            None = 0,
            Demo = 1,
        }

        public enum Languages
        {
            AmericanEnglish = 0,
            BritishEnglish = 1,
            Japanese = 2,
            French = 3,
            German = 4,
            LatinAmericanSpanish = 5,
            Spanish = 6,
            Italian = 7,
            Dutch = 8,
            CanadianFrench = 9,
            Portuguese = 10,
            Russian = 11,
            SimplifiedChinese = 12,
            TraditionalChinese = 13,
            Korean = 14,
        }

        public enum LogoHandling
        {
            Auto = 0,
            Manual = 1,
        }

        public enum LogoType
        {
            LicensedByNintendo = 0,
            DistributedByNintendo = 1,
            Nintendo = 2,
        }

        public enum RatingCategories
        {
            CERO = 0,
            GRACGCRB = 1,
            GSRMR = 2,
            ESRB = 3,
            ClassInd = 4,
            USK = 5,
            PEGI = 6,
            PEGIPortugal = 7,
            PEGIBBFC = 8,
            Russian = 9,
            ACB = 10,
            OFLC = 11,
            IARCGeneric = 12,
        }

        public enum ScreenResolutionBehavior
        {
            Manual = 0,
            OperationMode = 1,
            PerformanceMode = 2,
            Both = 3,
        }

        public enum StartupUserAccount
        {
            None = 0,
            Required = 1,
            RequiredWithNetworkServiceAccountAvailable = 2,
        }

        public enum SupportedNpadStyle
        {
            FullKey = 2,
            Handheld = 4,
            JoyDual = 16,
            JoyLeft = 256,
            JoyRight = 65536,
        }

        public enum TouchScreenUsage
        {
            Supported = 0,
            Required = 1,
            None = 2,
        }

    }

    public class tvOS
    {
        static public string buildNumber { get; set; }
        static public bool requireExtendedGameController { get; set; }
        static public UnityEditor.tvOSSdkVersion sdkVersion { get; set; }
        static public UnityEditor.tvOSTargetOSVersion targetOSVersion { get; set; }
        static public string targetOSVersionString { get; set; }

        public tvOS();

    }

    public static class VRCardboard
    {
        static public int depthFormat { get; set; }

    }

    public static class VRDaydream
    {
        static public Texture2D daydreamIcon { get; set; }
        static public Texture2D daydreamIconBackground { get; set; }
        static public int depthFormat { get; set; }
        static public bool enableVideoSurface { get; set; }
        static public bool enableVideoSurfaceProtectedMemory { get; set; }
        static public UnityEditor.XR.Daydream.SupportedHeadTracking maximumSupportedHeadTracking { get; set; }
        static public UnityEditor.XR.Daydream.SupportedHeadTracking minimumSupportedHeadTracking { get; set; }

    }

    public class VROculus
    {
        static public bool dashSupport { get; set; }
        static public bool lowOverheadMode { get; set; }
        static public bool protectedContext { get; set; }
        static public bool sharedDepthBuffer { get; set; }
        static public bool v2Signing { get; set; }

        public VROculus();

    }

    public static class VRWindowsMixedReality
    {
        static public DepthBufferFormat depthBufferFormat { get; set; }
        static public bool depthBufferSharingEnabled { get; set; }

        public enum DepthBufferFormat
        {
            DepthBufferFormat16Bit = 0,
            DepthBufferFormat24Bit = 1,
        }

    }

    public sealed class WebGL
    {
        static public bool analyzeBuildSize { get; set; }
        static public UnityEditor.WebGLCompressionFormat compressionFormat { get; set; }
        static public bool dataCaching { get; set; }
        static public bool debugSymbols { get; set; }
        static public string emscriptenArgs { get; set; }
        static public UnityEditor.WebGLExceptionSupport exceptionSupport { get; set; }
        static public UnityEditor.WebGLLinkerTarget linkerTarget { get; set; }
        static public int memorySize { get; set; }
        static public string modulesDirectory { get; set; }
        static public bool nameFilesAsHashes { get; set; }
        static public string template { get; set; }
        static public bool threadsSupport { get; set; }
        static public bool useEmbeddedResources { get; set; }
        static public bool useWasm { get; set; }
        static public bool wasmStreaming { get; set; }

        public WebGL();

    }

    public sealed class WSA
    {
        static public string applicationDescription { get; set; }
        static public string certificateIssuer { get; }
        static public Nullable<DateTime> certificateNotAfter { get; }
        static public string certificatePath { get; }
        static public string certificateSubject { get; }
        static public string commandLineArgsFile { get; set; }
        static public WSADefaultTileSize defaultTileSize { get; set; }
        static public bool enableIndependentInputSource { get; set; }
        static public bool enableLowLatencyPresentationAPI { get; set; }
        static public WSAInputSource inputSource { get; set; }
        static public bool largeTileShowName { get; set; }
        static public int lastRequiredScene { get; set; }
        static public bool mediumTileShowName { get; set; }
        static public string packageLogo { get; set; }
        static public string packageLogo140 { get; set; }
        static public string packageLogo180 { get; set; }
        static public string packageLogo240 { get; set; }
        static public string packageName { get; set; }
        static public Version packageVersion { get; set; }
        static public string phoneAppIcon { get; set; }
        static public string phoneAppIcon140 { get; set; }
        static public string phoneAppIcon240 { get; set; }
        static public string phoneMediumTile { get; set; }
        static public string phoneMediumTile140 { get; set; }
        static public string phoneMediumTile240 { get; set; }
        static public string phoneSmallTile { get; set; }
        static public string phoneSmallTile140 { get; set; }
        static public string phoneSmallTile240 { get; set; }
        static public string phoneSplashScreenImage { get; set; }
        static public string phoneSplashScreenImageScale140 { get; set; }
        static public string phoneSplashScreenImageScale240 { get; set; }
        static public string phoneWideTile { get; set; }
        static public string phoneWideTile140 { get; set; }
        static public string phoneWideTile240 { get; set; }
        static public Nullable<Color> splashScreenBackgroundColor { get; set; }
        static public string storeLargeTile { get; set; }
        static public string storeLargeTile140 { get; set; }
        static public string storeLargeTile180 { get; set; }
        static public string storeLargeTile80 { get; set; }
        static public string storeSmallTile { get; set; }
        static public string storeSmallTile140 { get; set; }
        static public string storeSmallTile180 { get; set; }
        static public string storeSmallTile80 { get; set; }
        static public string storeSplashScreenImage { get; set; }
        static public string storeSplashScreenImageScale140 { get; set; }
        static public string storeSplashScreenImageScale180 { get; set; }
        static public string storeTileLogo { get; set; }
        static public string storeTileLogo140 { get; set; }
        static public string storeTileLogo180 { get; set; }
        static public string storeTileLogo80 { get; set; }
        static public string storeTileSmallLogo { get; set; }
        static public string storeTileSmallLogo140 { get; set; }
        static public string storeTileSmallLogo180 { get; set; }
        static public string storeTileSmallLogo80 { get; set; }
        static public string storeTileWideLogo { get; set; }
        static public string storeTileWideLogo140 { get; set; }
        static public string storeTileWideLogo180 { get; set; }
        static public string storeTileWideLogo80 { get; set; }
        static public bool supportStreamingInstall { get; set; }
        static public Color tileBackgroundColor { get; set; }
        static public WSAApplicationForegroundText tileForegroundText { get; set; }
        static public string tileShortName { get; set; }
        static public WSAApplicationShowName tileShowName { get; set; }
        static public bool transparentSwapchain { get; set; }
        static public bool wideTileShowName { get; set; }

        static public bool GetCapability(WSACapability capability);
        static public bool GetTargetDeviceFamily(WSATargetFamily family);
        static public string GetVisualAssetsImage(WSAImageType type, WSAImageScale scale);
        static public void SetCapability(WSACapability capability, bool value);
        static public bool SetCertificate(string path, string password);
        static public void SetTargetDeviceFamily(WSATargetFamily family, bool value);
        static public void SetVisualAssetsImage(string image, WSAImageType type, WSAImageScale scale);

        public WSA();

        public static class Declarations
        {
            static public WSAFileTypeAssociations fileTypeAssociations { get; set; }
            static public string protocolName { get; set; }

        }

    }

    public enum WSAApplicationForegroundText
    {
        Light = 1,
        Dark = 2,
    }

    public enum WSAApplicationShowName
    {
        NotSet = 0,
        AllLogos = 1,
        NoLogos = 2,
        StandardLogoOnly = 3,
        WideLogoOnly = 4,
    }

    public enum WSACapability
    {
        EnterpriseAuthentication = 0,
        InternetClient = 1,
        InternetClientServer = 2,
        MusicLibrary = 3,
        PicturesLibrary = 4,
        PrivateNetworkClientServer = 5,
        RemovableStorage = 6,
        SharedUserCertificates = 7,
        VideosLibrary = 8,
        WebCam = 9,
        Proximity = 10,
        Microphone = 11,
        Location = 12,
        HumanInterfaceDevice = 13,
        AllJoyn = 14,
        BlockedChatMessages = 15,
        Chat = 16,
        CodeGeneration = 17,
        Objects3D = 18,
        PhoneCall = 19,
        UserAccountInformation = 20,
        VoipCall = 21,
        Bluetooth = 22,
        SpatialPerception = 23,
        InputInjectionBrokered = 24,
        Appointments = 25,
        BackgroundMediaPlayback = 26,
        Contacts = 27,
        LowLevelDevices = 28,
        OfflineMapsManagement = 29,
        PhoneCallHistoryPublic = 30,
        PointOfService = 31,
        RecordedCallsFolder = 32,
        RemoteSystem = 33,
        SystemManagement = 34,
        UserDataTasks = 35,
        UserNotificationListener = 36,
        GazeInput = 37,
    }

    public enum WSADefaultTileSize
    {
        NotSet = 0,
        Medium = 1,
        Wide = 2,
    }

    public struct WSAFileTypeAssociations
    {
        public string name;
        public WSASupportedFileType[] supportedFileTypes;

    }

    public enum WSAImageScale
    {
        Target16 = 16,
        Target24 = 24,
        Target32 = 32,
        Target48 = 48,
        _80 = 80,
        _100 = 100,
        _125 = 125,
        _140 = 140,
        _150 = 150,
        _180 = 180,
        _200 = 200,
        _240 = 240,
        Target256 = 256,
        _400 = 400,
    }

    public enum WSAImageType
    {
        PackageLogo = 1,
        SplashScreenImage = 2,
        UWPSquare44x44Logo = 31,
        UWPSquare71x71Logo = 32,
        UWPSquare150x150Logo = 33,
        UWPSquare310x310Logo = 34,
        UWPWide310x150Logo = 35,
    }

    public enum WSAInputSource
    {
        CoreWindow = 0,
        IndependentInputSource = 1,
        SwapChainPanel = 2,
    }

    public struct WSASupportedFileType
    {
        public string contentType;
        public string fileType;

    }

    public enum WSATargetFamily
    {
        Desktop = 0,
        Mobile = 1,
        Xbox = 2,
        Holographic = 3,
        Team = 4,
        IoT = 5,
        IoTHeadless = 6,
    }

    public sealed class XboxOne
    {
        static public string[] AllowedProductIds { get; }
        static public string AppManifestOverridePath { get; set; }
        static public string ContentId { get; set; }
        static public UnityEditor.XboxOneLoggingLevel defaultLoggingLevel { get; set; }
        static public string Description { get; set; }
        static public bool DisableKinectGpuReservation { get; set; }
        static public bool Enable7thCore { get; set; }
        static public bool EnablePIXSampling { get; set; }
        static public bool EnableVariableGPU { get; set; }
        static public string GameOsOverridePath { get; set; }
        static public bool IsContentPackage { get; set; }
        static public int monoLoggingLevel { get; set; }
        static public string OverrideIdentityName { get; set; }
        static public UnityEditor.XboxOnePackageUpdateGranularity PackageUpdateGranularity { get; set; }
        static public UnityEditor.XboxOneEncryptionLevel PackagingEncryption { get; set; }
        static public string PackagingOverridePath { get; set; }
        static public uint PersistentLocalStorageSize { get; set; }
        static public uint PresentImmediateThreshold { get; set; }
        static public string ProductId { get; set; }
        static public string SandboxId { get; set; }
        static public string SCID { get; set; }
        static public UnityEditor.ScriptCompiler scriptCompiler { get; set; }
        static public string[] SocketNames { get; }
        static public string TitleId { get; set; }
        static public string UpdateKey { get; set; }
        static public string Version { get; set; }
        static public int XTitleMemory { get; set; }

        static public bool AddAllowedProductId(string id);
        static public bool GetCapability(string capability);
        static public int GetGameRating(string name);
        static public void GetSocketDefinition(string name, out string port, out int protocol, out int usages, out string templateName, out int sessionRequirment, out int deviceUsages);
        static public bool GetSupportedLanguage(string language);
        static public void RemoveAllowedProductId(string id);
        static public void RemoveSocketDefinition(string name);
        static public void SetCapability(string capability, bool value);
        static public void SetGameRating(string name, int value);
        static public void SetSocketDefinition(string name, string port, int protocol, int[] usages, string templateName, int sessionRequirment, int[] deviceUsages);
        static public void SetSupportedLanguage(string language, bool enabled);
        static public void UpdateAllowedProductId(int idx, string id);

        public XboxOne();

    }

}

}
