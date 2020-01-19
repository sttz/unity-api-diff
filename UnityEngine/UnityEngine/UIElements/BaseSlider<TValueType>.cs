using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class BaseSlider<TValueType> : UIElements.BaseField<TValueType>
{
    static public string draggerUssClassName;
    static public string horizontalVariantUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string trackerUssClassName;
    static public string ussClassName;
    static public string verticalVariantUssClassName;

    public UIElements.SliderDirection direction { get; set; }
    public TValueType highValue { get; set; }
    public TValueType lowValue { get; set; }
    public float pageSize { get; set; }
    public TValueType range { get; }
    public TValueType value { get; set; }

    public void AdjustDragElement(float factor);

}

}
