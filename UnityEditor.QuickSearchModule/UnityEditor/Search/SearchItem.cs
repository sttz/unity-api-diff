using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public class SearchItem : IEquatable<UnityEditor.Search.SearchItem>, IComparable<UnityEditor.Search.SearchItem>, IComparable
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

    public int CompareTo(object other);
    public int CompareTo(UnityEditor.Search.SearchItem other);
    public bool Equals(object other);
    public bool Equals(UnityEditor.Search.SearchItem other);
    public string GetDescription(UnityEditor.Search.SearchContext context, bool stripHTML = false);
    public int GetHashCode();
    public string GetLabel(UnityEditor.Search.SearchContext context, bool stripHTML = false);
    public Texture2D GetPreview(UnityEditor.Search.SearchContext context, Vector2 size, UnityEditor.Search.FetchPreviewOptions options = 1024, bool cacheThumbnail = false);
    public Texture2D GetThumbnail(UnityEditor.Search.SearchContext context, bool cacheThumbnail = false);
    public string ToGlobalId();
    public Object ToObject();
    public Object ToObject(Type type);
    public T ToObject<T>();
    public string ToString();

}

}
