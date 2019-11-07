using System;
using UnityEngine;

namespace UnityEditor
{

public enum ModelImporterTangents
{
    Import = 0,
    CalculateLegacy = 1,
    CalculateLegacyWithSplitTangents = 4,
    CalculateMikk = 3,
    None = 2,
}

}
