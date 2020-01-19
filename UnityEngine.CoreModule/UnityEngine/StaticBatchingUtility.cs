using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public sealed class StaticBatchingUtility
{
    static public void Combine(GameObject staticBatchRoot);
    static public void Combine(GameObject[] gos, GameObject staticBatchRoot);

    public StaticBatchingUtility();

}

}
