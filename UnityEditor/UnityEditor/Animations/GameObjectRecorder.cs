using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Animations
{

public class GameObjectRecorder : Object
{
    public float currentTime { get; }
    public bool isRecording { get; }
    public GameObject root { get; }

    public GameObjectRecorder();
    public GameObjectRecorder(GameObject root);

    public void Bind(UnityEditor.EditorCurveBinding binding);
    public void BindAll(GameObject target, bool recursive);
    public void BindComponent(Component component);
    public void BindComponent(GameObject target, Type componentType, bool recursive);
    public void BindComponent<T>(GameObject target, bool recursive);
    public void BindComponentsOfType(GameObject target, Type componentType, bool recursive);
    public void BindComponentsOfType<T>(GameObject target, bool recursive);
    public UnityEditor.EditorCurveBinding[] GetBindings();
    public void ResetRecording();
    public void SaveToClip(AnimationClip clip);
    public void SaveToClip(AnimationClip clip, float fps);
    public void TakeSnapshot(float dt);

}

}
