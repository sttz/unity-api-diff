using System;
using UnityEngine;

namespace UnityEditor.Rendering
{

public static class EditorCameraUtils
{
    static public bool RenderToCubemap(Camera camera, Texture target, int faceMask, UnityEditor.StaticEditorFlags culledFlags);

}

}
