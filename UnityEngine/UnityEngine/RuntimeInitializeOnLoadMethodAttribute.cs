using System;
using UnityEngine;

namespace UnityEngine
{

public class RuntimeInitializeOnLoadMethodAttribute : Scripting.PreserveAttribute
{
    public RuntimeInitializeLoadType loadType { get; private set; }

    public RuntimeInitializeOnLoadMethodAttribute();
    public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType);

}

}
