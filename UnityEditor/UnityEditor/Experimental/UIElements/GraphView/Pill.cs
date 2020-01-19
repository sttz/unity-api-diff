using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Pill : Experimental.UIElements.VisualElement
{
    public bool highlighted { get; set; }
    public Texture icon { get; set; }
    public Experimental.UIElements.VisualElement left { get; set; }
    public Experimental.UIElements.VisualElement right { get; set; }
    public string text { get; set; }

    public Pill();
    public Pill(Experimental.UIElements.VisualElement left, Experimental.UIElements.VisualElement right);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.GraphView.Pill, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
