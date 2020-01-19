using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public abstract class BaseAnimValue<T> : ISerializationCallbackReceiver
{
    public float speed;
    public Events.UnityEvent valueChanged;

    public bool isAnimating { get; }
    protected float lerpPosition { get; }
    protected T start { get; }
    public T target { get; set; }
    public T value { get; set; }

    protected BaseAnimValue(T value);
    protected BaseAnimValue(T value, Events.UnityAction callback);

    protected void BeginAnimating(T newTarget, T newStart);
    protected T GetValue();
    protected void StopAnim(T newValue);

}

}
