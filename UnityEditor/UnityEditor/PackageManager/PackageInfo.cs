using System;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public sealed class PackageInfo
{
    static public UnityEditor.PackageManager.PackageInfo FindForAssembly(System.Reflection.Assembly assembly);
    static public UnityEditor.PackageManager.PackageInfo FindForAssetPath(string assetPath);

    public string assetPath { get; }
    public UnityEditor.PackageManager.AuthorInfo author { get; }
    public string category { get; }
    public Nullable<DateTime> datePublished { get; }
    public UnityEditor.PackageManager.DependencyInfo[] dependencies { get; }
    public string description { get; }
    public string displayName { get; }
    public UnityEditor.PackageManager.Error[] errors { get; }
    public bool isDirectDependency { get; }
    public string[] keywords { get; }
    public string name { get; }
    public string packageId { get; }
    public UnityEditor.PackageManager.RegistryInfo registry { get; }
    public UnityEditor.PackageManager.DependencyInfo[] resolvedDependencies { get; }
    public string resolvedPath { get; }
    public UnityEditor.PackageManager.PackageSource source { get; }
    public UnityEditor.PackageManager.PackageStatus status { get; }
    public string type { get; }
    public string version { get; }
    public UnityEditor.PackageManager.VersionsInfo versions { get; }

}

}
