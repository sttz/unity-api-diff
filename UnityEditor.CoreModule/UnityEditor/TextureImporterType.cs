using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public enum TextureImporterType
{
    Image = -2147483648,
    HDRI = -9,
    Advanced = -5,
    Cubemap = -3,
    Reflection = -3,
    Bump = -1,
    Default = 0,
    NormalMap = 1,
    GUI = 2,
    Cookie = 4,
    Lightmap = 6,
    Cursor = 7,
    Sprite = 8,
    SingleChannel = 10,
    Shadowmask = 11,
    DirectionalLightmap = 12,
}

}
