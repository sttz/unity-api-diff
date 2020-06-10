using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public interface ISceneSearchEngine : UnityEditor.SearchService.IFilterEngine<UnityEditor.HierarchyProperty>, UnityEditor.SearchService.ISearchEngineBase
{
}

}
