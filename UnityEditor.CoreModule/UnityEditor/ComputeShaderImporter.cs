using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class ComputeShaderImporter : UnityEditor.AssetImporter
{
    public UnityEditor.PreprocessorOverride preprocessorOverride { get; set; }

    public ComputeShaderImporter();

}

}
