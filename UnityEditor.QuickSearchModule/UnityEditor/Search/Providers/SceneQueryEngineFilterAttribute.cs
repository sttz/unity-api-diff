using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search.Providers
{

public class SceneQueryEngineFilterAttribute : UnityEditor.Search.QueryEngineFilterAttribute
{
    public SceneQueryEngineFilterAttribute(string token, string[] supportedOperators = null);
    public SceneQueryEngineFilterAttribute(string token, StringComparison options, string[] supportedOperators = null);
    public SceneQueryEngineFilterAttribute(string token, string paramTransformerFunction, string[] supportedOperators = null);
    public SceneQueryEngineFilterAttribute(string token, string paramTransformerFunction, StringComparison options, string[] supportedOperators = null);

}

}
