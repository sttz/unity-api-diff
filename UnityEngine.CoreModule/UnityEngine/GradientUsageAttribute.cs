using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class GradientUsageAttribute : PropertyAttribute
{
    public ColorSpace colorSpace;
    public bool hdr;

    public GradientUsageAttribute(bool hdr);
    public GradientUsageAttribute(bool hdr, ColorSpace colorSpace);

}

}
