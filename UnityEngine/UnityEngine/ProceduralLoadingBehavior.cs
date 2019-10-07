using System;
using UnityEngine;

namespace UnityEngine
{

public enum ProceduralLoadingBehavior
{
    DoNothing = 0,
    Generate = 1,
    BakeAndKeep = 2,
    BakeAndDiscard = 3,
    Cache = 4,
    DoNothingAndCache = 5,
}

}
