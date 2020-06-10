using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public abstract class BaseAnimValueNonAlloc<T> : UnityEditor.AnimatedValues.BaseAnimValue<T>
{
    protected BaseAnimValueNonAlloc(T value);
    protected BaseAnimValueNonAlloc(T value, Events.UnityAction callback);

    protected bool AreEqual(T a, T b);

}

}
