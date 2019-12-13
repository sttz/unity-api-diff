using System;
using UnityEngine;

namespace UnityEngine
{

public class HDROutputSettings
{
    static public HDROutputSettings[] displays;

    static public HDROutputSettings main { get; }

    static public void SetPaperWhiteInNits(float paperWhite);

    public bool active { get; }
    public bool automaticHDRTonemapping { get; set; }
    public bool available { get; }
    public ColorGamut displayColorGamut { get; }
    public RenderTextureFormat format { get; }
    public Experimental.Rendering.GraphicsFormat graphicsFormat { get; }
    public bool HDRModeChangeRequested { get; }
    public int maxFullFrameToneMapLuminance { get; }
    public int maxToneMapLuminance { get; }
    public int minToneMapLuminance { get; }
    public float paperWhiteNits { get; set; }

    public void RequestHDRModeChange(bool enabled);

}

}
