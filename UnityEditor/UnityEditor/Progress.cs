using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class Progress
{
    static public float GlobalProgress { get; }
    static public bool IsRunning { get; }

    static public event ProgressEventHandler OnAdded;
    static public event ProgressEventHandler OnRemoved;
    static public event ProgressEventHandler OnUpdated;

    static public bool Cancel(int id);
    static public int Clear(int id);
    static public IEnumerable<UnityEditor.ProgressItem> EnumerateItems();
    static public bool Exists(int id);
    static public void Finish(int id, UnityEditor.ProgressStatus status = 1);
    static public int GetCount();
    static public int[] GetCountPerStatus();
    static public string GetDescription(int id);
    static public int GetId(int index);
    static public string GetName(int id);
    static public UnityEditor.ProgressOptions GetOptions(int id);
    static public int GetParentId(int id);
    static public UnityEditor.ProgressItem GetProgressById(int id);
    static public int GetRunningProgressCount();
    static public long GetStartDateTime(int id);
    static public UnityEditor.ProgressStatus GetStatus(int id);
    static public long GetUpdateDateTime(int id);
    static public bool IsCancellable(int id);
    static public void RegisterCancelCallback(int id, Func<bool> callback);
    static public void Report(int id, float progress);
    static public void Report(int id, float progress, string description);
    static public int RunTask(string name, string description, Func<int, object, IEnumerator> taskHandler, UnityEditor.ProgressOptions options = 0, int parentId = -1, object userData = null);
    static public void SetDescription(int id, string description);
    static public void ShowDetails(bool shouldReposition = true);
    static public int Start(string name, string description = null, UnityEditor.ProgressOptions options = 0, int parentId = -1);
    static public void UnregisterCancelCallback(int id);

    public delegate void ProgressEventHandler(UnityEditor.ProgressItem[] operations);

}

}
