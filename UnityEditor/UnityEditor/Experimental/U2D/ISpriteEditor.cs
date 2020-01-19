using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ISpriteEditor
{
    public bool editingDisabled { get; }
    public bool enableMouseMoveEvent { set; }
    public UnityEditor.SpriteRect selectedSpriteRect { get; set; }
    public List<UnityEditor.SpriteRect> spriteRects { set; }
    public Rect windowDimension { get; }

    public void ApplyOrRevertModification(bool apply);
    public T GetDataProvider<T>();
    public UIElements.VisualElement GetMainVisualContainer();
    public bool HandleSpriteSelection();
    public void RequestRepaint();
    public void SetDataModified();
    public void SetPreviewTexture(Texture2D texture, int width, int height);

}

}
