using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class TextElement : UIElements.BindableElement, UIElements.ITextElement, UIElements.INotifyValueChanged<string>
{
    static public string ussClassName;

    public bool displayTooltipWhenElided { get; set; }
    public bool isElided { get; private set; }
    public string text { get; set; }

    public TextElement();

    public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.TextElement, UxmlTraits>
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
