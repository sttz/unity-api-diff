using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class PrecompiledAssemblyException : Exception
{
    public string[] filePaths { get; private set; }

    public PrecompiledAssemblyException(string message, string[] filePaths);

}

}
