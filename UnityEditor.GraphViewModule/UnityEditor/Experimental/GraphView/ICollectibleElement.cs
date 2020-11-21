using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface ICollectibleElement
{
    public void CollectElements(HashSet<UnityEditor.Experimental.GraphView.GraphElement> collectedElementSet, Func<UnityEditor.Experimental.GraphView.GraphElement, bool> conditionFunc);

}

}
