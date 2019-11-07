using System;
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
    static public bool InAnimationMode(UnityEditor.AnimationModeDriver driver);
    static public bool IsPropertyAnimated(Object target, string propertyPath);
    static public void SampleAnimationClip(GameObject gameObject, AnimationClip clip, float time);
    static public void SamplePlayableGraph(Playables.PlayableGraph graph, int index, float time);
    static public void StartAnimationMode();
    static public void StartAnimationMode(UnityEditor.AnimationModeDriver driver);
    static public void StopAnimationMode();
    static public void StopAnimationMode(UnityEditor.AnimationModeDriver driver);

    public AnimationMode();

}

}
