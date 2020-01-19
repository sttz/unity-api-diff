using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class AssemblyDefinitionException : Exception
{
    public string[] filePaths { get; private set; }

    public AssemblyDefinitionException(string message, string[] filePaths);

}

}
