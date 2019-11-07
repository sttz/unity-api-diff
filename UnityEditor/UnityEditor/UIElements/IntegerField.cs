using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class IntegerField : UnityEditor.UIElements.TextValueField<int>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public IntegerField();
    public IntegerField(int maxLength);
    public IntegerField(string label, int maxLength = -1);

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.UIElements.DeltaSpeed speed, int startValue);
    protected int StringToValue(string str);
    protected string ValueToString(int v);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.IntegerField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<int, UIElements.UxmlIntAttributeDescription>
    {
        public UxmlTraits();

    }

}

}
