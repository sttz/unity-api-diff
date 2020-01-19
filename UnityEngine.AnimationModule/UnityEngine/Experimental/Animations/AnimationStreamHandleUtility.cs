using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public static class AnimationStreamHandleUtility
{
    static public void ReadFloats(Experimental.Animations.AnimationStream stream, Unity.Collections.NativeArray<Experimental.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer);
    static public void ReadInts(Experimental.Animations.AnimationStream stream, Unity.Collections.NativeArray<Experimental.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer);
    static public void WriteFloats(Experimental.Animations.AnimationStream stream, Unity.Collections.NativeArray<Experimental.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<float> buffer, bool useMask);
    static public void WriteInts(Experimental.Animations.AnimationStream stream, Unity.Collections.NativeArray<Experimental.Animations.PropertyStreamHandle> handles, Unity.Collections.NativeArray<int> buffer, bool useMask);

}

}
