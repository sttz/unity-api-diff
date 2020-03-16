using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class BaseField<TValueType> : UIElements.BindableElement, UIElements.INotifyValueChanged<TValueType>
{
    static public string inputUssClassName;
    static public string labelDraggerVariantUssClassName;
    static public string labelUssClassName;
    static public string noLabelVariantUssClassName;
    static public string ussClassName;

    public string label { get; set; }
    public UIElements.Label labelElement { get; private set; }
    protected TValueType rawValue { get; set; }
    public TValueType value { get; set; }

    protected BaseField(string label, UIElements.VisualElement visualInput);

    public void SetValueWithoutNotify(TValueType newValue);

    public class UxmlTraits<TValueType> : UxmlTraits
    {
        public UxmlTraits();

        public void Init(UIElements.VisualElement ve, UIElements.IUxmlAttributes bag, UIElements.CreationContext cc);

    }

}

}