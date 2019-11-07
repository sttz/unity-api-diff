using System;
using UnityEngine;

namespace UnityEditorInternal.Profiling.Memory.Experimental
{

public class MemorySnapshotFileReader : ISerializationCallbackReceiver
{
    public MemorySnapshotFileReader(string filePath);
    public MemorySnapshotFileReader();

    public void Close();
    public void Dispose();
    public void GetDataArray(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, uint entryIndex, uint numEntries, T[]& dataOut, UnityEditorInternal.Profiling.Memory.Experimental.GetItem<T> getItemFunc);
    public T GetDataSingle(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, UnityEditorInternal.Profiling.Memory.Experimental.GetItem<T> getItemFunc);
    public string GetFilePath();
    public uint GetNumEntries(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType);
    public void OnAfterDeserialize();
    public void OnBeforeSerialize();
    public void Open(string filePath);

}

}
