using System;
using UnityEngine;

namespace UnityEditor.AssetImporters
{

public class MaterialDescription : IDisposable
{
    public string materialName { get; }

    public MaterialDescription();

    public void Dispose();
    public void GetFloatPropertyNames(System.Collections.Generic.List<string> names);
    public void GetStringPropertyNames(System.Collections.Generic.List<string> names);
    public void GetTexturePropertyNames(System.Collections.Generic.List<string> names);
    public void GetVector4PropertyNames(System.Collections.Generic.List<string> names);
    public bool HasAnimationCurve(string propertyName);
    public bool HasAnimationCurveInClip(string clipName, string propertyName);
    public bool TryGetAnimationCurve(string clipName, string propertyName, out AnimationCurve value);
    public bool TryGetProperty(string propertyName, out float value);
    public bool TryGetProperty(string propertyName, out Vector4 value);
    public bool TryGetProperty(string propertyName, out string value);
    public bool TryGetProperty(string propertyName, out UnityEditor.AssetImporters.TexturePropertyDescription value);

}

}
