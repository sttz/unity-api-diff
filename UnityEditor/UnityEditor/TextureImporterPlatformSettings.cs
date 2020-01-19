using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class TextureImporterPlatformSettings
{
    public bool allowsAlphaSplitting { get; set; }
    public UnityEditor.AndroidETC2FallbackOverride androidETC2FallbackOverride { get; set; }
    public int compressionQuality { get; set; }
    public bool crunchedCompression { get; set; }
    public UnityEditor.TextureImporterFormat format { get; set; }
    public int maxTextureSize { get; set; }
    public string name { get; set; }
    public bool overridden { get; set; }
    public UnityEditor.TextureResizeAlgorithm resizeAlgorithm { get; set; }
    public UnityEditor.TextureImporterCompression textureCompression { get; set; }

    public TextureImporterPlatformSettings();

    public void CopyTo(UnityEditor.TextureImporterPlatformSettings target);

}

}
