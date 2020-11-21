using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public static class SearchUtils
{
    static public char[] entrySeparators;

    static public IEnumerable<GameObject> FetchGameObjects();
    static public GameObject[] FetchGameObjects(SceneManagement.Scene scene);
    static public string[] FindShiftLeftVariations(string word);
    static public string GetHierarchyAssetPath(GameObject gameObject, bool prefabOnly = false);
    static public string GetHierarchyPath(GameObject gameObject, bool includeScene = true);
    static public string GetObjectPath(Object obj);
    static public string GetTransformPath(Transform tform);
    static public bool MatchSearchGroups(UnityEditor.Search.SearchContext context, string content, bool ignoreCase = false);
    static public void SelectMultipleItems(IEnumerable<UnityEditor.Search.SearchItem> items, bool focusProjectBrowser = false);
    static public string[] SplitCamelCase(string source);
    static public IEnumerable<string> SplitEntryComponents(string entry, char[] entrySeparators);
    static public IEnumerable<string> SplitFileEntryComponents(string path, char[] entrySeparators);

}

}
