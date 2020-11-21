using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public interface ISearchEngineBase
{
    public string name { get; }

    public void BeginSearch(UnityEditor.SearchService.ISearchContext context, string query);
    public void BeginSession(UnityEditor.SearchService.ISearchContext context);
    public void EndSearch(UnityEditor.SearchService.ISearchContext context);
    public void EndSession(UnityEditor.SearchService.ISearchContext context);

}

}
