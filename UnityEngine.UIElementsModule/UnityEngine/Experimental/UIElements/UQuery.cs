using System;
using System.Collections;
using System.Collections.Generic;
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
        public QueryBuilder<T2> Children<T2>(string name = null, string[] classes);
        public QueryBuilder<T2> Children<T2>(string name = null, string className = null);
        public QueryBuilder<T> Class(string classname);
        public QueryBuilder<T2> Descendents<T2>(string name = null, string classname = null);
        public QueryBuilder<T2> Descendents<T2>(string name = null, string[] classNames);
        public QueryBuilder<T> Enabled();
        public T First();
        public QueryBuilder<T> Focused();
        public void ForEach(Action<T> funcCall);
        public List<T2> ForEach<T2>(Func<T, T2> funcCall);
        public void ForEach<T2>(List<T2> result, Func<T, T2> funcCall);
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
        public QueryBuilder<T2> OfType<T2>(string name = null, string[] classes);
        public QueryBuilder<T2> OfType<T2>(string name = null, string className = null);
        public QueryBuilder<T> Selected();
        public List<T> ToList();
        public void ToList(List<T> results);
        public QueryBuilder<T> Visible();
        public QueryBuilder<T> Where(Func<T, bool> selectorPredicate);

    }

    public struct QueryState<T>
    {
        public T AtIndex(int index);
        public T First();
        public void ForEach(Action<T> funcCall);
        public List<T2> ForEach<T2>(Func<T, T2> funcCall);
        public void ForEach<T2>(List<T2> result, Func<T, T2> funcCall);
        public T Last();
        public QueryState<T> RebuildOn(Experimental.UIElements.VisualElement element);
        public List<T> ToList();
        public void ToList(List<T> results);

    }

}

}
