using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Playables
{

public static class Utility
{
    static public event Action<Playables.PlayableGraph> destroyingGraph;
    static public event Action<Playables.PlayableGraph> graphCreated;

    static public Playables.PlayableGraph[] GetAllGraphs();

}

}
