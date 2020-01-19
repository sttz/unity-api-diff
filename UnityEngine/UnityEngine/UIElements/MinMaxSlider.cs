using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MinMaxSlider : UIElements.BaseField<Vector2>
{
    static public string draggerUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string maxThumbUssClassName;
    static public string minThumbUssClassName;
    static public string trackerUssClassName;
    static public string ussClassName;

    public float highLimit { get; set; }
    public float lowLimit { get; set; }
    public float maxValue { get; set; }
    public float minValue { get; set; }
    public float range { get; }
    public Vector2 value { get; set; }

    public MinMaxSlider();
    public MinMaxSlider(float minValue, float maxValue, float minLimit, float maxLimit);
    public MinMaxSlider(string label, float minValue = 0, float maxValue = 10, float minLimit = -3.4028235E+38, float maxLimit = 3.4028235E+38);

    public void SetValueWithoutNotify(Vector2 newValue);

    public class UxmlFactory : UIElements.UxmlFactory<UIElements.MinMaxSlider, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector2>
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}
