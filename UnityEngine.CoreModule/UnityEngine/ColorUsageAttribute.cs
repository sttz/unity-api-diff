using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class ColorUsageAttribute : PropertyAttribute
{
    public bool hdr;
    public float maxBrightness;
    public float maxExposureValue;
    public float minBrightness;
    public float minExposureValue;
    public bool showAlpha;

    public ColorUsageAttribute(bool showAlpha);
    public ColorUsageAttribute(bool showAlpha, bool hdr);
    public ColorUsageAttribute(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue);

}

}
