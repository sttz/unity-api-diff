using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.UIElements.GraphView
{

public class BlackboardField : UnityEditor.Experimental.UIElements.GraphView.GraphElement
{
    public bool highlighted { get; set; }
    public Texture icon { get; set; }
    public string text { get; set; }
    public string typeText { get; set; }

    public BlackboardField();
    public BlackboardField(Texture icon, string text, string typeText);

    public void OpenTextEditor();

}

}
