using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class GenerateIconsWithMipLevels
{
    static public void GenerateAllIconsWithMipLevels();
    static public void GenerateIconWithMipLevels(string assetPath, System.Collections.Generic.Dictionary<int, Texture2D> mipTextures, System.IO.FileInfo fileInfo);
    static public void GenerateSelectedIconsWithMips();
    static public int MipLevelForAssetPath(string assetPath, string separator);
    static public bool VerifyIconPath(string assetPath, bool logError);

    public GenerateIconsWithMipLevels();

}

}
