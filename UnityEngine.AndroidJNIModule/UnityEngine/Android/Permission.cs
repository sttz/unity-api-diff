using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Android
{

public struct Permission
{
    static public string Camera = "android.permission.CAMERA";
    static public string CoarseLocation = "android.permission.ACCESS_COARSE_LOCATION";
    static public string ExternalStorageRead = "android.permission.READ_EXTERNAL_STORAGE";
    static public string ExternalStorageWrite = "android.permission.WRITE_EXTERNAL_STORAGE";
    static public string FineLocation = "android.permission.ACCESS_FINE_LOCATION";
    static public string Microphone = "android.permission.RECORD_AUDIO";

    static public bool HasUserAuthorizedPermission(string permission);
    static public void RequestUserPermission(string permission);
    static public void RequestUserPermission(string permission, Android.PermissionCallbacks callbacks);
    static public void RequestUserPermissions(string[] permissions);
    static public void RequestUserPermissions(string[] permissions, Android.PermissionCallbacks callbacks);

}

}
