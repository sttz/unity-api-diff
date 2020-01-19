using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngineInternal
{

public class TypeInferenceRuleAttribute : Attribute
{
    public TypeInferenceRuleAttribute(string rule);
    public TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);

    public string ToString();

}

}
