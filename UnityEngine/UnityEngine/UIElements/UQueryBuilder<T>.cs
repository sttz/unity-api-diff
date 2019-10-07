using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct UQueryBuilder<T> : IEquatable<UIElements.UQueryBuilder<T>>
{
    public UQueryBuilder(UIElements.VisualElement visualElement);

    public UIElements.UQueryBuilder<T> Active();
    public T AtIndex(int index);
    public UIElements.UQueryState<T> Build();
    public UIElements.UQueryBuilder<T> Checked();
    public UIElements.UQueryBuilder<T2> Children(string name = null, string[] classes);
    public UIElements.UQueryBuilder<T2> Children(string name = null, string className = null);
    public UIElements.UQueryBuilder<T> Class(string classname);
    public UIElements.UQueryBuilder<T2> Descendents(string name = null, string[] classNames);
    public UIElements.UQueryBuilder<T2> Descendents(string name = null, string classname = null);
    public UIElements.UQueryBuilder<T> Enabled();
    public bool Equals(UIElements.UQueryBuilder<T> other);
    public bool Equals(object obj);
    public T First();
    public UIElements.UQueryBuilder<T> Focused();
    public void ForEach(System.Collections.Generic.List<T2> result, Func<T, T2> funcCall);
    public System.Collections.Generic.List<T2> ForEach(Func<T, T2> funcCall);
    public void ForEach(Action<T> funcCall);
    public int GetHashCode();
    public UIElements.UQueryBuilder<T> Hovered();
    public T Last();
    public UIElements.UQueryBuilder<T> Name(string id);
    public UIElements.UQueryBuilder<T> NotActive();
    public UIElements.UQueryBuilder<T> NotChecked();
    public UIElements.UQueryBuilder<T> NotEnabled();
    public UIElements.UQueryBuilder<T> NotFocused();
    public UIElements.UQueryBuilder<T> NotHovered();
    public UIElements.UQueryBuilder<T> NotSelected();
    public UIElements.UQueryBuilder<T> NotVisible();
    public UIElements.UQueryBuilder<T2> OfType(string name = null, string[] classes);
    public UIElements.UQueryBuilder<T2> OfType(string name = null, string className = null);
    public UIElements.UQueryBuilder<T> Selected();
    public System.Collections.Generic.List<T> ToList();
    public void ToList(System.Collections.Generic.List<T> results);
    public UIElements.UQueryBuilder<T> Visible();
    public UIElements.UQueryBuilder<T> Where(Func<T, bool> selectorPredicate);

}

}
