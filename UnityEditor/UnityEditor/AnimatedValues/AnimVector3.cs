using System;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public class AnimVector3 : UnityEditor.AnimatedValues.BaseAnimValue<Vector3>
{
    public AnimVector3();
    public AnimVector3(Vector3 value);
    public AnimVector3(Vector3 value, Events.UnityAction callback);

    protected Vector3 GetValue();

}

}
