using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public abstract class BaseSlider<T> : Experimental.UIElements.BaseField<T>
{
    public Experimental.UIElements.SliderDirection direction { get; set; }
    public T highValue { get; set; }
    public T lowValue { get; set; }
    public float pageSize { get; set; }
    public T range { get; }
    public T value { get; set; }

    public BaseSlider(T start, T end, Experimental.UIElements.SliderDirection direction, float pageSize = 0);

    public void AdjustDragElement(float factor);
    public void OnPersistentDataReady();

}

}
