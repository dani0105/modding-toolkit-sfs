using System;

public class OptionalDelegate<T>
{
    public OptionalDelegate() { }

    public int CallCount { get; }
    public bool IsEmpty { get; }

    public void Clear() { }
    public void Invoke(T data) { }

    public static OptionalDelegate<T> operator +(OptionalDelegate<T> a, Action b) => null;
    public static OptionalDelegate<T> operator +(OptionalDelegate<T> a, Action<T> b) => null;
    public static OptionalDelegate<T> operator -(OptionalDelegate<T> a, Action b) => null;
    public static OptionalDelegate<T> operator -(OptionalDelegate<T> a, Action<T> b) => null;
}