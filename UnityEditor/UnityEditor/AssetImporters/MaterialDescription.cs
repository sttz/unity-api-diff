using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AssetImporters
{

public class MaterialDescription : IDisposable
{
    public string materialName { get; }

    public MaterialDescription();

    public void Dispose();
    public void GetFloatPropertyNames(List<string> names);
    public void GetStringPropertyNames(List<string> names);
    public void GetTexturePropertyNames(List<string> names);
    public void GetVector4PropertyNames(List<string> names);
    public bool HasAnimationCurve(string propertyName);
    public bool HasAnimationCurveInClip(string clipName, string propertyName);
    public bool TryGetAnimationCurve(string clipName, string propertyName, out AnimationCurve value);
    public bool TryGetProperty(string propertyName, out float value);
    public bool TryGetProperty(string propertyName, out string value);
    public bool TryGetProperty(string propertyName, out UnityEditor.AssetImporters.TexturePropertyDescription value);
    public bool TryGetProperty(string propertyName, out Vector4 value);

}

}
