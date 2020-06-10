using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AnimatedValues
{

public class AnimQuaternion : UnityEditor.AnimatedValues.BaseAnimValueNonAlloc<Quaternion>
{
    public AnimQuaternion(Quaternion value);
    public AnimQuaternion(Quaternion value, Events.UnityAction callback);

    protected Quaternion GetValue();

}

}
