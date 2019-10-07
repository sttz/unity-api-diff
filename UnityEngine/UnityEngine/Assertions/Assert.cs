using System;
using UnityEngine;

namespace UnityEngine.Assertions
{

public static class Assert
{
    static public bool raiseExceptions;

    static public void AreApproximatelyEqual(float expected, float actual);
    static public void AreApproximatelyEqual(float expected, float actual, string message);
    static public void AreApproximatelyEqual(float expected, float actual, float tolerance);
    static public void AreApproximatelyEqual(float expected, float actual, float tolerance, string message);
    static public void AreEqual(T expected, T actual);
    static public void AreEqual(T expected, T actual, string message);
    static public void AreEqual(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
    static public void AreEqual(Object expected, Object actual, string message);
    static public void AreEqual(sbyte expected, sbyte actual);
    static public void AreEqual(sbyte expected, sbyte actual, string message);
    static public void AreEqual(byte expected, byte actual);
    static public void AreEqual(byte expected, byte actual, string message);
    static public void AreEqual(char expected, char actual);
    static public void AreEqual(char expected, char actual, string message);
    static public void AreEqual(short expected, short actual);
    static public void AreEqual(short expected, short actual, string message);
    static public void AreEqual(ushort expected, ushort actual);
    static public void AreEqual(ushort expected, ushort actual, string message);
    static public void AreEqual(int expected, int actual);
    static public void AreEqual(int expected, int actual, string message);
    static public void AreEqual(uint expected, uint actual);
    static public void AreEqual(uint expected, uint actual, string message);
    static public void AreEqual(long expected, long actual);
    static public void AreEqual(long expected, long actual, string message);
    static public void AreEqual(ulong expected, ulong actual);
    static public void AreEqual(ulong expected, ulong actual, string message);
    static public void AreNotApproximatelyEqual(float expected, float actual);
    static public void AreNotApproximatelyEqual(float expected, float actual, string message);
    static public void AreNotApproximatelyEqual(float expected, float actual, float tolerance);
    static public void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message);
    static public void AreNotEqual(T expected, T actual);
    static public void AreNotEqual(T expected, T actual, string message);
    static public void AreNotEqual(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
    static public void AreNotEqual(Object expected, Object actual, string message);
    static public void AreNotEqual(sbyte expected, sbyte actual);
    static public void AreNotEqual(sbyte expected, sbyte actual, string message);
    static public void AreNotEqual(byte expected, byte actual);
    static public void AreNotEqual(byte expected, byte actual, string message);
    static public void AreNotEqual(char expected, char actual);
    static public void AreNotEqual(char expected, char actual, string message);
    static public void AreNotEqual(short expected, short actual);
    static public void AreNotEqual(short expected, short actual, string message);
    static public void AreNotEqual(ushort expected, ushort actual);
    static public void AreNotEqual(ushort expected, ushort actual, string message);
    static public void AreNotEqual(int expected, int actual);
    static public void AreNotEqual(int expected, int actual, string message);
    static public void AreNotEqual(uint expected, uint actual);
    static public void AreNotEqual(uint expected, uint actual, string message);
    static public void AreNotEqual(long expected, long actual);
    static public void AreNotEqual(long expected, long actual, string message);
    static public void AreNotEqual(ulong expected, ulong actual);
    static public void AreNotEqual(ulong expected, ulong actual, string message);
    static public bool Equals(object obj1, object obj2);
    static public void IsFalse(bool condition);
    static public void IsFalse(bool condition, string message);
    static public void IsNotNull(T value);
    static public void IsNotNull(T value, string message);
    static public void IsNotNull(Object value, string message);
    static public void IsNull(T value);
    static public void IsNull(T value, string message);
    static public void IsNull(Object value, string message);
    static public void IsTrue(bool condition);
    static public void IsTrue(bool condition, string message);
    static public bool ReferenceEquals(object obj1, object obj2);

}

}
