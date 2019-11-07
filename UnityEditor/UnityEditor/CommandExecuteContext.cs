using System;
using UnityEngine;

namespace UnityEditor
{

public class CommandExecuteContext
{
    public object[] args;
    public UnityEditor.CommandHint hint;
    public object result;

    public object data { get; }

    public CommandExecuteContext();

    public T GetArgument(int index, T defaultValue = null);

}

}
