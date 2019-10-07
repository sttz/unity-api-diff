using System;
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
