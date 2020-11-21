using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class QueryEngineFilterAttribute : Attribute
{
    public StringComparison comparisonOptions;
    public bool overridesStringComparison;
    public string paramTransformerFunction;
    public string[] supportedOperators;
    public string token;
    public bool useParamTransformer;

    public QueryEngineFilterAttribute(string token, string[] supportedOperators = null);
    public QueryEngineFilterAttribute(string token, StringComparison options, string[] supportedOperators = null);
    public QueryEngineFilterAttribute(string token, string paramTransformerFunction, string[] supportedOperators = null);
    public QueryEngineFilterAttribute(string token, string paramTransformerFunction, StringComparison options, string[] supportedOperators = null);

}

}
