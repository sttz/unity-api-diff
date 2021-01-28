using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public struct SearchDocument : IEquatable<UnityEditor.Search.SearchDocument>, IComparable<UnityEditor.Search.SearchDocument>
{
    public string id;
    public int index;
    public int score;

    public string path { get; }
    public bool valid { get; }

    public SearchDocument(UnityEditor.Search.SearchDocument doc, string path);
    public SearchDocument(UnityEditor.Search.SearchDocument doc, int score);
    public SearchDocument(int index, string id, string path = null, int score = 2147483647);

    public int CompareTo(UnityEditor.Search.SearchDocument other);
    public bool Equals(object other);
    public bool Equals(UnityEditor.Search.SearchDocument other);
    public int GetHashCode();
    public string ToString();

}

}
