using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public abstract class GraphViewToolWindow : UnityEditor.EditorWindow
{
    protected UnityEditor.Experimental.GraphView.GraphView m_SelectedGraphView;
    protected UIElements.VisualElement m_ToolbarContainer;

    protected string ToolName { get; }

    protected GraphViewToolWindow();

    public IEnumerable<Type> GetExtraPaneTypes();
    protected bool IsGraphViewSupported(UnityEditor.Experimental.GraphView.GraphView gv);
    protected void OnEnable();
    protected void OnGraphViewChanged();
    protected void OnGraphViewChanging();
    public void SelectGraphViewFromWindow(UnityEditor.Experimental.GraphView.GraphViewEditorWindow window, UnityEditor.Experimental.GraphView.GraphView graphView, int graphViewIndexInWindow = 0);

}

}
