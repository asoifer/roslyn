// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class CovariantReturnTests : EmitMetadataTestBase
{
private static MetadataReference _corelibraryWithCovariantReturnSupport;

private static MetadataReference CorelibraryWithCovariantReturnSupport
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23099,742,1055);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,778,974) || true) && (_corelibraryWithCovariantReturnSupport == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23099,778,974);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,870,955);

_corelibraryWithCovariantReturnSupport = f_23099_911_954();
DynAbs.Tracing.TraceSender.TraceExitCondition(23099,778,974);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,994,1040);

return _corelibraryWithCovariantReturnSupport;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23099,742,1055);

Microsoft.CodeAnalysis.MetadataReference
f_23099_911_954()
{
var return_v = MakeCorelibraryWithCovariantReturnSupport();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 911, 954);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,647,1066);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,647,1066);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static MetadataReference MakeCorelibraryWithCovariantReturnSupport()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23099,1078,8248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,1179,7369);

const string 
corLibraryCore = @"
namespace System
{
    public class Array
    {
        public static T[] Empty<T>() => throw null;
    }
    public class Console
    {
        public static void WriteLine(string message) => throw null;
    }
    public class Attribute { }
    [Flags]
    public enum AttributeTargets
    {
        Assembly = 0x1,
        Module = 0x2,
        Class = 0x4,
        Struct = 0x8,
        Enum = 0x10,
        Constructor = 0x20,
        Method = 0x40,
        Property = 0x80,
        Field = 0x100,
        Event = 0x200,
        Interface = 0x400,
        Parameter = 0x800,
        Delegate = 0x1000,
        ReturnValue = 0x2000,
        GenericParameter = 0x4000,
        All = 0x7FFF
    }
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public sealed class AttributeUsageAttribute : Attribute
    {
        public AttributeUsageAttribute(AttributeTargets validOn) { }
        public bool AllowMultiple
        {
            get => throw null;
            set { }
        }
        public bool Inherited
        {
            get => throw null;
            set { }
        }
        public AttributeTargets ValidOn => throw null;
    }
    public struct Boolean { }
    public struct Byte { }
    public class Delegate
    {
        public static Delegate CreateDelegate(Type type, object firstArgument, Reflection.MethodInfo method) => null;
    }
    public abstract class Enum : IComparable { }
    public class Exception
    {
        public Exception(string message) => throw null;
    }
    public class FlagsAttribute : Attribute { }
    public delegate T Func<out T>();
    public delegate U Func<in T, out U>(T arg);
    public interface IComparable { }
    public interface IDisposable
    {
        void Dispose();
    }
    public struct Int16 { }
    public struct Int32 { }
    public struct IntPtr { }
    public class MulticastDelegate : Delegate { }
    public struct Nullable<T> { }
    public class Object
    {
        public virtual string ToString() => throw null;
        public virtual int GetHashCode() => throw null;
        public virtual bool Equals(object other) => throw null;
    }
    public sealed class ParamArrayAttribute : Attribute { }
    public struct RuntimeMethodHandle { }
    public struct RuntimeTypeHandle { }
    public class String : IComparable { 
        public static String Empty = null;
        public override string ToString() => throw null;
        public static bool operator ==(string a, string b) => throw null;
        public static bool operator !=(string a, string b) => throw null;
        public override bool Equals(object other) => throw null;
        public override int GetHashCode() => throw null;
    }
    public class Type
    {
        public Reflection.FieldInfo GetField(string name) => null;
        public static Type GetType(string name) => null;
        public static Type GetTypeFromHandle(RuntimeTypeHandle handle) => null;
    }
    public class ValueType { }
    public struct Void { }

    namespace Collections
    {
        public interface IEnumerable
        {
            IEnumerator GetEnumerator();
        }
        public interface IEnumerator
        {
            object Current
            {
                get;
            }
            bool MoveNext();
            void Reset();
        }
    }
    namespace Collections.Generic
    {
        public interface IEnumerable<out T> : IEnumerable
        {
            new IEnumerator<T> GetEnumerator();
        }
        public interface IEnumerator<out T> : IEnumerator, IDisposable
        {
            new T Current
            {
                get;
            }
        }
    }
    namespace Linq.Expressions
    {
        public class Expression
        {
            public static ParameterExpression Parameter(Type type) => throw null;
            public static ParameterExpression Parameter(Type type, string name) => throw null;
            public static MethodCallExpression Call(Expression instance, Reflection.MethodInfo method, params Expression[] arguments) => throw null;
            public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters) => throw null;
            public static MemberExpression Property(Expression expression, Reflection.MethodInfo propertyAccessor) => throw null;
            public static ConstantExpression Constant(object value, Type type) => throw null;
            public static UnaryExpression Convert(Expression expression, Type type) => throw null;
        }
        public class ParameterExpression : Expression { }
        public class MethodCallExpression : Expression { }
        public abstract class LambdaExpression : Expression { }
        public class Expression<T> : LambdaExpression { }
        public class MemberExpression : Expression { }
        public class ConstantExpression : Expression { }
        public sealed class UnaryExpression : Expression { }
    }
    namespace Reflection
    {
        public class AssemblyVersionAttribute : Attribute
        {
            public AssemblyVersionAttribute(string version) { }
        }
        public class DefaultMemberAttribute : Attribute
        {
            public DefaultMemberAttribute(string name) { }
        }
        public abstract class MemberInfo { }
        public abstract class MethodBase : MemberInfo
        {
            public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) => throw null;
        }
        public abstract class MethodInfo : MethodBase
        {
            public virtual Delegate CreateDelegate(Type delegateType, object target) => throw null;
        }
        public abstract class FieldInfo : MemberInfo
        {
            public abstract object GetValue(object obj);
        }
    }
    namespace Runtime.CompilerServices
    {
        public static class RuntimeHelpers
        {
            public static object GetObjectValue(object obj) => null;
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,7383,7825);

const string 
corlibWithCovariantSupport = corLibraryCore + @"
namespace System.Runtime.CompilerServices
{
    public static class RuntimeFeature
    {
        public const string CovariantReturnsOfClasses = nameof(CovariantReturnsOfClasses);
        public const string DefaultImplementationsOfInterfaces = nameof(DefaultImplementationsOfInterfaces);
    }
    public sealed class PreserveBaseOverridesAttribute : Attribute { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,7839,8061);

var 
compilation = f_23099_7857_8060(new string[] {
                corlibWithCovariantSupport,
                @"[assembly: System.Reflection.AssemblyVersion(""4.0.0.0"")]"
            }, assemblyName: "mscorlib")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,8075,8107);

f_23099_8075_8106(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,8121,8237);

return f_23099_8128_8236(compilation, options: f_23099_8170_8235(runtimeMetadataVersion: "v5.1"));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23099,1078,8248);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_7857_8060(string[]
source,string
assemblyName)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 7857, 8060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_8075_8106(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 8075, 8106);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23099_8170_8235(string
runtimeMetadataVersion)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions( runtimeMetadataVersion:runtimeMetadataVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 8170, 8235);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_8128_8236(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = comp.EmitToImageReference( options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 8128, 8236);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,1078,8248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,1078,8248);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static CSharpCompilation CreateCovariantCompilation(
            string source,
            CSharpCompilationOptions options = null,
            IEnumerable<MetadataReference> references = null,
            string assemblyName = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23099,8260,9054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,8531,8585);

f_23099_8531_8584(f_23099_8546_8583());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,8599,8787);

references = (DynAbs.Tracing.TraceSender.Conditional_F1(23099, 8612, 8632)||(((references == null) &&DynAbs.Tracing.TraceSender.Conditional_F2(23099, 8652, 8699))||DynAbs.Tracing.TraceSender.Conditional_F3(23099, 8719, 8786)))?                new[] { f_23099_8660_8697()} :f_23099_8719_8786(f_23099_8719_8739(                references), f_23099_8748_8785());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,8801,9043);

return f_23099_8808_9042(source, options: options, parseOptions: TestOptions.WithCovariantReturns, references: references, assemblyName: assemblyName);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23099,8260,9054);

Microsoft.CodeAnalysis.MetadataReference
f_23099_8546_8583()
{
var return_v = CorelibraryWithCovariantReturnSupport;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23099, 8546, 8583);
return return_v;
}


int
f_23099_8531_8584(Microsoft.CodeAnalysis.MetadataReference
@object)
{
Assert.NotNull( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 8531, 8584);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_8660_8697()
{
var return_v = CorelibraryWithCovariantReturnSupport ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23099, 8660, 8697);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference[]
f_23099_8719_8739(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
source)
{
var return_v = source.ToArray<Microsoft.CodeAnalysis.MetadataReference>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 8719, 8739);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_8748_8785()
{
var return_v = CorelibraryWithCovariantReturnSupport;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23099, 8748, 8785);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
f_23099_8719_8786(Microsoft.CodeAnalysis.MetadataReference[]
source,Microsoft.CodeAnalysis.MetadataReference
element)
{
var return_v = source.Prepend<Microsoft.CodeAnalysis.MetadataReference>( element);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 8719, 8786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_8808_9042(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?
options,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
references,string?
assemblyName)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, parseOptions:parseOptions, references:references, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 8808, 9042);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,8260,9054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,8260,9054);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[ConditionalFact(typeof(CovariantReturnRuntimeOnly))]
        public void SimpleCovariantReturnEndToEndTest()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23099,9066,9952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,9201,9631);

var 
source = @"
using System;
class Base
{
    public virtual object M() => ""Base.M"";
}
class Derived : Base
{
    public override string M() => ""Derived.M"";
}
class Program
{
    static void Main()
    {
        Derived d = new Derived();
        Base b = d;
        string s = d.M();
        object o = b.M();
        Console.WriteLine(s.ToString());
        Console.WriteLine(o.ToString());
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,9645,9729);

var 
compilation = f_23099_9663_9728(source, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,9743,9775);

f_23099_9743_9774(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,9789,9835);

var 
expectedOutput =
@"Derived.M
Derived.M"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,9849,9941);

f_23099_9849_9940(this, compilation, expectedOutput: expectedOutput, verify: Verification.Skipped);
DynAbs.Tracing.TraceSender.TraceExitMethod(23099,9066,9952);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_9663_9728(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCovariantCompilation( source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 9663, 9728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_9743_9774(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 9743, 9774);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23099_9849_9940(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.CovariantReturnTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 9849, 9940);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,9066,9952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,9066,9952);
}
		}

[ConditionalFact(typeof(CovariantReturnRuntimeOnly))]
        public void CovariantRuntimeHasRequiredMembers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23099,9964,11131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,10100,10831);

var 
source = @"
using System;
class Base
{
    public virtual object M() => ""Base.M"";
}
class Derived : Base
{
    public override string M() => ""Derived.M"";
}
class Program
{
    static void Main()
    {
        var value = (string)Type.GetType(""System.Runtime.CompilerServices.RuntimeFeature"").GetField(""CovariantReturnsOfClasses"").GetValue(null);
        if (value != ""CovariantReturnsOfClasses"")
            throw new Exception(value.ToString());

        var attr = Type.GetType(""System.Runtime.CompilerServices.PreserveBaseOverridesAttribute"");
        if (attr == null)
            throw new Exception(""missing System.Runtime.CompilerServices.PreserveBaseOverridesAttribute"");
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,10845,10929);

var 
compilation = f_23099_10863_10928(source, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,10943,10975);

f_23099_10943_10974(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,10989,11014);

var 
expectedOutput = @""
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,11028,11120);

f_23099_11028_11119(this, compilation, expectedOutput: expectedOutput, verify: Verification.Skipped);
DynAbs.Tracing.TraceSender.TraceExitMethod(23099,9964,11131);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_10863_10928(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCovariantCompilation( source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 10863, 10928);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_10943_10974(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 10943, 10974);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23099_11028_11119(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.CovariantReturnTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 11028, 11119);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,9964,11131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,9964,11131);
}
		}

[Fact]
        public void VbOverrideOfCSharpCovariantReturn_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23099,11143,14240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,11234,11583);

var 
cSharpSource = @"
public class Base
{
    public virtual object M() => null;
    public virtual object P => null;
    public virtual object this[int i] => null;
}
public abstract class Derived : Base
{
    public override string M() => null;
    public override string P => null;
    public override string this[int i] => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,11597,11682);

var 
csharpCompilation = f_23099_11621_11681(f_23099_11621_11661(cSharpSource))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,11696,11759);

var 
csharpReference = f_23099_11718_11758(csharpCompilation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,11775,12217);

var 
vbSource = @"
Public Class Derived2 : Inherits Derived
    Public Overrides Function M() As Object
        Return Nothing
    End Function
    Public Overrides ReadOnly Property P As Object
        Get
            Return Nothing
        End Get
    End Property
    Public Overrides Default ReadOnly Property Item(i As Integer) As Object
        Get
            Return Nothing
        End Get
    End Property
End Class
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,12231,12449);

var 
ERR_InvalidOverrideDueToReturn2 =
f_23099_12286_12448(f_23099_12286_12433(f_23099_12286_12389(f_23099_12286_12337(typeof(VisualBasic.VisualBasicCompilation)), "Microsoft.CodeAnalysis.VisualBasic.ERRID"), "ERR_InvalidOverrideDueToReturn2"), null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,12463,14229);

f_23099_12463_14228(f_23099_12463_12589(this, vbSource, referencedAssemblies: new[] { f_23099_12532_12569(), csharpReference }), f_23099_12897_13077(f_23099_12897_13057(f_23099_12897_12945(ERR_InvalidOverrideDueToReturn2, "M"), "Public Overrides Function M() As Object", "Public Overridable Overloads Function M() As String"), 3, 31), f_23099_13379_13573(f_23099_13379_13553(f_23099_13379_13427(ERR_InvalidOverrideDueToReturn2, "P"), "Public Overrides ReadOnly Property P As Object", "Public Overridable Overloads ReadOnly Property P As String"), 6, 40), f_23099_13961_14209(f_23099_13961_14188(f_23099_13961_14012(ERR_InvalidOverrideDueToReturn2, "Item"), "Public Overrides ReadOnly Default Property Item(i As Integer) As Object", "Public Overridable Overloads ReadOnly Default Property Item(i As Integer) As String"), 11, 48));
DynAbs.Tracing.TraceSender.TraceExitMethod(23099,11143,14240);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_11621_11661(string
source)
{
var return_v = CreateCovariantCompilation( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 11621, 11661);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_11621_11681(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 11621, 11681);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_11718_11758(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 11718, 11758);
return return_v;
}


System.Reflection.Assembly
f_23099_12286_12337(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23099, 12286, 12337);
return return_v;
}


System.Type?
f_23099_12286_12389(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetType( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12286, 12389);
return return_v;
}


System.Reflection.FieldInfo?
f_23099_12286_12433(System.Type?
this_param,string
name)
{
var return_v = this_param.GetField( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12286, 12433);
return return_v;
}


object?
f_23099_12286_12448(System.Reflection.FieldInfo?
this_param,object?
obj)
{
var return_v = this_param.GetValue( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12286, 12448);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_12532_12569()
{
var return_v = CorelibraryWithCovariantReturnSupport;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23099, 12532, 12569);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
f_23099_12463_12589(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.CovariantReturnTests
this_param,string
code,Microsoft.CodeAnalysis.MetadataReference[]
referencedAssemblies)
{
var return_v = this_param.CreateVisualBasicCompilation( code, referencedAssemblies:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)referencedAssemblies);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12463, 12589);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_12897_12945(object?
code,string
squiggledText)
{
var return_v = Diagnostic( code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12897, 12945);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_12897_13057(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12897, 13057);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_12897_13077(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12897, 13077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_13379_13427(object?
code,string
squiggledText)
{
var return_v = Diagnostic( code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 13379, 13427);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_13379_13553(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 13379, 13553);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_13379_13573(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 13379, 13573);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_13961_14012(object?
code,string
squiggledText)
{
var return_v = Diagnostic( code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 13961, 14012);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_13961_14188(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 13961, 14188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23099_13961_14209(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 13961, 14209);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
f_23099_12463_14228(Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 12463, 14228);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,11143,14240);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,11143,14240);
}
		}

[Fact]
        public void VbOverrideOfCSharpCovariantReturn_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23099,14252,18423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,14343,14737);

var 
cSharpSource = @"
public class Base
{
    public virtual object M() => ""Base.M"";
    public virtual object P => ""Base.P"";
    public virtual object this[int i] => ""Base[]"";
}
public abstract class Derived : Base
{
    public override string M() => ""Derived.M"";
    public override string P => ""Derived.P"";
    public override string this[int i] => ""Derived[]"";
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,14751,14836);

var 
csharpCompilation = f_23099_14775_14835(f_23099_14775_14815(cSharpSource))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,14850,14913);

var 
csharpReference = f_23099_14872_14912(csharpCompilation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,14929,15923);

var 
vbSource = @"
Imports System
Public Class Derived2 : Inherits Derived
    Public Overrides Function M() As String
        Return ""Derived2.M""
    End Function
    Public Overrides ReadOnly Property P As String
        Get
            Return ""Derived2.P""
        End Get
    End Property
    Public Overrides Default ReadOnly Property Item(i As Integer) As String
        Get
            Return ""Derived2[]""
        End Get
    End Property
    Public Shared Sub Test(b As Base, d As Derived, d2 As Derived2)
        Console.WriteLine(b.M().ToString())
        Console.WriteLine(b.P.ToString())
        Console.WriteLine(b(0).ToString())
        Console.WriteLine(d.M())
        Console.WriteLine(d.P)
        Console.WriteLine(d(0))
        Console.WriteLine(d2.M())
        Console.WriteLine(d2.P)
        Console.WriteLine(d2(0))
    End Sub
    public Shared Sub Main()
        Dim d2 = new Derived2
        Test(d2, d2, d2)
    End Sub
End Class
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,15937,16088);

var 
compilationOptions = f_23099_15962_16087(f_23099_15962_16038(OutputKind.ConsoleApplication), OptimizationLevel.Release)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,16102,16345);

var 
vbCompilation = f_23099_16122_16344(f_23099_16122_16288(this, vbSource, compilationOptions: compilationOptions, referencedAssemblies: new[] { f_23099_16231_16268(), csharpReference }))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,16361,16568);

var 
expectedOutput = (DynAbs.Tracing.TraceSender.Conditional_F1(23099, 16382, 16446)||((f_23099_16382_16446_M(!ExecutionConditionUtil.RuntimeSupportsCovariantReturnsOfClasses)&&DynAbs.Tracing.TraceSender.Conditional_F2(23099, 16449, 16453))||DynAbs.Tracing.TraceSender.Conditional_F3(23099, 16456, 16567)))?null :@"
Derived2.M
Derived2.P
Derived2[]
Derived2.M
Derived2.P
Derived2[]
Derived2.M
Derived2.P
Derived2[]"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,16582,18412);

f_23099_16582_18411(f_23099_16582_16675(this, vbCompilation, verify: Verification.Skipped, expectedOutput: expectedOutput), "Derived2.Test", @"
{
  // Code size      118 (0x76)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  callvirt   ""Function Base.M() As Object""
  IL_0006:  callvirt   ""Function Object.ToString() As String""
  IL_000b:  call       ""Sub System.Console.WriteLine(String)""
  IL_0010:  ldarg.0
  IL_0011:  callvirt   ""Function Base.get_P() As Object""
  IL_0016:  callvirt   ""Function Object.ToString() As String""
  IL_001b:  call       ""Sub System.Console.WriteLine(String)""
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4.0
  IL_0022:  callvirt   ""Function Base.get_Item(Integer) As Object""
  IL_0027:  callvirt   ""Function Object.ToString() As String""
  IL_002c:  call       ""Sub System.Console.WriteLine(String)""
  IL_0031:  ldarg.1
  IL_0032:  callvirt   ""Function Derived.M() As String""
  IL_0037:  call       ""Sub System.Console.WriteLine(String)""
  IL_003c:  ldarg.1
  IL_003d:  callvirt   ""Function Derived.get_P() As String""
  IL_0042:  call       ""Sub System.Console.WriteLine(String)""
  IL_0047:  ldarg.1
  IL_0048:  ldc.i4.0
  IL_0049:  callvirt   ""Function Derived.get_Item(Integer) As String""
  IL_004e:  call       ""Sub System.Console.WriteLine(String)""
  IL_0053:  ldarg.2
  IL_0054:  callvirt   ""Function Derived2.M() As String""
  IL_0059:  call       ""Sub System.Console.WriteLine(String)""
  IL_005e:  ldarg.2
  IL_005f:  callvirt   ""Function Derived2.get_P() As String""
  IL_0064:  call       ""Sub System.Console.WriteLine(String)""
  IL_0069:  ldarg.2
  IL_006a:  ldc.i4.0
  IL_006b:  callvirt   ""Function Derived2.get_Item(Integer) As String""
  IL_0070:  call       ""Sub System.Console.WriteLine(String)""
  IL_0075:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23099,14252,18423);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_14775_14815(string
source)
{
var return_v = CreateCovariantCompilation( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 14775, 14815);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_14775_14835(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 14775, 14835);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_14872_14912(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 14872, 14912);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
f_23099_15962_16038(Microsoft.CodeAnalysis.OutputKind
outputKind)
{
var return_v = new Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions( outputKind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 15962, 16038);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
f_23099_15962_16087(Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
this_param,Microsoft.CodeAnalysis.OptimizationLevel
value)
{
var return_v = this_param.WithOptimizationLevel( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 15962, 16087);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_16231_16268()
{
var return_v = CorelibraryWithCovariantReturnSupport;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23099, 16231, 16268);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
f_23099_16122_16288(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.CovariantReturnTests
this_param,string
code,Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
compilationOptions,Microsoft.CodeAnalysis.MetadataReference[]
referencedAssemblies)
{
var return_v = this_param.CreateVisualBasicCompilation( code, compilationOptions:compilationOptions, referencedAssemblies:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)referencedAssemblies);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 16122, 16288);
return return_v;
}


Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
f_23099_16122_16344(Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 16122, 16344);
return return_v;
}


bool
f_23099_16382_16446_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23099, 16382, 16446);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23099_16582_16675(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.CovariantReturnTests
this_param,Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,string?
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 16582, 16675);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23099_16582_18411(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 16582, 18411);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,14252,18423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,14252,18423);
}
		}

[ConditionalFact(typeof(CovariantReturnRuntimeOnly))]
        public void CheckPreserveBaseOverride_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23099,18435,20430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,18565,18651);

var 
s0 = @"
public class Base
{
    public virtual object M() => ""Base.M"";
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,18665,18811);

var 
ref0 = f_23099_18676_18810(f_23099_18676_18787(f_23099_18676_18763(s0, assemblyName: "ref0")))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,18827,18874);

var 
s1a = @"
public class Mid : Base
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,18888,19081);

var 
ref1a = f_23099_18900_19080(f_23099_18900_19057(f_23099_18900_19033(s1a, references: new[] { ref0 }, assemblyName: "ref1")))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,19097,19190);

var 
s1b = @"
public class Mid : Base
{
    public override string M() => ""Mid.M"";
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,19204,19397);

var 
ref1b = f_23099_19216_19396(f_23099_19216_19373(f_23099_19216_19349(s1b, references: new[] { ref0 }, assemblyName: "ref1")))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,19413,19512);

var 
s2 = @"
public class Derived : Mid
{
    public override string M() => ""Derived.M"";
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,19526,19724);

var 
ref2 = f_23099_19537_19723(f_23099_19537_19700(f_23099_19537_19676(s2, references: new[] { ref0, ref1a }, assemblyName: "ref2")))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,19740,20056);

var 
program = @"
using System;
public class Program
{
    static void Main()
    {
        Derived d = new Derived();
        Mid m = d;
        Base b = m;
        Console.WriteLine(b.M().ToString());
        Console.WriteLine(m.M().ToString());
        Console.WriteLine(d.M().ToString());
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,20070,20196);

var 
compilation = f_23099_20088_20195(program, options: TestOptions.DebugExe, references: new[] { ref0, ref1b, ref2 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,20210,20242);

f_23099_20210_20241(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,20256,20313);

var 
expectedOutput =
@"Derived.M
Derived.M
Derived.M"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,20327,20419);

f_23099_20327_20418(this, compilation, expectedOutput: expectedOutput, verify: Verification.Skipped);
DynAbs.Tracing.TraceSender.TraceExitMethod(23099,18435,20430);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_18676_18763(string
source,string
assemblyName)
{
var return_v = CreateCovariantCompilation( source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 18676, 18763);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_18676_18787(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 18676, 18787);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_18676_18810(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 18676, 18810);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_18900_19033(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
assemblyName)
{
var return_v = CreateCovariantCompilation( source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 18900, 19033);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_18900_19057(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 18900, 19057);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_18900_19080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 18900, 19080);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_19216_19349(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
assemblyName)
{
var return_v = CreateCovariantCompilation( source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 19216, 19349);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_19216_19373(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 19216, 19373);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_19216_19396(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 19216, 19396);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_19537_19676(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
assemblyName)
{
var return_v = CreateCovariantCompilation( source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 19537, 19676);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_19537_19700(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 19537, 19700);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23099_19537_19723(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 19537, 19723);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_20088_20195(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCovariantCompilation( source, options:options, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 20088, 20195);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23099_20210_20241(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 20210, 20241);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23099_20327_20418(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.CovariantReturnTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23099, 20327, 20418);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23099,18435,20430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,18435,20430);
}
		}

public CovariantReturnTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23099,492,20437);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23099,492,20437);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,492,20437);
}


static CovariantReturnTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23099,492,20437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23099,598,636);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23099,492,20437);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23099,492,20437);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23099,492,20437);
}
}
