using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class ArrayUtility
{
    static public void Add<T>(T[] array, T item);
    static public void AddRange<T>(T[] array, T[] items);
    static public bool ArrayEquals<T>(T[] lhs, T[] rhs);
    static public bool ArrayReferenceEquals<T>(T[] lhs, T[] rhs);
    static public void Clear<T>(T[] array);
    static public bool Contains<T>(T[] array, T item);
    static public T Find<T>(T[] array, Predicate<T> match);
    static public List<T> FindAll<T>(T[] array, Predicate<T> match);
    static public int FindIndex<T>(T[] array, Predicate<T> match);
    static public int IndexOf<T>(T[] array, T value);
    static public void Insert<T>(T[] array, int index, T item);
    static public int LastIndexOf<T>(T[] array, T value);
    static public void Remove<T>(T[] array, T item);
    static public void RemoveAt<T>(T[] array, int index);

}

}
