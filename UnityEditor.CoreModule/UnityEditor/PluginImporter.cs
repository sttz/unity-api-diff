using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class PluginImporter : UnityEditor.AssetImporter
{
    static public UnityEditor.PluginImporter[] GetAllImporters();
    static public UnityEditor.PluginImporter[] GetImporters(UnityEditor.BuildTarget platform);
    static public UnityEditor.PluginImporter[] GetImporters(string platformName);
    static public UnityEditor.PluginImporter[] GetImporters(string buildTargetGroup, string buildTarget);
    static public UnityEditor.PluginImporter[] GetImporters(UnityEditor.BuildTargetGroup buildTargetGroup, UnityEditor.BuildTarget buildTarget);

    public string[] DefineConstraints { get; set; }
    public bool isNativePlugin { get; }
    public bool isPreloaded { get; set; }

    public PluginImporter();

    public void ClearSettings();
    public bool GetCompatibleWithAnyPlatform();
    public bool GetCompatibleWithEditor();
    public bool GetCompatibleWithEditor(string buildTargetGroup, string buildTarget);
    public bool GetCompatibleWithPlatform(UnityEditor.BuildTarget platform);
    public bool GetCompatibleWithPlatform(string platformName);
    public string GetEditorData(string key);
    public bool GetExcludeEditorFromAnyPlatform();
    public bool GetExcludeFromAnyPlatform(UnityEditor.BuildTarget platform);
    public bool GetExcludeFromAnyPlatform(string platformName);
    public bool GetIsOverridable();
    public string GetPlatformData(UnityEditor.BuildTarget platform, string key);
    public string GetPlatformData(string platformName, string key);
    public void SetCompatibleWithAnyPlatform(bool enable);
    public void SetCompatibleWithEditor(bool enable);
    public void SetCompatibleWithPlatform(UnityEditor.BuildTarget platform, bool enable);
    public void SetCompatibleWithPlatform(string platformName, bool enable);
    public void SetEditorData(string key, string value);
    public void SetExcludeEditorFromAnyPlatform(bool excludedFromAny);
    public void SetExcludeFromAnyPlatform(UnityEditor.BuildTarget platform, bool excludedFromAny);
    public void SetExcludeFromAnyPlatform(string platformName, bool excludedFromAny);
    public void SetIncludeInBuildDelegate(IncludeInBuildDelegate includeInBuildDelegate);
    public void SetPlatformData(UnityEditor.BuildTarget platform, string key, string value);
    public void SetPlatformData(string platformName, string key, string value);
    public bool ShouldIncludeInBuild();

    public delegate bool IncludeInBuildDelegate(string path);

}

}
