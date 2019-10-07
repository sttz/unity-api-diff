using System;
using UnityEngine;

namespace UnityEngine.Networking.Match
{

public class MatchInfoSnapshot
{
    public int averageEloScore { get; private set; }
    public int currentSize { get; private set; }
    public System.Collections.Generic.List<MatchInfoDirectConnectSnapshot> directConnectInfos { get; private set; }
    public Networking.Types.NodeID hostNodeId { get; private set; }
    public bool isPrivate { get; private set; }
    public System.Collections.Generic.Dictionary<string, long> matchAttributes { get; private set; }
    public int maxSize { get; private set; }
    public string name { get; private set; }
    public Networking.Types.NetworkID networkId { get; private set; }

    public MatchInfoSnapshot();

    public class MatchInfoDirectConnectSnapshot
    {
        public Networking.Types.HostPriority hostPriority { get; private set; }
        public Networking.Types.NodeID nodeId { get; private set; }
        public string privateAddress { get; private set; }
        public string publicAddress { get; private set; }

        public MatchInfoDirectConnectSnapshot();

    }

}

}
