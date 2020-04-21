using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering.VirtualTexturing
{

public static class EditorHelpers
{
    static public Experimental.Rendering.GraphicsFormat[] QuerySupportedFormats();
    static public bool ValidateTextureStack(Texture[] textures, out string errorMessage);

}

}
