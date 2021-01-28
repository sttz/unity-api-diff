using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface ISearchList : IList<UnityEditor.Search.SearchItem>, ICollection<UnityEditor.Search.SearchItem>, IEnumerable<UnityEditor.Search.SearchItem>, IEnumerable, IDisposable
{
    public UnityEditor.Search.SearchContext context { get; }
    public bool pending { get; }

    public void AddItems(IEnumerable<UnityEditor.Search.SearchItem> items);
    public IEnumerable<UnityEditor.Search.SearchItem> Fetch();
    public IEnumerable<UnityEditor.Search.SearchItem> GetRange(int skipCount, int count);
    public void InsertRange(int index, IEnumerable<UnityEditor.Search.SearchItem> items);
    public IEnumerable<TResult> Select<TResult>(Func<UnityEditor.Search.SearchItem, TResult> selector);

}

}
