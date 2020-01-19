using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public abstract class BaseCompositeField<TValue, TField, TFieldValue> : Experimental.UIElements.BaseField<TValue>
{
    protected List<TField> m_Fields;

    public Experimental.UIElements.VisualElement contentContainer { get; }
    public int focusIndex { get; set; }

    protected BaseCompositeField();

    public void SetValueWithoutNotify(TValue newValue);

    public class UxmlTraits<TValue, TField, TFieldValue> : UxmlTraits<TValue>
    {
        public UxmlTraits();

    }

}

}
