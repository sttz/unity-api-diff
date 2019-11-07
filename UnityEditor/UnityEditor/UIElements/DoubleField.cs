using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class DoubleField : UnityEditor.UIElements.TextValueField<double>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public DoubleField();
    public DoubleField(int maxLength);
    public DoubleField(string label, int maxLength = -1);

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.UIElements.DeltaSpeed speed, double startValue);
    protected double StringToValue(string str);
    protected string ValueToString(double v);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.DoubleField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<double, UIElements.UxmlDoubleAttributeDescription>
    {
        public UxmlTraits();

    }

}

}
