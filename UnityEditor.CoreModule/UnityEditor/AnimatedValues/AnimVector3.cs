using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public class AnimVector3 : UnityEditor.AnimatedValues.BaseAnimValueNonAlloc<Vector3>
{
    public AnimVector3();
    public AnimVector3(Vector3 value);
    public AnimVector3(Vector3 value, Events.UnityAction callback);

    protected Vector3 GetValue();

}

}
