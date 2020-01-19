using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class CloudProjectSettings
{
    static public string accessToken { get; }
    static public string organizationId { get; }
    static public string organizationName { get; }
    static public string projectId { get; }
    static public string projectName { get; }
    static public string userId { get; }
    static public string userName { get; }

    static public void RefreshAccessToken(Action<bool> refresh);

    public CloudProjectSettings();

}

}
