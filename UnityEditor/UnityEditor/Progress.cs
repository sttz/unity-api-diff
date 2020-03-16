using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public static class Progress
{
    static public float globalProgress { get; }
    static public TimeSpan globalRemainingTime { get; }
    static public bool running { get; }

    static public event Action<Item[]> added;
    static public event Action<Item[]> removed;
    static public event Action<Item[]> updated;

    static public bool Cancel(int id);
    static public void ClearRemainingTime(int id);
    static public IEnumerable<Item> EnumerateItems();
    static public bool Exists(int id);
    static public void Finish(int id, Status status = 1);
    static public int GetCount();
    static public int[] GetCountPerStatus();
    static public string GetDescription(int id);
    static public int GetId(int index);
    static public string GetName(int id);
    static public Options GetOptions(int id);
    static public int GetParentId(int id);
    static public float GetProgress(int id);
    static public Item GetProgressById(int id);
    static public long GetRemainingTime(int id);
    static public int GetRunningProgressCount();
    static public long GetStartDateTime(int id);
    static public Status GetStatus(int id);
    static public TimeDisplayMode GetTimeDisplayMode(int id);
    static public long GetUpdateDateTime(int id);
    static public bool IsCancellable(int id);
    static public void RegisterCancelCallback(int id, Func<bool> callback);
    static public int Remove(int id);
    static public void Report(int id, float progress);
    static public void Report(int id, float progress, string description);
    static public int RunTask(string name, string description, Func<int, object, IEnumerator> taskHandler, Options options = 0, int parentId = -1, object userData = null);
    static public void SetDescription(int id, string description);
    static public void SetRemainingTime(int id, long seconds);
    static public void SetTimeDisplayMode(int id, TimeDisplayMode displayMode);
    static public void ShowDetails(bool shouldReposition = true);
    static public int Start(string name, string description = null, Options options = 0, int parentId = -1);
    static public void UnregisterCancelCallback(int id);

    public class Item
    {
        public bool cancellable { get; }
        public string description { get; }
        public float elapsedTime { get; }
        public bool exists { get; }
        public bool finished { get; }
        public int id { get; internal set; }
        public bool indefinite { get; }
        public string name { get; }
        public Options options { get; }
        public int parentId { get; }
        public float progress { get; }
        public TimeSpan remainingTime { get; }
        public bool responding { get; }
        public bool running { get; }
        public DateTime startTime { get; }
        public Status status { get; }
        public TimeDisplayMode timeDisplayMode { get; }
        public DateTime updateTime { get; }

        public bool Cancel();
        public void ClearRemainingTime();
        public void Finish(Status finishedStatus = 1);
        public void RegisterCancelCallback(Func<bool> callback);
        public int Remove();
        public void Report(float newProgress);
        public void Report(float newProgress, string newDescription);
        public void SetDescription(string newDescription);
        public void SetRemainingTime(long seconds);
        public void SetTimeDisplayMode(TimeDisplayMode mode);
        public void UnregisterCancelCallback();

    }

    public enum Options
    {
        None = 0,
        Sticky = 1,
        Indefinite = 2,
        Synchronous = 4,
        Managed = 8,
        Unmanaged = 16,
    }

    public enum Status
    {
        Running = 0,
        Succeeded = 1,
        Failed = 2,
        Canceled = 3,
    }

    public class TaskError : TaskReport
    {
        public TaskError(string error);

    }

    public class TaskReport
    {
        public string description { get; internal set; }
        public string error { get; internal set; }
        public float progress { get; internal set; }

        public TaskReport(float progress = -1, string description = null);

    }

    public enum TimeDisplayMode
    {
        NoTimeShown = 0,
        ShowRunningTime = 1,
        ShowRemainingTime = 2,
    }

}

}
