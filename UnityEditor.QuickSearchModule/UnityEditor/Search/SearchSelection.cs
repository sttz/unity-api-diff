using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchSelection : IReadOnlyCollection<UnityEditor.Search.SearchItem>, IEnumerable<UnityEditor.Search.SearchItem>, IEnumerable
{
    public int Count { get; }

    public SearchSelection(IList<int> selection, UnityEditor.Search.ISearchList filteredItems);

    public UnityEditor.Search.SearchItem First();
    public IEnumerator<UnityEditor.Search.SearchItem> GetEnumerator();
    public UnityEditor.Search.SearchItem Last();
    public int MaxIndex();
    public int MinIndex();

}

}
