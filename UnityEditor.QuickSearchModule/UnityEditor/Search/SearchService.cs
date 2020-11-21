using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public static class SearchService
{
    static public IEnumerable<UnityEditor.Search.SearchProvider> OrderedProviders { get; }
    static public List<UnityEditor.Search.SearchProvider> Providers { get; private set; }

    static public UnityEditor.Search.SearchContext CreateContext(string providerId, string searchText = "", UnityEditor.Search.SearchFlags flags = 2);
    static public UnityEditor.Search.SearchContext CreateContext(IEnumerable<string> providerIds, string searchText = "", UnityEditor.Search.SearchFlags flags = 2);
    static public UnityEditor.Search.SearchContext CreateContext(IEnumerable<UnityEditor.Search.SearchProvider> providers, string searchText = "", UnityEditor.Search.SearchFlags flags = 2);
    static public UnityEditor.Search.SearchAction GetAction(UnityEditor.Search.SearchProvider provider, string actionId);
    static public List<UnityEditor.Search.SearchItem> GetItems(UnityEditor.Search.SearchContext context, UnityEditor.Search.SearchFlags options = 2);
    static public UnityEditor.Search.SearchProvider GetProvider(string providerId);
    static public void Refresh();
    static public void RefreshWindows();
    static public UnityEditor.Search.ISearchList Request(UnityEditor.Search.SearchContext context, UnityEditor.Search.SearchFlags options = 0);
    static public void SetActive(string providerId, bool active = true);
    static public UnityEditor.Search.ISearchView ShowContextual(string[] providerIds);
    static public UnityEditor.Search.ISearchView ShowObjectPicker(Action<Object, bool> selectHandler, Action<Object> trackingHandler, string searchText, string typeName, Type filterType, float defaultWidth = 850, float defaultHeight = 539, UnityEditor.Search.SearchFlags flags = 1610612744);
    static public UnityEditor.Search.ISearchView ShowWindow(UnityEditor.Search.SearchContext context = null, string topic = "Unity", float defaultWidth = 850, float defaultHeight = 539, bool saveFilters = true, bool reuseExisting = false, bool multiselect = true, bool dockable = true);

}

}
