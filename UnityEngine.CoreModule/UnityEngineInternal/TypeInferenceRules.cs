using System;
using System.Collections;
using System.Collections.Generic;
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
