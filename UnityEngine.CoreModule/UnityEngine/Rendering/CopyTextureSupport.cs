using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public enum CopyTextureSupport
{
    None = 0,
    Basic = 1,
    Copy3D = 2,
    DifferentTypes = 4,
    TextureToRT = 8,
    RTToTexture = 16,
}

}
