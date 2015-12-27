using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview.Cecil
{
    public class InjectClass
    {
        private const string ASSEMBLY_FILENAME = "ReviewCSharp.Test.dll";
        private const string TARGET_TYPENAME="ReviewCSharp.Test.Class1";
        private const string TARGET_METHODNAME = "Test";

        public static void InjectMethod()
        {
            Console.WriteLine("Haha, I'm from injector...");
        }

        static void Main(string[] args)
        {
            InjectDynamic();
            //InjectStatic();
            Console.ReadLine();
        }

        static void InjectDynamic()
        {
            AssemblyDefinition asm = AssemblyDefinition.ReadAssembly(ASSEMBLY_FILENAME);
            foreach (TypeDefinition type in asm.MainModule.Types)
            {
                if (type.FullName.Equals(TARGET_TYPENAME))
                {
                    foreach (MethodDefinition method in type.Methods)
                    {
                        if (method.Name.Equals(TARGET_METHODNAME))
                        {
                            Instruction instruction = method.Body.Instructions.First();
                            ILProcessor ilProcessor = method.Body.GetILProcessor();
                            MethodInfo methodInfo = typeof(InjectClass).GetMethod("InjectMethod", BindingFlags.Static | BindingFlags.Public);
                            MethodReference methodReference = asm.MainModule.ImportReference(methodInfo);
                            Instruction instructionCall = ilProcessor.Create(OpCodes.Call, methodReference);
                            ilProcessor.InsertBefore(instruction, instructionCall);
                            Instruction instructionNop = ilProcessor.Create(OpCodes.Nop);
                            ilProcessor.InsertAfter(instructionCall, instructionNop);
                        }
                    }
                }
            }

            asm.Write(ASSEMBLY_FILENAME);

            TestInjected();
        }       

        static void InjectStatic()
        {
            AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(ASSEMBLY_FILENAME);
            foreach (TypeDefinition type in assembly.MainModule.Types)
            {
                if (type.FullName.Equals(TARGET_TYPENAME))
                {
                    foreach (MethodDefinition method in type.Methods)
                    {
                        if (method.Name.Equals(TARGET_METHODNAME))
                        {

                            Instruction instruction = method.Body.Instructions.First();
                            ILProcessor ilProcessor = method.Body.GetILProcessor();
                            ilProcessor.InsertBefore(instruction, ilProcessor.Create(OpCodes.Ldstr, "Method start…"));
                            ilProcessor.InsertBefore(instruction, ilProcessor.Create(OpCodes.Call,
                                assembly.MainModule.ImportReference(typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }))));
                            instruction = method.Body.Instructions[method.Body.Instructions.Count - 1];

                            ilProcessor.InsertBefore(instruction, ilProcessor.Create(OpCodes.Ldstr, "Method finish…"));
                            ilProcessor.InsertBefore(instruction, ilProcessor.Create(OpCodes.Call,
                                assembly.MainModule.ImportReference(typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) }))));
                            break;
                        }
                    }
                }

            }

            assembly.Write(ASSEMBLY_FILENAME);

            TestInjected();
        }

        static void TestInjected()
        {
            Assembly assembly = Assembly.LoadFrom(ASSEMBLY_FILENAME);
            Type typeName = assembly.GetType(TARGET_TYPENAME);
            Object obj = Activator.CreateInstance(typeName);
            typeName.InvokeMember(TARGET_METHODNAME, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, obj, null);
        }

    }

}
