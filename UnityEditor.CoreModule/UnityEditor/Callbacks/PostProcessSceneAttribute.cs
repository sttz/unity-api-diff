using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Callbacks
{

public sealed class PostProcessSceneAttribute : UnityEditor.CallbackOrderAttribute
{
    public PostProcessSceneAttribute();
    public PostProcessSceneAttribute(int callbackOrder);
    public PostProcessSceneAttribute(int callbackOrder, int version);

}

}
