using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UIElements
{

public interface IValueField<T>
{
    public T value { get; set; }

    public void ApplyInputDeviceDelta(Vector3 delta, UnityEditor.UIElements.DeltaSpeed speed, T startValue);
    public void StartDragging();
    public void StopDragging();

}

}
