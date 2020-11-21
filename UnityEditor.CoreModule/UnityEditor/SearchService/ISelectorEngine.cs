using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public interface ISelectorEngine : UnityEditor.SearchService.ISearchEngineBase
{
    public bool SelectObject(UnityEditor.SearchService.ISearchContext context, Action<Object, bool> onObjectSelectorClosed, Action<Object> onObjectSelectedUpdated);
    public void SetSearchFilter(UnityEditor.SearchService.ISearchContext context, string searchFilter);

}

}
