using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public abstract class BaseBoolField : UIElements.BaseField<bool>
{
    protected UIElements.VisualElement m_CheckMark;
    protected UIElements.Label m_Label;

    public string text { get; set; }

    public BaseBoolField(string label);

    protected void InitLabel();
    public void SetValueWithoutNotify(bool newValue);
    protected void ToggleValue();
    protected void UpdateMixedValueContent();

}

}
