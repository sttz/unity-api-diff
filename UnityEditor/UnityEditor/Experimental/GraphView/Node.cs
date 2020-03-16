using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class Node : UnityEditor.Experimental.GraphView.GraphElement
{
    protected UIElements.VisualElement m_ButtonContainer;
    protected UIElements.VisualElement m_CollapseButton;

    public bool expanded { get; set; }
    public UIElements.VisualElement extensionContainer { get; private set; }
    public UIElements.VisualElement inputContainer { get; private set; }
    public UIElements.VisualElement mainContainer { get; private set; }
    public UIElements.VisualElement outputContainer { get; private set; }
    public string title { get; set; }
    public UIElements.VisualElement titleButtonContainer { get; private set; }
    public UIElements.VisualElement titleContainer { get; private set; }
    public UIElements.VisualElement topContainer { get; private set; }

    public Node();
    public Node(string uiFile);

    public void BuildContextualMenu(UIElements.ContextualMenuPopulateEvent evt);
    public Rect GetPosition();
    public UnityEditor.Experimental.GraphView.Port InstantiatePort(UnityEditor.Experimental.GraphView.Orientation orientation, UnityEditor.Experimental.GraphView.Direction direction, Capacity capacity, Type type);
    protected void OnPortRemoved(UnityEditor.Experimental.GraphView.Port port);
    public void RefreshExpandedState();
    public bool RefreshPorts();
    public void SetPosition(Rect newPos);
    protected void ToggleCollapse();
    protected void UseDefaultStyling();

}

}