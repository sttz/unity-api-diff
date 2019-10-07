using System;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public static class NativeArrayUnsafeUtility
{
    static public Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray(void dataPointer, int length, Unity.Collections.Allocator allocator);
    static public Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetAtomicSafetyHandle(Unity.Collections.NativeArray<T> array);
    static public void GetUnsafeBufferPointerWithoutChecks(Unity.Collections.NativeArray<T> nativeArray);
    static public void GetUnsafePtr(Unity.Collections.NativeArray<T> nativeArray);
    static public void GetUnsafeReadOnlyPtr(Unity.Collections.NativeArray<T> nativeArray);
    static public void SetAtomicSafetyHandle(Unity.Collections.NativeArray<T> array, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safety);

}

}
