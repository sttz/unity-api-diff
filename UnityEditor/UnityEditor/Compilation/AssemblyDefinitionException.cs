using System;
using UnityEngine;

namespace UnityEditor.Compilation
{

public class AssemblyDefinitionException : Exception
{
    public string[] filePaths { get; private set; }

    public AssemblyDefinitionException(string message, string[] filePaths);

}

}
