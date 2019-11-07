using System;
using UnityEngine;

namespace UnityEditor.Experimental.Licensing
{

public static class LicensingUtility
{
    static public bool HasEntitlement(string entitlement);
    static public string[] HasEntitlements(string[] entitlements);

}

}
