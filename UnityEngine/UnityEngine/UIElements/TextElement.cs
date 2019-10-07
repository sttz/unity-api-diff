using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class TextElement : UIElements.VisualElement, UIElements.ITextElement
{
    static public string ussClassName;

    public string text { get; set; }

    public TextElement();

    public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.TextElement, UxmlTraits>
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
