using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public abstract class BasePopupField<TValue, TChoice> : Experimental.UIElements.BaseField<TValue>
{
    protected Experimental.UIElements.TextElement m_TextElement;

    public string text { get; }

    protected BasePopupField();

    public void SetValueWithoutNotify(TValue newValue);

}

}
