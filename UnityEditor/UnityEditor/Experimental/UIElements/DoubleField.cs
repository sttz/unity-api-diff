using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class DoubleField : UnityEditor.Experimental.UIElements.TextValueField<double>
{
    protected string allowedCharacters { get; }

    public DoubleField();
    public DoubleField(int maxLength);

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.Experimental.UIElements.DeltaSpeed speed, double startValue);
    protected double StringToValue(string str);
    protected string ValueToString(double v);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.DoubleField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<double>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
