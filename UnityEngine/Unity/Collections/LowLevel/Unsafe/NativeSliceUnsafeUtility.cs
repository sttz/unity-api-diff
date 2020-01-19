using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public static class NativeSliceUnsafeUtility
{
    static public Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void dataPointer, int stride, int length);
    static public Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetAtomicSafetyHandle<T>(Unity.Collections.NativeSlice<T> slice);
    static public void GetUnsafePtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
    static public void GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
    static public void SetAtomicSafetyHandle<T>(Unity.Collections.NativeSlice<T> slice, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle safety);

}

}
