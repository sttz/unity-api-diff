using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class FloatField : UnityEditor.UIElements.TextValueField<float>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public FloatField();
    public FloatField(int maxLength);
    public FloatField(string label, int maxLength = -1);

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.UIElements.DeltaSpeed speed, float startValue);
    protected float StringToValue(string str);
    protected string ValueToString(float v);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.FloatField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UnityEditor.UIElements.TextValueFieldTraits<float, UIElements.UxmlFloatAttributeDescription>
    {
        public UxmlTraits();

    }

}

}
