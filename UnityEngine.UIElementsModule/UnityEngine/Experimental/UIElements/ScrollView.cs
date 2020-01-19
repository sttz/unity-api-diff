using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class ScrollView : Experimental.UIElements.VisualElement
{
    public Experimental.UIElements.VisualElement contentContainer { get; }
    public Experimental.UIElements.VisualElement contentView { get; }
    public Experimental.UIElements.VisualElement contentViewport { get; private set; }
    public float horizontalPageSize { get; set; }
    public Experimental.UIElements.Scroller horizontalScroller { get; private set; }
    public bool needsHorizontal { get; }
    public bool needsVertical { get; }
    public Vector2 scrollOffset { get; set; }
    public bool showHorizontal { get; set; }
    public bool showVertical { get; set; }
    public bool stretchContentWidth { get; set; }
    public float verticalPageSize { get; set; }
    public Experimental.UIElements.Scroller verticalScroller { get; private set; }

    public ScrollView();

    public void ScrollTo(Experimental.UIElements.VisualElement child);
    public void SetContents(Experimental.UIElements.VisualElement contents);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.ScrollView, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
