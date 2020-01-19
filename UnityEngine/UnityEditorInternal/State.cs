using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public class State : Object
{
    public bool iKOnFeet { get; set; }
    public bool mirror { get; set; }
    public float speed { get; set; }
    public string tag { get; set; }
    public string uniqueName { get; }
    public int uniqueNameHash { get; }

    public State();

    public UnityEditorInternal.BlendTree CreateBlendTree();
    public UnityEditorInternal.BlendTree CreateBlendTree(UnityEditorInternal.AnimatorControllerLayer layer);
    public Motion GetMotion();
    public Motion GetMotion(UnityEditorInternal.AnimatorControllerLayer layer);

}

}
