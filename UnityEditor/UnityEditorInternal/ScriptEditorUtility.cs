using System;
using UnityEngine;

namespace UnityEditorInternal
{

public class ScriptEditorUtility
{
    static public string GetExternalScriptEditor();
    static public string GetExternalScriptEditorArgs();
    static public System.Collections.Generic.Dictionary<string, string> GetFoundScriptEditorPaths(RuntimePlatform platform);
    static public ScriptEditor GetScriptEditorFromPath(string path);
    static public ScriptEditor GetScriptEditorFromPreferences();
    static public void RegisterIde(Func<Installation[]> pathCallBack);
    static public void SetExternalScriptEditor(string path);
    static public void SetExternalScriptEditorArgs(string args);

    public ScriptEditorUtility();

    public enum ScriptEditor
    {
        SystemDefault = 0,
        MonoDevelop = 1,
        VisualStudio = 2,
        VisualStudioExpress = 3,
        VisualStudioCode = 4,
        Rider = 5,
        Other = 32,
    }

    public struct Installation
    {
        public string Name;
        public string Path;

    }

}

}
