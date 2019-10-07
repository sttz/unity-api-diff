using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class VisualElement : Experimental.UIElements.Focusable, Experimental.UIElements.ITransform, Experimental.UIElements.IUIElementDataWatch, System.Collections.Generic.IEnumerable<Experimental.UIElements.VisualElement>, Experimental.UIElements.IVisualElementScheduler, Experimental.UIElements.IStyle, System.Collections.IEnumerable
{
    static public int defaultFocusIndex;

    public bool canGrabFocus { get; }
    public int childCount { get; }
    public ClippingOptions clippingOptions { get; set; }
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public Rect contentRect { get; }
    public Experimental.UIElements.IUIElementDataWatch dataWatch { get; }
    public bool enabled { get; set; }
    public bool enabledInHierarchy { get; }
    public bool enabledSelf { get; }
    public Experimental.UIElements.FocusController focusController { get; }
    public Experimental.UIElements.VisualElement this[int key] { get; }
    public Rect layout { get; set; }
    public Rect localBound { get; }
    public string name { get; set; }
    protected Rect paddingRect { get; }
    public Experimental.UIElements.IPanel panel { get; }
    public Experimental.UIElements.VisualElement parent { get; }
    public string persistenceKey { get; set; }
    public Experimental.UIElements.PickingMode pickingMode { get; set; }
    public Experimental.UIElements.IVisualElementScheduler schedule { get; }
    public Hierarchy shadow { get; private set; }
    public Experimental.UIElements.IStyle style { get; }
    public string tooltip { get; set; }
    public Experimental.UIElements.ITransform transform { get; }
    public object userData { get; set; }
    public bool visible { get; set; }
    public Rect worldBound { get; }
    public Matrix4x4 worldTransform { get; }

    public VisualElement();

    public void Add(Experimental.UIElements.VisualElement child);
    public void AddStyleSheetPath(string sheetPath);
    public void AddToClassList(string className);
    public bool AnyDirty(Experimental.UIElements.ChangeType type);
    public void BringToFront();
    public System.Collections.Generic.IEnumerable<Experimental.UIElements.VisualElement> Children();
    public bool ClassListContains(string cls);
    public void Clear();
    public void ClearClassList();
    public void ClearDirty(Experimental.UIElements.ChangeType type);
    public bool Contains(Experimental.UIElements.VisualElement child);
    public bool ContainsPoint(Vector2 localPoint);
    public void Dirty(Experimental.UIElements.ChangeType type);
    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    public Experimental.UIElements.VisualElement ElementAt(int index);
    public void EnableInClassList(string className, bool enable);
    public object FindAncestorUserData();
    public Experimental.UIElements.VisualElement FindCommonAncestor(Experimental.UIElements.VisualElement other);
    public void Focus();
    public System.Collections.Generic.IEnumerator<Experimental.UIElements.VisualElement> GetEnumerator();
    public T GetFirstAncestorOfType();
    public T GetFirstOfType();
    public string GetFullHierarchicalPersistenceKey();
    public T GetOrCreatePersistentData(object existing, string key);
    public T GetOrCreatePersistentData(ScriptableObject existing, string key);
    public bool HasStyleSheetPath(string sheetPath);
    public int IndexOf(Experimental.UIElements.VisualElement element);
    public void Insert(int index, Experimental.UIElements.VisualElement element);
    public bool IsDirty(Experimental.UIElements.ChangeType type);
    public void MarkDirtyRepaint();
    public void OnPersistentDataReady();
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle style);
    public bool Overlaps(Rect rectangle);
    public void OverwriteFromPersistedData(object obj, string key);
    public void PlaceBehind(Experimental.UIElements.VisualElement sibling);
    public void PlaceInFront(Experimental.UIElements.VisualElement sibling);
    public void Remove(Experimental.UIElements.VisualElement element);
    public void RemoveAt(int index);
    public void RemoveFromClassList(string className);
    public void RemoveFromHierarchy();
    public void RemoveStyleSheetPath(string sheetPath);
    public void ResetPositionProperties();
    public void SavePersistentData();
    public void SendEvent(Experimental.UIElements.EventBase e);
    public void SendToBack();
    public void SetEnabled(bool value);
    public void SetSize(Vector2 size);
    public void Sort(Comparison<Experimental.UIElements.VisualElement> comp);
    public void ToggleInClassList(string className);
    public string ToString();

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.VisualElement, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : Experimental.UIElements.UxmlTraits
    {
        protected Experimental.UIElements.UxmlIntAttributeDescription m_FocusIndex;

        public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

    public enum MeasureMode
    {
        Undefined = 0,
        Exactly = 1,
        AtMost = 2,
    }

    public enum ClippingOptions
    {
        ClipContents = 0,
        NoClipping = 1,
        ClipAndCacheContents = 2,
    }

    public struct Hierarchy
    {
        public int childCount { get; }
        public Experimental.UIElements.VisualElement this[int key] { get; }
        public Experimental.UIElements.VisualElement parent { get; }

        public void Add(Experimental.UIElements.VisualElement child);
        public System.Collections.Generic.IEnumerable<Experimental.UIElements.VisualElement> Children();
        public void Clear();
        public Experimental.UIElements.VisualElement ElementAt(int index);
        public int IndexOf(Experimental.UIElements.VisualElement element);
        public void Insert(int index, Experimental.UIElements.VisualElement child);
        public void Remove(Experimental.UIElements.VisualElement child);
        public void RemoveAt(int index);
        public void Sort(Comparison<Experimental.UIElements.VisualElement> comp);

    }

}

}
