using System;
using UnityEngine;

namespace UnityEngineInternal
{

public enum TypeInferenceRules
{
    TypeReferencedByFirstArgument = 0,
    TypeReferencedBySecondArgument = 1,
    ArrayOfTypeReferencedByFirstArgument = 2,
    TypeOfFirstArgument = 3,
}

}
