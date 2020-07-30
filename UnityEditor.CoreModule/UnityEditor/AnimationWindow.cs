using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class AnimationWindow : UnityEditor.EditorWindow, UnityEditor.IHasCustomMenu
{
    public AnimationClip animationClip { get; set; }
    public bool canPreview { get; }
    public bool canRecord { get; }
    public int frame { get; set; }
    public bool playing { get; set; }
    public bool previewing { get; set; }
    public bool recording { get; set; }
    public float time { get; set; }

    public void AddItemsToMenu(UnityEditor.GenericMenu menu);

}

}
