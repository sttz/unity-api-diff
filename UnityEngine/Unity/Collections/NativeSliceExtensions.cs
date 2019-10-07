using System;
using UnityEngine;

namespace Unity.Collections
{

public static class NativeSliceExtensions
{
    static public Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray);
    static public Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, int start);
    static public Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, int start, int length);
    static public Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice);
    static public Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, int start);
    static public Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, int start, int length);

}

}
