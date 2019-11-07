using System;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public static class Client
{
    static public UnityEditor.PackageManager.Requests.AddRequest Add(string identifier);
    static public UnityEditor.PackageManager.Requests.EmbedRequest Embed(string packageName);
    static public UnityEditor.PackageManager.Requests.ListRequest List(bool offlineMode, bool includeIndirectDependencies);
    static public UnityEditor.PackageManager.Requests.ListRequest List(bool offlineMode);
    static public UnityEditor.PackageManager.Requests.ListRequest List();
    static public UnityEditor.PackageManager.Requests.PackRequest Pack(string packageFolder, string targetFolder);
    static public UnityEditor.PackageManager.Requests.RemoveRequest Remove(string packageName);
    static public UnityEditor.PackageManager.Requests.ResetToEditorDefaultsRequest ResetToEditorDefaults();
    static public UnityEditor.PackageManager.Requests.SearchRequest Search(string packageIdOrName, bool offlineMode);
    static public UnityEditor.PackageManager.Requests.SearchRequest Search(string packageIdOrName);
    static public UnityEditor.PackageManager.Requests.SearchRequest SearchAll(bool offlineMode);
    static public UnityEditor.PackageManager.Requests.SearchRequest SearchAll();

}

}
