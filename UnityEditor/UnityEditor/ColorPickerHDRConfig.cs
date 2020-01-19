using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class ColorPickerHDRConfig
{
    public float maxBrightness;
    public float maxExposureValue;
    public float minBrightness;
    public float minExposureValue;

    public ColorPickerHDRConfig(float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue);

}

}
