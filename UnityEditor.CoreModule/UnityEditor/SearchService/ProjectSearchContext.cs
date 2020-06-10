using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public class ProjectSearchContext : UnityEditor.SearchService.ISearchContext
{
    public UnityEditor.SearchService.SearchEngineScope engineScope { get; protected set; }
    public Guid guid { get; }
    public IEnumerable<string> requiredTypeNames { get; set; }
    public IEnumerable<Type> requiredTypes { get; set; }

    public ProjectSearchContext();

}

}
