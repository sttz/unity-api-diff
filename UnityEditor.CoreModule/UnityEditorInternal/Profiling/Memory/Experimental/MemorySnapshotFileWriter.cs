using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal.Profiling.Memory.Experimental
{

public class MemorySnapshotFileWriter : IDisposable
{
    public MemorySnapshotFileWriter();
    public MemorySnapshotFileWriter(string filepath);

    public void Close();
    public void Dispose();
    public void Open(string filename);
    public void WriteEntry(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, string data);
    public void WriteEntry<T>(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, T data);
    public void WriteEntryArray<T>(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, T[] data);

}

}
