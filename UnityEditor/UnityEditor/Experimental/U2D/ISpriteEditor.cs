using System;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ISpriteEditor
{
    public bool editingDisabled { get; }
    public bool enableMouseMoveEvent { set; }
    public UnityEditor.SpriteRect selectedSpriteRect { get; set; }
    public System.Collections.Generic.List<UnityEditor.SpriteRect> spriteRects { set; }
    public Rect windowDimension { get; }

    public void ApplyOrRevertModification(bool apply);
    public T GetDataProvider();
    public Experimental.UIElements.VisualElement GetMainVisualContainer();
    public bool HandleSpriteSelection();
    public void RequestRepaint();
    public void SetDataModified();
    public void SetPreviewTexture(Texture2D texture, int width, int height);

}

}
