using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public class Utility
{
    static public bool useRandomSourceID { get; set; }

    static public Networking.Types.NetworkAccessToken GetAccessTokenForNetwork(Networking.Types.NetworkID netId);
    static public Networking.Types.AppID GetAppID();
    static public Networking.Types.SourceID GetSourceID();
    static public void SetAccessTokenForNetwork(Networking.Types.NetworkID netId, Networking.Types.NetworkAccessToken accessToken);
    static public void SetAppID(Networking.Types.AppID newAppID);

}

}
