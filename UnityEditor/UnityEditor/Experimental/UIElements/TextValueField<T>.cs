using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public abstract class TextValueField<T> : Experimental.UIElements.TextInputFieldBase<T>, UnityEditor.Experimental.UIElements.IValueField<T>
{
    protected string allowedCharacters { get; }
    public string formatString { get; set; }
    public T value { get; set; }

    protected TextValueField(int maxLength);

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.Experimental.UIElements.DeltaSpeed speed, T startValue);
    public void SetValueAndNotify(T newValue);
    public void SetValueWithoutNotify(T newValue);
    protected T StringToValue(string str);
    protected string ValueToString(T value);

    public class UxmlTraits<T> : UxmlTraits<T>
    {
        public UxmlTraits();

    }

}

}
