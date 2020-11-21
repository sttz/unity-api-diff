using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.CodeEditor
{

public class CodeEditor
{
    static public Unity.CodeEditor.IExternalCodeEditor CurrentEditor { get; }
    static public string CurrentEditorInstallation { get; }
    static public string CurrentEditorPath { get; }
    static public Unity.CodeEditor.CodeEditor Editor { get; }

    static public bool OSOpenFile(string appPath, string arguments);
    static public string ParseArgument(string arguments, string path, int line, int column);
    static public string QuoteForProcessStart(string argument);
    static public void Register(Unity.CodeEditor.IExternalCodeEditor externalCodeEditor);
    static public void SetExternalScriptEditor(string path);
    static public void Unregister(Unity.CodeEditor.IExternalCodeEditor externalCodeEditor);

    public Unity.CodeEditor.IExternalCodeEditor CurrentCodeEditor { get; }
    public Installation CurrentInstallation { get; }

    public CodeEditor();

    public Unity.CodeEditor.IExternalCodeEditor GetCodeEditorForPath(string editorPath);
    public Dictionary<string, string> GetFoundScriptEditorPaths();
    public Installation GetInstallationForPath(string editorPath);
    public void SetCodeEditor(string editorPath);

    public struct Installation
    {
        public string Name;
        public string Path;

    }

}

}
