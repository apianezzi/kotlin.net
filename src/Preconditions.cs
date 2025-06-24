namespace kotlin.net;

/// <summary>
/// Kotlin style preconditions: https://github.com/JetBrains/kotlin/blob/rrr/2.1.0/core-docs/libraries/stdlib/src/kotlin/util/Preconditions.kt
/// </summary>
public static class Preconditions
{
    public static void Require(bool value, string message = "Failed requirement.")
    {
        if (!value)
        {
            throw new ArgumentOutOfRangeException(message);
        }
    }

    public static T RequireNotNull<T>(T? value, string message = "Required value was null.")
    {
        if (value is null)
        {
            throw new ArgumentNullException(message);
        }

        return value;
    }

    public static void Check(bool value, string message = "Check failed.")
    {
        if (!value)
        {
            throw new InvalidOperationException(message);
        }
    }

    public static T CheckNotNull<T>(T? value, string message = "Required value was not null.")
    {
        if (value is null)
        {
            throw new InvalidOperationException(message);
        }

        return value;
    }

    public static void Error(string message) => throw new InvalidOperationException(message);
}