using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public static class NativeArrayUnsafeUtility
{
    static public Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray<T>(void dataPointer, int length, Unity.Collections.Allocator allocator);
    static public Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetAtomicSafetyHandle<T>(Unity.Collections.NativeArray<T> array);
    static public void GetUnsafeBufferPointerWithoutChecks<T>(Unity.Collections.NativeArray<T> nativeArray);
    static public void GetUnsafePtr<T>(Unity.Collections.NativeArray<T> nativeArray);
    static public void GetUnsafeReadOnlyPtr<T>(ReadOnly<T> nativeArray);
    static public void GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray<T> nativeArray);
    static public void SetAtomicSafetyHandle<T>(Unity.Collections.NativeArray<T> array, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safety);

}

}
