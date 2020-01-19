using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class BuildPipeline
{
    static public bool isBuildingPlayer { get; }

    static public bool BuildAssetBundle(Object mainAsset, Object[] assets, string pathName, UnityEditor.BuildAssetBundleOptions assetBundleOptions, UnityEditor.BuildTarget targetPlatform);
    static public bool BuildAssetBundle(Object mainAsset, Object[] assets, string pathName, out uint crc, UnityEditor.BuildAssetBundleOptions assetBundleOptions, UnityEditor.BuildTarget targetPlatform);
    static public bool BuildAssetBundleExplicitAssetNames(Object[] assets, string[] assetNames, string pathName, UnityEditor.BuildAssetBundleOptions assetBundleOptions, UnityEditor.BuildTarget targetPlatform);
    static public bool BuildAssetBundleExplicitAssetNames(Object[] assets, string[] assetNames, string pathName, out uint crc, UnityEditor.BuildAssetBundleOptions assetBundleOptions, UnityEditor.BuildTarget targetPlatform);
    static public AssetBundleManifest BuildAssetBundles(string outputPath, UnityEditor.BuildAssetBundleOptions assetBundleOptions, UnityEditor.BuildTarget targetPlatform);
    static public AssetBundleManifest BuildAssetBundles(string outputPath, UnityEditor.AssetBundleBuild[] builds, UnityEditor.BuildAssetBundleOptions assetBundleOptions, UnityEditor.BuildTarget targetPlatform);
    static public UnityEditor.Build.Reporting.BuildReport BuildPlayer(UnityEditor.BuildPlayerOptions buildPlayerOptions);
    static public UnityEditor.Build.Reporting.BuildReport BuildPlayer(string[] levels, string locationPathName, UnityEditor.BuildTarget target, UnityEditor.BuildOptions options);
    static public UnityEditor.Build.Reporting.BuildReport BuildPlayer(UnityEditor.EditorBuildSettingsScene[] levels, string locationPathName, UnityEditor.BuildTarget target, UnityEditor.BuildOptions options);
    static public string BuildStreamedSceneAssetBundle(string[] levels, string locationPath, UnityEditor.BuildTarget target);
    static public string BuildStreamedSceneAssetBundle(string[] levels, string locationPath, UnityEditor.BuildTarget target, out uint crc);
    static public string BuildStreamedSceneAssetBundle(string[] levels, string locationPath, UnityEditor.BuildTarget target, UnityEditor.BuildOptions options);
    static public string BuildStreamedSceneAssetBundle(string[] levels, string locationPath, UnityEditor.BuildTarget target, out uint crc, UnityEditor.BuildOptions options);
    static public UnityEditor.BuildTargetGroup GetBuildTargetGroup(UnityEditor.BuildTarget platform);
    static public bool GetCRCForAssetBundle(string targetPath, out uint crc);
    static public bool GetHashForAssetBundle(string targetPath, out Hash128 hash);
    static public string GetPlaybackEngineDirectory(UnityEditor.BuildTarget target, UnityEditor.BuildOptions options);
    static public string GetPlaybackEngineDirectory(UnityEditor.BuildTargetGroup buildTargetGroup, UnityEditor.BuildTarget target, UnityEditor.BuildOptions options);
    static public bool IsBuildTargetSupported(UnityEditor.BuildTargetGroup buildTargetGroup, UnityEditor.BuildTarget target);
    static public void PopAssetDependencies();
    static public void PushAssetDependencies();

    public BuildPipeline();

}

}
