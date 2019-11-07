using System;
using UnityEngine;

namespace UnityEditor
{

public class ShaderData
{
    public Subshader ActiveSubshader { get; }
    public int ActiveSubshaderIndex { get; }
    public Shader SourceShader { get; private set; }
    public int SubshaderCount { get; }

    public Subshader GetSubshader(int index);

    public class Subshader
    {
        public int PassCount { get; }

        public Pass GetPass(int passIndex);

    }

    public class Pass
    {
        public string Name { get; }
        public string SourceCode { get; }

    }

}

}
