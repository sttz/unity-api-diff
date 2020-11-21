using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Analytics
{

public static class Analytics
{
    static public string configUrl { get; }
    static public bool deviceStatsEnabled { get; set; }
    static public bool enabled { get; set; }
    static public string eventUrl { get; }
    static public bool initializeOnStartup { get; set; }
    static public bool limitUserTracking { get; set; }
    static public bool playerOptedOut { get; }

    static public Analytics.AnalyticsResult CustomEvent(string customEventName);
    static public Analytics.AnalyticsResult CustomEvent(string customEventName, IDictionary<string, object> eventData);
    static public Analytics.AnalyticsResult CustomEvent(string customEventName, Vector3 position);
    static public Analytics.AnalyticsResult EnableCustomEvent(string customEventName, bool enabled);
    static public Analytics.AnalyticsResult EnableEvent(string eventName, bool enabled, int ver = 1, string prefix = "");
    static public Analytics.AnalyticsResult FlushEvents();
    static public Analytics.AnalyticsResult IsCustomEventEnabled(string customEventName);
    static public Analytics.AnalyticsResult IsEventEnabled(string eventName, int ver = 1, string prefix = "");
    static public Analytics.AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey = "", string prefix = "");
    static public Analytics.AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix = "");
    static public Analytics.AnalyticsResult ResumeInitialization();
    static public Analytics.AnalyticsResult SendEvent(string eventName, object parameters, int ver = 1, string prefix = "");
    static public Analytics.AnalyticsResult SetEventEndPoint(string eventName, string endPoint, int ver = 1, string prefix = "");
    static public Analytics.AnalyticsResult SetEventPriority(string eventName, Analytics.AnalyticsEventPriority eventPriority, int ver = 1, string prefix = "");
    static public Analytics.AnalyticsResult SetUserBirthYear(int birthYear);
    static public Analytics.AnalyticsResult SetUserGender(Analytics.Gender gender);
    static public Analytics.AnalyticsResult SetUserId(string userId);
    static public Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency);
    static public Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
    static public Analytics.AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService);

}

}
