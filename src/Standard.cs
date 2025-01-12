using System;

namespace kotlin.net;

/// <summary>
/// Kotlin style helper and scope functions: https://github.com/JetBrains/kotlin/blob/rrr/2.1.0/core-docs/libraries/stdlib/src/kotlin/util/Standard.kt
/// </summary>
public static class Standard
{
    public static void TODO() => throw new NotImplementedException();

    public static void TODO(string reason) => throw new NotImplementedException(reason);
    
    public static TOut Run<TOut>(Func<TOut> func) => func();
    
    public static TOut Let<TIn, TOut>(this TIn receiver, Func<TIn, TOut> block) => block(receiver);

    public static TIn Also<TIn>(this TIn receiver, Action<TIn> block)
    {
        block(receiver);
        return receiver;
    }

    public static T? TakeIf<T>(this T receiver, Func<T, bool> predicate) => predicate(receiver) ? receiver : default;

    public static T? TakeUnless<T>(this T receiver, Func<T, bool> predicate) => !predicate(receiver) ? receiver : default;

    public static void Repeat(int times, Action action)
    {
        for (var i = 0; i < times; i++)
        {
            action();
        }
    }
}