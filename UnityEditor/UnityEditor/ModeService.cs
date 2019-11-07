using System;
using UnityEngine;

namespace UnityEditor
{

public static class ModeService
{
    static public string currentId { get; }
    static public int currentIndex { get; private set; }
    static public int modeCount { get; }
    static public string[] modeNames { get; }

    static public event Action<ModeChangedArgs> modeChanged;

    static public void ChangeModeById(string modeId);
    static public void Update();

    public struct ModeChangedArgs
    {
        public int nextIndex;
        public int prevIndex;

    }

}

}
