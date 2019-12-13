using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface ICollectibleElement
{
    public void CollectElements(System.Collections.Generic.HashSet<UnityEditor.Experimental.GraphView.GraphElement> collectedElementSet, Func<UnityEditor.Experimental.GraphView.GraphElement, bool> conditionFunc);

}

}
