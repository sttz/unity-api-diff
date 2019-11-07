using System;
using UnityEngine;

namespace UnityEditor.Build.Player
{

public static class PlayerBuildInterface
{
    static public Func<System.Collections.Generic.IEnumerable<string>> ExtraTypesProvider;

    static public UnityEditor.Build.Player.ScriptCompilationResult CompilePlayerScripts(UnityEditor.Build.Player.ScriptCompilationSettings input, string outputFolder);

}

}
