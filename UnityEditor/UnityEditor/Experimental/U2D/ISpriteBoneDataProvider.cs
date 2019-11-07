using System;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ISpriteBoneDataProvider
{
    public System.Collections.Generic.List<Experimental.U2D.SpriteBone> GetBones(UnityEditor.GUID guid);
    public void SetBones(UnityEditor.GUID guid, System.Collections.Generic.List<Experimental.U2D.SpriteBone> bones);

}

}
