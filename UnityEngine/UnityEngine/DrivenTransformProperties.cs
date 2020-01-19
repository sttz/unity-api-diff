using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public enum DrivenTransformProperties
{
    All = -1,
    None = 0,
    AnchoredPositionX = 2,
    AnchoredPositionY = 4,
    AnchoredPosition = 6,
    AnchoredPositionZ = 8,
    AnchoredPosition3D = 14,
    Rotation = 16,
    ScaleX = 32,
    ScaleY = 64,
    ScaleZ = 128,
    Scale = 224,
    AnchorMinX = 256,
    AnchorMinY = 512,
    AnchorMin = 768,
    AnchorMaxX = 1024,
    AnchorMaxY = 2048,
    AnchorMax = 3072,
    Anchors = 3840,
    SizeDeltaX = 4096,
    SizeDeltaY = 8192,
    SizeDelta = 12288,
    PivotX = 16384,
    PivotY = 32768,
    Pivot = 49152,
}

}
