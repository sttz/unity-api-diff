using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Compilation
{

public struct CompilerMessage
{
    public int column;
    public string file;
    public int line;
    public string message;
    public UnityEditor.Compilation.CompilerMessageType type;

}

}
