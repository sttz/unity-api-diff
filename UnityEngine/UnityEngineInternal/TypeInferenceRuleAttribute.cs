using System;
using UnityEngine;

namespace UnityEngineInternal
{

public class TypeInferenceRuleAttribute : Attribute
{
    public TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);
    public TypeInferenceRuleAttribute(string rule);

    public string ToString();

}

}
