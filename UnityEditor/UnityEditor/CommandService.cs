using System;
using UnityEngine;

namespace UnityEditor
{

public static class CommandService
{
    static public object Execute(string id);
    static public object Execute(string id, UnityEditor.CommandHint hint);
    static public object Execute(string id, UnityEditor.CommandHint hint, object[] args);
    static public bool Exists(string id);
    static public string GetCommandLabel(string commandId);
    static public void RegisterCommand(string id, string label, UnityEditor.CommandHandler handler, UnityEditor.CommandHint hint = -1);
    static public void RegisterCommand(string id, UnityEditor.CommandHandler handler, UnityEditor.CommandHint hint = -1);
    static public bool UnregisterCommand(string id);

}

}
