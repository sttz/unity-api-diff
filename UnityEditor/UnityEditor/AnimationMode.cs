using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class AnimationMode
{
    static public Color animatedPropertyColor { get; }
    static public Color candidatePropertyColor { get; }
    static public Color recordedPropertyColor { get; }

    static public void AddEditorCurveBinding(GameObject gameObject, UnityEditor.EditorCurveBinding binding);
    static public void AddPropertyModification(UnityEditor.EditorCurveBinding binding, UnityEditor.PropertyModification modification, bool keepPrefabOverride);
    static public void BeginSampling();
    static public void EndSampling();
    static public bool InAnimationMode();
    static public bool IsPropertyAnimated(Object target, string propertyPath);
    static public void SampleAnimationClip(GameObject gameObject, AnimationClip clip, float time);
    static public void StartAnimationMode();
    static public void StopAnimationMode();

    public AnimationMode();

}

}
