using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Animations
{

public static class AnimationSceneHandleUtility
{
    static public void ReadFloats(Animations.AnimationStream stream, Unity.Collections.NativeArray<Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<float> buffer);
    static public void ReadInts(Animations.AnimationStream stream, Unity.Collections.NativeArray<Animations.PropertySceneHandle> handles, Unity.Collections.NativeArray<int> buffer);

}

}
