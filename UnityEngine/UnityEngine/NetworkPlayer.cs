using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct NetworkPlayer
{
    public string externalIP { get; }
    public int externalPort { get; }
    public string guid { get; }
    public string ipAddress { get; }
    public int port { get; }

    public NetworkPlayer(string ip, int port);

}

}
