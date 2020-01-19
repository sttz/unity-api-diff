using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct DrivenRectTransformTracker
{
    static public void StartRecordingUndo();
    static public void StopRecordingUndo();

    public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties);
    public void Clear();
    public void Clear(bool revertValues);

}

}
