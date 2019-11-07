using System;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public class AnimQuaternion : UnityEditor.AnimatedValues.BaseAnimValue<Quaternion>
{
    public AnimQuaternion(Quaternion value);
    public AnimQuaternion(Quaternion value, Events.UnityAction callback);

    protected Quaternion GetValue();

}

}
