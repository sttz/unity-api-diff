using System;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public struct AtomicSafetyHandle
{
    static public void CheckDeallocateAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void CheckExistsAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void CheckGetSecondaryDataPointerAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void CheckReadAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void CheckWriteAndBumpSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void CheckWriteAndThrow(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle Create();
    static public Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompleted(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndDisableReadWrite(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public Unity.Collections.LowLevel.Unsafe.EnforceJobResult EnforceAllBufferJobsHaveCompletedAndRelease(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public bool GetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public int GetReaderArray(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle, int maxCount, IntPtr output);
    static public string GetReaderName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle, int readerIndex);
    static public Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempMemoryHandle();
    static public Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetTempUnsafePtrSliceHandle();
    static public Unity.Jobs.JobHandle GetWriter(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public string GetWriterName(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public bool IsTempMemoryHandle(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void PrepareUndisposable(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void Release(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);
    static public void SetAllowReadOrWriteAccess(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle, bool allowReadWriteAccess);
    static public void SetAllowSecondaryVersionWriting(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle, bool allowWriting);
    static public void UseSecondaryVersion(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle handle);

}

}
