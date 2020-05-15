//using System;
//using System.Collections.Generic;
//using System.Text;
//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.CSharp;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
//using Microsoft.CodeAnalysis.Text;

//namespace SourceGeneratorSamples
//{
//    [Generator]
//    public class ConsoleWritelineHighjack : ISourceGenerator
//    {
//        private string GetCodeForNamespace(string name) => $@"
//namespace {name}
//{{
//    internal static class Console
//    {{
//        private static int _counter = 0;

//        public static void WriteLine(string line) => System.Console.WriteLine($""{{_counter++:00}}:{{line}}"");
//    }}
//}}
//";

//        public void Execute(SourceGeneratorContext context)
//        {
//            SyntaxReceiver receiver = context.SyntaxReceiver as SyntaxReceiver;

//            foreach (string name in receiver.Namespaces)
//            {
//                string code = GetCodeForNamespace(name);
//                context.AddSource($"{name}.Console.Generated", SourceText.From(code, Encoding.UTF8));
//            }
//        }

//        public void Initialize(InitializationContext context)
//        {
//            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
//        }

//        class SyntaxReceiver : ISyntaxReceiver
//        {
//            public HashSet<string> Namespaces { get; } = new HashSet<string>();

//            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
//            {
//                if (syntaxNode is NamespaceDeclarationSyntax namespaceDeclarationSyntax)
//                {
//                    string namespaceName = namespaceDeclarationSyntax.Name.ToString();
//                    Namespaces.Add(namespaceName);
//                }
//            }
//        }
//    }
//}
