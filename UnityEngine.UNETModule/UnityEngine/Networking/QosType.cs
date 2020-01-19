using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Networking
{

public enum QosType
{
    Unreliable = 0,
    UnreliableFragmented = 1,
    UnreliableSequenced = 2,
    Reliable = 3,
    ReliableFragmented = 4,
    ReliableSequenced = 5,
    StateUpdate = 6,
    ReliableStateUpdate = 7,
    AllCostDelivery = 8,
    UnreliableFragmentedSequenced = 9,
    ReliableFragmentedSequenced = 10,
}

}
