using System;
using UnityEngine;

namespace UnityEngine.Animations
{

public static class AnimationStreamHandleUtility
{
    static public void ReadFloats(Animations.AnimationStream stream, Unity.Collections.NativeArray<Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer);
    static public void ReadInts(Animations.AnimationStream stream, Unity.Collections.NativeArray<Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer);
    static public void WriteFloats(Animations.AnimationStream stream, Unity.Collections.NativeArray<Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer, bool useMask);
    static public void WriteInts(Animations.AnimationStream stream, Unity.Collections.NativeArray<Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer, bool useMask);

}

}
