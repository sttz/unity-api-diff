using System;
using UnityEngine;

namespace UnityEditor.Networking.PlayerConnection
{

public class ConnectedPlayer
{
    public string name { get; }
    public int playerId { get; }
    public int PlayerId { get; }

    public ConnectedPlayer();
    public ConnectedPlayer(int playerId);
    public ConnectedPlayer(int playerId, string name);

}

}
