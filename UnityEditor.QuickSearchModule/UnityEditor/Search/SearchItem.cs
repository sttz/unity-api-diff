using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchItem : IEquatable<UnityEditor.Search.SearchItem>, IComparable<UnityEditor.Search.SearchItem>
{
    static public UnityEditor.Search.SearchItem none;

    public UnityEditor.Search.SearchContext context;
    public object data;
    public string description;
    public string id;
    public string label;
    public UnityEditor.Search.SearchItemOptions options;
    public Texture2D preview;
    public UnityEditor.Search.SearchProvider provider;
    public int score;
    public Texture2D thumbnail;

    public SearchItem(string _id);

    public int Compare(UnityEditor.Search.SearchItem x, UnityEditor.Search.SearchItem y);
    public int CompareTo(UnityEditor.Search.SearchItem other);
    public bool Equals(object other);
    public bool Equals(UnityEditor.Search.SearchItem other);
    public string GetDescription(UnityEditor.Search.SearchContext context, bool stripHTML = false);
    public int GetHashCode();
    public string GetLabel(UnityEditor.Search.SearchContext context, bool stripHTML = false);

}

}
