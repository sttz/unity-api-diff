using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class EditorMaterialUtility
{
    static public bool IsBackgroundMaterial(Material material);
    static public void ResetDefaultTextures(Material material, bool overrideSetTextures);
    static public void SetShaderDefaults(Shader shader, string[] name, Texture[] textures);
    static public void SetShaderNonModifiableDefaults(Shader shader, string[] name, Texture[] textures);

    public EditorMaterialUtility();

}

}
