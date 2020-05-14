using System;

namespace GeneratedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run the various scenarios
            Console.WriteLine("Running HelloWorld:");
            UseHelloWorldGenerator.Run();

            Console.WriteLine("Running AutoNotify:");
            UseAutoNotifyGenerator.Run();

            Console.WriteLine("Running XmlSettings:");
            UseXmlSettingsGenerator.Run();
        }
    }
}
