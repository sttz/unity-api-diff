using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Assertions.Must
{

public static class MustExtensions
{
    static public void MustBeApproximatelyEqual(float actual, float expected);
    static public void MustBeApproximatelyEqual(float actual, float expected, string message);
    static public void MustBeApproximatelyEqual(float actual, float expected, float tolerance);
    static public void MustBeApproximatelyEqual(float actual, float expected, float tolerance, string message);
    static public void MustBeEqual<T>(T actual, T expected);
    static public void MustBeEqual<T>(T actual, T expected, string message);
    static public void MustBeFalse(bool value);
    static public void MustBeFalse(bool value, string message);
    static public void MustBeNull<T>(T expected);
    static public void MustBeNull<T>(T expected, string message);
    static public void MustBeTrue(bool value);
    static public void MustBeTrue(bool value, string message);
    static public void MustNotBeApproximatelyEqual(float actual, float expected);
    static public void MustNotBeApproximatelyEqual(float actual, float expected, string message);
    static public void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance);
    static public void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance, string message);
    static public void MustNotBeEqual<T>(T actual, T expected);
    static public void MustNotBeEqual<T>(T actual, T expected, string message);
    static public void MustNotBeNull<T>(T expected);
    static public void MustNotBeNull<T>(T expected, string message);

}

}
