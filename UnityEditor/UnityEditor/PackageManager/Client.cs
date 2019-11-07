using System;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public static class Client
{
    static public UnityEditor.PackageManager.Requests.AddRequest Add(string packageIdOrName);
    static public UnityEditor.PackageManager.Requests.ListRequest List(bool offlineMode = false);
    static public UnityEditor.PackageManager.Requests.RemoveRequest Remove(string packageIdOrName);
    static public UnityEditor.PackageManager.Requests.ResetToEditorDefaultsRequest ResetToEditorDefaults();
    static public UnityEditor.PackageManager.Requests.SearchRequest Search(string packageIdOrName);
    static public UnityEditor.PackageManager.Requests.SearchRequest SearchAll();

}

}
