using System;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class Node : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    protected Experimental.UIElements.VisualElement m_ButtonContainer;
    protected Experimental.UIElements.VisualElement m_CollapseButton;

    public bool expanded { get; set; }
    public Experimental.UIElements.VisualElement extensionContainer { get; private set; }
    public Experimental.UIElements.VisualElement inputContainer { get; private set; }
    public Experimental.UIElements.VisualElement mainContainer { get; private set; }
    public Experimental.UIElements.VisualElement outputContainer { get; private set; }
    public string title { get; set; }
    public Experimental.UIElements.VisualElement titleButtonContainer { get; private set; }
    public Experimental.UIElements.VisualElement titleContainer { get; private set; }
    public Experimental.UIElements.VisualElement topContainer { get; private set; }

    public Node();
    public Node(string uiFile);

    public void BuildContextualMenu(Experimental.UIElements.ContextualMenuPopulateEvent evt);
    public Rect GetPosition();
    public UnityEditor.Experimental.UIElements.GraphView.Port InstantiatePort(UnityEditor.Experimental.UIElements.GraphView.Orientation orientation, UnityEditor.Experimental.UIElements.GraphView.Direction direction, Capacity capacity, Type type);
    protected void OnPortRemoved(UnityEditor.Experimental.UIElements.GraphView.Port port);
    public void RefreshExpandedState();
    public bool RefreshPorts();
    public void SetPosition(Rect newPos);
    protected void ToggleCollapse();
    protected void UseDefaultStyling();

}

}
