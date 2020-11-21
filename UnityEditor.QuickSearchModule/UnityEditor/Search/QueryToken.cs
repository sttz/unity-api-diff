using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public struct QueryToken
{
    public int length { get; }
    public int position { get; }
    public string text { get; }

    public QueryToken(string text, int position);
    public QueryToken(string text, int position, int length);

}

}
