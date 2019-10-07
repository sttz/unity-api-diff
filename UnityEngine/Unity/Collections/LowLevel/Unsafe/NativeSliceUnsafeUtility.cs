using System;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public static class NativeSliceUnsafeUtility
{
    static public Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice(void dataPointer, int stride, int length);
    static public Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetAtomicSafetyHandle(Unity.Collections.NativeSlice<T> slice);
    static public void GetUnsafePtr(Unity.Collections.NativeSlice<T> nativeSlice);
    static public void GetUnsafeReadOnlyPtr(Unity.Collections.NativeSlice<T> nativeSlice);
    static public void SetAtomicSafetyHandle(Unity.Collections.NativeSlice<T> slice, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safety);

}

}
