using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Pill : UIElements.VisualElement
{
    public bool highlighted { get; set; }
    public Texture icon { get; set; }
    public UIElements.VisualElement left { get; set; }
    public UIElements.VisualElement right { get; set; }
    public string text { get; set; }

    public Pill();
    public Pill(UIElements.VisualElement left, UIElements.VisualElement right);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.Experimental.GraphView.Pill, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
