using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class RequireComponent : Attribute
{
    public Type m_Type0;
    public Type m_Type1;
    public Type m_Type2;

    public RequireComponent(Type requiredComponent);
    public RequireComponent(Type requiredComponent, Type requiredComponent2);
    public RequireComponent(Type requiredComponent, Type requiredComponent2, Type requiredComponent3);

}

}
