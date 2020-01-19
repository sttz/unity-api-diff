using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Image : UIElements.VisualElement
{
    static public string ussClassName;

    public Texture image { get; set; }
    public ScaleMode scaleMode { get; set; }
    public Rect sourceRect { get; set; }
    public Color tintColor { get; set; }
    public Rect uv { get; set; }
    public UIElements.VectorImage vectorImage { get; set; }

    public Image();

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Image, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
