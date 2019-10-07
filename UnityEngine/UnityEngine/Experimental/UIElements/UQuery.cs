using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public static class UQuery
{
    public struct QueryBuilder<T>
    {
        public QueryBuilder(Experimental.UIElements.VisualElement visualElement);

        public QueryBuilder<T> Active();
        public T AtIndex(int index);
        public QueryState<T> Build();
        public QueryBuilder<T> Checked();
        public QueryBuilder<T2> Children(string name = null, string[] classes);
        public QueryBuilder<T2> Children(string name = null, string className = null);
        public QueryBuilder<T> Class(string classname);
        public QueryBuilder<T2> Descendents(string name = null, string[] classNames);
        public QueryBuilder<T2> Descendents(string name = null, string classname = null);
        public QueryBuilder<T> Enabled();
        public T First();
        public QueryBuilder<T> Focused();
        public void ForEach(System.Collections.Generic.List<T2> result, Func<T, T2> funcCall);
        public System.Collections.Generic.List<T2> ForEach(Func<T, T2> funcCall);
        public void ForEach(Action<T> funcCall);
        public QueryBuilder<T> Hovered();
        public T Last();
        public QueryBuilder<T> Name(string id);
        public QueryBuilder<T> NotActive();
        public QueryBuilder<T> NotChecked();
        public QueryBuilder<T> NotEnabled();
        public QueryBuilder<T> NotFocused();
        public QueryBuilder<T> NotHovered();
        public QueryBuilder<T> NotSelected();
        public QueryBuilder<T> NotVisible();
        public QueryBuilder<T2> OfType(string name = null, string[] classes);
        public QueryBuilder<T2> OfType(string name = null, string className = null);
        public QueryBuilder<T> Selected();
        public System.Collections.Generic.List<T> ToList();
        public void ToList(System.Collections.Generic.List<T> results);
        public QueryBuilder<T> Visible();
        public QueryBuilder<T> Where(Func<T, bool> selectorPredicate);

    }

    public struct QueryState<T>
    {
        public T AtIndex(int index);
        public T First();
        public void ForEach(Action<T> funcCall);
        public void ForEach(System.Collections.Generic.List<T2> result, Func<T, T2> funcCall);
        public System.Collections.Generic.List<T2> ForEach(Func<T, T2> funcCall);
        public T Last();
        public QueryState<T> RebuildOn(Experimental.UIElements.VisualElement element);
        public void ToList(System.Collections.Generic.List<T> results);
        public System.Collections.Generic.List<T> ToList();

    }

}

}
