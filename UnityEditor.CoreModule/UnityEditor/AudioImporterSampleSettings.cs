using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct AudioImporterSampleSettings
{
    public AudioCompressionFormat compressionFormat;
    public int conversionMode;
    public AudioClipLoadType loadType;
    public float quality;
    public uint sampleRateOverride;
    public UnityEditor.AudioSampleRateSetting sampleRateSetting;

}

}
