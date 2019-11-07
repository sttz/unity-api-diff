using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public class BlackboardField : UnityEditor.Experimental.GraphView.GraphElement
{
    public bool highlighted { get; set; }
    public Texture icon { get; set; }
    public string text { get; set; }
    public string typeText { get; set; }

    public BlackboardField();
    public BlackboardField(Texture icon, string text, string typeText);

    protected void ExecuteDefaultAction(UIElements.EventBase evt);
    public void OpenTextEditor();

}

}