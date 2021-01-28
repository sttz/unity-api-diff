using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public static class ContentBuildInterface
{
    static public uint ArchiveAndCompress(UnityEditor.Build.Content.ResourceFile[] resourceFiles, string outputBundlePath, BuildCompression compression);
    static public uint ArchiveAndCompress(UnityEditor.Build.Content.ResourceFile[] resourceFiles, string outputBundlePath, BuildCompression compression, bool stripUnityVersion);
    static public void CalculateBuildUsageTags(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs, UnityEditor.Build.Content.ObjectIdentifier[] dependentObjectIDs, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet);
    static public void CalculateBuildUsageTags(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs, UnityEditor.Build.Content.ObjectIdentifier[] dependentObjectIDs, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache);
    static public UnityEditor.Build.Content.GameManagerDependencyInfo CalculatePlayerDependenciesForGameManagers(UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet);
    static public UnityEditor.Build.Content.GameManagerDependencyInfo CalculatePlayerDependenciesForGameManagers(UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache);
    static public UnityEditor.Build.Content.GameManagerDependencyInfo CalculatePlayerDependenciesForGameManagers(UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache, UnityEditor.Build.Content.DependencyType mode);
    static public UnityEditor.Build.Content.SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet);
    static public UnityEditor.Build.Content.SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache);
    static public UnityEditor.Build.Content.SceneDependencyInfo CalculatePlayerDependenciesForScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache, UnityEditor.Build.Content.DependencyType mode);
    static public Hash128 CalculatePlayerSerializationHashForType(Type type, UnityEditor.Build.Player.TypeDB typeDB);
    static public UnityEditor.AssetBundleBuild[] GenerateAssetBundleBuilds();
    static public UnityEditor.Build.Content.BuildUsageTagGlobal GetGlobalUsageFromGraphicsSettings();
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerAssetRepresentations(UnityEditor.GUID asset, UnityEditor.BuildTarget target);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObject(UnityEditor.Build.Content.ObjectIdentifier objectID, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObject(Object targetObject, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObject(UnityEditor.Build.Content.ObjectIdentifier objectID, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB, UnityEditor.Build.Content.DependencyType mode);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObject(Object targetObject, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB, UnityEditor.Build.Content.DependencyType mode);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObjects(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObjects(Object[] objects, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObjects(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB, UnityEditor.Build.Content.DependencyType mode);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerDependenciesForObjects(Object[] objects, UnityEditor.BuildTarget target, UnityEditor.Build.Player.TypeDB typeDB, UnityEditor.Build.Content.DependencyType mode);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerObjectIdentifiersInAsset(UnityEditor.GUID asset, UnityEditor.BuildTarget target);
    static public UnityEditor.Build.Content.ObjectIdentifier[] GetPlayerObjectIdentifiersInSerializedFile(string filePath, UnityEditor.BuildTarget target);
    static public Type GetTypeForObject(UnityEditor.Build.Content.ObjectIdentifier objectID);
    static public Type[] GetTypeForObjects(UnityEditor.Build.Content.ObjectIdentifier[] objectIDs);
    static public Type[] GetTypesForObject(UnityEditor.Build.Content.ObjectIdentifier objectID);
    static public bool ObjectIsSupportedInBuild(Object targetObject);
    static public UnityEditor.Build.Content.SceneDependencyInfo PrepareScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet, string outputFolder);
    static public UnityEditor.Build.Content.SceneDependencyInfo PrepareScene(string scenePath, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildUsageCache usageCache, string outputFolder);
    static public void StartProfileCapture(UnityEditor.Build.Content.ProfileCaptureOptions options);
    static public UnityEditor.Build.Content.ContentBuildProfileEvent[] StopProfileCapture();
    static public UnityEditor.Build.Content.WriteResult WriteGameManagersSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteManagerParameters parameters);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteSceneParameters parameters);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap, UnityEditor.Build.Content.PreloadInfo preloadInfo);
    static public UnityEditor.Build.Content.WriteResult WriteSceneSerializedFile(string outputFolder, string scenePath, string processedScene, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap, UnityEditor.Build.Content.PreloadInfo preloadInfo, UnityEditor.Build.Content.SceneBundleInfo sceneBundleInfo);
    static public UnityEditor.Build.Content.WriteResult WriteSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteParameters parameters);
    static public UnityEditor.Build.Content.WriteResult WriteSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap);
    static public UnityEditor.Build.Content.WriteResult WriteSerializedFile(string outputFolder, UnityEditor.Build.Content.WriteCommand writeCommand, UnityEditor.Build.Content.BuildSettings settings, UnityEditor.Build.Content.BuildUsageTagGlobal globalUsage, UnityEditor.Build.Content.BuildUsageTagSet usageSet, UnityEditor.Build.Content.BuildReferenceMap referenceMap, UnityEditor.Build.Content.AssetBundleInfo bundleInfo);

}

}
