using System;
using UnityEngine;

namespace UnityEditor.U2D
{

public class SpriteAtlasAsset : Object
{
    public bool isVariant { get; }

    public SpriteAtlasAsset();

    public void Add(Object[] objects);
    public UnityEditor.U2D.SpriteAtlasPackingSettings GetPackingSettings();
    public UnityEditor.TextureImporterPlatformSettings GetPlatformSettings(string buildTarget);
    public UnityEditor.U2D.SpriteAtlasTextureSettings GetTextureSettings();
    public void Remove(Object[] objects);
    public void SetIncludeInBuild(bool value);
    public void SetIsVariant(bool value);
    public void SetMasterAtlas(U2D.SpriteAtlas atlas);
    public void SetPackingSettings(UnityEditor.U2D.SpriteAtlasPackingSettings src);
    public void SetPlatformSettings(UnityEditor.TextureImporterPlatformSettings src);
    public void SetTextureSettings(UnityEditor.U2D.SpriteAtlasTextureSettings src);
    public void SetVariantScale(float value);

}

}
