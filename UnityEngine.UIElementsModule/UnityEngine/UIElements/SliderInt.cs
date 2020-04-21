using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class SliderInt : UIElements.BaseSlider<int>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public float pageSize { get; set; }

    public SliderInt();
    public SliderInt(int start, int end, UIElements.SliderDirection direction = 0, float pageSize = 0);
    public SliderInt(string label, int start = 0, int end = 10, UIElements.SliderDirection direction = 0, float pageSize = 0);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.SliderInt, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<int, UIElements.UxmlIntAttributeDescription>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
