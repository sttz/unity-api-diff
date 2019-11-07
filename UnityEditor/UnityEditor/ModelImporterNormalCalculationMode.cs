using System;
using UnityEngine;

namespace UnityEditor
{

public enum ModelImporterNormalCalculationMode
{
    Unweighted_Legacy = 0,
    Unweighted = 1,
    AreaWeighted = 2,
    AngleWeighted = 3,
    AreaAndAngleWeighted = 4,
}

}
