using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public static class UnsafeUtility
{
    static public void AddressOf<T>(T output);
    static public int AlignOf<T>();
    static public T ArrayElementAsRef<T>(void ptr, int index);
    static public T As<U, T>(U from);
    static public T AsRef<T>(void ptr);
    static public void CopyObjectAddressToPtr(object target, void dstPtr);
    static public void CopyPtrToStructure<T>(void ptr, out T output);
    static public void CopyStructureToPtr<T>(T input, void ptr);
    static public bool EnumEquals<T>(T lhs, T rhs);
    static public int EnumToInt<T>(T enumValue);
    static public void Free(void memory, Unity.Collections.Allocator allocator);
    static public int GetFieldOffset(System.Reflection.FieldInfo field);
    static public bool IsBlittable(Type type);
    static public bool IsBlittable<T>();
    static public bool IsUnmanaged(Type type);
    static public bool IsUnmanaged<T>();
    static public bool IsValidAllocator(Unity.Collections.Allocator allocator);
    static public bool IsValidNativeContainerElementType(Type type);
    static public bool IsValidNativeContainerElementType<T>();
    static public void Malloc(long size, int alignment, Unity.Collections.Allocator allocator);
    static public void MemClear(void destination, long size);
    static public int MemCmp(void ptr1, void ptr2, long size);
    static public void MemCpy(void destination, void source, long size);
    static public void MemCpyReplicate(void destination, void source, int size, int count);
    static public void MemCpyStride(void destination, int destinationStride, void source, int sourceStride, int elementSize, int count);
    static public void MemMove(void destination, void source, long size);
    static public void MemSet(void destination, byte value, long size);
    static public void PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle);
    static public void PinGCObjectAndGetAddress(object target, out ulong gcHandle);
    static public T ReadArrayElement<T>(void source, int index);
    static public T ReadArrayElementWithStride<T>(void source, int index, int stride);
    static public void ReleaseGCObject(ulong gcHandle);
    static public int SizeOf(Type type);
    static public int SizeOf<T>();
    static public void WriteArrayElement<T>(void destination, int index, T value);
    static public void WriteArrayElementWithStride<T>(void destination, int index, int stride, T value);

}

}
