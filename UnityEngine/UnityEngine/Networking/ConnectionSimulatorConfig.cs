using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public class ConnectionSimulatorConfig : IDisposable
{
    public ConnectionSimulatorConfig(int outMinDelay, int outAvgDelay, int inMinDelay, int inAvgDelay, float packetLossPercentage);

    public void Dispose();

}

}
