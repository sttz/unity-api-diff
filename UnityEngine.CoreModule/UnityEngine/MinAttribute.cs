using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class MinAttribute : PropertyAttribute
{
    public float min;

    public MinAttribute(float min);

}

}
