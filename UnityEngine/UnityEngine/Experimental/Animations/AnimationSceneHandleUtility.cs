using System;
using UnityEngine;

namespace UnityEngine.Experimental.Animations
{

public static class AnimationSceneHandleUtility
{
    static public void ReadFloats(Experimental.Animations.AnimationStream stream, Unity.Collections.NativeArray<Experimental.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<float> buffer);
    static public void ReadInts(Experimental.Animations.AnimationStream stream, Unity.Collections.NativeArray<Experimental.Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<int> buffer);

}

}
