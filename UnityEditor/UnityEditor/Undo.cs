using System;
using UnityEngine;

namespace UnityEditor
{

public class Undo
{
    static public PostprocessModifications postprocessModifications;
    static public UndoRedoCallback undoRedoPerformed;
    static public WillFlushUndoRecord willFlushUndoRecord;

    static public Component AddComponent(GameObject gameObject, Type type);
    static public T AddComponent(GameObject gameObject);
    static public void ClearAll();
    static public void ClearSnapshotTarget();
    static public void ClearUndo(Object identifier);
    static public void CollapseUndoOperations(int groupIndex);
    static public void CreateSnapshot();
    static public void DestroyObjectImmediate(Object objectToUndo);
    static public void FlushUndoRecordObjects();
    static public int GetCurrentGroup();
    static public string GetCurrentGroupName();
    static public void IncrementCurrentGroup();
    static public void MoveGameObjectToScene(GameObject go, SceneManagement.Scene scene, string name);
    static public void PerformRedo();
    static public void PerformUndo();
    static public void RecordObject(Object objectToUndo, string name);
    static public void RecordObjects(Object[] objectsToUndo, string name);
    static public void RegisterCompleteObjectUndo(Object objectToUndo, string name);
    static public void RegisterCompleteObjectUndo(Object[] objectsToUndo, string name);
    static public void RegisterCreatedObjectUndo(Object objectToUndo, string name);
    static public void RegisterFullObjectHierarchyUndo(Object objectToUndo, string name);
    static public void RegisterFullObjectHierarchyUndo(Object objectToUndo);
    static public void RegisterSceneUndo(string name);
    static public void RegisterSnapshot();
    static public void RegisterUndo(Object objectToUndo, string name);
    static public void RegisterUndo(Object[] objectsToUndo, string name);
    static public void RestoreSnapshot();
    static public void RevertAllDownToGroup(int group);
    static public void RevertAllInCurrentGroup();
    static public void SetCurrentGroupName(string name);
    static public void SetSnapshotTarget(Object objectToUndo, string name);
    static public void SetSnapshotTarget(Object[] objectsToUndo, string name);
    static public void SetTransformParent(Transform transform, Transform newParent, string name);

    public Undo();

    public delegate void UndoRedoCallback();

    public delegate void WillFlushUndoRecord();

    public delegate UnityEditor.UndoPropertyModification[] PostprocessModifications(UnityEditor.UndoPropertyModification[] modifications);

}

}
