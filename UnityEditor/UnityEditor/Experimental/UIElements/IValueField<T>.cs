using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements
{

public interface IValueField<T>
{
    public T value { get; set; }

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.Experimental.UIElements.DeltaSpeed speed, T startValue);

}

}
