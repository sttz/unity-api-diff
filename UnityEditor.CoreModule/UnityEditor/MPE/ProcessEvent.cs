using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.MPE
{

public enum ProcessEvent
{
    UMP_EVENT_UNDEFINED = 0,
    Undefined = 0,
    UMP_EVENT_CREATE = 1,
    Create = 1,
    UMP_EVENT_INITIALIZE = 2,
    Initialize = 2,
    UMP_EVENT_AFTER_DOMAIN_RELOAD = 3,
    AfterDomainReload = 3,
    UMP_EVENT_SHUTDOWN = 4,
    Shutdown = 4,
}

}
