using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class TextureImporter : UnityEditor.AssetImporter
{
    static public bool IsDefaultPlatformTextureFormatValid(UnityEditor.TextureImporterType textureType, UnityEditor.TextureImporterFormat currentFormat);
    static public bool IsPlatformTextureFormatValid(UnityEditor.TextureImporterType textureType, UnityEditor.BuildTarget target, UnityEditor.TextureImporterFormat currentFormat);

    public bool allowAlphaSplitting { get; set; }
    public bool alphaIsTransparency { get; set; }
    public UnityEditor.TextureImporterAlphaSource alphaSource { get; set; }
    public float alphaTestReferenceValue { get; set; }
    public UnityEditor.AndroidETC2FallbackOverride androidETC2FallbackOverride { get; set; }
    public int anisoLevel { get; set; }
    public bool borderMipmap { get; set; }
    public int compressionQuality { get; set; }
    public bool convertToNormalmap { get; set; }
    public bool correctGamma { get; set; }
    public bool crunchedCompression { get; set; }
    public bool fadeout { get; set; }
    public FilterMode filterMode { get; set; }
    public UnityEditor.TextureImporterGenerateCubemap generateCubemap { get; set; }
    public bool generateMipsInLinearSpace { get; set; }
    public bool grayscaleToAlpha { get; set; }
    public float heightmapScale { get; set; }
    public bool ignorePngGamma { get; set; }
    public bool isReadable { get; set; }
    public bool lightmap { get; set; }
    public bool linearTexture { get; set; }
    public int maxTextureSize { get; set; }
    public float mipMapBias { get; set; }
    public bool mipmapEnabled { get; set; }
    public int mipmapFadeDistanceEnd { get; set; }
    public int mipmapFadeDistanceStart { get; set; }
    public UnityEditor.TextureImporterMipFilter mipmapFilter { get; set; }
    public bool mipMapsPreserveCoverage { get; set; }
    public bool normalmap { get; set; }
    public UnityEditor.TextureImporterNormalFilter normalmapFilter { get; set; }
    public UnityEditor.TextureImporterNPOTScale npotScale { get; set; }
    public bool qualifiesForSpritePacking { get; }
    public SecondarySpriteTexture[] secondarySpriteTextures { get; set; }
    public Vector4 spriteBorder { get; set; }
    public UnityEditor.SpriteImportMode spriteImportMode { get; set; }
    public string spritePackingTag { get; set; }
    public Vector2 spritePivot { get; set; }
    public float spritePixelsPerUnit { get; set; }
    public float spritePixelsToUnits { get; set; }
    public UnityEditor.SpriteMetaData[] spritesheet { get; set; }
    public bool sRGBTexture { get; set; }
    public bool streamingMipmaps { get; set; }
    public int streamingMipmapsPriority { get; set; }
    public UnityEditor.TextureImporterCompression textureCompression { get; set; }
    public UnityEditor.TextureImporterFormat textureFormat { get; set; }
    public UnityEditor.TextureImporterShape textureShape { get; set; }
    public UnityEditor.TextureImporterType textureType { get; set; }
    public TextureWrapMode wrapMode { get; set; }
    public TextureWrapMode wrapModeU { get; set; }
    public TextureWrapMode wrapModeV { get; set; }
    public TextureWrapMode wrapModeW { get; set; }

    public TextureImporter();

    public void ClearPlatformTextureSettings(string platform);
    public bool DoesSourceTextureHaveAlpha();
    public bool DoesSourceTextureHaveColor();
    public bool GetAllowsAlphaSplitting();
    public UnityEditor.TextureImporterFormat GetAutomaticFormat(string platform);
    public UnityEditor.TextureImporterPlatformSettings GetDefaultPlatformTextureSettings();
    public bool GetPlatformTextureSettings(string platform, out int maxTextureSize, out UnityEditor.TextureImporterFormat textureFormat, out int compressionQuality, out bool etc1AlphaSplitEnabled);
    public bool GetPlatformTextureSettings(string platform, out int maxTextureSize, out UnityEditor.TextureImporterFormat textureFormat, out int compressionQuality);
    public bool GetPlatformTextureSettings(string platform, out int maxTextureSize, out UnityEditor.TextureImporterFormat textureFormat);
    public UnityEditor.TextureImporterPlatformSettings GetPlatformTextureSettings(string platform);
    public void ReadTextureImportInstructions(UnityEditor.BuildTarget target, out TextureFormat desiredFormat, out ColorSpace colorSpace, out int compressionQuality);
    public void ReadTextureSettings(UnityEditor.TextureImporterSettings dest);
    public void SetAllowsAlphaSplitting(bool flag);
    public void SetPlatformTextureSettings(string platform, int maxTextureSize, UnityEditor.TextureImporterFormat textureFormat, int compressionQuality, bool allowsAlphaSplit);
    public void SetPlatformTextureSettings(string platform, int maxTextureSize, UnityEditor.TextureImporterFormat textureFormat);
    public void SetPlatformTextureSettings(string platform, int maxTextureSize, UnityEditor.TextureImporterFormat textureFormat, bool allowsAlphaSplit);
    public void SetPlatformTextureSettings(UnityEditor.TextureImporterPlatformSettings platformSettings);
    public void SetTextureSettings(UnityEditor.TextureImporterSettings src);

}

}
