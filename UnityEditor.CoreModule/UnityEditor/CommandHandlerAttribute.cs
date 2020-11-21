using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class CommandHandlerAttribute : Attribute
{
    public UnityEditor.CommandHint hint { get; }
    public string id { get; }
    public string label { get; }

    public CommandHandlerAttribute(string id);
    public CommandHandlerAttribute(string id, UnityEditor.CommandHint hint);
    public CommandHandlerAttribute(string id, string label);
    public CommandHandlerAttribute(string id, string label, UnityEditor.CommandHint hint);

}

}
