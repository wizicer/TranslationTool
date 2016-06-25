using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateText
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(@"UpdateText Usage:

    UpdateText source.md [translation.md]
");
                Environment.Exit(0);
            }

            string sourceFile = null;
            string translationFile = null;
            var source = string.Empty;
            var translation = string.Empty;

            if (args.Length >= 1)
            {
                sourceFile = args[0];
            }

            if (args.Length >= 2)
            {
                translationFile = args[1];
            }

            if (!File.Exists(sourceFile))
            {
                Console.WriteLine($"source file {sourceFile} not found");
                Environment.Exit(1);
            }

            source = File.ReadAllText(sourceFile);

            if (File.Exists(translationFile))
            {
                translation = File.ReadAllText(translationFile);
            }

            var newtranslation = Core.Update(source, translation);
            File.WriteAllText(translationFile, newtranslation);
        }
    }
}
