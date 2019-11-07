using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IFilterBuildAssemblies : UnityEditor.Build.IOrderedCallback
{
    public string[] OnFilterAssemblies(UnityEditor.BuildOptions buildOptions, string[] assemblies);

}

}
