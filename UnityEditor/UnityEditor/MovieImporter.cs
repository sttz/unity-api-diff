using System;
using UnityEngine;

namespace UnityEditor
{

public class MovieImporter : UnityEditor.AssetImporter
{
    public float duration { get; }
    public bool linearTexture { get; set; }
    public float quality { get; set; }

    public MovieImporter();

}

}
