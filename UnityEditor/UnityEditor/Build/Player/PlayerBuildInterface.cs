using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Player
{

public static class PlayerBuildInterface
{
    static public Func<IEnumerable<string>> ExtraTypesProvider;

    static public UnityEditor.Build.Player.ScriptCompilationResult CompilePlayerScripts(UnityEditor.Build.Player.ScriptCompilationSettings input, string outputFolder);

}

}