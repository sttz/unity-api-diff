using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ISpriteOutlineDataProvider
{
    public List<Vector2[]> GetOutlines(UnityEditor.GUID guid);
    public float GetTessellationDetail(UnityEditor.GUID guid);
    public void SetOutlines(UnityEditor.GUID guid, List<Vector2[]> data);
    public void SetTessellationDetail(UnityEditor.GUID guid, float value);

}

}
