using System;
using UnityEngine;

namespace Unity.CodeEditor
{

public class CodeEditor
{
    static public Unity.CodeEditor.IExternalCodeEditor CurrentEditor { get; }
    static public string CurrentEditorInstallation { get; }

    static public bool OSOpenFile(string appPath, string arguments);
    static public string ParseArgument(string arguments, string path, int line, int column);
    static public void Register(Unity.CodeEditor.IExternalCodeEditor externalCodeEditor);
    static public void SetExternalScriptEditor(string path);
    static public void Unregister(Unity.CodeEditor.IExternalCodeEditor externalCodeEditor);

    public CodeEditor();

    public struct Installation
    {
        public string Name;
        public string Path;

    }

}

}
