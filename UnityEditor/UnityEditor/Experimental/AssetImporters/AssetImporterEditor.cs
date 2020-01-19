using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.AssetImporters
{

public abstract class AssetImporterEditor : UnityEditor.Editor
{
    public bool showImportedObject { get; }
    protected bool useAssetDrawPreview { get; }

    protected AssetImporterEditor();

    protected void Apply();
    protected bool ApplyButton();
    protected bool ApplyButton(string buttonText);
    protected void ApplyRevertGUI();
    protected void Awake();
    public bool HasModified();
    protected bool OnApplyRevertGUI();
    public void OnDisable();
    public void OnEnable();
    protected void ResetValues();
    protected void RevertButton();
    protected void RevertButton(string buttonText);

}

}
