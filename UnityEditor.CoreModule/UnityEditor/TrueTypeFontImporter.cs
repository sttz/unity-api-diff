using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class TrueTypeFontImporter : UnityEditor.AssetImporter
{
    public UnityEditor.AscentCalculationMode ascentCalculationMode { get; set; }
    public int characterPadding { get; set; }
    public int characterSpacing { get; set; }
    public string customCharacters { get; set; }
    public string[] fontNames { get; set; }
    public Font[] fontReferences { get; set; }
    public UnityEditor.FontRenderingMode fontRenderingMode { get; set; }
    public int fontSize { get; set; }
    public UnityEditor.FontTextureCase fontTextureCase { get; set; }
    public string fontTTFName { get; }
    public bool includeFontData { get; set; }
    public bool shouldRoundAdvanceValue { get; set; }

    public TrueTypeFontImporter();

    public Font GenerateEditableFont(string path);

}

}
