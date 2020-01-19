using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public static class UQueryExtensions
{
    static public UIElements.VisualElement Q(UIElements.VisualElement e, string name = null, string[] classes);
    static public UIElements.VisualElement Q(UIElements.VisualElement e, string name = null, string className = null);
    static public T Q<T>(UIElements.VisualElement e, string name = null, string[] classes);
    static public T Q<T>(UIElements.VisualElement e, string name = null, string className = null);
    static public UIElements.UQueryBuilder<UIElements.VisualElement> Query(UIElements.VisualElement e);
    static public UIElements.UQueryBuilder<UIElements.VisualElement> Query(UIElements.VisualElement e, string name = null, string[] classes);
    static public UIElements.UQueryBuilder<UIElements.VisualElement> Query(UIElements.VisualElement e, string name = null, string className = null);
    static public UIElements.UQueryBuilder<T> Query<T>(UIElements.VisualElement e, string name = null, string[] classes);
    static public UIElements.UQueryBuilder<T> Query<T>(UIElements.VisualElement e, string name = null, string className = null);

}

}
