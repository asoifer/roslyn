// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public class FunctionPointerOperations : SemanticModelTestBase
    {
        private CSharpCompilation CreateFunctionPointerCompilation(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 526, 743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 624, 732);

                return f_22000_631_731(source, options: TestOptions.UnsafeReleaseDll, parseOptions: TestOptions.Regular9);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 526, 743);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 526, 743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 526, 743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Fact]
        public void FunctionPointerLoad()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 755, 1518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 829, 1030);

                var
                comp = f_22000_840_1029(this, @"
unsafe class C
{
    static void M1() => throw null;
    static void M2()
    {
        delegate*<void> ptr = /*<bind>*/&M1/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 1046, 1341);

                var
                expectedOperationTree = @"
IAddressOfOperation (OperationKind.AddressOf, Type: delegate*<System.Void>) (Syntax: '&M1')
  Reference: 
    IMethodReferenceOperation: void C.M1() (Static) (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
      Instance Receiver: 
        null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 1357, 1507);

                f_22000_1357_1506(comp, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[0]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 755, 1518);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 755, 1518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 755, 1518);
            }
        }

        [Fact]
        public void FunctionPointerLoad_WithThisReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 1530, 2766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 1622, 1809);

                var
                comp = f_22000_1633_1808(this, @"
unsafe class C
{
    void M1() => throw null;
    void M2()
    {
        delegate*<void> ptr = /*<bind>*/&M1/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 1825, 2217);

                var
                expectedOperationTree = @"
IAddressOfOperation (OperationKind.AddressOf, Type: null, IsInvalid) (Syntax: '&M1')
  Reference: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
      Children(1):
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 2233, 2619);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_2504_2603(f_22000_2504_2583(f_22000_2504_2559(ErrorCode.ERR_FuncPtrMethMustBeStatic, "M1"), "C.M1()"), 7, 42)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 2635, 2755);

                f_22000_2635_2754(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 1530, 2766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 1530, 2766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 1530, 2766);
            }
        }

        [Fact]
        public void FunctionPointerLoad_WithInstanceReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 2778, 3990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 2874, 3073);

                var
                comp = f_22000_2885_3072(this, @"
unsafe class C
{
    void M1() => throw null;
    static void M2(C c)
    {
        delegate*<void> ptr = /*<bind>*/&c.M1/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 3089, 3437);

                var
                expectedOperationTree = @"
IAddressOfOperation (OperationKind.AddressOf, Type: null, IsInvalid) (Syntax: '&c.M1')
  Reference: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'c.M1')
      Children(1):
          IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 3453, 3843);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_3726_3827(f_22000_3726_3807(f_22000_3726_3783(ErrorCode.ERR_FuncPtrMethMustBeStatic, "c.M1"), "C.M1()"), 7, 42)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 3859, 3979);

                f_22000_3859_3978(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 2778, 3990);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 2778, 3990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 2778, 3990);
            }
        }

        [Fact]
        public void FunctionPointerLoad_WithStaticReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 4002, 4925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 4096, 4331);

                var
                comp = f_22000_4107_4330(this, @"
static class Helper { public static void M1() => throw null; }
unsafe class C
{
    static void M2()
    {
        delegate*<void> ptr = /*<bind>*/&Helper.M1/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 4347, 4661);

                var
                expectedOperationTree = @"
IAddressOfOperation (OperationKind.AddressOf, Type: delegate*<System.Void>) (Syntax: '&Helper.M1')
  Reference: 
    IMethodReferenceOperation: void Helper.M1() (Static) (OperationKind.MethodReference, Type: null) (Syntax: 'Helper.M1')
      Instance Receiver: 
        null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 4677, 4748);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 4764, 4914);

                f_22000_4764_4913(comp, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[0]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 4002, 4925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 4002, 4925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 4002, 4925);
            }
        }

        [Fact]
        public void FunctionPointerLoad_NonExistantMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 4937, 5953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 5029, 5193);

                var
                comp = f_22000_5040_5192(this, @"
unsafe class C
{
    static void M2()
    {
        delegate*<void> ptr = /*<bind>*/&M1/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 5209, 5443);

                var
                expectedOperationTree = @"
IAddressOfOperation (OperationKind.AddressOf, Type: ?*, IsInvalid) (Syntax: '&M1')
  Reference: 
    IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'M1')
      Children(0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 5459, 5806);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_5702_5790(f_22000_5702_5770(f_22000_5702_5750(ErrorCode.ERR_NameNotInContext, "M1"), "M1"), 6, 42)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 5822, 5942);

                f_22000_5822_5941(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 4937, 5953);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 4937, 5953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 4937, 5953);
            }
        }

        [Fact]
        public void FunctionPointerLoad_InvalidMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 5965, 7166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 6053, 6250);

                var
                comp = f_22000_6064_6249(this, @"
unsafe class C
{
    static string M1() => null;
    static void M2()
    {
        delegate*<void> ptr = /*<bind>*/&M1/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 6266, 6658);

                var
                expectedOperationTree = @"
IAddressOfOperation (OperationKind.AddressOf, Type: null, IsInvalid) (Syntax: '&M1')
  Reference: 
    IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'M1')
      Children(1):
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 6674, 7019);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_6907_7003(f_22000_6907_6983(f_22000_6907_6949(ErrorCode.ERR_BadRetType, "M1"), "C.M1()", "string"), 7, 42)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 7035, 7155);

                f_22000_7035_7154(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 5965, 7166);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 5965, 7166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 5965, 7166);
            }
        }

        [Fact]
        public void FunctionPointerInvocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 7178, 8243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 7258, 7458);

                var
                comp = f_22000_7269_7457(this, @"
unsafe class C
{
    public string Prop { get; }
    void M(delegate*<string, void> ptr)
    {
        /*<bind>*/ptr(Prop)/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 7474, 8067);

                var
                expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: System.Void) (Syntax: 'ptr(Prop)')
  Children(2):
      IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.String, System.Void>) (Syntax: 'ptr')
      IPropertyReferenceOperation: System.String C.Prop { get; } (OperationKind.PropertyReference, Type: System.String) (Syntax: 'Prop')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'Prop')
            "
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 8083, 8232);

                f_22000_8083_8231(comp, expectedOperationTree, expectedDiagnostics: new DiagnosticDescription[0]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 7178, 8243);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 7178, 8243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 7178, 8243);
            }
        }

        [Fact]
        public void FunctionPointerInvocation_TooFewArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 8255, 9788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 8351, 8559);

                var
                comp = f_22000_8362_8558(this, @"
unsafe class C
{
    public string Prop { get; }
    void M(delegate*<string, string, void> ptr)
    {
        /*<bind>*/ptr(Prop)/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 8575, 9223);

                var
                expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'ptr(Prop)')
  Children(2):
      IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.String, System.String, System.Void>, IsInvalid) (Syntax: 'ptr')
      IPropertyReferenceOperation: System.String C.Prop { get; } (OperationKind.PropertyReference, Type: System.String, IsInvalid) (Syntax: 'Prop')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'Prop')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 9239, 9642);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_9491_9626(f_22000_9491_9606(f_22000_9491_9552(ErrorCode.ERR_BadFuncPointerArgCount, "ptr(Prop)"), "delegate*<string, string, void>", "1"), 7, 19)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 9658, 9777);

                f_22000_9658_9776(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 8255, 9788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 8255, 9788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 8255, 9788);
            }
        }

        [Fact]
        public void FunctionPointerInvocation_TooManyArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 9800, 11284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 9897, 10089);

                var
                comp = f_22000_9908_10088(this, @"
unsafe class C
{
    public string Prop { get; }
    void M(delegate*<void> ptr)
    {
        /*<bind>*/ptr(Prop)/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 10105, 10735);

                var
                expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'ptr(Prop)')
  Children(2):
      IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.Void>, IsInvalid) (Syntax: 'ptr')
      IPropertyReferenceOperation: System.String C.Prop { get; } (OperationKind.PropertyReference, Type: System.String, IsInvalid) (Syntax: 'Prop')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'Prop')
            "
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 10751, 11138);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_11003_11122(f_22000_11003_11102(f_22000_11003_11064(ErrorCode.ERR_BadFuncPointerArgCount, "ptr(Prop)"), "delegate*<void>", "1"), 7, 19)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 11154, 11273);

                f_22000_11154_11272(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 9800, 11284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 9800, 11284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 9800, 11284);
            }
        }

        [Fact]
        public void FunctionPointerInvocation_IncorrectParameterType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 11296, 12736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 11399, 11596);

                var
                comp = f_22000_11410_11595(this, @"
unsafe class C
{
    public string Prop { get; }
    void M(delegate*<int, void> ptr)
    {
        /*<bind>*/ptr(Prop)/*</bind>*/;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 11612, 12233);

                var
                expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'ptr(Prop)')
  Children(2):
      IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.Int32, System.Void>) (Syntax: 'ptr')
      IPropertyReferenceOperation: System.String C.Prop { get; } (OperationKind.PropertyReference, Type: System.String, IsInvalid) (Syntax: 'Prop')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'Prop')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 12249, 12590);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_12474_12574(f_22000_12474_12554(f_22000_12474_12518(ErrorCode.ERR_BadArgType, "Prop"), "1", "string", "int"), 7, 23)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 12606, 12725);

                f_22000_12606_12724(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 11296, 12736);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 11296, 12736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 11296, 12736);
            }
        }

        [Fact]
        public void FunctionPointerInvocation_IncorrectReturnUsage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 12748, 17146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 12849, 13083);

                var
                comp = f_22000_12860_13082(this, @"
unsafe class C
{
    public string Prop { get; }
    void M(delegate*<string, int> ptr)
    /*<bind>*/{
        string s = ptr(Prop);
        s = ptr(Prop);
    }/*</bind>*/
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 13099, 16408);

                var
                expectedOperationTree = @"
IBlockOperation (2 statements, 1 locals) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  Locals: Local_1: System.String s
  IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'string s = ptr(Prop);')
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'string s = ptr(Prop)')
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.String s) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 's = ptr(Prop)')
            Initializer: 
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= ptr(Prop)')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsInvalid, IsImplicit) (Syntax: 'ptr(Prop)')
                  Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    IOperation:  (OperationKind.None, Type: System.Int32, IsInvalid) (Syntax: 'ptr(Prop)')
                      Children(2):
                          IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.String, System.Int32>, IsInvalid) (Syntax: 'ptr')
                          IPropertyReferenceOperation: System.String C.Prop { get; } (OperationKind.PropertyReference, Type: System.String, IsInvalid) (Syntax: 'Prop')
                            Instance Receiver: 
                              IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'Prop')
      Initializer: 
        null
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 's = ptr(Prop);')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String, IsInvalid) (Syntax: 's = ptr(Prop)')
        Left: 
          ILocalReferenceOperation: s (OperationKind.LocalReference, Type: System.String) (Syntax: 's')
        Right: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, IsInvalid, IsImplicit) (Syntax: 'ptr(Prop)')
            Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IOperation:  (OperationKind.None, Type: System.Int32, IsInvalid) (Syntax: 'ptr(Prop)')
                Children(2):
                    IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.String, System.Int32>, IsInvalid) (Syntax: 'ptr')
                    IPropertyReferenceOperation: System.String C.Prop { get; } (OperationKind.PropertyReference, Type: System.String, IsInvalid) (Syntax: 'Prop')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'Prop')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 16424, 17015);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22000_16638_16742(f_22000_16638_16722(f_22000_16638_16691(ErrorCode.ERR_NoImplicitConv, "ptr(Prop)"), "int", "string"), 7, 20),
f_22000_16895_16999(f_22000_16895_16979(f_22000_16895_16948(ErrorCode.ERR_NoImplicitConv, "ptr(Prop)"), "int", "string"), 8, 13)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 17031, 17135);

                f_22000_17031_17134(comp, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 12748, 17146);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 12748, 17146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 12748, 17146);
            }
        }

        [Fact]
        public void FunctionPointerAddressOf_InCFG()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 17158, 20425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 17243, 17499);

                var
                comp = f_22000_17254_17498(this, @"
unsafe class C
{
    static void M1() {}
    static void M2() {}

    static void Test(delegate*<void> ptr, bool b)
    /*<bind>*/{
        ptr = b ? (delegate*<void>)&M1 : &M2;
    }/*</bind>*/
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 17515, 20293);

                var
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'ptr')
              Value: 
                IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.Void>) (Syntax: 'ptr')
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '(delegate*<void>)&M1')
              Value: 
                IAddressOfOperation (OperationKind.AddressOf, Type: delegate*<System.Void>) (Syntax: '(delegate*<void>)&M1')
                  Reference: 
                    IMethodReferenceOperation: void C.M1() (Static) (OperationKind.MethodReference, Type: null) (Syntax: 'M1')
                      Instance Receiver: 
                        null
        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '&M2')
              Value: 
                IAddressOfOperation (OperationKind.AddressOf, Type: delegate*<System.Void>) (Syntax: '&M2')
                  Reference: 
                    IMethodReferenceOperation: void C.M2() (Static) (OperationKind.MethodReference, Type: null) (Syntax: 'M2')
                      Instance Receiver: 
                        null
        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ptr = b ? ( ... )&M1 : &M2;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: delegate*<System.Void>) (Syntax: 'ptr = b ? ( ... >)&M1 : &M2')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: delegate*<System.Void>, IsImplicit) (Syntax: 'ptr')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: delegate*<System.Void>, IsImplicit) (Syntax: 'b ? (delega ... >)&M1 : &M2')
        Next (Regular) Block[B5]
            Leaving: {R1}
}
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 20309, 20414);

                f_22000_20309_20413(comp, expectedFlowGraph, new DiagnosticDescription[0]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 17158, 20425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 17158, 20425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 17158, 20425);
            }
        }

        [Fact]
        public void FunctionPointerInvocation_InCFG()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22000, 20437, 23169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 20523, 20789);

                var
                comp = f_22000_20534_20788(this, @"
unsafe class C
{
    static void M1() {}
    static void M2() {}

    static void Test(delegate*<string, void> ptr, bool b, string s1, string s2)
    /*<bind>*/{
        ptr(b ? s1 : s2);
    }/*</bind>*/
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 20805, 23037);

                var
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}
.locals {R1}
{
    CaptureIds: [0] [1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'ptr')
              Value: 
                IParameterReferenceOperation: ptr (OperationKind.ParameterReference, Type: delegate*<System.String, System.Void>) (Syntax: 'ptr')
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's1')
              Value: 
                IParameterReferenceOperation: s1 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's1')
        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 's2')
              Value: 
                IParameterReferenceOperation: s2 (OperationKind.ParameterReference, Type: System.String) (Syntax: 's2')
        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'ptr(b ? s1 : s2);')
              Expression: 
                IOperation:  (OperationKind.None, Type: System.Void) (Syntax: 'ptr(b ? s1 : s2)')
                  Children(2):
                      IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: delegate*<System.String, System.Void>, IsImplicit) (Syntax: 'ptr')
                      IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: System.String, IsImplicit) (Syntax: 'b ? s1 : s2')
        Next (Regular) Block[B5]
            Leaving: {R1}
}
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22000, 23053, 23158);

                f_22000_23053_23157(comp, expectedFlowGraph, new DiagnosticDescription[0]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22000, 20437, 23169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22000, 20437, 23169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 20437, 23169);
            }
        }

        public FunctionPointerOperations()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(22000, 447, 23176);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(22000, 447, 23176);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 447, 23176);
        }


        static FunctionPointerOperations()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(22000, 447, 23176);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(22000, 447, 23176);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22000, 447, 23176);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(22000, 447, 23176);

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_631_731(string
        source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 631, 731);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_840_1029(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 840, 1029);
            return return_v;
        }


        int
        f_22000_1357_1506(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics: expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 1357, 1506);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_1633_1808(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 1633, 1808);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_2504_2559(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 2504, 2559);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_2504_2583(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 2504, 2583);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_2504_2603(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 2504, 2603);
            return return_v;
        }


        int
        f_22000_2635_2754(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 2635, 2754);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_2885_3072(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 2885, 3072);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_3726_3783(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 3726, 3783);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_3726_3807(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 3726, 3807);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_3726_3827(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 3726, 3827);
            return return_v;
        }


        int
        f_22000_3859_3978(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 3859, 3978);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_4107_4330(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 4107, 4330);
            return return_v;
        }


        int
        f_22000_4764_4913(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics: expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 4764, 4913);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_5040_5192(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 5040, 5192);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_5702_5750(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 5702, 5750);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_5702_5770(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 5702, 5770);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_5702_5790(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 5702, 5790);
            return return_v;
        }


        int
        f_22000_5822_5941(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 5822, 5941);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_6064_6249(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 6064, 6249);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_6907_6949(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 6907, 6949);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_6907_6983(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 6907, 6983);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_6907_7003(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 6907, 7003);
            return return_v;
        }


        int
        f_22000_7035_7154(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<PrefixUnaryExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 7035, 7154);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_7269_7457(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 7269, 7457);
            return return_v;
        }


        int
        f_22000_8083_8231(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics: expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 8083, 8231);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_8362_8558(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 8362, 8558);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_9491_9552(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 9491, 9552);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_9491_9606(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 9491, 9606);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_9491_9626(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 9491, 9626);
            return return_v;
        }


        int
        f_22000_9658_9776(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 9658, 9776);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_9908_10088(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 9908, 10088);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_11003_11064(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 11003, 11064);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_11003_11102(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 11003, 11102);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_11003_11122(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 11003, 11122);
            return return_v;
        }


        int
        f_22000_11154_11272(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 11154, 11272);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_11410_11595(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 11410, 11595);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_12474_12518(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 12474, 12518);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_12474_12554(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 12474, 12554);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_12474_12574(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 12474, 12574);
            return return_v;
        }


        int
        f_22000_12606_12724(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 12606, 12724);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_12860_13082(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 12860, 13082);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_16638_16691(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 16638, 16691);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_16638_16722(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 16638, 16722);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_16638_16742(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 16638, 16742);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_16895_16948(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 16895, 16948);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_16895_16979(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 16895, 16979);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22000_16895_16999(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 16895, 16999);
            return return_v;
        }


        int
        f_22000_17031_17134(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>(compilation, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 17031, 17134);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_17254_17498(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 17254, 17498);
            return return_v;
        }


        int
        f_22000_20309_20413(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(compilation, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 20309, 20413);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22000_20534_20788(Microsoft.CodeAnalysis.CSharp.UnitTests.FunctionPointerOperations
        this_param, string
        source)
        {
            var return_v = this_param.CreateFunctionPointerCompilation(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 20534, 20788);
            return return_v;
        }


        int
        f_22000_23053_23157(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(compilation, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22000, 23053, 23157);
            return 0;
        }

    }
}
