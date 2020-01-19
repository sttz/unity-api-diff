using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class GradientUsageAttribute : PropertyAttribute
{
    public bool hdr;

    public GradientUsageAttribute(bool hdr);

}

}
