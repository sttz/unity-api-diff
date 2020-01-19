using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class ShaderImporter : UnityEditor.AssetImporter
{
    public ShaderImporter();

    public Texture GetDefaultTexture(string name);
    public Texture GetNonModifiableTexture(string name);
    public Shader GetShader();
    public void SetDefaultTextures(string[] name, Texture[] textures);
    public void SetNonModifiableTextures(string[] name, Texture[] textures);

}

}
