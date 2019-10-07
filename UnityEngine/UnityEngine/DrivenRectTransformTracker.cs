using System;
using UnityEngine;

namespace UnityEngine
{

public struct DrivenRectTransformTracker
{
    static public void StartRecordingUndo();
    static public void StopRecordingUndo();

    public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties);
    public void Clear(bool revertValues);
    public void Clear();

}

}
