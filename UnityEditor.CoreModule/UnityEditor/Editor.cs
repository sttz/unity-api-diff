using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class Editor : ScriptableObject, UnityEditor.IPreviewable, UnityEditor.IToolModeOwner
{
    static public event Action<UnityEditor.Editor> finishedDefaultHeaderGUI;

    static public void CreateCachedEditor(Object targetObject, Type editorType, UnityEditor.Editor previousEditor);
    static public void CreateCachedEditor(Object[] targetObjects, Type editorType, UnityEditor.Editor previousEditor);
    static public void CreateCachedEditorWithContext(Object targetObject, Object context, Type editorType, UnityEditor.Editor previousEditor);
    static public void CreateCachedEditorWithContext(Object[] targetObjects, Object context, Type editorType, UnityEditor.Editor previousEditor);
    static public UnityEditor.Editor CreateEditor(Object targetObject);
    static public UnityEditor.Editor CreateEditor(Object[] targetObjects);
    static public UnityEditor.Editor CreateEditor(Object targetObject, Type editorType);
    static public UnityEditor.Editor CreateEditor(Object[] targetObjects, Type editorType);
    static public UnityEditor.Editor CreateEditorWithContext(Object[] targetObjects, Object context);
    static public UnityEditor.Editor CreateEditorWithContext(Object[] targetObjects, Object context, Type editorType);
    static public void DrawFoldoutInspector(Object target, UnityEditor.Editor editor);

    public UnityEditor.SerializedObject serializedObject { get; }
    public Object target { get; set; }
    public Object[] targets { get; }

    public Editor();

    public void Cleanup();
    public UIElements.VisualElement CreateInspectorGUI();
    public bool DrawDefaultInspector();
    public void DrawHeader();
    public void DrawPreview(Rect previewArea);
    public string GetInfoString();
    public GUIContent GetPreviewTitle();
    public bool HasPreviewGUI();
    public void Initialize(Object[] targets);
    public bool MoveNextTarget();
    protected void OnHeaderGUI();
    public void OnInspectorGUI();
    public void OnInteractivePreviewGUI(Rect r, GUIStyle background);
    public void OnPreviewGUI(Rect r, GUIStyle background);
    public void OnPreviewSettings();
    public void ReloadPreviewInstances();
    public Texture2D RenderStaticPreview(string assetPath, Object[] subAssets, int width, int height);
    public void Repaint();
    public bool RequiresConstantRepaint();
    public void ResetTarget();
    protected bool ShouldHideOpenButton();
    public bool UseDefaultMargins();

}

}
