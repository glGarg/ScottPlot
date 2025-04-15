using BenchmarkDotNet.Running;
using System.Reflection;

namespace ScottPlotBench;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run(Assembly.GetExecutingAssembly());
    }
}
