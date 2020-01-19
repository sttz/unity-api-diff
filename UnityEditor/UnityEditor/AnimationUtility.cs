using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class AnimationUtility
{
    static public OnCurveWasModified onCurveWasModified;

    static public string CalculateTransformPath(Transform targetTransform, Transform root);
    static public void ConstrainToPolynomialCurve(AnimationCurve curve);
    static public UnityEditor.AnimationClipCurveData[] GetAllCurves(AnimationClip clip);
    static public UnityEditor.AnimationClipCurveData[] GetAllCurves(AnimationClip clip, bool includeCurveData);
    static public UnityEditor.EditorCurveBinding[] GetAnimatableBindings(GameObject targetObject, GameObject root);
    static public Object GetAnimatedObject(GameObject root, UnityEditor.EditorCurveBinding binding);
    static public AnimationClip[] GetAnimationClips(Animation component);
    static public AnimationClip[] GetAnimationClips(GameObject gameObject);
    static public UnityEditor.AnimationClipSettings GetAnimationClipSettings(AnimationClip clip);
    static public AnimationEvent[] GetAnimationEvents(AnimationClip clip);
    static public UnityEditor.EditorCurveBinding[] GetCurveBindings(AnimationClip clip);
    static public AnimationCurve GetEditorCurve(AnimationClip clip, UnityEditor.EditorCurveBinding binding);
    static public AnimationCurve GetEditorCurve(AnimationClip clip, string relativePath, Type type, string propertyName);
    static public Type GetEditorCurveValueType(GameObject root, UnityEditor.EditorCurveBinding binding);
    static public bool GetFloatValue(GameObject root, UnityEditor.EditorCurveBinding binding, out float data);
    static public bool GetFloatValue(GameObject root, string relativePath, Type type, string propertyName, out float data);
    static public bool GetGenerateMotionCurves(AnimationClip clip);
    static public bool GetKeyBroken(AnimationCurve curve, int index);
    static public TangentMode GetKeyLeftTangentMode(AnimationCurve curve, int index);
    static public TangentMode GetKeyRightTangentMode(AnimationCurve curve, int index);
    static public UnityEditor.ObjectReferenceKeyframe[] GetObjectReferenceCurve(AnimationClip clip, UnityEditor.EditorCurveBinding binding);
    static public UnityEditor.EditorCurveBinding[] GetObjectReferenceCurveBindings(AnimationClip clip);
    static public bool GetObjectReferenceValue(GameObject root, UnityEditor.EditorCurveBinding binding, out Object data);
    static public bool InAnimationMode();
    static public Type PropertyModificationToEditorCurveBinding(UnityEditor.PropertyModification modification, GameObject gameObject, out UnityEditor.EditorCurveBinding binding);
    static public void SetAdditiveReferencePose(AnimationClip clip, AnimationClip referenceClip, float time);
    static public void SetAnimationClips(Animation animation, AnimationClip[] clips);
    static public void SetAnimationClipSettings(AnimationClip clip, UnityEditor.AnimationClipSettings srcClipInfo);
    static public void SetAnimationEvents(AnimationClip clip, AnimationEvent[] events);
    static public void SetAnimationType(AnimationClip clip, UnityEditor.ModelImporterAnimationType type);
    static public void SetEditorCurve(AnimationClip clip, UnityEditor.EditorCurveBinding binding, AnimationCurve curve);
    static public void SetEditorCurve(AnimationClip clip, string relativePath, Type type, string propertyName, AnimationCurve curve);
    static public void SetGenerateMotionCurves(AnimationClip clip, bool value);
    static public void SetKeyBroken(AnimationCurve curve, int index, bool broken);
    static public void SetKeyLeftTangentMode(AnimationCurve curve, int index, TangentMode tangentMode);
    static public void SetKeyRightTangentMode(AnimationCurve curve, int index, TangentMode tangentMode);
    static public void SetObjectReferenceCurve(AnimationClip clip, UnityEditor.EditorCurveBinding binding, UnityEditor.ObjectReferenceKeyframe[] keyframes);
    static public void StartAnimationMode(Object[] objects);
    static public void StopAnimationMode();

    public AnimationUtility();

    public enum CurveModifiedType
    {
        CurveDeleted = 0,
        CurveModified = 1,
        ClipModified = 2,
    }

    public delegate void OnCurveWasModified(AnimationClip clip, UnityEditor.EditorCurveBinding binding, CurveModifiedType type);

    public enum TangentMode
    {
        Free = 0,
        Auto = 1,
        Linear = 2,
        Constant = 3,
        ClampedAuto = 4,
    }

}

}
