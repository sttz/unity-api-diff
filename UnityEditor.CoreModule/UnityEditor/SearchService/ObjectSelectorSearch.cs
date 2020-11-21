using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public static class ObjectSelectorSearch
{
    static public UnityEditor.SearchService.SearchEngineScope EngineScope = 2;

    static public void RegisterEngine(UnityEditor.SearchService.IObjectSelectorEngine engine);
    static public void UnregisterEngine(UnityEditor.SearchService.IObjectSelectorEngine engine);

}

}
