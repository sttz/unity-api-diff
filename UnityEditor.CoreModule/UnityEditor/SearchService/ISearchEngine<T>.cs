using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public interface ISearchEngine<T> : UnityEditor.SearchService.ISearchEngineBase
{
    public IEnumerable<T> Search(UnityEditor.SearchService.ISearchContext context, string query, Action<IEnumerable<T>> asyncItemsReceived);

}

}
