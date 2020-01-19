using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct UQueryState<T> : IEquatable<UIElements.UQueryState<T>>
{
    public T AtIndex(int index);
    public bool Equals(object obj);
    public bool Equals(UIElements.UQueryState<T> other);
    public T First();
    public void ForEach(Action<T> funcCall);
    public List<T2> ForEach<T2>(Func<T, T2> funcCall);
    public void ForEach<T2>(List<T2> result, Func<T, T2> funcCall);
    public int GetHashCode();
    public T Last();
    public UIElements.UQueryState<T> RebuildOn(UIElements.VisualElement element);
    public List<T> ToList();
    public void ToList(List<T> results);

}

}
