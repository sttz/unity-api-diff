using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchContext : IDisposable
{
    public string actionId { get; private set; }
    public string filterId { get; private set; }
    public UnityEditor.EditorWindow focusedWindow { get; internal set; }
    public UnityEditor.Search.SearchFlags options { get; set; }
    public int progressId { get; set; }
    public IEnumerable<UnityEditor.Search.SearchProvider> providers { get; private set; }
    public bool searchInProgress { get; }
    public string searchPhrase { get; }
    public string searchQuery { get; private set; }
    public string searchText { get; set; }
    public UnityEditor.Search.ISearchView searchView { get; internal set; }
    public string[] searchWords { get; private set; }
    public UnityEditor.Search.SearchSelection selection { get; }
    public string[] textFilters { get; private set; }
    public bool wantsMore { get; set; }

    public event Action<UnityEditor.Search.SearchContext, IEnumerable<UnityEditor.Search.SearchItem>> asyncItemReceived;
    public event Action<UnityEditor.Search.SearchContext> sessionEnded;
    public event Action<UnityEditor.Search.SearchContext> sessionStarted;

    public SearchContext(IEnumerable<UnityEditor.Search.SearchProvider> providers);
    public SearchContext(IEnumerable<UnityEditor.Search.SearchProvider> providers, string searchText);
    public SearchContext(IEnumerable<UnityEditor.Search.SearchProvider> providers, string searchText, UnityEditor.Search.SearchFlags options);

    public void Dispose();
    protected void Dispose(bool disposing);
    public int GetHashCode();
    public bool IsEnabled(string providerId);
    public void ResetFilter(bool enableAll);
    public void SetFilter(string providerId, bool isEnabled);

}

}
