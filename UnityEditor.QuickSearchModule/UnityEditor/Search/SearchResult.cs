using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public struct SearchResult : IEquatable<UnityEditor.Search.SearchResult>, IComparable<UnityEditor.Search.SearchResult>
{
    static public UnityEditor.Search.SearchResult nil;

    public string id;
    public int index;
    public int score;

    public bool valid { get; }

    public SearchResult(int index);
    public SearchResult(int index, int score);
    public SearchResult(string id, int index, int score);

    public int CompareTo(UnityEditor.Search.SearchResult other);
    public bool Equals(object other);
    public bool Equals(UnityEditor.Search.SearchResult other);
    public int GetHashCode();

}

}
