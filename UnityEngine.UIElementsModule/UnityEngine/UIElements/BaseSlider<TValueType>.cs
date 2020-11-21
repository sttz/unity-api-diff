using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class BaseSlider<TValueType> : UIElements.BaseField<TValueType>
{
    static public string dragContainerUssClassName;
    static public string draggerBorderUssClassName;
    static public string draggerUssClassName;
    static public string horizontalVariantUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string textFieldClassName;
    static public string trackerUssClassName;
    static public string ussClassName;
    static public string verticalVariantUssClassName;

    static protected float GetClosestPowerOfTen(float positiveNumber);
    static protected float RoundToMultipleOf(float value, float roundingValue);

    public UIElements.SliderDirection direction { get; set; }
    public TValueType highValue { get; set; }
    public bool inverted { get; set; }
    public TValueType lowValue { get; set; }
    public float pageSize { get; set; }
    public TValueType range { get; }
    public bool showInputField { get; set; }
    public TValueType value { get; set; }

    public void AdjustDragElement(float factor);
    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    public void SetValueWithoutNotify(TValueType newValue);
    protected void UpdateMixedValueContent();

}

}
