using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class IHVImageFormatImporter : UnityEditor.AssetImporter
{
    public FilterMode filterMode { get; set; }
    public bool isReadable { get; set; }
    public bool streamingMipmaps { get; set; }
    public int streamingMipmapsPriority { get; set; }
    public TextureWrapMode wrapMode { get; set; }
    public TextureWrapMode wrapModeU { get; set; }
    public TextureWrapMode wrapModeV { get; set; }
    public TextureWrapMode wrapModeW { get; set; }

    public IHVImageFormatImporter();

}

}
