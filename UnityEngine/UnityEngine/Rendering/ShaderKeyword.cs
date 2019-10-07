using System;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct ShaderKeyword
{
    static public string GetGlobalKeywordName(Rendering.ShaderKeyword index);
    static public Rendering.ShaderKeywordType GetGlobalKeywordType(Rendering.ShaderKeyword index);
    static public string GetKeywordName(Shader shader, Rendering.ShaderKeyword index);
    static public Rendering.ShaderKeywordType GetKeywordType(Shader shader, Rendering.ShaderKeyword index);
    static public bool IsKeywordLocal(Rendering.ShaderKeyword index);

    public int index { get; }

    public ShaderKeyword(string keywordName);
    public ShaderKeyword(Shader shader, string keywordName);

    public string GetKeywordName();
    public Rendering.ShaderKeywordType GetKeywordType();
    public string GetName();
    public bool IsValid();

}

}
