using System;
using UnityEngine;

namespace UnityEditor.UIElements
{

public class LongField : UnityEditor.UIElements.TextValueField<long>
{
    static public string inputUssClassName;
    static public string labelUssClassName;
    static public string ussClassName;

    public LongField();
    public LongField(int maxLength);
    public LongField(string label, int maxLength = -1);

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.UIElements.DeltaSpeed speed, long startValue);
    protected long StringToValue(string str);
    protected string ValueToString(long v);

    public class UxmlFactory : UIElements.UxmlFactory<UnityEditor.UIElements.LongField, UxmlTraits>
    {
        public UxmlFactory();

    }

    public class UxmlTraits : UIElements.BaseFieldTraits<long, UIElements.UxmlLongAttributeDescription>
    {
        public UxmlTraits();

    }

}

}
