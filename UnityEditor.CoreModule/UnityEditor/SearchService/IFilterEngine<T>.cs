using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public interface IFilterEngine<T> : UnityEditor.SearchService.ISearchEngineBase
{
    public bool Filter(UnityEditor.SearchService.ISearchContext context, string query, T objectToFilter);

}

}
