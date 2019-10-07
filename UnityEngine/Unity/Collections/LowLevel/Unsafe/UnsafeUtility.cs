using System;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{

public static class UnsafeUtility
{
    static public void AddressOf(T& output);
    static public int AlignOf();
    static public void CopyObjectAddressToPtr(object target, void dstPtr);
    static public void CopyPtrToStructure(void ptr, out T& output);
    static public void CopyStructureToPtr(T& input, void ptr);
    static public int EnumToInt(T enumValue);
    static public void Free(void memory, Unity.Collections.Allocator allocator);
    static public int GetFieldOffset(System.Reflection.FieldInfo field);
    static public bool IsBlittable();
    static public bool IsBlittable(Type type);
    static public bool IsUnmanaged(Type type);
    static public bool IsUnmanaged();
    static public bool IsValidAllocator(Unity.Collections.Allocator allocator);
    static public void Malloc(long size, int alignment, Unity.Collections.Allocator allocator);
    static public void MemClear(void destination, long size);
    static public int MemCmp(void ptr1, void ptr2, long size);
    static public void MemCpy(void destination, void source, long size);
    static public void MemCpyReplicate(void destination, void source, int size, int count);
    static public void MemCpyStride(void destination, int destinationStride, void source, int sourceStride, int elementSize, int count);
    static public void MemMove(void destination, void source, long size);
    static public void PinGCArrayAndGetDataAddress(Array target, out ulong gcHandle);
    static public void PinGCObjectAndGetAddress(object target, out ulong gcHandle);
    static public T ReadArrayElement(void source, int index);
    static public T ReadArrayElementWithStride(void source, int index, int stride);
    static public void ReleaseGCObject(ulong gcHandle);
    static public int SizeOf(Type type);
    static public int SizeOf();
    static public void WriteArrayElement(void destination, int index, T value);
    static public void WriteArrayElementWithStride(void destination, int index, int stride, T value);

}

}
