using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class VisualElement : UIElements.Focusable, UIElements.ITransform, UIElements.IVisualElementScheduler, UIElements.IResolvedStyle
{
    public bool cacheAsBitmap { get; set; }
    public bool canGrabFocus { get; }
    public int childCount { get; }
    public UIElements.VisualElement contentContainer { get; }
    public Rect contentRect { get; }
    public UIElements.ICustomStyle customStyle { get; }
    public bool enabledInHierarchy { get; }
    public bool enabledSelf { get; private set; }
    public UIElements.FocusController focusController { get; }
    public Hierarchy hierarchy { get; private set; }
    public UIElements.VisualElement this[int key] { get; }
    public Rect layout { get; internal set; }
    public Rect localBound { get; }
    public string name { get; set; }
    protected Rect paddingRect { get; }
    public UIElements.IPanel panel { get; }
    public UIElements.VisualElement parent { get; }
    public UIElements.PickingMode pickingMode { get; set; }
    public UIElements.IResolvedStyle resolvedStyle { get; }
    public UIElements.IVisualElementScheduler schedule { get; }
    public UIElements.IStyle style { get; }
    public UIElements.VisualElementStyleSheetSet styleSheets { get; }
    public string tooltip { get; set; }
    public UIElements.ITransform transform { get; }
    public object userData { get; set; }
    public string viewDataKey { get; set; }
    public bool visible { get; set; }
    public Rect worldBound { get; }
    public Matrix4x4 worldTransform { get; }

    public VisualElement();

    public void Add(UIElements.VisualElement child);
    public void AddToClassList(string className);
    public void BringToFront();
    public IEnumerable<UIElements.VisualElement> Children();
    public bool ClassListContains(string cls);
    public void Clear();
    public void ClearClassList();
    public bool Contains(UIElements.VisualElement child);
    public bool ContainsPoint(Vector2 localPoint);
    public UIElements.VisualElement ElementAt(int index);
    public void EnableInClassList(string className, bool enable);
    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    public object FindAncestorUserData();
    public UIElements.VisualElement FindCommonAncestor(UIElements.VisualElement other);
    public void Focus();
    public T GetFirstAncestorOfType<T>();
    public T GetFirstOfType<T>();
    public int IndexOf(UIElements.VisualElement element);
    public void Insert(int index, UIElements.VisualElement element);
    public void MarkDirtyRepaint();
    public bool Overlaps(Rect rectangle);
    public void PlaceBehind(UIElements.VisualElement sibling);
    public void PlaceInFront(UIElements.VisualElement sibling);
    public void Remove(UIElements.VisualElement element);
    public void RemoveAt(int index);
    public void RemoveFromClassList(string className);
    public void RemoveFromHierarchy();
    public void SendEvent(UIElements.EventBase e);
    public void SendToBack();
    public void SetEnabled(bool value);
    public void Sort(Comparison<UIElements.VisualElement> comp);
    public void ToggleInClassList(string className);
    public string ToString();

    public struct Hierarchy
    {
        public int childCount { get; }
        public UIElements.VisualElement this[int key] { get; }
        public UIElements.VisualElement parent { get; }

        public void Add(UIElements.VisualElement child);
        public IEnumerable<UIElements.VisualElement> Children();
        public void Clear();
        public UIElements.VisualElement ElementAt(int index);
        public bool Equals(object obj);
        public bool Equals(Hierarchy other);
        public int GetHashCode();
        public int IndexOf(UIElements.VisualElement element);
        public void Insert(int index, UIElements.VisualElement child);
        public void Remove(UIElements.VisualElement child);
        public void RemoveAt(int index);
        public void Sort(Comparison<UIElements.VisualElement> comp);

    }

    public enum MeasureMode
    {
        Undefined = 0,
        Exactly = 1,
        AtMost = 2,
    }

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.VisualElement, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.UxmlTraits
    {
        protected UIElements.UxmlBoolAttributeDescription focusable { get; set; }
        protected UIElements.UxmlIntAttributeDescription focusIndex { get; set; }
        public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
