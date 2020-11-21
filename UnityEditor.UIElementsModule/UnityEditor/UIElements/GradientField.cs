using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class GradientField : UIElements.BaseField<Gradient>
{
    static public string borderUssClassName;
    static public string contentUssClassName;
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public ColorSpace colorSpace { get; set; }
    public Gradient value { get; set; }

    public GradientField();
    public GradientField(string label);

    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    public void SetValueWithoutNotify(Gradient newValue);
    protected void UpdateMixedValueContent();

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.GradientField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<Gradient>
    {
        public UxmlTraits();

    }

}

}
