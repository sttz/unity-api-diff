using System;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ISpriteEditorDataProvider
{
    public float pixelsPerUnit { get; }
    public UnityEditor.SpriteImportMode spriteImportMode { get; }
    public Object targetObject { get; }

    public void Apply();
    public T GetDataProvider();
    public UnityEditor.SpriteRect[] GetSpriteRects();
    public bool HasDataProvider(Type type);
    public void InitSpriteEditorDataProvider();
    public void SetSpriteRects(UnityEditor.SpriteRect[] spriteRects);

}

}
