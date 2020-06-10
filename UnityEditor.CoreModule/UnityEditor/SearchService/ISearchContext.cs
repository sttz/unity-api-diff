using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public interface ISearchContext
{
    public UnityEditor.SearchService.SearchEngineScope engineScope { get; }
    public Guid guid { get; }
    public IEnumerable<string> requiredTypeNames { get; }
    public IEnumerable<Type> requiredTypes { get; }

}

}
