using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public struct ParseResult<T> : UnityEditor.Search.IParseResult
{
    static public UnityEditor.Search.ParseResult<T> none;

    public T parsedValue;

    public bool success { get; }

    public ParseResult(bool success, T value);

}

}
