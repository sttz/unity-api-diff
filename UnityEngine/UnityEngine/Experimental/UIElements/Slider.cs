using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class Slider : Experimental.UIElements.BaseSlider<float>
{
    public Action<float> valueChanged { get; set; }

    public Slider();
    public Slider(float start, float end, Action<float> valueChanged, Experimental.UIElements.SliderDirection direction = 0, float pageSize = 0);
    public Slider(float start, float end, Experimental.UIElements.SliderDirection direction = 0, float pageSize = 0);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.Slider, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<float>
    {
        public System.Collections.Generic.IEnumerable<Experimental.UIElements.UxmlChildElementDescription> uxmlChildElementsDescription { get; }

        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
