using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Rendering
{

public static class EditorCameraUtils
{
    static public bool RenderToCubemap(Camera camera, Texture target, int faceMask, UnityEditor.StaticEditorFlags culledFlags);

}

}
