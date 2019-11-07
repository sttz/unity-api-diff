using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class ActiveEditorTracker
{
    static public UnityEditor.ActiveEditorTracker sharedTracker { get; }

    static public bool HasCustomEditor(Object obj);
    static public UnityEditor.Editor MakeCustomEditor(Object obj);

    public UnityEditor.Editor[] activeEditors { get; }
    public bool hasComponentsWhichCannotBeMultiEdited { get; }
    public UnityEditor.InspectorMode inspectorMode { get; set; }
    public bool isDirty { get; }
    public bool isLocked { get; set; }

    public ActiveEditorTracker();

    public void ClearDirty();
    public void Destroy();
    public bool Equals(object o);
    public void ForceRebuild();
    public int GetHashCode();
    public int GetVisible(int index);
    public void RebuildIfNecessary();
    public void SetVisible(int index, int visible);
    public void VerifyModifiedMonoBehaviours();

}

}
