using System;
using UnityEngine;

namespace UnityEngine
{

public class NetworkView : Behaviour
{
    public int group { get; set; }
    public bool isMine { get; }
    public Component observed { get; set; }
    public NetworkPlayer owner { get; }
    public NetworkStateSynchronization stateSynchronization { get; set; }
    public NetworkViewID viewID { get; set; }

    public NetworkView();

    public void RPC(string name, RPCMode mode, object[] args);
    public void RPC(string name, NetworkPlayer target, object[] args);

}

}
