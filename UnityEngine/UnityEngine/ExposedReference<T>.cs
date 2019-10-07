using System;
using UnityEngine;

namespace UnityEngine
{

public struct ExposedReference<T>
{
    public Object defaultValue;
    public PropertyName exposedName;

    public T Resolve(IExposedPropertyTable resolver);

}

}
