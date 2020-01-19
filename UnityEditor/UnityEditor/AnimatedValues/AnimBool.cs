using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public class AnimBool : UnityEditor.AnimatedValues.BaseAnimValue<bool>
{
    public float faded { get; }

    public AnimBool();
    public AnimBool(Events.UnityAction callback);
    public AnimBool(bool value);
    public AnimBool(bool value, Events.UnityAction callback);

    public float Fade(float from, float to);
    protected bool GetValue();

}

}
