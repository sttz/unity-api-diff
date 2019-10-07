using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Scroller : Experimental.UIElements.VisualElement
{
    public Experimental.UIElements.SliderDirection direction { get; set; }
    public Experimental.UIElements.ScrollerButton highButton { get; private set; }
    public float highValue { get; set; }
    public Experimental.UIElements.ScrollerButton lowButton { get; private set; }
    public float lowValue { get; set; }
    public Experimental.UIElements.Slider slider { get; private set; }
    public float value { get; set; }

    public event Action<float> valueChanged;

    public Scroller();
    public Scroller(float lowValue, float highValue, Action<float> valueChanged, Experimental.UIElements.SliderDirection direction = 1);

    public void Adjust(float factor);
    public void ScrollPageDown();
    public void ScrollPageDown(float factor);
    public void ScrollPageUp();
    public void ScrollPageUp(float factor);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.Scroller, UxmlTraits>
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
