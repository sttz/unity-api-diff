using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchProvider
{
    public bool active;
    public Func<UnityEditor.Search.SearchItem, UnityEditor.Search.SearchContext, string> fetchDescription;
    public Func<UnityEditor.Search.SearchContext, List<UnityEditor.Search.SearchItem>, UnityEditor.Search.SearchProvider, object> fetchItems;
    public Func<UnityEditor.Search.SearchItem, UnityEditor.Search.SearchContext, string> fetchLabel;
    public Func<UnityEditor.Search.SearchItem, UnityEditor.Search.SearchContext, Vector2, UnityEditor.Search.FetchPreviewOptions, Texture2D> fetchPreview;
    public Func<UnityEditor.Search.SearchItem, UnityEditor.Search.SearchContext, Texture2D> fetchThumbnail;
    public string filterId;
    public Func<bool> isEnabledForContextualSearch;
    public bool isExplicitProvider;
    public Action onDisable;
    public Action onEnable;
    public int priority;
    public bool showDetails;
    public UnityEditor.Search.ShowDetailsOptions showDetailsOptions;
    public Action<UnityEditor.Search.SearchItem, UnityEditor.Search.SearchContext> startDrag;
    public Func<UnityEditor.Search.SearchItem, Type, Object> toObject;
    public Action<UnityEditor.Search.SearchItem, UnityEditor.Search.SearchContext> trackSelection;

    public string id { get; private set; }
    public string name { get; private set; }

    public SearchProvider(string id);
    public SearchProvider(string id, string displayName);
    public SearchProvider(string id, Func<UnityEditor.Search.SearchContext, UnityEditor.Search.SearchProvider, object> fetchItemsHandler);
    public SearchProvider(string id, Func<UnityEditor.Search.SearchContext, List<UnityEditor.Search.SearchItem>, UnityEditor.Search.SearchProvider, object> fetchItemsHandler);
    public SearchProvider(string id, string displayName, Func<UnityEditor.Search.SearchContext, UnityEditor.Search.SearchProvider, object> fetchItemsHandler);
    public SearchProvider(string id, string displayName, Func<UnityEditor.Search.SearchContext, List<UnityEditor.Search.SearchItem>, UnityEditor.Search.SearchProvider, object> fetchItemsHandler);

    public UnityEditor.Search.SearchItem CreateItem(string id);
    public UnityEditor.Search.SearchItem CreateItem(UnityEditor.Search.SearchContext context, string id);
    public UnityEditor.Search.SearchItem CreateItem(string id, string label);
    public UnityEditor.Search.SearchItem CreateItem(string id, string label, string description, Texture2D thumbnail, object data);
    public UnityEditor.Search.SearchItem CreateItem(UnityEditor.Search.SearchContext context, string id, string label, string description, Texture2D thumbnail, object data);
    public UnityEditor.Search.SearchItem CreateItem(string id, int score, string label, string description, Texture2D thumbnail, object data);
    public UnityEditor.Search.SearchItem CreateItem(UnityEditor.Search.SearchContext context, string id, int score, string label, string description, Texture2D thumbnail, object data);
    public string ToString();

}

}
