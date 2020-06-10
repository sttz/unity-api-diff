using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.Profiling.Memory.Experimental
{

public class MemorySnapshotFileReader : ISerializationCallbackReceiver
{
    public MemorySnapshotFileReader();
    public MemorySnapshotFileReader(string filePath);

    public void Close();
    public void Dispose();
    public void GetDataArray<T>(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, uint entryIndex, uint numEntries, T[] dataOut, UnityEditorInternal.Profiling.Memory.Experimental.GetItem<T> getItemFunc);
    public T GetDataSingle<T>(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, UnityEditorInternal.Profiling.Memory.Experimental.GetItem<T> getItemFunc);
    public string GetFilePath();
    public uint GetNumEntries(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType);
    public void OnAfterDeserialize();
    public void OnBeforeSerialize();
    public void Open(string filePath);

}

}
