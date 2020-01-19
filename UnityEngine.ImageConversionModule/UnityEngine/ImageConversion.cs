using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public static class ImageConversion
{
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
