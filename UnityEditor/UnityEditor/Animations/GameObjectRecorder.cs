using System;
using UnityEngine;

namespace UnityEditor.Animations
{

public class GameObjectRecorder : Object
{
    public float currentTime { get; }
    public bool isRecording { get; }
    public GameObject root { get; }

    public GameObjectRecorder(GameObject root);
    public GameObjectRecorder();

    public void Bind(UnityEditor.EditorCurveBinding binding);
    public void BindAll(GameObject target, bool recursive);
    public void BindComponent(Component component);
    public void BindComponent(GameObject target, Type componentType, bool recursive);
    public void BindComponent(GameObject target, bool recursive);
    public void BindComponentsOfType(GameObject target, bool recursive);
    public void BindComponentsOfType(GameObject target, Type componentType, bool recursive);
    public UnityEditor.EditorCurveBinding[] GetBindings();
    public void ResetRecording();
    public void SaveToClip(AnimationClip clip);
    public void SaveToClip(AnimationClip clip, float fps);
    public void SaveToClip(AnimationClip clip, float fps, UnityEditor.Animations.CurveFilterOptions filterOptions);
    public void TakeSnapshot(float dt);

}

}
