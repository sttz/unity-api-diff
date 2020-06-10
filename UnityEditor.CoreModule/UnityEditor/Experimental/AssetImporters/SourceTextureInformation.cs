using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public class SourceTextureInformation
{
    public bool containsAlpha { get; set; }
    public bool hdr { get; set; }
    public int height { get; set; }
    public int width { get; set; }

    public SourceTextureInformation();

}

}
