using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public static class SceneSearch
{
    static public UnityEditor.SearchService.SearchEngineScope EngineScope = 0;

    static public void RegisterEngine(UnityEditor.SearchService.ISceneSearchEngine engine);
    static public void UnregisterEngine(UnityEditor.SearchService.ISceneSearchEngine engine);

}

}
