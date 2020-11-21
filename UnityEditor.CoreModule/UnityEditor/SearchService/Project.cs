using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public static class Project
{
    static public UnityEditor.SearchService.SearchEngineScope EngineScope = 1;

    static public void RegisterEngine(UnityEditor.SearchService.IProjectSearchEngine engine);
    static public void UnregisterEngine(UnityEditor.SearchService.IProjectSearchEngine engine);

}

}
