using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class TextureImporterSettings
{
    static public bool Equal(UnityEditor.TextureImporterSettings a, UnityEditor.TextureImporterSettings b);

    public bool alphaIsTransparency { get; set; }
    public UnityEditor.TextureImporterAlphaSource alphaSource { get; set; }
    public float alphaTestReferenceValue { get; set; }
    public int aniso { get; set; }
    public bool borderMipmap { get; set; }
    public int compressionQuality { get; set; }
    public bool convertToNormalMap { get; set; }
    public UnityEditor.TextureImporterCubemapConvolution cubemapConvolution { get; set; }
    public float cubemapConvolutionExponent { get; set; }
    public int cubemapConvolutionSteps { get; set; }
    public bool fadeOut { get; set; }
    public FilterMode filterMode { get; set; }
    public UnityEditor.TextureImporterGenerateCubemap generateCubemap { get; set; }
    public bool generateMipsInLinearSpace { get; set; }
    public bool grayscaleToAlpha { get; set; }
    public float heightmapScale { get; set; }
    public bool ignorePngGamma { get; set; }
    public bool lightmap { get; set; }
    public bool linearTexture { get; set; }
    public int maxTextureSize { get; set; }
    public float mipmapBias { get; set; }
    public bool mipmapEnabled { get; set; }
    public int mipmapFadeDistanceEnd { get; set; }
    public int mipmapFadeDistanceStart { get; set; }
    public UnityEditor.TextureImporterMipFilter mipmapFilter { get; set; }
    public bool mipMapsPreserveCoverage { get; set; }
    public bool normalMap { get; set; }
    public UnityEditor.TextureImporterNormalFilter normalMapFilter { get; set; }
    public UnityEditor.TextureImporterNPOTScale npotScale { get; set; }
    public bool readable { get; set; }
    public UnityEditor.TextureImporterRGBMMode rgbm { get; set; }
    public bool seamlessCubemap { get; set; }
    public UnityEditor.TextureImporterSingleChannelComponent singleChannelComponent { get; set; }
    public int spriteAlignment { get; set; }
    public Vector4 spriteBorder { get; set; }
    public uint spriteExtrude { get; set; }
    public bool spriteGenerateFallbackPhysicsShape { get; set; }
    public SpriteMeshType spriteMeshType { get; set; }
    public int spriteMode { get; set; }
    public Vector2 spritePivot { get; set; }
    public float spritePixelsPerUnit { get; set; }
    public float spritePixelsToUnits { get; set; }
    public float spriteTessellationDetail { get; set; }
    public bool sRGBTexture { get; set; }
    public bool streamingMipmaps { get; set; }
    public int streamingMipmapsPriority { get; set; }
    public UnityEditor.TextureImporterFormat textureFormat { get; set; }
    public UnityEditor.TextureImporterShape textureShape { get; set; }
    public UnityEditor.TextureImporterType textureType { get; set; }
    public bool vtOnly { get; set; }
    public TextureWrapMode wrapMode { get; set; }
    public TextureWrapMode wrapModeU { get; set; }
    public TextureWrapMode wrapModeV { get; set; }
    public TextureWrapMode wrapModeW { get; set; }

    public TextureImporterSettings();

    public void ApplyTextureType(UnityEditor.TextureImporterType type);
    public void ApplyTextureType(UnityEditor.TextureImporterType type, bool applyAll);
    public void CopyTo(UnityEditor.TextureImporterSettings target);

}

}
