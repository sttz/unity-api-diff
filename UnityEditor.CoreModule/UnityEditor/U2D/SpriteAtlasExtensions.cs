using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D
{

public static class SpriteAtlasExtensions
{
    static public void Add(U2D.SpriteAtlas spriteAtlas, Object[] objects);
    static public Object[] GetPackables(U2D.SpriteAtlas spriteAtlas);
    static public UnityEditor.U2D.SpriteAtlasPackingSettings GetPackingSettings(U2D.SpriteAtlas spriteAtlas);
    static public UnityEditor.TextureImporterPlatformSettings GetPlatformSettings(U2D.SpriteAtlas spriteAtlas, string buildTarget);
    static public UnityEditor.U2D.SpriteAtlasTextureSettings GetTextureSettings(U2D.SpriteAtlas spriteAtlas);
    static public void Remove(U2D.SpriteAtlas spriteAtlas, Object[] objects);
    static public void SetIncludeInBuild(U2D.SpriteAtlas spriteAtlas, bool value);
    static public void SetIsVariant(U2D.SpriteAtlas spriteAtlas, bool value);
    static public void SetMasterAtlas(U2D.SpriteAtlas spriteAtlas, U2D.SpriteAtlas value);
    static public void SetPackingSettings(U2D.SpriteAtlas spriteAtlas, UnityEditor.U2D.SpriteAtlasPackingSettings src);
    static public void SetPlatformSettings(U2D.SpriteAtlas spriteAtlas, UnityEditor.TextureImporterPlatformSettings src);
    static public void SetTextureSettings(U2D.SpriteAtlas spriteAtlas, UnityEditor.U2D.SpriteAtlasTextureSettings src);
    static public void SetVariantScale(U2D.SpriteAtlas spriteAtlas, float value);

}

}
