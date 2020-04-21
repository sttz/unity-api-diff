using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Callbacks
{

public sealed class PostProcessBuildAttribute : UnityEditor.CallbackOrderAttribute
{
    public PostProcessBuildAttribute();
    public PostProcessBuildAttribute(int callbackOrder);

}

}
