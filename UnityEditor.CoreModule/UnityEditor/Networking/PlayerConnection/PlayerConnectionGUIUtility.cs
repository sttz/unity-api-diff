using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Networking.PlayerConnection
{

public static class PlayerConnectionGUIUtility
{
    static public Networking.PlayerConnection.IConnectionState GetConnectionState(UnityEditor.EditorWindow parentWindow, Action<string> connectedCallback = null);

}

}
