using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public abstract class BasePopupField<TValueType, TValueChoice> : UIElements.BaseField<TValueType>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string textUssClassName;
    static public string ussClassName;

    public string text { get; }
    protected UIElements.TextElement textElement { get; }

    protected void ExecuteDefaultActionAtTarget(UIElements.EventBase evt);
    public void SetValueWithoutNotify(TValueType newValue);

}

}
