using System;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class PrecompiledAssemblyException : Exception
{
    public string[] filePaths { get; private set; }

    public PrecompiledAssemblyException(string message, string[] filePaths);

}

}
