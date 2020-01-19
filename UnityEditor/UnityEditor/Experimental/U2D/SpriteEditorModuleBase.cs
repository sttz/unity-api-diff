using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public abstract class SpriteEditorModuleBase
{
    public string moduleName { get; }
    public UnityEditor.Experimental.U2D.ISpriteEditor spriteEditor { get; internal set; }

    protected SpriteEditorModuleBase();

    public bool ApplyRevert(bool apply);
    public bool CanBeActivated();
    public void DoMainGUI();
    public void DoPostGUI();
    public void DoToolbarGUI(Rect drawArea);
    public void OnModuleActivate();
    public void OnModuleDeactivate();

}

}
