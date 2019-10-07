using System;
using UnityEngine;

namespace UnityEngine
{

public interface IExposedPropertyTable
{
    public void ClearReferenceValue(PropertyName id);
    public Object GetReferenceValue(PropertyName id, out bool idValid);
    public void SetReferenceValue(PropertyName id, Object value);

}

}
