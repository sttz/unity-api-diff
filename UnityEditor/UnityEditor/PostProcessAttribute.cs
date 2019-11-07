using System;
using UnityEngine;

namespace UnityEditor
{

public abstract class PostProcessAttribute : UnityEditor.CallbackOrderAttribute
{
    protected int m_PostprocessOrder;

    protected PostProcessAttribute();

}

}
