using System;
using UnityEngine;

namespace UnityEditorInternal.Profiling.Memory.Experimental
{

public class MemorySnapshotFileWriter : IDisposable
{
    public MemorySnapshotFileWriter(string filepath);
    public MemorySnapshotFileWriter();

    public void Close();
    public void Dispose();
    public void Open(string filename);
    public void WriteEntry(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, string data);
    public void WriteEntry(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, T data);
    public void WriteEntryArray(UnityEditorInternal.Profiling.Memory.Experimental.FileFormat.EntryType entryType, T[] data);

}

}
