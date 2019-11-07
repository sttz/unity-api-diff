using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class ScrollView : UIElements.VisualElement
{
    static public string contentUssClassName;
    static public string hContentVariantUssClassName;
    static public string horizontalVariantUssClassName;
    static public string hScrollerUssClassName;
    static public string hViewportVariantUssClassName;
    static public string scrollVariantUssClassName;
    static public string ussClassName;
    static public string vContentVariantUssClassName;
    static public string verticalHorizontalVariantUssClassName;
    static public string verticalVariantUssClassName;
    static public string vhContentVariantUssClassName;
    static public string vhViewportVariantUssClassName;
    static public string viewportUssClassName;
    static public string vScrollerUssClassName;
    static public string vViewportVariantUssClassName;

    public UIElements.VisualElement contentContainer { get; }
    public UIElements.VisualElement contentViewport { get; private set; }
    public float horizontalPageSize { get; set; }
    public UIElements.Scroller horizontalScroller { get; private set; }
    public Vector2 scrollOffset { get; set; }
    public bool showHorizontal { get; set; }
    public bool showVertical { get; set; }
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

}

}
