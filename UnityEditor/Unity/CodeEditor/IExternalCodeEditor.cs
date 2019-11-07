using System;
using UnityEngine;

namespace Unity.CodeEditor
{

public interface IExternalCodeEditor
{
    public Installation[] Installations { get; }

    public void Initialize(string editorInstallationPath);
    public void OnGUI();
    public bool OpenProject(string filePath = "", int line = -1, int column = -1);
    public void SyncAll();
    public void SyncIfNeeded(string[] addedFiles, string[] deletedFiles, string[] movedFiles, string[] movedFromFiles, string[] importedFiles);
    public bool TryGetInstallationForPath(string editorPath, out Installation installation);

}

}
