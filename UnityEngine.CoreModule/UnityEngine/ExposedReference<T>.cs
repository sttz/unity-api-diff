using System;
using System.Collections;
using System.Collections.Generic;
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
