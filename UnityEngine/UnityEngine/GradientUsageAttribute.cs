using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class GradientUsageAttribute : PropertyAttribute
{
    public bool hdr;

    public GradientUsageAttribute(bool hdr);

}

}
