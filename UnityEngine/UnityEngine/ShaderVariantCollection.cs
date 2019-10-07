using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class ShaderVariantCollection : Object
{
    public bool isWarmedUp { get; }
    public int shaderCount { get; }
    public int variantCount { get; }

    public ShaderVariantCollection();

    public bool Add(ShaderVariant variant);
    public void Clear();
    public bool Contains(ShaderVariant variant);
    public bool Remove(ShaderVariant variant);
    public void WarmUp();

    public struct ShaderVariant
    {
        public string[] keywords;
        public Rendering.PassType passType;
        public Shader shader;

        public ShaderVariant(Shader shader, Rendering.PassType passType, string[] keywords);

    }

}

}
