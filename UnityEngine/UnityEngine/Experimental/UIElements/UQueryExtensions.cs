using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public static class UQueryExtensions
{
    static public T Q(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public T Q(Experimental.UIElements.VisualElement e, string name = null, string className = null);
    static public Experimental.UIElements.VisualElement Q(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public Experimental.UIElements.VisualElement Q(Experimental.UIElements.VisualElement e, string name = null, string className = null);
    static public QueryBuilder<Experimental.UIElements.VisualElement> Query(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public QueryBuilder<Experimental.UIElements.VisualElement> Query(Experimental.UIElements.VisualElement e, string name = null, string className = null);
    static public QueryBuilder<T> Query(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public QueryBuilder<T> Query(Experimental.UIElements.VisualElement e, string name = null, string className = null);
    static public QueryBuilder<Experimental.UIElements.VisualElement> Query(Experimental.UIElements.VisualElement e);

}

}
