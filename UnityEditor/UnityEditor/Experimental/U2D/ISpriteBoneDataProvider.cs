using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ISpriteBoneDataProvider
{
    public List<Experimental.U2D.SpriteBone> GetBones(UnityEditor.GUID guid);
    public void SetBones(UnityEditor.GUID guid, List<Experimental.U2D.SpriteBone> bones);

}

}
