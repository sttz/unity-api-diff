using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.SearchService
{

public class ObjectSelectorSearchContext : UnityEditor.SearchService.ISearchContext
{
    public IEnumerable<int> allowedInstanceIds { get; set; }
    public Object currentObject { get; set; }
    public Object[] editedObjects { get; set; }
    public UnityEditor.SearchService.SearchEngineScope engineScope { get; protected set; }
    public Guid guid { get; }
    public IEnumerable<string> requiredTypeNames { get; set; }
    public IEnumerable<Type> requiredTypes { get; set; }
    public Func<UnityEditor.SearchService.ObjectSelectorTargetInfo, Object[], UnityEditor.SearchService.ObjectSelectorSearchContext, bool> selectorConstraint { get; set; }
    public UnityEditor.SearchService.VisibleObjects visibleObjects { get; set; }

    public ObjectSelectorSearchContext();

}

}
