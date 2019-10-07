using System;
using UnityEngine;

namespace UnityEngine
{

public interface ICanvasRaycastFilter
{
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);

}

}
