using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class EditMode
{
    static public OnEditModeStopFunc onEditModeEndDelegate;
    static public OnEditModeStartFunc onEditModeStartDelegate;

    static public SceneViewEditMode editMode { get; private set; }

    static public void ChangeEditMode(SceneViewEditMode mode, Bounds bounds, UnityEditor.Editor caller);
    static public void DoEditModeInspectorModeButton(SceneViewEditMode mode, string label, GUIContent icon, Bounds bounds, UnityEditor.Editor caller);
    static public void DoEditModeInspectorModeButton(SceneViewEditMode mode, string label, GUIContent icon, Func<Bounds> getBoundsOfTargets, UnityEditor.Editor caller);
    static public void DoInspectorToolbar(SceneViewEditMode[] modes, GUIContent[] guiContents, Bounds bounds, UnityEditor.Editor caller);
    static public void DoInspectorToolbar(SceneViewEditMode[] modes, GUIContent[] guiContents, Func<Bounds> getBoundsOfTargets, UnityEditor.Editor caller);
    static public bool IsOwner(UnityEditor.Editor editor);
    static public void OnSelectionChange();
    static public void QuitEditMode();
    static public void ResetToolToPrevious();

    public EditMode();

    public delegate void OnEditModeStartFunc(UnityEditor.Editor editor, SceneViewEditMode mode);

    public delegate void OnEditModeStopFunc(UnityEditor.Editor editor);

    public enum SceneViewEditMode
    {
        None = 0,
        Collider = 1,
        ClothConstraints = 2,
        ClothSelfAndInterCollisionParticles = 3,
        ReflectionProbeBox = 4,
        ReflectionProbeOrigin = 5,
        LightProbeProxyVolumeBox = 6,
        LightProbeProxyVolumeOrigin = 7,
        LightProbeGroup = 8,
        JointAngularLimits = 9,
        GridPainting = 10,
        GridPicking = 11,
        GridEraser = 12,
        GridFloodFill = 13,
        GridBox = 14,
        GridSelect = 15,
        GridMove = 16,
        ParticleSystemCollisionModulePlanesMove = 17,
        ParticleSystemCollisionModulePlanesRotate = 18,
        LineRendererEdit = 19,
        LineRendererCreate = 20,
    }

}

}
