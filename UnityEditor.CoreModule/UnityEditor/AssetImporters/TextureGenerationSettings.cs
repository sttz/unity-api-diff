using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AssetImporters
{

public struct TextureGenerationSettings
{
    public string assetPath { get; set; }
    public bool enablePostProcessor { get; set; }
    public UnityEditor.TextureImporterPlatformSettings platformSettings { get; set; }
    public bool qualifyForSpritePacking { get; set; }
    public SecondarySpriteTexture[] secondarySpriteTextures { get; set; }
    public UnityEditor.AssetImporters.SourceTextureInformation sourceTextureInformation { get; set; }
    public UnityEditor.AssetImporters.SpriteImportData[] spriteImportData { get; set; }
    public string spritePackingTag { get; set; }
    public UnityEditor.TextureImporterSettings textureImporterSettings { get; set; }

    public TextureGenerationSettings(UnityEditor.TextureImporterType type);

}

}
