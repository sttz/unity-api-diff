using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{
    public float alpha { get; set; }
    public bool blocksRaycasts { get; set; }
    public bool ignoreParentGroups { get; set; }
    public bool interactable { get; set; }

    public CanvasGroup();

    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);

}

}
