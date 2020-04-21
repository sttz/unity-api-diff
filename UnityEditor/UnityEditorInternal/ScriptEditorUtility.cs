using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class ScriptEditorUtility
{
    static public string GetExternalScriptEditor();
    static public string GetExternalScriptEditorArgs();
    static public Dictionary<string, string> GetFoundScriptEditorPaths(RuntimePlatform platform);
    static public ScriptEditor GetScriptEditorFromPath(string path);
    static public ScriptEditor GetScriptEditorFromPreferences();
    static public void RegisterIde(Func<Installation[]> pathCallBack);
    static public void SetExternalScriptEditor(string path);
    static public void SetExternalScriptEditorArgs(string args);

    public ScriptEditorUtility();

    public struct Installation
    {
        public string Name;
        public string Path;

    }

    public enum ScriptEditor
    {
        SystemDefault = 0,
        MonoDevelop = 1,
        VisualStudio = 2,
        VisualStudioExpress = 3,
        Other = 32,
    }

}

}
