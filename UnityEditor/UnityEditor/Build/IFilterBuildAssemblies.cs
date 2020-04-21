using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IFilterBuildAssemblies : UnityEditor.Build.IOrderedCallback
{
    public string[] OnFilterAssemblies(UnityEditor.BuildOptions buildOptions, string[] assemblies);

}

}
