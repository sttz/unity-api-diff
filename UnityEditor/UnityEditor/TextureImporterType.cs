using System;
using UnityEngine;

namespace UnityEditor
{

public enum TextureImporterType
{
    Default = 0,
    Image = 0,
    NormalMap = 1,
    Bump = 1,
    GUI = 2,
    Sprite = 8,
    Cursor = 7,
    Cubemap = 3,
    Reflection = 3,
    Cookie = 4,
    Lightmap = 6,
    HDRI = 9,
    Advanced = 5,
    SingleChannel = 10,
}

}
