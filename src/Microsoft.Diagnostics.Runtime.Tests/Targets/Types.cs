using System;
using System.Threading.Tasks;

class Types
{
    static object s_one = new object();
    static object s_two = new object();
    static object s_three = new object();

    static object[] s_array = new object[] { s_one, s_two, s_three };

    static Foo s_foo = new Foo();

    static object s_i = 42;

    public static void Main(string[] args)
    {
        Foo f = new Foo();
        Foo[] foos = new Foo[] { f };

        Inner();

        GC.KeepAlive(foos);
    }

    private static void Inner()
    {
        throw new Exception();
    }

    private static async void GenericMethod<T, V>(string s, T t, int i, V v, double d)
    {
        await Task.Delay(500);
    }
}
