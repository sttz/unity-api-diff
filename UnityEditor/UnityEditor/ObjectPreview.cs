using System;
using UnityEngine;

namespace UnityEditor
{

public class ObjectPreview : UnityEditor.IPreviewable
{
    protected int m_ReferenceTargetIndex;
    protected Object[] m_Targets;

    public Object target { get; }

    public ObjectPreview();

    public void DrawPreview(Rect previewArea);
    public string GetInfoString();
    public GUIContent GetPreviewTitle();
    public bool HasPreviewGUI();
    public void Initialize(Object[] targets);
    public bool MoveNextTarget();
    public void OnInteractivePreviewGUI(Rect r, GUIStyle background);
    public void OnPreviewGUI(Rect r, GUIStyle background);
    public void OnPreviewSettings();
    public void ReloadPreviewInstances();
    public void ResetTarget();

}

}
