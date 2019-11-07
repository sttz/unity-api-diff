using System;
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
