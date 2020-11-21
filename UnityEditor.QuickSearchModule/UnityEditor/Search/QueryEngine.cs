using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class QueryEngine : UnityEditor.Search.QueryEngine<object>
{
    public QueryEngine();
    public QueryEngine(bool validateFilters);
    public QueryEngine(UnityEditor.Search.QueryValidationOptions validationOptions);

}

}
