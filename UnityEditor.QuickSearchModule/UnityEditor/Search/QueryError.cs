using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class QueryError
{
    public int index { get; set; }
    public int length { get; set; }
    public string reason { get; set; }

    public QueryError();
    public QueryError(int index, string reason);
    public QueryError(int index, int length, string reason);

}

}
