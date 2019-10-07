using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Scroller : UIElements.VisualElement
{
    static public string highButtonUssClassName;
    static public string horizontalVariantUssClassName;
    static public string lowButtonUssClassName;
    static public string sliderUssClassName;
    static public string ussClassName;
    static public string verticalVariantUssClassName;

    public UIElements.SliderDirection direction { get; set; }
    public UIElements.RepeatButton highButton { get; private set; }
    public float highValue { get; set; }
    public UIElements.RepeatButton lowButton { get; private set; }
    public float lowValue { get; set; }
    public UIElements.Slider slider { get; private set; }
    public float value { get; set; }

    public event Action<float> valueChanged;

    public Scroller();
    public Scroller(float lowValue, float highValue, Action<float> valueChanged, UIElements.SliderDirection direction = 1);

    public void Adjust(float factor);
    public void ScrollPageDown();
    public void ScrollPageDown(float factor);
    public void ScrollPageUp();
    public void ScrollPageUp(float factor);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Scroller, UxmlTraits>
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
