using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class TwoPaneSplitView : UIElements.VisualElement
{
    public UIElements.VisualElement contentContainer { get; }
    public UIElements.VisualElement fixedPane { get; }
    public int fixedPaneIndex { get; set; }
    public float fixedPaneInitialDimension { get; set; }
    public UIElements.VisualElement flexedPane { get; }
    public UIElements.TwoPaneSplitViewOrientation orientation { get; set; }

    public TwoPaneSplitView();
    public TwoPaneSplitView(int fixedPaneIndex, float fixedPaneStartDimension, UIElements.TwoPaneSplitViewOrientation orientation);

    public void CollapseChild(int index);
    public void UnCollapse();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.TwoPaneSplitView, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
