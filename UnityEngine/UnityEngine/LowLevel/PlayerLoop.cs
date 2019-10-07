using System;
using UnityEngine;

namespace UnityEngine.LowLevel
{

public class PlayerLoop
{
    static public LowLevel.PlayerLoopSystem GetCurrentPlayerLoop();
    static public LowLevel.PlayerLoopSystem GetDefaultPlayerLoop();
    static public void SetPlayerLoop(LowLevel.PlayerLoopSystem loop);

    public PlayerLoop();

}

}
