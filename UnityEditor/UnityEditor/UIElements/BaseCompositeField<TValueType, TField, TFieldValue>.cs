using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public abstract class BaseCompositeField<TValueType, TField, TFieldValue> : UIElements.BaseField<TValueType>
{
    static public string fieldGroupUssClassName;
    static public string fieldUssClassName;
    static public string firstFieldVariantUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string multilineVariantUssClassName;
    static public string spacerUssClassName;
    static public string twoLinesVariantUssClassName;
    static public string ussClassName;

    protected BaseCompositeField(string label, int fieldsByLine);

    public void SetValueWithoutNotify(TValueType newValue);

}

}
