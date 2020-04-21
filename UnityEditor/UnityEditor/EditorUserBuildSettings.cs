using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class EditorUserBuildSettings : Object
{
    static public Action activeBuildTargetChanged;

    static public UnityEditor.BuildTarget activeBuildTarget { get; }
    static public string[] activeScriptCompilationDefines { get; }
    static public bool allowDebugging { get; set; }
    static public UnityEditor.MobileTextureSubtarget androidBuildSubtarget { get; set; }
    static public UnityEditor.AndroidBuildSystem androidBuildSystem { get; set; }
    static public UnityEditor.AndroidBuildType androidBuildType { get; set; }
    static public bool androidCreateSymbolsZip { get; set; }
    static public UnityEditor.AndroidMinification androidDebugMinification { get; set; }
    static public UnityEditor.AndroidETC2Fallback androidETC2Fallback { get; set; }
    static public UnityEditor.AndroidMinification androidReleaseMinification { get; set; }
    static public bool androidUseLegacySdkTools { get; set; }
    static public bool buildAppBundle { get; set; }
    static public bool buildScriptsOnly { get; set; }
    static public bool buildWithDeepProfilingSupport { get; set; }
    static public bool compressFilesInPackage { get; set; }
    static public bool compressWithPsArc { get; set; }
    static public bool connectProfiler { get; set; }
    static public bool development { get; set; }
    static public bool enableHeadlessMode { get; set; }
    static public bool explicitArrayBoundsChecks { get; set; }
    static public bool explicitDivideByZeroChecks { get; set; }
    static public bool explicitNullChecks { get; set; }
    static public bool exportAsGoogleAndroidProject { get; set; }
    static public bool forceInstallation { get; set; }
    static public bool forceOptimizeScriptCompilation { get; }
    static public bool installInBuildFolder { get; set; }
    static public UnityEditor.iOSBuildType iOSBuildConfigType { get; set; }
    static public bool movePackageToDiscOuterEdge { get; set; }
    static public bool needSubmissionMaterials { get; set; }
    static public UnityEditor.PS4BuildSubtarget ps4BuildSubtarget { get; set; }
    static public UnityEditor.PS4HardwareTarget ps4HardwareTarget { get; set; }
    static public UnityEditor.BuildTargetGroup selectedBuildTargetGroup { get; set; }
    static public UnityEditor.BuildTarget selectedStandaloneTarget { get; set; }
    static public int streamingInstallLaunchRange { get; set; }
    static public bool switchCreateRomFile { get; set; }
    static public bool switchEnableDebugPad { get; set; }
    static public bool switchEnableHeapInspector { get; set; }
    static public bool switchHTCSScriptDebugging { get; set; }
    static public bool switchNVNDrawValidation { get; set; }
    static public bool switchNVNDrawValidation_Heavy { get; set; }
    static public bool switchNVNDrawValidation_Light { get; set; }
    static public bool switchNVNGraphicsDebugger { get; set; }
    static public bool switchNVNShaderDebugging { get; set; }
    static public bool switchRedirectWritesToHostMount { get; set; }
    static public bool symlinkLibraries { get; set; }
    static public bool waitForManagedDebugger { get; set; }
    static public bool waitForPlayerConnection { get; set; }
    static public bool webGLUsePreBuiltUnityEngine { get; set; }
    static public string windowsDevicePortalAddress { get; set; }
    static public string windowsDevicePortalPassword { get; set; }
    static public string windowsDevicePortalUsername { get; set; }
    static public string wsaArchitecture { get; set; }
    static public UnityEditor.WSABuildAndRunDeployTarget wsaBuildAndRunDeployTarget { get; set; }
    static public string wsaMinUWPSDK { get; set; }
    static public UnityEditor.WSASDK wsaSDK { get; set; }
    static public UnityEditor.WSASubtarget wsaSubtarget { get; set; }
    static public UnityEditor.WSAUWPBuildType wsaUWPBuildType { get; set; }
    static public string wsaUWPSDK { get; set; }
    static public string wsaUWPVisualStudioVersion { get; set; }
    static public UnityEditor.XboxBuildSubtarget xboxBuildSubtarget { get; set; }
    static public string xboxOneAdditionalDebugPorts { get; set; }
    static public UnityEditor.XboxOneDeployDrive xboxOneDeployDrive { get; set; }
    static public UnityEditor.XboxOneDeployMethod xboxOneDeployMethod { get; set; }
    static public string xboxOneNetworkSharePath { get; set; }
    static public bool xboxOneRebootIfDeployFailsAndRetry { get; set; }
    static public string xboxOneUsername { get; set; }

    static public string GetBuildLocation(UnityEditor.BuildTarget target);
    static public string GetPlatformSettings(string platformName, string name);
    static public string GetPlatformSettings(string buildTargetGroup, string platformName, string name);
    static public void SetBuildLocation(UnityEditor.BuildTarget target, string location);
    static public void SetPlatformSettings(string platformName, string name, string value);
    static public void SetPlatformSettings(string buildTargetGroup, string buildTarget, string name, string value);
    static public bool SwitchActiveBuildTarget(UnityEditor.BuildTarget target);
    static public bool SwitchActiveBuildTarget(UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget target);
    static public bool SwitchActiveBuildTargetAsync(UnityEditor.BuildTargetGroup targetGroup, UnityEditor.BuildTarget target);

}

}
