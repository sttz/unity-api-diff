using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class ScrollView : UIElements.VisualElement
{
    static public string contentUssClassName;
    static public string horizontalVariantUssClassName;
    static public string hScrollerUssClassName;
    static public string scrollVariantUssClassName;
    static public string ussClassName;
    static public string verticalHorizontalVariantUssClassName;
    static public string verticalVariantUssClassName;
    static public string viewportUssClassName;
    static public string vScrollerUssClassName;

    public UIElements.VisualElement contentContainer { get; }
    public UIElements.VisualElement contentViewport { get; private set; }
    public float elasticity { get; set; }
    public float horizontalPageSize { get; set; }
    public UIElements.Scroller horizontalScroller { get; private set; }
    public float scrollDecelerationRate { get; set; }
    public Vector2 scrollOffset { get; set; }
    public bool showHorizontal { get; set; }
    public bool showVertical { get; set; }
    public TouchScrollBehavior touchScrollBehavior { get; set; }
    public float verticalPageSize { get; set; }
    public UIElements.Scroller verticalScroller { get; private set; }

    public ScrollView();
    public ScrollView(UIElements.ScrollViewMode scrollViewMode);

    public void ScrollTo(UIElements.VisualElement child);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.ScrollView, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

    public enum TouchScrollBehavior
    {
        Unrestricted = 0,
        Elastic = 1,
        Clamped = 2,
    }

}

}