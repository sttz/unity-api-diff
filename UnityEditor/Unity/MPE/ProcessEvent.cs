using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.MPE
{

public enum ProcessEvent
{
    UMP_EVENT_UNDEFINED = -1,
    UMP_EVENT_CREATE = 1,
    UMP_EVENT_INITIALIZE = 2,
    UMP_EVENT_AFTER_DOMAIN_RELOAD = 3,
    UMP_EVENT_SHUTDOWN = 4,
}

}
