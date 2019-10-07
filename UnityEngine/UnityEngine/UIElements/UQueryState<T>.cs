using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct UQueryState<T> : IEquatable<UIElements.UQueryState<T>>
{
    public T AtIndex(int index);
    public bool Equals(UIElements.UQueryState<T> other);
    public bool Equals(object obj);
    public T First();
    public void ForEach(Action<T> funcCall);
    public void ForEach(System.Collections.Generic.List<T2> result, Func<T, T2> funcCall);
    public System.Collections.Generic.List<T2> ForEach(Func<T, T2> funcCall);
    public int GetHashCode();
    public T Last();
    public UIElements.UQueryState<T> RebuildOn(UIElements.VisualElement element);
    public void ToList(System.Collections.Generic.List<T> results);
    public System.Collections.Generic.List<T> ToList();

}

}
