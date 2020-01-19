using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.PackageManager
{

public static class Client
{
    static public UnityEditor.PackageManager.Requests.AddRequest Add(string packageIdOrName);
    static public UnityEditor.PackageManager.Requests.ListRequest List();
    static public UnityEditor.PackageManager.Requests.ListRequest List(bool offlineMode);
    static public UnityEditor.PackageManager.Requests.ListRequest List(bool offlineMode, bool includeIndirectDependencies);
    static public UnityEditor.PackageManager.Requests.RemoveRequest Remove(string packageIdOrName);
    static public UnityEditor.PackageManager.Requests.ResetToEditorDefaultsRequest ResetToEditorDefaults();
    static public UnityEditor.PackageManager.Requests.SearchRequest Search(string packageIdOrName);
    static public UnityEditor.PackageManager.Requests.SearchRequest Search(string packageIdOrName, bool offlineMode);
    static public UnityEditor.PackageManager.Requests.SearchRequest SearchAll();
    static public UnityEditor.PackageManager.Requests.SearchRequest SearchAll(bool offlineMode);

}

}
