using System;
using UnityEngine;

namespace UnityEditor.Callbacks
{

public sealed class PostProcessBuildAttribute : UnityEditor.CallbackOrderAttribute
{
    public PostProcessBuildAttribute();
    public PostProcessBuildAttribute(int callbackOrder);

}

}
