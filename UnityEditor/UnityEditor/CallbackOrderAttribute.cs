using System;
using UnityEngine;

namespace UnityEditor
{

public abstract class CallbackOrderAttribute : Attribute
{
    protected int m_CallbackOrder;

    protected CallbackOrderAttribute();

}

}
