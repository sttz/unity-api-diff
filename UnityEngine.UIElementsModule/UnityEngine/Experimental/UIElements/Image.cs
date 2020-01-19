using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Image : Experimental.UIElements.VisualElement
{
    public Experimental.UIElements.StyleSheets.StyleValue<Texture> image { get; set; }
    public Experimental.UIElements.StyleSheets.StyleValue<ScaleMode> scaleMode { get; set; }
    public Rect sourceRect { get; set; }
    public Rect uv { get; set; }

    public Image();

    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    protected void OnStyleResolved(Experimental.UIElements.StyleSheets.ICustomStyle elementStyle);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.Image, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

    }

}

}
