using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public static class UQueryExtensions
{
    static public Experimental.UIElements.VisualElement Q(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public Experimental.UIElements.VisualElement Q(Experimental.UIElements.VisualElement e, string name = null, string className = null);
    static public T Q<T>(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public T Q<T>(Experimental.UIElements.VisualElement e, string name = null, string className = null);
    static public QueryBuilder<Experimental.UIElements.VisualElement> Query(Experimental.UIElements.VisualElement e);
    static public QueryBuilder<Experimental.UIElements.VisualElement> Query(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public QueryBuilder<Experimental.UIElements.VisualElement> Query(Experimental.UIElements.VisualElement e, string name = null, string className = null);
    static public QueryBuilder<T> Query<T>(Experimental.UIElements.VisualElement e, string name = null, string[] classes);
    static public QueryBuilder<T> Query<T>(Experimental.UIElements.VisualElement e, string name = null, string className = null);

}

}
