using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public class AnimFloat : UnityEditor.AnimatedValues.BaseAnimValueNonAlloc<float>
{
    public AnimFloat(float value);
    public AnimFloat(float value, Events.UnityAction callback);

    protected float GetValue();

}

}
