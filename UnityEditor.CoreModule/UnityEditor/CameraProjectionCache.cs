using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public struct CameraProjectionCache
{
    public CameraProjectionCache(Camera camera);

    public Vector2 GUIToScreenPoint(Vector2 guiPoint);
    public Vector2 ScreenToGUIPoint(Vector2 screenPoint);
    public Vector2 WorldToGUIPoint(Vector3 worldPoint);
    public Vector2 WorldToScreenPoint(Vector3 worldPoint);

}

}
