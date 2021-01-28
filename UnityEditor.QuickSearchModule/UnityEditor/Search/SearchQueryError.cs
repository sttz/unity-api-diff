using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchQueryError
{
    public UnityEditor.Search.SearchContext context { get; }
    public int index { get; }
    public int length { get; }
    public UnityEditor.Search.SearchProvider provider { get; }
    public string reason { get; }
    public UnityEditor.Search.SearchQueryErrorType type { get; }

    public SearchQueryError(int index, int length, string reason, UnityEditor.Search.SearchContext context, UnityEditor.Search.SearchProvider provider, bool fromSearchQuery = true, UnityEditor.Search.SearchQueryErrorType type = 0);

    public int GetHashCode();

}

}
