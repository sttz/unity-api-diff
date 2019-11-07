using System;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public static class ContentBuildInterface
{
    static public uint ArchiveAndCompress(UnityEditor.Build.Content.ResourceFile[] resourceFiles, string outputBundlePath, BuildCompression compression);
    static public uint ArchiveAndCompress(UnityEditor.Build.Content.ResourceFile[] resourceFiles, string outputBundlePath, BuildCompression compression, bool stripUnityVersion);
    static public void CalculateBuildUsageTags(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs, UnityEditor.Build.Content.ObjectIdentifier[] dependentObjectIDs, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet);
    static public void CalculateBuildUsageTags(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs, UnityEditor.Build.Content.ObjectIdentifier[] dependentObjectIDs, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache);
    static public UnityEditor.Build.Content.SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet);
    static public UnityEditor.Build.Content.SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache);
    static public UnityEditor.AssetBundleBuild[] GenerateAssetBundleBuilds();
    static public UnityEditor.Build.Content.BuildUsageTagGlobal GetGlobalUsageFromGraphicsSettings();
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObject(UnityEditor.Build.Content.ObjectIdentifier objectID, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObjects(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerObjectIdentifiersInAsset(UnityEditor.GUID asset, UnityEditor.BuildTarget target);
    static public Type GetTypeForObject(UnityEditor.Build.Content.ObjectIdentifier objectID);
    static public Type[] GetTypeForObjects(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs);
    static public UnityEditor.Build.Content.SceneDependencyInfo PrepareScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet, string outputFolder);
    static public UnityEditor.Build.Content.SceneDependencyInfo PrepareScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache, string outputFolder);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteSceneParameters parameters);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap, UnityEditor.Build.Content.PreloadInfo preloadInfo);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap, UnityEditor.Build.Content.PreloadInfo preloadInfo, UnityEditor.Build.Content.SceneBundleInfo sceneBundleInfo);
    static public UnityEditor.Build.Content.WriteResult WriteSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteParameters parameters);
    static public UnityEditor.Build.Content.WriteResult WriteSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap);
    static public UnityEditor.Build.Content.WriteResult WriteSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap, UnityEditor.Build.Content.AssetBundleInfo bundleInfo);

}

}
