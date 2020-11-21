using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.UnityLinker
{

public sealed class UnityLinkerBuildPipelineData
{
    public string inputDirectory;
    public UnityEditor.BuildTarget target;

    public UnityLinkerBuildPipelineData(UnityEditor.BuildTarget target, string inputDirectory);

}

}
