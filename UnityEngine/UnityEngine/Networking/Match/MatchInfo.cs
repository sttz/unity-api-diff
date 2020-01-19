using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking.Match
{

public class MatchInfo
{
    public Networking.Types.NetworkAccessToken accessToken { get; private set; }
    public string address { get; private set; }
    public int domain { get; private set; }
    public Networking.Types.NetworkID networkId { get; private set; }
    public Networking.Types.NodeID nodeId { get; private set; }
    public int port { get; private set; }
    public bool usingRelay { get; private set; }

    public MatchInfo();

    public string ToString();

}

}
