using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Search
{

public interface IQueryHandlerFactory<TData, TQueryHandler, TPayload>
{
    public TQueryHandler Create(UnityEditor.Search.QueryGraph graph, ICollection<UnityEditor.Search.QueryError> errors);

}

}
