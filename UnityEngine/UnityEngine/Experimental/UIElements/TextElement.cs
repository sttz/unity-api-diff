using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class TextElement : Experimental.UIElements.VisualElement, Experimental.UIElements.ITextElement
{
    public string text { get; set; }

    public TextElement();

    protected void DoRepaint(Experimental.UIElements.IStylePainter painter);
    public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.TextElement, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits
    {
        public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
