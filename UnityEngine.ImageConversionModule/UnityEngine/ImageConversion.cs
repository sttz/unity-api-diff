using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class ImageConversion
{
    static public byte[] EncodeArrayToEXR(Array array, Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, EXRFlags flags = 0);
    static public byte[] EncodeArrayToJPG(Array array, Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0, int quality = 75);
    static public byte[] EncodeArrayToPNG(Array array, Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0);
    static public byte[] EncodeArrayToTGA(Array array, Experimental.Rendering.GraphicsFormat format, uint width, uint height, uint rowBytes = 0);
    static public byte[] EncodeToEXR(Texture2D tex);
    static public byte[] EncodeToEXR(Texture2D tex, EXRFlags flags);
    static public byte[] EncodeToJPG(Texture2D tex);
    static public byte[] EncodeToJPG(Texture2D tex, int quality);
    static public byte[] EncodeToPNG(Texture2D tex);
    static public byte[] EncodeToTGA(Texture2D tex);
    static public bool LoadImage(Texture2D tex, byte[] data);
    static public bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable);

}

}
