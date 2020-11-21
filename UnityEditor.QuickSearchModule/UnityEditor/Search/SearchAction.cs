using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchAction
{
    public bool closeWindowAfterExecution;
    public Func<IReadOnlyCollection<UnityEditor.Search.SearchItem>, bool> enabled;
    public Action<UnityEditor.Search.SearchItem[]> execute;
    public Action<UnityEditor.Search.SearchItem> handler;

    public string displayName { get; }
    public string id { get; private set; }

    public SearchAction(string providerId, string id, GUIContent content);
    public SearchAction(string providerId, string id, GUIContent content, Action<UnityEditor.Search.SearchItem[]> handler);
    public SearchAction(string providerId, string id, GUIContent content, Action<UnityEditor.Search.SearchItem> handler);
    public SearchAction(string providerId, string name, Texture2D icon = null, string tooltip = null);
    public SearchAction(string providerId, string name, Texture2D icon, string tooltip, Action<UnityEditor.Search.SearchItem[]> handler);
    public SearchAction(string providerId, string name, Texture2D icon, string tooltip, Action<UnityEditor.Search.SearchItem> handler);

}

}
