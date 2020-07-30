using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.AssetImporters
{

public abstract class AssetImporterEditor : UnityEditor.Editor
{
    protected ExtraDataSerializedObject extraDataSerializedObject { get; }
    protected Object extraDataTarget { get; }
    protected Object[] extraDataTargets { get; }
    protected Type extraDataType { get; }
    protected bool needsApplyRevert { get; }
    public bool showImportedObject { get; }
    protected bool useAssetDrawPreview { get; }

    protected AssetImporterEditor();

    protected void Apply();
    protected bool ApplyButton();
    protected void ApplyRevertGUI();
    protected void Awake();
    protected bool CanApply();
    public bool HasModified();
    protected void InitializeExtraDataInstance(Object extraData, int targetIndex);
    protected bool OnApplyRevertGUI();
    public void OnDisable();
    public void OnEnable();
    public void OnInspectorGUI();
    protected void ResetValues();
    protected void RevertButton();

    protected sealed class ExtraDataSerializedObject : UnityEditor.SerializedObject
    {
        public void ApplyModifiedProperties();
        public void SetIsDifferentCacheDirty();
        public void Update();
        public void UpdateIfRequiredOrScript();

    }

}

}
