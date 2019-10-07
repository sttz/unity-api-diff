using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class Slider : UIElements.BaseSlider<float>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public Slider();
    public Slider(float start, float end, UIElements.SliderDirection direction = 0, float pageSize = 0);
    public Slider(string label, float start = 0, float end = 10, UIElements.SliderDirection direction = 0, float pageSize = 0);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.Slider, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<float, UIElements.UxmlFloatAttributeDescription>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
