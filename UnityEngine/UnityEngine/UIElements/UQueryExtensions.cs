using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class UQueryExtensions
{
    static public T Q(UIElements.VisualElement e, string name = null, string[] classes);
    static public UIElements.VisualElement Q(UIElements.VisualElement e, string name = null, string[] classes);
    static public T Q(UIElements.VisualElement e, string name = null, string className = null);
    static public UIElements.VisualElement Q(UIElements.VisualElement e, string name = null, string className = null);
    static public UIElements.UQueryBuilder<UIElements.VisualElement> Query(UIElements.VisualElement e, string name = null, string[] classes);
    static public UIElements.UQueryBuilder<UIElements.VisualElement> Query(UIElements.VisualElement e, string name = null, string className = null);
    static public UIElements.UQueryBuilder<T> Query(UIElements.VisualElement e, string name = null, string[] classes);
    static public UIElements.UQueryBuilder<T> Query(UIElements.VisualElement e, string name = null, string className = null);
    static public UIElements.UQueryBuilder<UIElements.VisualElement> Query(UIElements.VisualElement e);

}

}
