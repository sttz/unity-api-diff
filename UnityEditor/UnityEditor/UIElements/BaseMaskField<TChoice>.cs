using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public abstract class BaseMaskField<TChoice> : UnityEditor.UIElements.BasePopupField<TChoice, string>
{
    public void SetValueWithoutNotify(TChoice newValue);

}

}
