using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public class ShaderKeyword
{
    public ShaderKeyword(string keywordName);

    public string GetKeywordName();
    public Rendering.ShaderKeywordType GetKeywordType();
    public string GetName();
    public bool IsValid();

}

}