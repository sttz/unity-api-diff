using System;
using UnityEngine;

namespace UnityEditor
{

public static class ArrayUtility
{
    static public void Add(T[]& array, T item);
    static public void AddRange(T[]& array, T[] items);
    static public bool ArrayEquals(T[] lhs, T[] rhs);
    static public bool ArrayReferenceEquals(T[] lhs, T[] rhs);
    static public void Clear(T[]& array);
    static public bool Contains(T[] array, T item);
    static public T Find(T[] array, Predicate<T> match);
    static public System.Collections.Generic.List<T> FindAll(T[] array, Predicate<T> match);
    static public int FindIndex(T[] array, Predicate<T> match);
    static public int IndexOf(T[] array, T value);
    static public void Insert(T[]& array, int index, T item);
    static public int LastIndexOf(T[] array, T value);
    static public void Remove(T[]& array, T item);
    static public void RemoveAt(T[]& array, int index);

}

}
