using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build.Content
{

public enum DependencyType
{
    RecursiveOperation = 1,
    MissingReferences = 2,
    ValidReferences = 4,
    DefaultDependencies = 5,
}

}
