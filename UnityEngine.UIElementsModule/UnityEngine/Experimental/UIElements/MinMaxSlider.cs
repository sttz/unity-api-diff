using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public class MinMaxSlider : Experimental.UIElements.BaseField<Vector2>
{
    public float highLimit { get; set; }
    public float lowLimit { get; set; }
    public float maxValue { get; set; }
    public float minValue { get; set; }
    public float range { get; }
    public Vector2 value { get; set; }

    public MinMaxSlider();
    public MinMaxSlider(float minValue, float maxValue, float minLimit, float maxLimit);

    public void SetValueWithoutNotify(Vector2 newValue);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<Experimental.UIElements.MinMaxSlider, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Vector2>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
