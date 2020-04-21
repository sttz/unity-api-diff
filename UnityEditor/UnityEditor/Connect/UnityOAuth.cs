using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Connect
{

public static class UnityOAuth
{
    static public event Action UserLoggedIn;
    static public event Action UserLoggedOut;

    static public void GetAuthorizationCodeAsync(string clientId, Action<AuthCodeResponse> callback);

    public struct AuthCodeResponse
    {
        public string AuthCode { get; set; }
        public Exception Exception { get; set; }

    }

}

}
