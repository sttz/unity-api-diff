using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface IQueryHandler<TData, TPayload>
{
    public bool Eval(TData element);
    public IEnumerable<TData> Eval(TPayload payload);

}

}
