using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class ShaderGUI
{
    static protected UnityEditor.MaterialProperty FindProperty(string propertyName, UnityEditor.MaterialProperty[] properties);
    static protected UnityEditor.MaterialProperty FindProperty(string propertyName, UnityEditor.MaterialProperty[] properties, bool propertyIsMandatory);

    protected ShaderGUI();

    public void AssignNewShaderToMaterial(Material material, Shader oldShader, Shader newShader);
    public void OnClosed(Material material);
    public void OnGUI(UnityEditor.MaterialEditor materialEditor, UnityEditor.MaterialProperty[] properties);
    public void OnMaterialInteractivePreviewGUI(UnityEditor.MaterialEditor materialEditor, Rect r, GUIStyle background);
    public void OnMaterialPreviewGUI(UnityEditor.MaterialEditor materialEditor, Rect r, GUIStyle background);
    public void OnMaterialPreviewSettingsGUI(UnityEditor.MaterialEditor materialEditor);

}

}
