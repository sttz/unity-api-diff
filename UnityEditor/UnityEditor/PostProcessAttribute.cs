using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public abstract class PostProcessAttribute : UnityEditor.CallbackOrderAttribute
{
    protected int m_PostprocessOrder;

    protected PostProcessAttribute();

}

}
