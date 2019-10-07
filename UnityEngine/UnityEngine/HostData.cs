using System;
using UnityEngine;

namespace UnityEngine
{

public class HostData
{
    public string comment { get; set; }
    public int connectedPlayers { get; set; }
    public string gameName { get; set; }
    public string gameType { get; set; }
    public string guid { get; set; }
    public string[] ip { get; set; }
    public bool passwordProtected { get; set; }
    public int playerLimit { get; set; }
    public int port { get; set; }
    public bool useNat { get; set; }

    public HostData();

}

}
