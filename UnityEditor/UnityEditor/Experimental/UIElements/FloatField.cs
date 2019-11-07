using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public class FloatField : UnityEditor.Experimental.UIElements.TextValueField<float>
{
    protected string allowedCharacters { get; }

    public FloatField();
    public FloatField(int maxLength);

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.Experimental.UIElements.DeltaSpeed speed, float startValue);
    protected float StringToValue(string str);
    protected string ValueToString(float v);

    public class UxmlFactory : Experimental.UIElements.UxmlFactory<UnityEditor.Experimental.UIElements.FloatField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UxmlTraits<float>
    {
        public UxmlTraits();

        public void Init(Experimental.UIElements.VisualElement ve, Experimental.UIElements.IUxmlAttributes bag, Experimental.UIElements.CreationContext cc);

    }

}

}
