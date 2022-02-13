// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void VariableDeclarator()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,657,1965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,849,981);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i1;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,995,1492);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,1506,1812);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_1709_1796(f_22075_1709_1776(f_22075_1709_1756(ErrorCode.WRN_UnreferencedVar, "i1"), "i1"), 6, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,1828,1954);

f_22075_1828_1953(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,657,1965);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,657,1965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,657,1965);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void VariableDeclaratorWithInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,1977,3530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,2184,2320);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i1 = 1;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,2334,3036);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i1 = 1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = 1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = 1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,3050,3377);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_3270_3361(f_22075_3270_3341(f_22075_3270_3321(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 6, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,3393,3519);

f_22075_3393_3518(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,1977,3530);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,1977,3530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,1977,3530);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void VariableDeclaratorWithInvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,3542,5122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,3756,3891);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i1 = ;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,3905,4665);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'int i1 = ;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1 = ')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = ')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= ')
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                Children(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,4679,4969);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_4868_4953(f_22075_4868_4933(f_22075_4868_4914(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,4985,5111);

f_22075_4985_5110(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,3542,5122);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,3542,5122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,3542,5122);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void MultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,5134,6869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,5328,5464);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i1, i2;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,5478,6152);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i1, i2;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1, i2')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1')
          Initializer: 
            null
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,6166,6716);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_6373_6460(f_22075_6373_6440(f_22075_6373_6420(ErrorCode.WRN_UnreferencedVar, "i1"), "i1"), 6, 23),
f_22075_6613_6700(f_22075_6613_6680(f_22075_6613_6660(ErrorCode.WRN_UnreferencedVar, "i2"), "i2"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,6732,6858);

f_22075_6732_6857(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,5134,6869);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,5134,6869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,5134,6869);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void MultipleDeclarationsWithInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,6881,9100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,7091,7235);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i1 = 2, i2 = 2;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,7249,8333);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i1 = 2, i2 = 2;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = 2, i2 = 2')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = 2')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2 = 2')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,8347,8947);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_8575_8666(f_22075_8575_8646(f_22075_8575_8626(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 6, 23),
f_22075_8840_8931(f_22075_8840_8911(f_22075_8840_8891(ErrorCode.WRN_UnreferencedVarAssg, "i2"), "i2"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,8963,9089);

f_22075_8963_9088(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,6881,9100);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,6881,9100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,6881,9100);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void MultipleDeclarationsWithInvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,9112,11356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,9328,9471);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i1 = , i2 = 2;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,9485,10627);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'int i1 = , i2 = 2;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1 = , i2 = 2')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = ')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= ')
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                Children(0)
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2 = 2')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,10641,11203);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_10838_10923(f_22075_10838_10903(f_22075_10838_10884(ErrorCode.ERR_InvalidExprTerm, ","), ","), 6, 28),
f_22075_11096_11187(f_22075_11096_11167(f_22075_11096_11147(ErrorCode.WRN_UnreferencedVarAssg, "i2"), "i2"), 6, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,11219,11345);

f_22075_11219_11344(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,9112,11356);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,9112,11356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,9112,11356);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void InvalidMultipleVariableDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,11368,13078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,11576,11708);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i,;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,11722,12415);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'int i,;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i,')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i')
          Initializer: 
            null
        IVariableDeclaratorOperation (Symbol: System.Int32 ) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,12429,12925);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_12607_12676(f_22075_12607_12656(ErrorCode.ERR_IdentifierExpected, ";"), 6, 25),
f_22075_12824_12909(f_22075_12824_12889(f_22075_12824_12870(ErrorCode.WRN_UnreferencedVar, "i"), "i"), 6, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,12941,13067);

f_22075_12941_13066(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,11368,13078);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,11368,13078);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,11368,13078);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void VariableDeclaratorExpressionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,13090,14561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,13303,13478);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i = GetInt();/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,13492,14341);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i = GetInt();')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = GetInt()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = GetInt()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetInt()')
              IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
                Instance Receiver: 
                  null
                Arguments(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,14355,14408);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,14424,14550);

f_22075_14424_14549(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,13090,14561);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,13090,14561);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,13090,14561);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void MultipleVariableDeclarationsExpressionInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,14573,16591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,14797,14986);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int i = GetInt(), j = GetInt();/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,15000,16371);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i = Get ... = GetInt();')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = Get ...  = GetInt()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = GetInt()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetInt()')
              IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
                Instance Receiver: 
                  null
                Arguments(0)
        IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = GetInt()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetInt()')
              IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
                Instance Receiver: 
                  null
                Arguments(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,16385,16438);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,16454,16580);

f_22075_16454_16579(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,14573,16591);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,14573,16591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,14573,16591);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void VariableDeclaratorLocalReferenceInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,16603,17883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,16754,16943);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        /*<bind>*/int i1 = i;/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,16957,17663);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i1 = i;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = i')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = i')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i')
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,17677,17730);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,17746,17872);

f_22075_17746_17871(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,16603,17883);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,16603,17883);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,16603,17883);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void MultipleDeclarationsLocalReferenceInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,17895,19579);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,18049,18247);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        /*<bind>*/int i1 = i, i2 = i1;/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,18261,19359);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'int i1 = i, i2 = i1;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = i, i2 = i1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = i')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i')
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2 = i1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i1')
              ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,19373,19426);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,19442,19568);

f_22075_19442_19567(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,17895,19579);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,17895,19579);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,17895,19579);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void InvalidArrayDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,19591,21455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,19722,19859);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int[2, 3] a;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,19873,20649);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'int[2, 3] a;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[2, 3] a')
    Ignored Dimensions(2):
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32[,] a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,20663,21302);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_20947_21025(f_22075_20947_21005(ErrorCode.ERR_ArraySizeInDeclaration, "[2, 3]"), 6, 22),
f_22075_21201_21286(f_22075_21201_21266(f_22075_21201_21247(ErrorCode.WRN_UnreferencedVar, "a"), "a"), 6, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,21318,21444);

f_22075_21318_21443(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,19591,21455);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,19591,21455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,19591,21455);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void InvalidArrayMultipleDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,21467,23788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,21606,21746);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/int[2, 3] a, b;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,21760,22712);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'int[2, 3] a, b;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[2, 3] a, b')
    Ignored Dimensions(2):
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2, IsInvalid) (Syntax: '2')
        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3, IsInvalid) (Syntax: '3')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32[,] a) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'a')
          Initializer: 
            null
        IVariableDeclaratorOperation (Symbol: System.Int32[,] b) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'b')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,22726,23635);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_23013_23091(f_22075_23013_23071(ErrorCode.ERR_ArraySizeInDeclaration, "[2, 3]"), 6, 22),
f_22075_23270_23355(f_22075_23270_23335(f_22075_23270_23316(ErrorCode.WRN_UnreferencedVar, "a"), "a"), 6, 29),
f_22075_23534_23619(f_22075_23534_23599(f_22075_23534_23580(ErrorCode.WRN_UnreferencedVar, "b"), "b"), 6, 32)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,23651,23777);

f_22075_23651_23776(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,21467,23788);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,21467,23788);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,21467,23788);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestGetOperationForVariableInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,23800,24543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,23946,24093);

string 
source = @"
class Test
{
    void M()
    {
        var x /*<bind>*/= 1/*</bind>*/;
        System.Console.WriteLine(x);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,24107,24331);

string 
expectedOperationTree = @"
IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,24345,24398);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,24414,24532);

f_22075_24414_24531(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,23800,24543);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,23800,24543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,23800,24543);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredArguments_WithInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,24555,26500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,24723,24834);

string 
source = @"
class C
{
    void M1()
    {
        int /*<bind>*/x[10] = 1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,24848,25365);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x[10] = 1')
  Initializer: 
    IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  IgnoredArguments(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,25379,26354);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_25731_25796(f_22075_25731_25776(ErrorCode.ERR_CStyleArray, "[10]"), 6, 24),
f_22075_26007_26081(f_22075_26007_26061(ErrorCode.ERR_ArraySizeInDeclaration, "10"), 6, 25),
f_22075_26249_26338(f_22075_26249_26318(f_22075_26249_26299(ErrorCode.WRN_UnreferencedVarAssg, "x"), "x"), 6, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,26370,26489);

f_22075_26370_26488(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,24555,26500);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,24555,26500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,24555,26500);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredArguments_NoInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,26512,28233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,26678,26785);

string 
source = @"
class C
{
    void M1()
    {
        int /*<bind>*/x[10]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,26799,27127);

string 
expectedOperationTree = @"
IVariableDeclaratorOperation (Symbol: System.Int32 x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x[10]')
  Initializer: 
    null
  IgnoredArguments(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,27141,28087);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_27489_27554(f_22075_27489_27534(ErrorCode.ERR_CStyleArray, "[10]"), 6, 24),
f_22075_27761_27835(f_22075_27761_27815(ErrorCode.ERR_ArraySizeInDeclaration, "10"), 6, 25),
f_22075_27986_28071(f_22075_27986_28051(f_22075_27986_28032(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 6, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28103,28222);

f_22075_28103_28221(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,26512,28233);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,26512,28233);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,26512,28233);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredArgumentsWithInitializer_VerifyChildren()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,28245,29032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28427,28538);

string 
source = @"
class C
{
    void M1()
    {
        int /*<bind>*/x[10] = 1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28554,28603);

var 
compilation = f_22075_28572_28602(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28617,28706);

(var operation, _) = f_22075_28638_28705(compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28720,28777);

var 
declarator = (IVariableDeclaratorOperation)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28791,28836);

f_22075_28791_28835(2, f_22075_28807_28834(f_22075_28807_28826(declarator)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28850,28920);

f_22075_28850_28919(OperationKind.Literal, f_22075_28886_28918(f_22075_28886_28913(f_22075_28886_28905(declarator))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,28934,29021);

f_22075_28934_29020(OperationKind.VariableInitializer, f_22075_28982_29019(f_22075_28982_29014(f_22075_28982_29001(declarator), 1)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,28245,29032);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,28245,29032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,28245,29032);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredArguments_VerifyChildren()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,29044,29711);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,29211,29318);

string 
source = @"
class C
{
    void M1()
    {
        int /*<bind>*/x[10]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,29334,29383);

var 
compilation = f_22075_29352_29382(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,29397,29486);

(var operation, _) = f_22075_29418_29485(compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,29500,29557);

var 
declarator = (IVariableDeclaratorOperation)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,29571,29616);

f_22075_29571_29615(1, f_22075_29587_29614(f_22075_29587_29606(declarator)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,29630,29700);

f_22075_29630_29699(OperationKind.Literal, f_22075_29666_29698(f_22075_29666_29693(f_22075_29666_29685(declarator))));
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,29044,29711);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,29044,29711);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,29044,29711);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_WithInitializer_VerifyChildren()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,29723,30399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,29882,29989);

string 
source = @"
class C
{
    void M1()
    {
        int /*<bind>*/x = 1/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30005,30054);

var 
compilation = f_22075_30023_30053(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30068,30157);

(var operation, _) = f_22075_30089_30156(compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30171,30228);

var 
declarator = (IVariableDeclaratorOperation)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30242,30287);

f_22075_30242_30286(1, f_22075_30258_30285(f_22075_30258_30277(declarator)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30301,30388);

f_22075_30301_30387(OperationKind.VariableInitializer, f_22075_30349_30386(f_22075_30349_30381(f_22075_30349_30368(declarator), 0)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,29723,30399);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,29723,30399);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,29723,30399);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_NoChildren()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,30411,30879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30550,30653);

string 
source = @"
class C
{
    void M1()
    {
        int /*<bind>*/x/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30669,30718);

var 
compilation = f_22075_30687_30717(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30732,30821);

(var operation, _) = f_22075_30753_30820(compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,30835,30868);

f_22075_30835_30867(f_22075_30848_30866(operation));
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,30411,30879);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,30411,30879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,30411,30879);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_WithInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,30891,32924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,31060,31175);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/int[10] x = { 1 };/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,31189,32381);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[10] x = { 1 }')
  Ignored Dimensions(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = { 1 }')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= { 1 }')
            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsImplicit) (Syntax: '{ 1 }')
              Dimension Sizes(1):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: '{ 1 }')
              Initializer: 
                IArrayInitializerOperation (1 elements) (OperationKind.ArrayInitializer, Type: null) (Syntax: '{ 1 }')
                  Element Values(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,32395,32777);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_32685_32761(f_22075_32685_32741(ErrorCode.ERR_ArraySizeInDeclaration, "[10]"), 6, 22)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,32793,32913);

f_22075_32793_32912(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,30891,32924);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,30891,32924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,30891,32924);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_NoInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,32936,34524);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,33103,33210);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/int[10] x;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,33224,33730);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[10] x')
  Ignored Dimensions(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,33744,34377);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_34026_34102(f_22075_34026_34082(ErrorCode.ERR_ArraySizeInDeclaration, "[10]"), 6, 22),
f_22075_34276_34361(f_22075_34276_34341(f_22075_34276_34322(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 6, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,34393,34513);

f_22075_34393_34512(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,32936,34524);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,32936,34524);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,32936,34524);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_InArrayOfArrays()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,34536,36151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,34705,34829);

string 
source = @"
using System;
class C
{
    void M1()
    {
        /*<bind>*/int[][10] x;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,34843,35353);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[][10] x')
  Ignored Dimensions(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[][] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,35367,36004);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_35651_35727(f_22075_35651_35707(ErrorCode.ERR_ArraySizeInDeclaration, "[10]"), 7, 24),
f_22075_35903_35988(f_22075_35903_35968(f_22075_35903_35949(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 7, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,36020,36140);

f_22075_36020_36139(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,34536,36151);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,34536,36151);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,34536,36151);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_2ndDimensionOfMultidimensionalArray()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,36163,38121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,36352,36475);

string 
source = @"
using System;
class C
{
    void M1()
    {
        /*<bind>*/int[,10] x;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,36489,37103);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[,10] x')
  Ignored Dimensions(2):
      IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
        Children(0)
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[,] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,37117,37974);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_37400_37477(f_22075_37400_37457(ErrorCode.ERR_ArraySizeInDeclaration, "[,10]"), 7, 22),
f_22075_37635_37698(f_22075_37635_37678(ErrorCode.ERR_ValueExpected, ""), 7, 23),
f_22075_37873_37958(f_22075_37873_37938(f_22075_37873_37919(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 7, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,37990,38110);

f_22075_37990_38109(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,36163,38121);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,36163,38121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,36163,38121);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensionsWithInitializer_VerifyChildren()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,38133,38930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,38316,38431);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/int[10] x = { 1 }/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,38447,38496);

var 
compilation = f_22075_38465_38495(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,38510,38600);

(var operation, _) = f_22075_38531_38599(compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,38614,38673);

var 
declaration = (IVariableDeclarationOperation)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,38687,38733);

f_22075_38687_38732(2, f_22075_38703_38731(f_22075_38703_38723(declaration)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,38747,38818);

f_22075_38747_38817(OperationKind.Literal, f_22075_38783_38816(f_22075_38783_38811(f_22075_38783_38803(declaration))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,38832,38919);

f_22075_38832_38918(OperationKind.VariableDeclarator, f_22075_38879_38917(f_22075_38879_38912(f_22075_38879_38899(declaration), 1)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,38133,38930);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,38133,38930);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,38133,38930);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_VerifyChildren()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,38942,39716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39110,39217);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/int[10] x;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39233,39282);

var 
compilation = f_22075_39251_39281(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39296,39386);

(var operation, _) = f_22075_39317_39385(compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39400,39459);

var 
declaration = (IVariableDeclarationOperation)operation
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39473,39519);

f_22075_39473_39518(2, f_22075_39489_39517(f_22075_39489_39509(declaration)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39533,39604);

f_22075_39533_39603(OperationKind.Literal, f_22075_39569_39602(f_22075_39569_39597(f_22075_39569_39589(declaration))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39618,39705);

f_22075_39618_39704(OperationKind.VariableDeclarator, f_22075_39665_39703(f_22075_39665_39698(f_22075_39665_39685(declaration), 1)));
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,38942,39716);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,38942,39716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,38942,39716);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_VerifyInvalidDimensions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,39728,40969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,39905,40012);

string 
source = @"
class C
{
    void M1()
    {
        int[/*<bind>*/10/*</bind>*/] x;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,40026,40161);

string 
expectedOperationTree = "ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,40177,40831);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_40459_40556(f_22075_40459_40536(ErrorCode.ERR_ArraySizeInDeclaration, "[/*<bind>*/10/*</bind>*/]"), 6, 12),
f_22075_40730_40815(f_22075_40730_40795(f_22075_40730_40776(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 6, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,40847,40958);

f_22075_40847_40957(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,39728,40969);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,39728,40969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,39728,40969);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_TestSemanticModel()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,40981,42689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41152,41280);

string 
source = @"
class C
{
    void M1()
    {
        int[10] x;
        int[M2()]
    }

    int M2() => 42;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41296,41351);

var 
tree = f_22075_41307_41350(source, options: TestOptions.Regular)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41365,41400);

var 
comp = f_22075_41376_41399(tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41414,41482);

var 
model = f_22075_41426_41481(comp, tree, ignoreAccessibility: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41496,41556);

var 
nodes = f_22075_41508_41555(tree.GetCompilationUnitRoot())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41572,41643);

var 
literalExpr = f_22075_41590_41642(f_22075_41590_41629(nodes), 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41659,41703);

f_22075_41659_41702(@"10", f_22075_41679_41701(literalExpr));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41717,41805);

f_22075_41717_41804("System.Int32", f_22075_41746_41803(f_22075_41746_41776(model, literalExpr).Type));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41819,41916);

f_22075_41819_41915("System.Int32", f_22075_41848_41914(f_22075_41848_41878(model, literalExpr).ConvertedType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,41930,41998);

f_22075_41930_41997(Conversion.Identity, f_22075_41964_41996(model, literalExpr));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42014,42086);

var 
invocExpr = f_22075_42030_42085(f_22075_42030_42072(nodes), 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42102,42146);

f_22075_42102_42145(@"M2()", f_22075_42124_42144(invocExpr));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42160,42246);

f_22075_42160_42245("System.Int32", f_22075_42189_42244(f_22075_42189_42217(model, invocExpr).Type));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42260,42355);

f_22075_42260_42354("System.Int32", f_22075_42289_42353(f_22075_42289_42317(model, invocExpr).ConvertedType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42369,42435);

f_22075_42369_42434(Conversion.Identity, f_22075_42403_42433(model, invocExpr));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42451,42498);

var 
invocInfo = f_22075_42467_42497(model, invocExpr)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42512,42545);

f_22075_42512_42544(invocInfo.Symbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42559,42614);

f_22075_42559_42613(SymbolKind.Method, f_22075_42591_42612(invocInfo.Symbol));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42628,42678);

f_22075_42628_42677("M2", f_22075_42647_42676(invocInfo.Symbol));
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,40981,42689);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,40981,42689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,40981,42689);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_OutVarDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,42701,45702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,42872,43054);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/int[M2(out var z)] x;/*</bind>*/
        z = 34;
    }
    
    public int M2(out int i) => i = 42;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,43068,44588);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[M2(out var z)] x')
  Ignored Dimensions(1):
      IInvocationOperation ( System.Int32 C.M2(out System.Int32 i)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2(out var z)')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out var z')
              IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var z')
                ILocalReferenceOperation: z (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'z')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,44602,45555);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_44895_44982(f_22075_44895_44962(ErrorCode.ERR_ArraySizeInDeclaration, "[M2(out var z)]"), 6, 22),
f_22075_45180_45269(f_22075_45180_45249(f_22075_45180_45230(ErrorCode.WRN_UnreferencedVarAssg, "z"), "z"), 6, 34),
f_22075_45454_45539(f_22075_45454_45519(f_22075_45454_45500(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 6, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,45571,45691);

f_22075_45571_45690(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,42701,45702);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,42701,45702);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,42701,45702);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_OutVarDeclaration_InNullableArrayType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,45714,49075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,45905,46088);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/int[M2(out var z)]? x;/*</bind>*/
        z = 34;
    }
    
    public int M2(out int i) => i = 42;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,46102,47624);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[M2(out var z)]? x')
  Ignored Dimensions(1):
      IInvocationOperation ( System.Int32 C.M2(out System.Int32 i)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2(out var z)')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out var z')
              IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var z')
                ILocalReferenceOperation: z (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'z')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[]? x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,47638,48928);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_47932_48019(f_22075_47932_47999(ErrorCode.ERR_ArraySizeInDeclaration, "[M2(out var z)]"), 6, 22),
f_22075_48218_48307(f_22075_48218_48287(f_22075_48218_48268(ErrorCode.WRN_UnreferencedVarAssg, "z"), "z"), 6, 34),
f_22075_48551_48641(f_22075_48551_48621(ErrorCode.WRN_MissingNonNullTypesContextForAnnotation, "?"), 6, 37),
f_22075_48827_48912(f_22075_48827_48892(f_22075_48827_48873(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 6, 39)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,48944,49064);

f_22075_48944_49063(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,45714,49075);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,45714,49075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,45714,49075);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_OutVarDeclaration_InRefType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,49087,52425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,49268,49454);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/ref int[M2(out var z)] y;/*</bind>*/
        z = 34;
    }
    
    public int M2(out int i) => i = 42;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,49468,51003);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'ref int[M2(out var z)] y')
  Ignored Dimensions(1):
      IInvocationOperation ( System.Int32 C.M2(out System.Int32 i)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2(out var z)')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out var z')
              IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var z')
                ILocalReferenceOperation: z (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'z')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] y) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'y')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,51017,52278);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_51314_51401(f_22075_51314_51381(ErrorCode.ERR_ArraySizeInDeclaration, "[M2(out var z)]"), 6, 26),
f_22075_51603_51692(f_22075_51603_51672(f_22075_51603_51653(ErrorCode.WRN_UnreferencedVarAssg, "z"), "z"), 6, 38),
f_22075_51901_51988(f_22075_51901_51968(ErrorCode.ERR_ByReferenceVariableMustBeInitialized, "y"), 6, 42),
f_22075_52177_52262(f_22075_52177_52242(f_22075_52177_52223(ErrorCode.WRN_UnreferencedVar, "y"), "y"), 6, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,52294,52414);

f_22075_52294_52413(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,49087,52425);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,49087,52425);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,49087,52425);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_OutVarDeclaration_InDoublyNestedType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,52437,56131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,52627,52814);

string 
source = @"
class C
{
    void M1()
    {
        /*<bind>*/ref int[M2(out var z)]? y;/*</bind>*/
        z = 34;
    }
    
    public int M2(out int i) => i = 42;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,52828,54367);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'ref int[M2( ...  var z)]? y')
  Ignored Dimensions(1):
      IInvocationOperation ( System.Int32 C.M2(out System.Int32 i)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2(out var z)')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out var z')
              IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'var z')
                ILocalReferenceOperation: z (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'z')
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[]? y) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'y')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,54381,55984);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_54679_54766(f_22075_54679_54746(ErrorCode.ERR_ArraySizeInDeclaration, "[M2(out var z)]"), 6, 26),
f_22075_54969_55058(f_22075_54969_55038(f_22075_54969_55019(ErrorCode.WRN_UnreferencedVarAssg, "z"), "z"), 6, 38),
f_22075_55306_55396(f_22075_55306_55376(ErrorCode.WRN_MissingNonNullTypesContextForAnnotation, "?"), 6, 41),
f_22075_55606_55693(f_22075_55606_55673(ErrorCode.ERR_ByReferenceVariableMustBeInitialized, "y"), 6, 43),
f_22075_55883_55968(f_22075_55883_55948(f_22075_55883_55929(ErrorCode.WRN_UnreferencedVar, "y"), "y"), 6, 43)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,56000,56120);

f_22075_56000_56119(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,52437,56131);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,52437,56131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,52437,56131);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_NestedArrayType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,56145,58200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,56314,56445);

string 
source = @"
class C
{
#nullable enable
    void M1()
    {
        /*<bind>*/int[10]?[20]? x;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,56459,57084);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[10]?[20]? x')
  Ignored Dimensions(2):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 20, IsInvalid) (Syntax: '20')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[]?[]? x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,57098,58053);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_57386_57462(f_22075_57386_57442(ErrorCode.ERR_ArraySizeInDeclaration, "[10]"), 7, 22),
f_22075_57696_57772(f_22075_57696_57752(ErrorCode.ERR_ArraySizeInDeclaration, "[20]"), 7, 27),
f_22075_57952_58037(f_22075_57952_58017(f_22075_57952_57998(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 7, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,58069,58189);

f_22075_58069_58188(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,56145,58200);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,56145,58200);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,56145,58200);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_AliasQualifiedName01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,58212,60516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,58386,58541);

string 
source = @"
using Col=System.Collections.Generic;
class C
{
    void M1()
    {
        /*<bind>*/Col::List<int[]> x;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,58555,58607);

var 
syntaxTree = f_22075_58572_58606(source, filename: "file.cs")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,58621,58741);

var 
rankSpecifierOld = f_22075_58644_58740(f_22075_58644_58732(f_22075_58644_58697(syntaxTree.GetCompilationUnitRoot())))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,58755,58998);

var 
rankSpecifierNew = f_22075_58778_58997(rankSpecifierOld
, f_22075_58823_58996(f_22075_58869_58995(f_22075_58899_58994(SyntaxKind.NumericLiteralExpression, f_22075_58968_58993(10)))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,59012,59120);

syntaxTree = f_22075_59025_59119(f_22075_59025_59108(syntaxTree.GetCompilationUnitRoot(), rankSpecifierOld, rankSpecifierNew));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,59136,59686);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Col::List<int[10]> x')
  Ignored Dimensions(1):
      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 10, IsInvalid) (Syntax: '10')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Collections.Generic.List<System.Int32[]> x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,59700,60355);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_59993_60069(f_22075_59993_60049(ErrorCode.ERR_ArraySizeInDeclaration, "[10]"), 7, 32),
f_22075_60254_60339(f_22075_60254_60319(f_22075_60254_60300(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 7, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,60371,60505);

f_22075_60371_60504(new[] { syntaxTree }, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,58212,60516);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,58212,60516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,58212,60516);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_AliasQualifiedName02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,60528,62072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,60702,60862);

string 
source = @"
using List=System.Collections.Generic.List<int[10]>;

class C
{
    void M1()
    {
        /*<bind>*/List x;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,60878,61268);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'List x')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Collections.Generic.List<System.Int32[]> x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,61282,61925);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_61577_61653(f_22075_61577_61633(ErrorCode.ERR_ArraySizeInDeclaration, "[10]"), 2, 47),
f_22075_61824_61909(f_22075_61824_61889(f_22075_61824_61870(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 8, 24)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,61941,62061);

f_22075_61941_62060(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,60528,62072);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,60528,62072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,60528,62072);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_DeclarationPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,62084,65012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,62256,62409);

string 
source = @"
class C
{
    void M1()
    {
        int y = 10;
        /*<bind>*/int[y is int z] x;/*</bind>*/
        z = 34;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,62423,63652);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[y is int z] x')
  Ignored Dimensions(1):
      IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'y is int z')
        Conversion: CommonConversion (Exists: False, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
        Operand: 
          IIsPatternOperation (OperationKind.IsPattern, Type: System.Boolean, IsInvalid) (Syntax: 'y is int z')
            Value: 
              ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
            Pattern: 
              IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,63666,64865);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_63887_63976(f_22075_63887_63956(f_22075_63887_63937(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 6, 13),
f_22075_64212_64296(f_22075_64212_64276(ErrorCode.ERR_ArraySizeInDeclaration, "[y is int z]"), 7, 22),
f_22075_64479_64582(f_22075_64479_64562(f_22075_64479_64533(ErrorCode.ERR_NoImplicitConv, "y is int z"), "bool", "int"), 7, 23),
f_22075_64764_64849(f_22075_64764_64829(f_22075_64764_64810(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 7, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,64881,65001);

f_22075_64881_65000(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,62084,65012);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,62084,65012);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,62084,65012);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IVariableDeclaration_InvalidIgnoredDimensions_SwitchExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,65024,68742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,65194,65373);

string 
source = @"
class C
{
    void M1()
    {
        int y = 10;
        /*<bind>*/int[M(y switch { int z => 42 })] x;/*</bind>*/
    }

    int M(int a) => a;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,65389,67615);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[M(y swi ... => 42 })] x')
  Ignored Dimensions(1):
      IInvocationOperation ( System.Int32 C.M(System.Int32 a)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M(y switch  ...  z => 42 })')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: a) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'y switch { int z => 42 }')
              ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'y switch { int z => 42 }')
                Value: 
                  ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
                Arms(1):
                    ISwitchExpressionArmOperation (1 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'int z => 42')
                      Pattern: 
                        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
                      Locals: Local_1: System.Int32 z
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,67631,68595);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_67852_67941(f_22075_67852_67921(f_22075_67852_67902(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 6, 13),
f_22075_68194_68295(f_22075_68194_68275(ErrorCode.ERR_ArraySizeInDeclaration, "[M(y switch { int z => 42 })]"), 7, 22),
f_22075_68494_68579(f_22075_68494_68559(f_22075_68494_68540(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 7, 52)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,68611,68731);

f_22075_68611_68730(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,65024,68742);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,65024,68742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,65024,68742);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void FixedStatementDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,68812,70830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,69011,69293);

string 
source = @"
class Program
{
    int i1;
    static void Main(string[] args)
    {
        var reference = new Program();
        unsafe
        {
            fixed (/*<bind>*/int* p = &reference.i1/*</bind>*/)
            {

            }
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,69311,70395);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int* p = &reference.i1')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32* p) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p = &reference.i1')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &reference.i1')
            IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&reference.i1')
              Children(1):
                  IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&reference.i1')
                    Reference: 
                      IFieldReferenceOperation: System.Int32 Program.i1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'reference.i1')
                        Instance Receiver: 
                          ILocalReferenceOperation: reference (OperationKind.LocalReference, Type: Program) (Syntax: 'reference')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,70409,70683);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_70599_70667(f_22075_70599_70648(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 8, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,70699,70819);

f_22075_70699_70818(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,68812,70830);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,68812,70830);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,68812,70830);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void FixedStatementMultipleDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,70842,73772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,71049,71356);

string 
source = @"
class Program
{
    int i1, i2;
    static void Main(string[] args)
    {
        var reference = new Program();
        unsafe
        {
            fixed (/*<bind>*/int* p1 = &reference.i1, p2 = &reference.i2/*</bind>*/)
            {

            }
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,71370,73337);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int* p1 = & ... eference.i2')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = &reference.i1')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &reference.i1')
            IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&reference.i1')
              Children(1):
                  IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&reference.i1')
                    Reference: 
                      IFieldReferenceOperation: System.Int32 Program.i1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'reference.i1')
                        Instance Receiver: 
                          ILocalReferenceOperation: reference (OperationKind.LocalReference, Type: Program) (Syntax: 'reference')
      IVariableDeclaratorOperation (Symbol: System.Int32* p2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p2 = &reference.i2')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &reference.i2')
            IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&reference.i2')
              Children(1):
                  IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&reference.i2')
                    Reference: 
                      IFieldReferenceOperation: System.Int32 Program.i2 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'reference.i2')
                        Instance Receiver: 
                          ILocalReferenceOperation: reference (OperationKind.LocalReference, Type: Program) (Syntax: 'reference')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,73351,73625);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_73541_73609(f_22075_73541_73590(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 8, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,73641,73761);

f_22075_73641_73760(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,70842,73772);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,70842,73772);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,70842,73772);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void FixedStatementInvalidAssignment()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,73784,75785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,73989,74258);

string 
source = @"
class Program
{
    int i1;
    static void Main(string[] args)
    {
        var reference = new Program();
        unsafe
        {
            fixed (/*<bind>*/int* p = /*</bind>*/)
            {

            }
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,74272,74906);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int* p = /*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32* p) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p = /*</bind>*/')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= /*</bind>*/')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,74920,75638);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_75120_75206(f_22075_75120_75185(f_22075_75120_75166(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 10, 50),
f_22075_75342_75410(f_22075_75342_75391(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 8, 9),
f_22075_75526_75622(f_22075_75526_75603(f_22075_75526_75575(ErrorCode.WRN_UnreferencedField, "i1"), "Program.i1"), 4, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,75654,75774);

f_22075_75654_75773(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,73784,75785);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,73784,75785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,73784,75785);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void FixedStatementMultipleDeclarationsInvalidInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,75797,78705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,76024,76305);

string 
source = @"
class Program
{
    int i1, i2;
    static void Main(string[] args)
    {
        var reference = new Program();
        unsafe
        {
            fixed (/*<bind>*/int* p1 = , p2 = /*</bind>*/)
            {

            }
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,76319,77357);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int* p1 = , ... /*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1 = ')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= ')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
      IVariableDeclaratorOperation (Symbol: System.Int32* p2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p2 = /*</bind>*/')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= /*</bind>*/')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,77371,78558);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_77579_77665(f_22075_77579_77644(f_22075_77579_77625(ErrorCode.ERR_InvalidExprTerm, ","), ","), 10, 40),
f_22075_77819_77905(f_22075_77819_77884(f_22075_77819_77865(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 10, 58),
f_22075_78041_78109(f_22075_78041_78090(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 8, 9),
f_22075_78229_78326(f_22075_78229_78306(f_22075_78229_78278(ErrorCode.WRN_UnreferencedField, "i2"), "Program.i2"), 4, 13),
f_22075_78446_78542(f_22075_78446_78523(f_22075_78446_78495(ErrorCode.WRN_UnreferencedField, "i1"), "Program.i1"), 4, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,78574,78694);

f_22075_78574_78693(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,75797,78705);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,75797,78705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,75797,78705);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void FixedStatementNoInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,78717,80477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,78918,79184);

string 
source = @"
class Program
{
    int i1;
    static void Main(string[] args)
    {
        var reference = new Program();
        unsafe
        {
            fixed (/*<bind>*/int* p/*</bind>*/)
            {

            }
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,79198,79576);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int* p')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32* p) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,79590,80330);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_79780_79848(f_22075_79780_79829(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 8, 9),
f_22075_80037_80102(f_22075_80037_80081(ErrorCode.ERR_FixedMustInit, "p"), 10, 35),
f_22075_80218_80314(f_22075_80218_80295(f_22075_80218_80267(ErrorCode.WRN_UnreferencedField, "i1"), "Program.i1"), 4, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,80346,80466);

f_22075_80346_80465(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,78717,80477);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,78717,80477);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,78717,80477);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void FixedStatementMultipleDeclarationsNoInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,80489,82948);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,80711,80986);

string 
source = @"
class Program
{
    int i1, i2;
    static void Main(string[] args)
    {
        var reference = new Program();
        unsafe
        {
            fixed (/*<bind>*/int* p1, p2/*</bind>*/)
            {

            }
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,81000,81560);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int* p1, p2')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1')
        Initializer: 
          null
      IVariableDeclaratorOperation (Symbol: System.Int32* p2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p2')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,81574,82801);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_81764_81832(f_22075_81764_81813(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 8, 9),
f_22075_82026_82092(f_22075_82026_82071(ErrorCode.ERR_FixedMustInit, "p1"), 10, 35),
f_22075_82286_82352(f_22075_82286_82331(ErrorCode.ERR_FixedMustInit, "p2"), 10, 39),
f_22075_82472_82569(f_22075_82472_82549(f_22075_82472_82521(ErrorCode.WRN_UnreferencedField, "i2"), "Program.i2"), 4, 13),
f_22075_82689_82785(f_22075_82689_82766(f_22075_82689_82738(ErrorCode.WRN_UnreferencedField, "i1"), "Program.i1"), 4, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,82817,82937);

f_22075_82817_82936(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,80489,82948);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,80489,82948);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,80489,82948);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void FixedStatementInvalidMulipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,82960,85895);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,83174,83462);

string 
source = @"
class Program
{
    int i1, i2;
    static void Main(string[] args)
    {
        var reference = new Program();
        unsafe
        {
            fixed (/*<bind>*/int* p1 = &reference.i1,/*</bind>*/)
            {

            }
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,83476,84749);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int* p1 = & ... /*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32* p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = &reference.i1')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= &reference.i1')
            IOperation:  (OperationKind.None, Type: null, IsImplicit) (Syntax: '&reference.i1')
              Children(1):
                  IAddressOfOperation (OperationKind.AddressOf, Type: System.Int32*) (Syntax: '&reference.i1')
                    Reference: 
                      IFieldReferenceOperation: System.Int32 Program.i1 (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'reference.i1')
                        Instance Receiver: 
                          ILocalReferenceOperation: reference (OperationKind.LocalReference, Type: Program) (Syntax: 'reference')
      IVariableDeclaratorOperation (Symbol: System.Int32* ) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,84763,85748);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_84970_85040(f_22075_84970_85019(ErrorCode.ERR_IdentifierExpected, ")"), 10, 65),
f_22075_85176_85244(f_22075_85176_85225(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 8, 9),
f_22075_85451_85515(f_22075_85451_85494(ErrorCode.ERR_FixedMustInit, ""), 10, 65),
f_22075_85635_85732(f_22075_85635_85712(f_22075_85635_85684(ErrorCode.WRN_UnreferencedField, "i2"), "Program.i2"), 4, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,85764,85884);

f_22075_85764_85883(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,82960,85895);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,82960,85895);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,82960,85895);
}
		}

[Fact]
        public void FixedStatement_InvalidIgnoredDimensions_SwitchExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,85907,90166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,86018,86288);

string 
source = @"
class C
{
    void M1()
    {
        int y = 10;
        unsafe
        {
            fixed (/*<bind>*/int[M2(y switch { int z => 42 })] p1 = null/*</bind>*/)
            {

            }
        }
    }

    int M2(int x) => x;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,86304,88766);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[M2(y sw ... ] p1 = null')
  Ignored Dimensions(1):
      IInvocationOperation ( System.Int32 C.M2(System.Int32 x)) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'M2(y switch ...  z => 42 })')
        Instance Receiver: 
          IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
        Arguments(1):
            IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'y switch { int z => 42 }')
              ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'y switch { int z => 42 }')
                Value: 
                  ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
                Arms(1):
                    ISwitchExpressionArmOperation (1 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'int z => 42')
                      Pattern: 
                        IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
                      Value: 
                        ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
                      Locals: Local_1: System.Int32 z
              InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
              OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1 = null')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= null')
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,88782,90019);

var 
expectedDiagnostics = new[]
            {
f_22075_88994_89083(f_22075_88994_89063(f_22075_88994_89044(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 6, 13),
f_22075_89239_89307(f_22075_89239_89288(ErrorCode.ERR_IllegalUnsafe, "unsafe"), 7, 9),
f_22075_89580_89682(f_22075_89580_89662(ErrorCode.ERR_ArraySizeInDeclaration, "[M2(y switch { int z => 42 })]"), 9, 33),
f_22075_89928_90003(f_22075_89928_89983(ErrorCode.ERR_BadFixedInitType, "p1 = null"), 9, 64)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,90035,90155);

f_22075_90035_90154(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,85907,90166);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,85907,90166);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,85907,90166);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,90236,91618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,90435,90680);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1 = new Program()/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,90694,91404);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Program p1  ... w Program()')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = new Program()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new Program()')
            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
              Arguments(0)
              Initializer: 
                null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,91418,91471);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,91487,91607);

f_22075_91487_91606(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,90236,91618);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,90236,91618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,90236,91618);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementMultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,91630,93536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,91838,92103);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1 = new Program(), p2 = new Program()/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,92117,93322);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Program p1  ... w Program()')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = new Program()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new Program()')
            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
              Arguments(0)
              Initializer: 
                null
      IVariableDeclaratorOperation (Symbol: Program p2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p2 = new Program()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new Program()')
            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
              Arguments(0)
              Initializer: 
                null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,93336,93389);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,93405,93525);

f_22075_93405_93524(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,91630,93536);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,91630,93536);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,91630,93536);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementInvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,93548,95091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,93754,93985);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1 =/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,93999,94630);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Program p1 =/*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1 =/*</bind>*/')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=/*</bind>*/')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,94644,94944);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_94843_94928(f_22075_94843_94908(f_22075_94843_94889(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 8, 49)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,94960,95080);

f_22075_94960_95079(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,93548,95091);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,93548,95091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,93548,95091);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementMultipleDeclarationsInvalidInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,95103,97306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,95330,95567);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1 =, p2 =/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,95581,96603);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Program p1  ... /*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1 =')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
      IVariableDeclaratorOperation (Symbol: Program p2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p2 =/*</bind>*/')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=/*</bind>*/')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,96617,97159);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_96822_96907(f_22075_96822_96887(f_22075_96822_96868(ErrorCode.ERR_InvalidExprTerm, ","), ","), 8, 38),
f_22075_97058_97143(f_22075_97058_97123(f_22075_97058_97104(ErrorCode.ERR_InvalidExprTerm, ")"), ")"), 8, 55)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,97175,97295);

f_22075_97175_97294(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,95103,97306);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,95103,97306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,95103,97306);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementNoInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,97318,98625);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,97519,97748);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,97762,98140);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Program p1')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,98154,98478);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_98397_98462(f_22075_98397_98442(ErrorCode.ERR_FixedMustInit, "p1"), 8, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,98494,98614);

f_22075_98494_98613(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,97318,98625);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,97318,98625);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,97318,98625);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementMultipleDeclarationsNoInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,98637,100404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,98859,99092);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1, p2/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,99106,99657);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Program p1, p2')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p1')
        Initializer: 
          null
      IVariableDeclaratorOperation (Symbol: Program p2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'p2')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,99671,100257);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_99918_99983(f_22075_99918_99963(ErrorCode.ERR_FixedMustInit, "p1"), 8, 34),
f_22075_100176_100241(f_22075_100176_100221(ErrorCode.ERR_FixedMustInit, "p2"), 8, 38)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,100273,100393);

f_22075_100273_100392(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,98637,100404);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,98637,100404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,98637,100404);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementInvalidMultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,100416,102498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,100631,100877);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1 = new Program(),/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,100891,101777);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'Program p1  ... /*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = new Program()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new Program()')
            IObjectCreationOperation (Constructor: Program..ctor()) (OperationKind.ObjectCreation, Type: Program) (Syntax: 'new Program()')
              Arguments(0)
              Initializer: 
                null
      IVariableDeclaratorOperation (Symbol: Program ) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,101791,102351);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_101997_102066(f_22075_101997_102046(ErrorCode.ERR_IdentifierExpected, ")"), 8, 64),
f_22075_102272_102335(f_22075_102272_102315(ErrorCode.ERR_FixedMustInit, ""), 8, 64)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,102367,102487);

f_22075_102367_102486(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,100416,102498);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,100416,102498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,100416,102498);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementExpressionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,102510,103949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,102719,103016);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1 = GetProgram()/*</bind>*/)
        {
        }
    }

    static Program GetProgram() => new Program();

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,103030,103735);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Program p1  ... etProgram()')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = GetProgram()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetProgram()')
            IInvocationOperation (Program Program.GetProgram()) (OperationKind.Invocation, Type: Program) (Syntax: 'GetProgram()')
              Instance Receiver: 
                null
              Arguments(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,103749,103802);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,103818,103938);

f_22075_103818_103937(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,102510,103949);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,102510,103949);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,102510,103949);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementMultipleDeclarationsExpressionInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,103961,105930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,104191,104507);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        using (/*<bind>*/Program p1 = GetProgram(), p2 = GetProgram()/*</bind>*/)
        {
        }
    }

    static Program GetProgram() => new Program();

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,104521,105716);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Program p1  ... etProgram()')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p1 = GetProgram()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetProgram()')
            IInvocationOperation (Program Program.GetProgram()) (OperationKind.Invocation, Type: Program) (Syntax: 'GetProgram()')
              Instance Receiver: 
                null
              Arguments(0)
      IVariableDeclaratorOperation (Symbol: Program p2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p2 = GetProgram()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetProgram()')
            IInvocationOperation (Program Program.GetProgram()) (OperationKind.Invocation, Type: Program) (Syntax: 'GetProgram()')
              Instance Receiver: 
                null
              Arguments(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,105730,105783);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,105799,105919);

f_22075_105799_105918(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,103961,105930);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,103961,105930);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,103961,105930);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementLocalReferenceInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,105942,107213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,106155,106426);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        Program p1 = new Program();
        using (/*<bind>*/Program p2 = p1/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,106440,106999);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Program p2 = p1')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p2 = p1')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= p1')
            ILocalReferenceOperation: p1 (OperationKind.LocalReference, Type: Program) (Syntax: 'p1')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,107013,107066);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,107082,107202);

f_22075_107082_107201(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,105942,107213);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,105942,107213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,105942,107213);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void UsingStatementMultipleDeclarationsLocalReferenceInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,107225,108891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,107459,107739);

string 
source = @"
using System;

class Program : IDisposable
{
    static void Main(string[] args)
    {
        Program p1 = new Program();
        using (/*<bind>*/Program p2 = p1, p3 = p1/*</bind>*/)
        {
        }
    }

    public void Dispose() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,107753,108677);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'Program p2 = p1, p3 = p1')
  Declarators:
      IVariableDeclaratorOperation (Symbol: Program p2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p2 = p1')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= p1')
            ILocalReferenceOperation: p1 (OperationKind.LocalReference, Type: Program) (Syntax: 'p1')
      IVariableDeclaratorOperation (Symbol: Program p3) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'p3 = p1')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= p1')
            ILocalReferenceOperation: p1 (OperationKind.LocalReference, Type: Program) (Syntax: 'p1')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,108691,108744);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,108760,108880);

f_22075_108760_108879(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,107225,108891);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,107225,108891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,107225,108891);
}
		}

[Fact]
        public void UsingBlock_InvalidIgnoredDimensions_SwitchExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,108903,112812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,109010,109157);

string 
source = @"
class C
{
    void M1()
    {
        int y = 10;
       using( /*<bind>*/int[] x = new int[0]/*</bind>*/){}
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,109171,109223);

var 
syntaxTree = f_22075_109188_109222(source, filename: "file.cs")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,109237,109357);

var 
rankSpecifierOld = f_22075_109260_109356(f_22075_109260_109348(f_22075_109260_109313(syntaxTree.GetCompilationUnitRoot())))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,109371,109576);

var 
rankSpecifierNew = f_22075_109394_109575(rankSpecifierOld
, f_22075_109439_109574(f_22075_109485_109573(f_22075_109515_109572("y switch { int z => 42 }"))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,109590,109698);

syntaxTree = f_22075_109603_109697(f_22075_109603_109686(syntaxTree.GetCompilationUnitRoot(), rankSpecifierOld, rankSpecifierNew));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,109716,111551);

string 
expectedOperationTree = @"
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[y switc ...  new int[0]')
      Ignored Dimensions(1):
          ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'y switch { int z => 42 }')
            Value:
              ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
            Arms(1):
                ISwitchExpressionArmOperation (1 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'int z => 42')
                  Pattern:
                    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
                  Value:
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
                  Locals: Local_1: System.Int32 z
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = new int[0]')
            Initializer:
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new int[0]')
                IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsInvalid) (Syntax: 'new int[0]')
                  Dimension Sizes(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
                  Initializer:
                    null
      Initializer:
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,111567,112651);

var 
expectedDiagnostics = new[]
            {
f_22075_111779_111868(f_22075_111779_111848(f_22075_111779_111829(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 6, 13),
f_22075_112135_112265(f_22075_112135_112245(f_22075_112135_112222(ErrorCode.ERR_NoConvToIDisp, "int[y switch { int z => 42 }] x = new int[0]"), "int[]"), 7, 25),
f_22075_112536_112634(f_22075_112536_112614(ErrorCode.ERR_ArraySizeInDeclaration, "[y switch { int z => 42 }]"), 7, 28),
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,112667,112801);

f_22075_112667_112800(new[] { syntaxTree }, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,108903,112812);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,108903,112812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,108903,112812);
}
		}

[Fact]
        public void UsingStatement_InvalidIgnoredDimensions_SwitchExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,112824,117019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,112935,113081);

string 
source = @"
class C
{
    void M1()
    {
        int y = 10;
       using( /*<bind>*/int[] x = new int[0]/*</bind>*/);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,113095,113147);

var 
syntaxTree = f_22075_113112_113146(source, filename: "file.cs")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,113161,113281);

var 
rankSpecifierOld = f_22075_113184_113280(f_22075_113184_113272(f_22075_113184_113237(syntaxTree.GetCompilationUnitRoot())))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,113295,113500);

var 
rankSpecifierNew = f_22075_113318_113499(rankSpecifierOld
, f_22075_113363_113498(f_22075_113409_113497(f_22075_113439_113496("y switch { int z => 42 }"))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,113514,113622);

syntaxTree = f_22075_113527_113621(f_22075_113527_113610(syntaxTree.GetCompilationUnitRoot(), rankSpecifierOld, rankSpecifierNew));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,113640,115475);

string 
expectedOperationTree = @"
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[y switc ...  new int[0]')
      Ignored Dimensions(1):
          ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'y switch { int z => 42 }')
            Value:
              ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
            Arms(1):
                ISwitchExpressionArmOperation (1 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'int z => 42')
                  Pattern:
                    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
                  Value:
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
                  Locals: Local_1: System.Int32 z
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = new int[0]')
            Initializer:
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new int[0]')
                IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsInvalid) (Syntax: 'new int[0]')
                  Dimension Sizes(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
                  Initializer:
                    null
      Initializer:
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,115491,116858);

var 
expectedDiagnostics = new[]
            {
f_22075_115703_115792(f_22075_115703_115772(f_22075_115703_115753(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 6, 13),
f_22075_116058_116188(f_22075_116058_116168(f_22075_116058_116145(ErrorCode.ERR_NoConvToIDisp, "int[y switch { int z => 42 }] x = new int[0]"), "int[]"), 7, 25),
f_22075_116458_116556(f_22075_116458_116536(ErrorCode.ERR_ArraySizeInDeclaration, "[y switch { int z => 42 }]"), 7, 28),
f_22075_116762_116842(f_22075_116762_116822(ErrorCode.WRN_PossibleMistakenNullStatement, ";"), 7, 81)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,116874,117008);

f_22075_116874_117007(new[] { syntaxTree }, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,112824,117019);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,112824,117019);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,112824,117019);
}
		}

[Fact]
        public void UsingDeclaration_InvalidIgnoredDimensions_SwitchExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,117031,120429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,117144,117312);

string 
source = @"
class C
{
    void M1()
    {
        int y = 10;
       using /*<bind>*/int[y switch { int z => 42 }] x = new int[0]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,117328,119163);

string 
expectedOperationTree = @"
    IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[y switc ...  new int[0]')
      Ignored Dimensions(1):
          ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'y switch { int z => 42 }')
            Value:
              ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
            Arms(1):
                ISwitchExpressionArmOperation (1 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'int z => 42')
                  Pattern:
                    IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
                  Value:
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
                  Locals: Local_1: System.Int32 z
      Declarators:
          IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'x = new int[0]')
            Initializer:
              IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= new int[0]')
                IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[], IsInvalid) (Syntax: 'new int[0]')
                  Dimension Sizes(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0, IsInvalid) (Syntax: '0')
                  Initializer:
                    null
      Initializer:
        null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,119179,120282);

var 
expectedDiagnostics = new[]
            {
f_22075_119391_119480(f_22075_119391_119460(f_22075_119391_119441(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 6, 13),
f_22075_119743_119900(f_22075_119743_119881(f_22075_119743_119858(ErrorCode.ERR_NoConvToIDisp, "using /*<bind>*/int[y switch { int z => 42 }] x = new int[0]/*</bind>*/;"), "int[]"), 7, 8),
f_22075_120168_120266(f_22075_120168_120246(ErrorCode.ERR_ArraySizeInDeclaration, "[y switch { int z => 42 }]"), 7, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,120298,120418);

f_22075_120298_120417(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,117031,120429);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,117031,120429);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,117031,120429);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,120492,121641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,120684,120860);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i = 0/*</bind>*/; i < 0; i++)
        {

        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,120874,121427);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,121441,121494);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,121510,121630);

f_22075_121510_121629(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,120492,121641);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,120492,121641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,120492,121641);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopMultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,121653,123473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,121854,122035);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i = 0, j = 0/*</bind>*/; i < 0; i++)
        {
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,122049,122965);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = 0, j = 0')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = 0')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
      IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = 0')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 0')
            ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,122979,123326);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_123221_123310(f_22075_123221_123290(f_22075_123221_123271(ErrorCode.WRN_UnreferencedVarAssg, "j"), "j"), 6, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,123342,123462);

f_22075_123342_123461(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,121653,123473);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,121653,123473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,121653,123473);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopInvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,123485,124967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,123684,123858);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i =/*</bind>*/; i < 0; i++)
        {

        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,123872,124501);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i =/*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i =/*</bind>*/')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=/*</bind>*/')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,124515,124820);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_124719_124804(f_22075_124719_124784(f_22075_124719_124765(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,124836,124956);

f_22075_124836_124955(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,123485,124967);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,123485,124967);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,123485,124967);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopMultipleDeclarationsInvalidInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,124979,127127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,125199,125378);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i =, j =/*</bind>*/; i < 0; i++)
        {

        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,125392,126416);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i =, j =/*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i =')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
      IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'j =/*</bind>*/')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=/*</bind>*/')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,126430,126980);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_126639_126724(f_22075_126639_126704(f_22075_126639_126685(ErrorCode.ERR_InvalidExprTerm, ","), ","), 6, 31),
f_22075_126879_126964(f_22075_126879_126944(f_22075_126879_126925(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 47)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,126996,127116);

f_22075_126996_127115(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,124979,127127);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,124979,127127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,124979,127127);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopNoInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,127139,128346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,127333,127505);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i/*</bind>*/; i < 0; i++)
        {

        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,127519,127873);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,127887,128199);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_128098_128183(f_22075_128098_128163(f_22075_128098_128144(ErrorCode.ERR_UseDefViolation, "i"), "i"), 6, 42)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,128215,128335);

f_22075_128215_128334(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,127139,128346);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,127139,128346);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,127139,128346);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopMultipleDeclarationsNoInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,128358,130007);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,128572,128747);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i, j/*</bind>*/; i < 0; i++)
        {

        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,128761,129279);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i, j')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i')
        Initializer: 
          null
      IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,129293,129860);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_129507_129592(f_22075_129507_129572(f_22075_129507_129553(ErrorCode.ERR_UseDefViolation, "i"), "i"), 6, 45),
f_22075_129759_129844(f_22075_129759_129824(f_22075_129759_129805(ErrorCode.WRN_UnreferencedVar, "j"), "j"), 6, 31)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,129876,129996);

f_22075_129876_129995(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,128358,130007);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,128358,130007);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,128358,130007);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopInvalidMultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,130019,131873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,130227,130402);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i =,/*</bind>*/; i < 0; i++)
        {

        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,130416,131194);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i =,/*</bind>*/')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i =')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '=')
            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
              Children(0)
      IVariableDeclaratorOperation (Symbol: System.Int32 ) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '')
        Initializer: 
          null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,131208,131726);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_131413_131498(f_22075_131413_131478(f_22075_131413_131459(ErrorCode.ERR_InvalidExprTerm, ","), ","), 6, 31),
f_22075_131641_131710(f_22075_131641_131690(ErrorCode.ERR_IdentifierExpected, ";"), 6, 43)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,131742,131862);

f_22075_131742_131861(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,130019,131873);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,130019,131873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,130019,131873);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopExpressionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,131885,133222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,132087,132303);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i = GetInt()/*</bind>*/; i < 0; i++)
        {

        }
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,132317,133008);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = GetInt()')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = GetInt()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetInt()')
            IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
              Instance Receiver: 
                null
              Arguments(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,133022,133075);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,133091,133211);

f_22075_133091_133210(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,131885,133222);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,131885,133222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,131885,133222);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ForLoopMultipleDeclarationsExpressionInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,133234,135104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,133457,133687);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        for (/*<bind>*/int i = GetInt(), j = GetInt()/*</bind>*/; i < 0; i++)
        {

        }
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,133701,134890);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i = Get ...  = GetInt()')
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32 i) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i = GetInt()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetInt()')
            IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
              Instance Receiver: 
                null
              Arguments(0)
      IVariableDeclaratorOperation (Symbol: System.Int32 j) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'j = GetInt()')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= GetInt()')
            IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32) (Syntax: 'GetInt()')
              Instance Receiver: 
                null
              Arguments(0)
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,134904,134957);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,134973,135093);

f_22075_134973_135092(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,133234,135104);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,133234,135104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,133234,135104);
}
		}

[Fact]
        public void ForLoop_InvalidIgnoredDimensions_SwitchExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,135116,138497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,135220,135368);

string 
source = @"
class C
{
    void M1()
    {
        int y = 10;
        for (/*<bind/>*/int[] x = new int[0]/*</bind>*/;;);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,135382,135434);

var 
syntaxTree = f_22075_135399_135433(source, filename: "file.cs")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,135448,135568);

var 
rankSpecifierOld = f_22075_135471_135567(f_22075_135471_135559(f_22075_135471_135524(syntaxTree.GetCompilationUnitRoot())))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,135582,135787);

var 
rankSpecifierNew = f_22075_135605_135786(rankSpecifierOld
, f_22075_135650_135785(f_22075_135696_135784(f_22075_135726_135783("y switch { int z => 42 }"))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,135801,135909);

syntaxTree = f_22075_135814_135908(f_22075_135814_135897(syntaxTree.GetCompilationUnitRoot(), rankSpecifierOld, rankSpecifierNew));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,135927,137632);

string 
expectedOperationTree = @"
IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int[y switc ...  new int[0]')
  Ignored Dimensions(1):
      ISwitchExpressionOperation (1 arms) (OperationKind.SwitchExpression, Type: System.Int32, IsInvalid) (Syntax: 'y switch { int z => 42 }')
        Value: 
          ILocalReferenceOperation: y (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'y')
        Arms(1):
            ISwitchExpressionArmOperation (1 locals) (OperationKind.SwitchExpressionArm, Type: null, IsInvalid) (Syntax: 'int z => 42')
              Pattern: 
                IDeclarationPatternOperation (OperationKind.DeclarationPattern, Type: null, IsInvalid) (Syntax: 'int z') (InputType: System.Int32, NarrowedType: System.Int32, DeclaredSymbol: System.Int32 z, MatchesNull: False)
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 42, IsInvalid) (Syntax: '42')
              Locals: Local_1: System.Int32 z
  Declarators:
      IVariableDeclaratorOperation (Symbol: System.Int32[] x) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'x = new int[0]')
        Initializer: 
          IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= new int[0]')
            IArrayCreationOperation (OperationKind.ArrayCreation, Type: System.Int32[]) (Syntax: 'new int[0]')
              Dimension Sizes(1):
                  ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 0) (Syntax: '0')
              Initializer: 
                null
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,137648,138336);

var 
expectedDiagnostics = new[]
            {
f_22075_137860_137949(f_22075_137860_137929(f_22075_137860_137910(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"), 6, 13),
f_22075_138221_138319(f_22075_138221_138299(ErrorCode.ERR_ArraySizeInDeclaration, "[y switch { int z => 42 }]"), 7, 28),
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,138352,138486);

f_22075_138352_138485(new[] { syntaxTree }, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,135116,138497);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,135116,138497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,135116,138497);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalDeclaration()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,138575,140134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,138770,138912);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1 = 1;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,138926,139634);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'const int i1 = 1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = 1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = 1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,139648,139981);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_139874_139965(f_22075_139874_139945(f_22075_139874_139925(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 6, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,139997,140123);

f_22075_139997_140122(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,138575,140134);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,138575,140134);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,138575,140134);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalMultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,140146,142437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,140350,140552);

string 
source = @"
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1 = 1, i2 = 2;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,140566,141658);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'const int i ...  1, i2 = 2;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = 1, i2 = 2')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = 1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 1')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2 = 2')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= 2')
              ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,141672,142284);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_141906_141997(f_22075_141906_141977(f_22075_141906_141957(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 9, 29),
f_22075_142177_142268(f_22075_142177_142248(f_22075_142177_142228(ErrorCode.WRN_UnreferencedVarAssg, "i2"), "i2"), 9, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,142300,142426);

f_22075_142300_142425(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,140146,142437);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,140146,142437);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,140146,142437);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalDeclarationInvalidInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,142449,144046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,142662,142803);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1 = ;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,142817,143583);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'const int i1 = ;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1 = ')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = ')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= ')
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                Children(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,143597,143893);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_143792_143877(f_22075_143792_143857(f_22075_143792_143838(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,143909,144035);

f_22075_143909_144034(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,142449,144046);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,142449,144046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,142449,144046);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalMultipleDeclarationsInvalidInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,144058,146330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,144281,144429);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1 = , i2 = ;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,144443,145627);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'const int i1 = , i2 = ;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1 = , i2 = ')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = ')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= ')
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                Children(0)
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i2 = ')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= ')
              IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                Children(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,145641,146177);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_145843_145928(f_22075_145843_145908(f_22075_145843_145889(ErrorCode.ERR_InvalidExprTerm, ","), ","), 6, 34),
f_22075_146076_146161(f_22075_146076_146141(f_22075_146076_146122(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 6, 41)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,146193,146319);

f_22075_146193_146318(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,144058,146330);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,144058,146330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,144058,146330);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalDeclarationNoInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,146342,147943);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,146550,146688);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,146702,147238);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'const int i1;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,147252,147790);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_147462_147532(f_22075_147462_147512(ErrorCode.ERR_ConstValueRequired, "i1"), 6, 29),
f_22075_147687_147774(f_22075_147687_147754(f_22075_147687_147734(ErrorCode.WRN_UnreferencedVar, "i1"), "i1"), 6, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,147806,147932);

f_22075_147806_147931(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,146342,147943);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,146342,147943);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,146342,147943);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalMultipleDeclarationsNoInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,147955,150242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,148173,148315);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1, i2;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,148329,149053);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'const int i1, i2;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1, i2')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1')
          Initializer: 
            null
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i2')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,149067,150089);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_149281_149351(f_22075_149281_149331(ErrorCode.ERR_ConstValueRequired, "i1"), 6, 29),
f_22075_149511_149581(f_22075_149511_149561(ErrorCode.ERR_ConstValueRequired, "i2"), 6, 33),
f_22075_149740_149827(f_22075_149740_149807(f_22075_149740_149787(ErrorCode.WRN_UnreferencedVar, "i1"), "i1"), 6, 29),
f_22075_149986_150073(f_22075_149986_150053(f_22075_149986_150033(ErrorCode.WRN_UnreferencedVar, "i2"), "i2"), 6, 33)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,150105,150231);

f_22075_150105_150230(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,147955,150242);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,147955,150242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,147955,150242);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalInvalidMultipleDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,150254,152465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,150465,150604);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1,;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,150618,151332);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'const int i1,;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1,')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1')
          Initializer: 
            null
        IVariableDeclaratorOperation (Symbol: System.Int32 ) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: '')
          Initializer: 
            null
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,151346,152312);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_151557_151627(f_22075_151557_151607(ErrorCode.ERR_ConstValueRequired, "i1"), 6, 29),
f_22075_151758_151827(f_22075_151758_151807(ErrorCode.ERR_IdentifierExpected, ";"), 6, 32),
f_22075_151984_152053(f_22075_151984_152033(ErrorCode.ERR_ConstValueRequired, ";"), 6, 32),
f_22075_152209_152296(f_22075_152209_152276(f_22075_152209_152256(ErrorCode.WRN_UnreferencedVar, "i1"), "i1"), 6, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,152328,152454);

f_22075_152328_152453(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,150254,152465);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,150254,152465);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,150254,152465);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalDeclarationExpressionInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,152477,154315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,152693,152875);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1 = GetInt();/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,152889,153803);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'const int i1 = GetInt();')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1 = GetInt()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = GetInt()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= GetInt()')
              IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'GetInt()')
                Instance Receiver: 
                  null
                Arguments(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,153817,154162);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_154047_154146(f_22075_154047_154126(f_22075_154047_154106(ErrorCode.ERR_NotConstantExpression, "GetInt()"), "i1"), 6, 34)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,154178,154304);

f_22075_154178_154303(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,152477,154315);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,152477,154315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,152477,154315);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalMultipleDeclarationsExpressionInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,154327,157044);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,154553,154750);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        /*<bind>*/const int i1 = GetInt(), i2 = GetInt();/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,154764,156227);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null, IsInvalid) (Syntax: 'const int i ... = GetInt();')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null, IsInvalid) (Syntax: 'int i1 = Ge ...  = GetInt()')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i1 = GetInt()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= GetInt()')
              IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'GetInt()')
                Instance Receiver: 
                  null
                Arguments(0)
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null, IsInvalid) (Syntax: 'i2 = GetInt()')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null, IsInvalid) (Syntax: '= GetInt()')
              IInvocationOperation (System.Int32 Program.GetInt()) (OperationKind.Invocation, Type: System.Int32, IsInvalid) (Syntax: 'GetInt()')
                Instance Receiver: 
                  null
                Arguments(0)
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,156241,156891);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_156486_156585(f_22075_156486_156565(f_22075_156486_156545(ErrorCode.ERR_NotConstantExpression, "GetInt()"), "i1"), 6, 34),
f_22075_156776_156875(f_22075_156776_156855(f_22075_156776_156835(ErrorCode.ERR_NotConstantExpression, "GetInt()"), "i2"), 6, 49)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,156907,157033);

f_22075_156907_157032(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,154327,157044);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,154327,157044);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,154327,157044);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalDeclarationLocalReferenceInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,157056,158716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,157276,157477);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        const int i = 1;
        /*<bind>*/const int i1 = i;/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,157491,158216);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'const int i1 = i;')
  IVariableDeclarationOperation (1 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = i')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = i')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i')
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32, Constant: 1) (Syntax: 'i')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,158230,158563);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_158456_158547(f_22075_158456_158527(f_22075_158456_158507(ErrorCode.WRN_UnreferencedVarAssg, "i1"), "i1"), 7, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,158579,158705);

f_22075_158579_158704(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,157056,158716);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,157056,158716);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,157056,158716);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact, WorkItem(17599, "https://github.com/dotnet/roslyn/issues/17599")]
        public void ConstLocalMultipleDeclarationsLocalReferenceInitializers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,158728,160822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,158958,159168);

string 
source = @"
class Program
{
    static void Main(string[] args)
    {
        const int i = 1;
        /*<bind>*/const int i1 = i, i2 = i1;/*</bind>*/
    }

    static int GetInt() => 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,159182,160313);

string 
expectedOperationTree = @"
IVariableDeclarationGroupOperation (1 declarations) (OperationKind.VariableDeclarationGroup, Type: null) (Syntax: 'const int i ... i, i2 = i1;')
  IVariableDeclarationOperation (2 declarators) (OperationKind.VariableDeclaration, Type: null) (Syntax: 'int i1 = i, i2 = i1')
    Declarators:
        IVariableDeclaratorOperation (Symbol: System.Int32 i1) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i1 = i')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i')
              ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32, Constant: 1) (Syntax: 'i')
        IVariableDeclaratorOperation (Symbol: System.Int32 i2) (OperationKind.VariableDeclarator, Type: null) (Syntax: 'i2 = i1')
          Initializer: 
            IVariableInitializerOperation (OperationKind.VariableInitializer, Type: null) (Syntax: '= i1')
              ILocalReferenceOperation: i1 (OperationKind.LocalReference, Type: System.Int32, Constant: 1) (Syntax: 'i1')
    Initializer: 
      null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,160327,160669);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_160562_160653(f_22075_160562_160633(f_22075_160562_160613(ErrorCode.WRN_UnreferencedVarAssg, "i2"), "i2"), 7, 37)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,160685,160811);

f_22075_160685_160810(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,158728,160822);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,158728,160822);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,158728,160822);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,160892,163616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,161048,161285);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int a = 1;
        var b = 2;
        int c = 3, d = 4;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,161299,161352);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,161368,163493);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 b] [System.Int32 c] [System.Int32 d]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (4)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 1')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = 2')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = 2')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'c = 3')
              Left: 
                ILocalReferenceOperation: c (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'c = 3')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = 4')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = 4')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 4) (Syntax: '4')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,163507,163605);

f_22075_163507_163604(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,160892,163616);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,160892,163616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,160892,163616);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,163628,165102);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,163784,163986);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int a;
        a = 1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,164000,164053);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,164069,164979);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 a]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'a = 1')
                  Left: 
                    ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,164993,165091);

f_22075_164993_165090(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,163628,165102);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,163628,165102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,163628,165102);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,165114,167559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,165270,165488);

string 
source = @"
class C
{
    void M(bool a, int b, int c)
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int d = a ? b : c;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,165502,165555);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,165571,167436);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 d]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
              Value: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = a ? b : c')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = a ? b : c')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ? b : c')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,167450,167548);

f_22075_167450_167547(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,165114,167559);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,165114,167559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,165114,167559);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,167571,169179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,167727,167916);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int d = ;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,167930,168198);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_168097_168182(f_22075_168097_168162(f_22075_168097_168143(ErrorCode.ERR_InvalidExprTerm, ";"), ";"), 7, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,168214,169056);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 d]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd = ')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd = ')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: '')
                  Children(0)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,169070,169168);

f_22075_169070_169167(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,167571,169179);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,167571,169179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,167571,169179);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,169191,170551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,169347,169543);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        const int d = 1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,169557,169610);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,169626,170428);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 d]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = 1')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,170442,170540);

f_22075_170442_170539(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,169191,170551);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,169191,170551);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,169191,170551);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_05_WithControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,170563,173019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,170735,170942);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        const int d = true ? 1 : 2;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,170956,171009);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,171025,172896);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 d]
    CaptureIds: [0]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

        Next (Regular) Block[B2]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '1')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B4]
    Block[B3] - Block [UnReachable]
        Predecessors: [B1]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: '2')
              Value: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 2) (Syntax: '2')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = true ? 1 : 2')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = true ? 1 : 2')
              Right: 
                IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, Constant: 1, IsImplicit) (Syntax: 'true ? 1 : 2')

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,172910,173008);

f_22075_172910_173007(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,170563,173019);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,170563,173019);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,170563,173019);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,173031,175042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,173187,173381);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int d[10] = 1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,173395,174071);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_173726_173791(f_22075_173726_173771(ErrorCode.ERR_CStyleArray, "[10]"), 7, 14),
f_22075_173981_174055(f_22075_173981_174035(ErrorCode.ERR_ArraySizeInDeclaration, "10"), 7, 15)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,174087,174919);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 d]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd[10] = 1')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'd[10] = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,174933,175031);

f_22075_174933_175030(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,173031,175042);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,173031,175042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,173031,175042);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,175054,176612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,175210,175398);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int = 5;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,175412,175655);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_175570_175639(f_22075_175570_175619(ErrorCode.ERR_IdentifierExpected, "="), 7, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,175671,176489);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 ]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= 5')
              Left: 
                ILocalReferenceOperation:  (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '= 5')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 5) (Syntax: '5')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,176503,176601);

f_22075_176503_176600(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,175054,176612);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,175054,176612);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,175054,176612);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,176624,178467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,176780,176998);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int a = 1;
        ref int b = ref a;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,177012,177065);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,177081,178344);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 b]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 1')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = ref a')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = ref a')
              Right: 
                ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'a')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,178358,178456);

f_22075_178358_178455(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,176624,178467);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,176624,178467);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,176624,178467);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,178479,180096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,178635,178851);

string 
source = @"
class C
{
    int _c = 1;
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        ref int b = ref _c;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,178865,178918);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,178934,179973);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 b]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'b = ref _c')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'b = ref _c')
              Right: 
                IFieldReferenceOperation: System.Int32 C._c (OperationKind.FieldReference, Type: System.Int32) (Syntax: '_c')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: '_c')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,179987,180085);

f_22075_179987_180084(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,178479,180096);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,178479,180096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,178479,180096);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,180108,182124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,180264,180458);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        ref int b = 1;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,180472,180988);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_180671_180764(f_22075_180671_180744(ErrorCode.ERR_InitializeByReferenceVariableWithValue, "b = 1"), 7, 17),
f_22075_180904_180972(f_22075_180904_180952(ErrorCode.ERR_RefLvalueExpected, "1"), 7, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,181004,182001);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 b]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b = 1')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b = 1')
              Right: 
                IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: '1')
                  Children(1):
                      ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1, IsInvalid) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,182015,182113);

f_22075_182015_182112(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,180108,182124);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,180108,182124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,180108,182124);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,182136,184255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,182292,182506);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int a = 1;
        ref int b = a;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,182520,182828);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_182719_182812(f_22075_182719_182792(ErrorCode.ERR_InitializeByReferenceVariableWithValue, "b = a"), 8, 17)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,182844,184132);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 a] [System.Int32 b]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (2)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'a = 1')
              Left: 
                ILocalReferenceOperation: a (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'a = 1')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

            ISimpleAssignmentOperation (IsRef) (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b = a')
              Left: 
                ILocalReferenceOperation: b (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'b = a')
              Right: 
                ILocalReferenceOperation: a (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'a')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,184146,184244);

f_22075_184146_184243(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,182136,184255);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,182136,184255);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,182136,184255);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,184267,187472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,184423,184648);

string 
source = @"
class C
{
    void M(bool a, int b, int c)
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        int d = b, e = a ? b : c;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,184662,184715);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,184731,187349);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 d] [System.Int32 e]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'd = b')
              Left: 
                ILocalReferenceOperation: d (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'd = b')
              Right: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [0]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (0)
            Jump if False (Regular) to Block[B4]
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'b')
                  Value: 
                    IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'b')

            Next (Regular) Block[B5]
        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
                  Value: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'c')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsImplicit) (Syntax: 'e = a ? b : c')
                  Left: 
                    ILocalReferenceOperation: e (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsImplicit) (Syntax: 'e = a ? b : c')
                  Right: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'a ? b : c')

            Next (Regular) Block[B6]
                Leaving: {R2} {R1}
    }
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,187363,187461);

f_22075_187363_187460(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,184267,187472);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,184267,187472);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,184267,187472);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void VariableDeclaration_13()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22075,187484,189222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,187640,187842);

string 
source = @"
class C
{
    void M()
    /*<bind>*/{
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        a = 1;
        int a;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,187856,188158);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22075_188044_188142(f_22075_188044_188123(f_22075_188044_188104(ErrorCode.ERR_VariableUsedBeforeDeclaration, "a"), "a"), 7, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,188174,189099);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 a]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'a = 1;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: var, IsInvalid) (Syntax: 'a = 1')
                  Left: 
                    ILocalReferenceOperation: a (OperationKind.LocalReference, Type: var, IsInvalid) (Syntax: 'a')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22075,189113,189211);

f_22075_189113_189210(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22075,187484,189222);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22075,187484,189222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22075,187484,189222);
}
		}

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_1709_1756(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 1709, 1756);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_1709_1776(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 1709, 1776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_1709_1796(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 1709, 1796);
return return_v;
}


int
f_22075_1828_1953(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 1828, 1953);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_3270_3321(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 3270, 3321);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_3270_3341(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 3270, 3341);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_3270_3361(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 3270, 3361);
return return_v;
}


int
f_22075_3393_3518(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 3393, 3518);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_4868_4914(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 4868, 4914);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_4868_4933(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 4868, 4933);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_4868_4953(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 4868, 4953);
return return_v;
}


int
f_22075_4985_5110(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 4985, 5110);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_6373_6420(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 6373, 6420);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_6373_6440(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 6373, 6440);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_6373_6460(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 6373, 6460);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_6613_6660(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 6613, 6660);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_6613_6680(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 6613, 6680);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_6613_6700(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 6613, 6700);
return return_v;
}


int
f_22075_6732_6857(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 6732, 6857);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_8575_8626(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 8575, 8626);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_8575_8646(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 8575, 8646);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_8575_8666(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 8575, 8666);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_8840_8891(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 8840, 8891);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_8840_8911(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 8840, 8911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_8840_8931(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 8840, 8931);
return return_v;
}


int
f_22075_8963_9088(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 8963, 9088);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_10838_10884(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 10838, 10884);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_10838_10903(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 10838, 10903);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_10838_10923(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 10838, 10923);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_11096_11147(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 11096, 11147);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_11096_11167(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 11096, 11167);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_11096_11187(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 11096, 11187);
return return_v;
}


int
f_22075_11219_11344(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 11219, 11344);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_12607_12656(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 12607, 12656);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_12607_12676(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 12607, 12676);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_12824_12870(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 12824, 12870);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_12824_12889(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 12824, 12889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_12824_12909(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 12824, 12909);
return return_v;
}


int
f_22075_12941_13066(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 12941, 13066);
return 0;
}


int
f_22075_14424_14549(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 14424, 14549);
return 0;
}


int
f_22075_16454_16579(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 16454, 16579);
return 0;
}


int
f_22075_17746_17871(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 17746, 17871);
return 0;
}


int
f_22075_19442_19567(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 19442, 19567);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_20947_21005(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 20947, 21005);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_20947_21025(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 20947, 21025);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_21201_21247(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 21201, 21247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_21201_21266(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 21201, 21266);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_21201_21286(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 21201, 21286);
return return_v;
}


int
f_22075_21318_21443(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 21318, 21443);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23013_23071(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23013, 23071);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23013_23091(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23013, 23091);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23270_23316(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23270, 23316);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23270_23335(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23270, 23335);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23270_23355(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23270, 23355);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23534_23580(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23534, 23580);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23534_23599(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23534, 23599);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_23534_23619(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23534, 23619);
return return_v;
}


int
f_22075_23651_23776(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 23651, 23776);
return 0;
}


int
f_22075_24414_24531(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<EqualsValueClauseSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 24414, 24531);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_25731_25776(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 25731, 25776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_25731_25796(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 25731, 25796);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_26007_26061(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 26007, 26061);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_26007_26081(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 26007, 26081);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_26249_26299(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 26249, 26299);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_26249_26318(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 26249, 26318);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_26249_26338(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 26249, 26338);
return return_v;
}


int
f_22075_26370_26488(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 26370, 26488);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_27489_27534(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 27489, 27534);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_27489_27554(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 27489, 27554);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_27761_27815(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 27761, 27815);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_27761_27835(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 27761, 27835);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_27986_28032(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 27986, 28032);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_27986_28051(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 27986, 28051);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_27986_28071(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 27986, 28071);
return return_v;
}


int
f_22075_28103_28221(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclaratorSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28103, 28221);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22075_28572_28602(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28572, 28602);
return return_v;
}


(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
f_22075_28638_28705(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = GetOperationAndSyntaxForTest<VariableDeclaratorSyntax>( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28638, 28705);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_28807_28826(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 28807, 28826);
return return_v;
}


int
f_22075_28807_28834(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.Count<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28807, 28834);
return return_v;
}


int
f_22075_28791_28835(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28791, 28835);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_28886_28905(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 28886, 28905);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_28886_28913(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28886, 28913);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_28886_28918(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 28886, 28918);
return return_v;
}


int
f_22075_28850_28919(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28850, 28919);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_28982_29001(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 28982, 29001);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_28982_29014(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source,int
index)
{
var return_v = source.ElementAt<Microsoft.CodeAnalysis.IOperation>( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28982, 29014);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_28982_29019(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 28982, 29019);
return return_v;
}


int
f_22075_28934_29020(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 28934, 29020);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22075_29352_29382(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 29352, 29382);
return return_v;
}


(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
f_22075_29418_29485(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = GetOperationAndSyntaxForTest<VariableDeclaratorSyntax>( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 29418, 29485);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_29587_29606(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 29587, 29606);
return return_v;
}


int
f_22075_29587_29614(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.Count<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 29587, 29614);
return return_v;
}


int
f_22075_29571_29615(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 29571, 29615);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_29666_29685(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 29666, 29685);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_29666_29693(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 29666, 29693);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_29666_29698(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 29666, 29698);
return return_v;
}


int
f_22075_29630_29699(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 29630, 29699);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22075_30023_30053(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30023, 30053);
return return_v;
}


(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
f_22075_30089_30156(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = GetOperationAndSyntaxForTest<VariableDeclaratorSyntax>( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30089, 30156);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_30258_30277(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 30258, 30277);
return return_v;
}


int
f_22075_30258_30285(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.Count<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30258, 30285);
return return_v;
}


int
f_22075_30242_30286(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30242, 30286);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_30349_30368(Microsoft.CodeAnalysis.Operations.IVariableDeclaratorOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 30349, 30368);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_30349_30381(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source,int
index)
{
var return_v = source.ElementAt<Microsoft.CodeAnalysis.IOperation>( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30349, 30381);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_30349_30386(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 30349, 30386);
return return_v;
}


int
f_22075_30301_30387(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30301, 30387);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22075_30687_30717(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30687, 30717);
return return_v;
}


(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
f_22075_30753_30820(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = GetOperationAndSyntaxForTest<VariableDeclaratorSyntax>( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30753, 30820);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_30848_30866(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 30848, 30866);
return return_v;
}


int
f_22075_30835_30867(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 30835, 30867);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_32685_32741(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 32685, 32741);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_32685_32761(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 32685, 32761);
return return_v;
}


int
f_22075_32793_32912(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 32793, 32912);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_34026_34082(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 34026, 34082);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_34026_34102(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 34026, 34102);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_34276_34322(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 34276, 34322);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_34276_34341(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 34276, 34341);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_34276_34361(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 34276, 34361);
return return_v;
}


int
f_22075_34393_34512(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 34393, 34512);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_35651_35707(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 35651, 35707);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_35651_35727(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 35651, 35727);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_35903_35949(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 35903, 35949);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_35903_35968(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 35903, 35968);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_35903_35988(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 35903, 35988);
return return_v;
}


int
f_22075_36020_36139(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 36020, 36139);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_37400_37457(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37400, 37457);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_37400_37477(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37400, 37477);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_37635_37678(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37635, 37678);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_37635_37698(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37635, 37698);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_37873_37919(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37873, 37919);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_37873_37938(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37873, 37938);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_37873_37958(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37873, 37958);
return return_v;
}


int
f_22075_37990_38109(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 37990, 38109);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22075_38465_38495(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38465, 38495);
return return_v;
}


(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
f_22075_38531_38599(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = GetOperationAndSyntaxForTest<VariableDeclarationSyntax>( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38531, 38599);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_38703_38723(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 38703, 38723);
return return_v;
}


int
f_22075_38703_38731(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.Count<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38703, 38731);
return return_v;
}


int
f_22075_38687_38732(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38687, 38732);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_38783_38803(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 38783, 38803);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_38783_38811(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38783, 38811);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_38783_38816(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 38783, 38816);
return return_v;
}


int
f_22075_38747_38817(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38747, 38817);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_38879_38899(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 38879, 38899);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_38879_38912(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source,int
index)
{
var return_v = source.ElementAt<Microsoft.CodeAnalysis.IOperation>( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38879, 38912);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_38879_38917(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 38879, 38917);
return return_v;
}


int
f_22075_38832_38918(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 38832, 38918);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22075_39251_39281(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39251, 39281);
return return_v;
}


(Microsoft.CodeAnalysis.IOperation operation, Microsoft.CodeAnalysis.SyntaxNode node)
f_22075_39317_39385(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = GetOperationAndSyntaxForTest<VariableDeclarationSyntax>( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39317, 39385);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_39489_39509(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 39489, 39509);
return return_v;
}


int
f_22075_39489_39517(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.Count<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39489, 39517);
return return_v;
}


int
f_22075_39473_39518(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39473, 39518);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_39569_39589(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 39569, 39589);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_39569_39597(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.IOperation>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39569, 39597);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_39569_39602(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 39569, 39602);
return return_v;
}


int
f_22075_39533_39603(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39533, 39603);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
f_22075_39665_39685(Microsoft.CodeAnalysis.Operations.IVariableDeclarationOperation
this_param)
{
var return_v = this_param.Children;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 39665, 39685);
return return_v;
}


Microsoft.CodeAnalysis.IOperation
f_22075_39665_39698(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
source,int
index)
{
var return_v = source.ElementAt<Microsoft.CodeAnalysis.IOperation>( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39665, 39698);
return return_v;
}


Microsoft.CodeAnalysis.OperationKind
f_22075_39665_39703(Microsoft.CodeAnalysis.IOperation
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 39665, 39703);
return return_v;
}


int
f_22075_39618_39704(Microsoft.CodeAnalysis.OperationKind
expected,Microsoft.CodeAnalysis.OperationKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 39618, 39704);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_40459_40536(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 40459, 40536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_40459_40556(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 40459, 40556);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_40730_40776(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 40730, 40776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_40730_40795(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 40730, 40795);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_40730_40815(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 40730, 40815);
return return_v;
}


int
f_22075_40847_40957(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 40847, 40957);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_41307_41350(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = Parse( text, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41307, 41350);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22075_41376_41399(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41376, 41399);
return return_v;
}


Microsoft.CodeAnalysis.SemanticModel
f_22075_41426_41481(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree,bool
ignoreAccessibility)
{
var return_v = this_param.GetSemanticModel( syntaxTree, ignoreAccessibility:ignoreAccessibility);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41426, 41481);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22075_41508_41555(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41508, 41555);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>
f_22075_41590_41629(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41590, 41629);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
f_22075_41590_41642(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>
source,int
index)
{
var return_v = source.ElementAt<Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax>( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41590, 41642);
return return_v;
}


string
f_22075_41679_41701(Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41679, 41701);
return return_v;
}


int
f_22075_41659_41702(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41659, 41702);
return 0;
}


Microsoft.CodeAnalysis.TypeInfo
f_22075_41746_41776(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
node)
{
var return_v = this_param.GetTypeInfo( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41746, 41776);
return return_v;
}


string
f_22075_41746_41803(Microsoft.CodeAnalysis.ITypeSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41746, 41803);
return return_v;
}


int
f_22075_41717_41804(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41717, 41804);
return 0;
}


Microsoft.CodeAnalysis.TypeInfo
f_22075_41848_41878(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
node)
{
var return_v = this_param.GetTypeInfo( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41848, 41878);
return return_v;
}


string
f_22075_41848_41914(Microsoft.CodeAnalysis.ITypeSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41848, 41914);
return return_v;
}


int
f_22075_41819_41915(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41819, 41915);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_22075_41964_41996(Microsoft.CodeAnalysis.SemanticModel
semanticModel,Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
expression)
{
var return_v = semanticModel.GetConversion( (Microsoft.CodeAnalysis.SyntaxNode)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41964, 41996);
return return_v;
}


int
f_22075_41930_41997(Microsoft.CodeAnalysis.CSharp.Conversion
expected,Microsoft.CodeAnalysis.CSharp.Conversion
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 41930, 41997);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>
f_22075_42030_42072(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42030, 42072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
f_22075_42030_42085(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>
source,int
index)
{
var return_v = source.ElementAt<Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax>( index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42030, 42085);
return return_v;
}


string
f_22075_42124_42144(Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42124, 42144);
return return_v;
}


int
f_22075_42102_42145(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42102, 42145);
return 0;
}


Microsoft.CodeAnalysis.TypeInfo
f_22075_42189_42217(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
node)
{
var return_v = this_param.GetTypeInfo( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42189, 42217);
return return_v;
}


string
f_22075_42189_42244(Microsoft.CodeAnalysis.ITypeSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42189, 42244);
return return_v;
}


int
f_22075_42160_42245(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42160, 42245);
return 0;
}


Microsoft.CodeAnalysis.TypeInfo
f_22075_42289_42317(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
node)
{
var return_v = this_param.GetTypeInfo( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42289, 42317);
return return_v;
}


string
f_22075_42289_42353(Microsoft.CodeAnalysis.ITypeSymbol?
symbol)
{
var return_v = symbol.ToTestDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42289, 42353);
return return_v;
}


int
f_22075_42260_42354(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42260, 42354);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_22075_42403_42433(Microsoft.CodeAnalysis.SemanticModel
semanticModel,Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
expression)
{
var return_v = semanticModel.GetConversion( (Microsoft.CodeAnalysis.SyntaxNode)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42403, 42433);
return return_v;
}


int
f_22075_42369_42434(Microsoft.CodeAnalysis.CSharp.Conversion
expected,Microsoft.CodeAnalysis.CSharp.Conversion
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42369, 42434);
return 0;
}


Microsoft.CodeAnalysis.SymbolInfo
f_22075_42467_42497(Microsoft.CodeAnalysis.SemanticModel
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax
node)
{
var return_v = this_param.GetSymbolInfo( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42467, 42497);
return return_v;
}


int
f_22075_42512_42544(Microsoft.CodeAnalysis.ISymbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42512, 42544);
return 0;
}


Microsoft.CodeAnalysis.SymbolKind
f_22075_42591_42612(Microsoft.CodeAnalysis.ISymbol?
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 42591, 42612);
return return_v;
}


int
f_22075_42559_42613(Microsoft.CodeAnalysis.SymbolKind
expected,Microsoft.CodeAnalysis.SymbolKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42559, 42613);
return 0;
}


string
f_22075_42647_42676(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.MetadataName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 42647, 42676);
return return_v;
}


int
f_22075_42628_42677(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 42628, 42677);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_44895_44962(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 44895, 44962);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_44895_44982(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 44895, 44982);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_45180_45230(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 45180, 45230);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_45180_45249(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 45180, 45249);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_45180_45269(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 45180, 45269);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_45454_45500(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 45454, 45500);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_45454_45519(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 45454, 45519);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_45454_45539(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 45454, 45539);
return return_v;
}


int
f_22075_45571_45690(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 45571, 45690);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_47932_47999(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 47932, 47999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_47932_48019(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 47932, 48019);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48218_48268(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48218, 48268);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48218_48287(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48218, 48287);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48218_48307(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48218, 48307);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48551_48621(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48551, 48621);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48551_48641(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48551, 48641);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48827_48873(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48827, 48873);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48827_48892(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48827, 48892);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_48827_48912(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48827, 48912);
return return_v;
}


int
f_22075_48944_49063(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 48944, 49063);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_51314_51381(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 51314, 51381);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_51314_51401(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 51314, 51401);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_51603_51653(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 51603, 51653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_51603_51672(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 51603, 51672);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_51603_51692(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 51603, 51692);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_51901_51968(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 51901, 51968);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_51901_51988(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 51901, 51988);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_52177_52223(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 52177, 52223);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_52177_52242(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 52177, 52242);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_52177_52262(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 52177, 52262);
return return_v;
}


int
f_22075_52294_52413(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 52294, 52413);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_54679_54746(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 54679, 54746);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_54679_54766(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 54679, 54766);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_54969_55019(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 54969, 55019);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_54969_55038(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 54969, 55038);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_54969_55058(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 54969, 55058);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_55306_55376(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 55306, 55376);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_55306_55396(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 55306, 55396);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_55606_55673(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 55606, 55673);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_55606_55693(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 55606, 55693);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_55883_55929(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 55883, 55929);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_55883_55948(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 55883, 55948);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_55883_55968(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 55883, 55968);
return return_v;
}


int
f_22075_56000_56119(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 56000, 56119);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_57386_57442(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 57386, 57442);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_57386_57462(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 57386, 57462);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_57696_57752(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 57696, 57752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_57696_57772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 57696, 57772);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_57952_57998(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 57952, 57998);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_57952_58017(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 57952, 58017);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_57952_58037(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 57952, 58037);
return return_v;
}


int
f_22075_58069_58188(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58069, 58188);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_58572_58606(string
text,string
filename)
{
var return_v = Parse( text, filename:filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58572, 58606);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22075_58644_58697(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58644, 58697);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
f_22075_58644_58732(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58644, 58732);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_58644_58740(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58644, 58740);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_22075_58968_58993(int
value)
{
var return_v = SyntaxFactory.Literal( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58968, 58993);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
f_22075_58899_58994(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind,Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = SyntaxFactory.LiteralExpression( kind, token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58899, 58994);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
f_22075_58869_58995(params Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
nodesAndTokens)
{
var return_v = SyntaxFactory.NodeOrTokenList( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58869, 58995);
return return_v;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
f_22075_58823_58996(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
nodesAndTokens)
{
var return_v = SyntaxFactory.SeparatedList<ExpressionSyntax>( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58823, 58996);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_58778_58997(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
this_param,Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
sizes)
{
var return_v = this_param.WithSizes( sizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 58778, 58997);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
f_22075_59025_59108(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
root,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
oldNode,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
newNode)
{
var return_v = root.ReplaceNode<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax>( (Microsoft.CodeAnalysis.SyntaxNode)oldNode, (Microsoft.CodeAnalysis.SyntaxNode)newNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 59025, 59108);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_59025_59119(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.SyntaxTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 59025, 59119);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_59993_60049(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 59993, 60049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_59993_60069(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 59993, 60069);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_60254_60300(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 60254, 60300);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_60254_60319(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 60254, 60319);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_60254_60339(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 60254, 60339);
return return_v;
}


int
f_22075_60371_60504(Microsoft.CodeAnalysis.SyntaxTree[]
testSyntaxes,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSyntaxes, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 60371, 60504);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_61577_61633(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 61577, 61633);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_61577_61653(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 61577, 61653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_61824_61870(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 61824, 61870);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_61824_61889(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 61824, 61889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_61824_61909(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 61824, 61909);
return return_v;
}


int
f_22075_61941_62060(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 61941, 62060);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_63887_63937(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 63887, 63937);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_63887_63956(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 63887, 63956);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_63887_63976(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 63887, 63976);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64212_64276(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64212, 64276);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64212_64296(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64212, 64296);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64479_64533(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64479, 64533);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64479_64562(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64479, 64562);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64479_64582(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64479, 64582);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64764_64810(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64764, 64810);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64764_64829(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64764, 64829);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_64764_64849(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64764, 64849);
return return_v;
}


int
f_22075_64881_65000(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 64881, 65000);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_67852_67902(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 67852, 67902);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_67852_67921(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 67852, 67921);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_67852_67941(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 67852, 67941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_68194_68275(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 68194, 68275);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_68194_68295(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 68194, 68295);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_68494_68540(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 68494, 68540);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_68494_68559(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 68494, 68559);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_68494_68579(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 68494, 68579);
return return_v;
}


int
f_22075_68611_68730(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 68611, 68730);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_70599_70648(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 70599, 70648);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_70599_70667(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 70599, 70667);
return return_v;
}


int
f_22075_70699_70818(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 70699, 70818);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_73541_73590(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 73541, 73590);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_73541_73609(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 73541, 73609);
return return_v;
}


int
f_22075_73641_73760(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 73641, 73760);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75120_75166(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75120, 75166);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75120_75185(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75120, 75185);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75120_75206(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75120, 75206);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75342_75391(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75342, 75391);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75342_75410(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75342, 75410);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75526_75575(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75526, 75575);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75526_75603(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75526, 75603);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_75526_75622(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75526, 75622);
return return_v;
}


int
f_22075_75654_75773(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 75654, 75773);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_77579_77625(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 77579, 77625);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_77579_77644(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 77579, 77644);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_77579_77665(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 77579, 77665);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_77819_77865(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 77819, 77865);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_77819_77884(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 77819, 77884);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_77819_77905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 77819, 77905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78041_78090(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78041, 78090);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78041_78109(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78041, 78109);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78229_78278(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78229, 78278);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78229_78306(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78229, 78306);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78229_78326(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78229, 78326);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78446_78495(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78446, 78495);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78446_78523(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78446, 78523);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_78446_78542(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78446, 78542);
return return_v;
}


int
f_22075_78574_78693(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 78574, 78693);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_79780_79829(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 79780, 79829);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_79780_79848(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 79780, 79848);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_80037_80081(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 80037, 80081);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_80037_80102(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 80037, 80102);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_80218_80267(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 80218, 80267);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_80218_80295(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 80218, 80295);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_80218_80314(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 80218, 80314);
return return_v;
}


int
f_22075_80346_80465(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 80346, 80465);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_81764_81813(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 81764, 81813);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_81764_81832(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 81764, 81832);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82026_82071(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82026, 82071);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82026_82092(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82026, 82092);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82286_82331(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82286, 82331);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82286_82352(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82286, 82352);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82472_82521(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82472, 82521);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82472_82549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82472, 82549);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82472_82569(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82472, 82569);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82689_82738(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82689, 82738);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82689_82766(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82689, 82766);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_82689_82785(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82689, 82785);
return return_v;
}


int
f_22075_82817_82936(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 82817, 82936);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_84970_85019(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 84970, 85019);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_84970_85040(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 84970, 85040);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_85176_85225(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85176, 85225);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_85176_85244(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85176, 85244);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_85451_85494(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85451, 85494);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_85451_85515(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85451, 85515);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_85635_85684(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85635, 85684);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_85635_85712(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85635, 85712);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_85635_85732(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85635, 85732);
return return_v;
}


int
f_22075_85764_85883(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 85764, 85883);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_88994_89044(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 88994, 89044);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_88994_89063(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 88994, 89063);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_88994_89083(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 88994, 89083);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_89239_89288(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 89239, 89288);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_89239_89307(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 89239, 89307);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_89580_89662(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 89580, 89662);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_89580_89682(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 89580, 89682);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_89928_89983(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 89928, 89983);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_89928_90003(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 89928, 90003);
return return_v;
}


int
f_22075_90035_90154(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 90035, 90154);
return 0;
}


int
f_22075_91487_91606(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 91487, 91606);
return 0;
}


int
f_22075_93405_93524(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 93405, 93524);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_94843_94889(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 94843, 94889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_94843_94908(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 94843, 94908);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_94843_94928(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 94843, 94928);
return return_v;
}


int
f_22075_94960_95079(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 94960, 95079);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_96822_96868(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 96822, 96868);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_96822_96887(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 96822, 96887);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_96822_96907(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 96822, 96907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_97058_97104(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 97058, 97104);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_97058_97123(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 97058, 97123);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_97058_97143(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 97058, 97143);
return return_v;
}


int
f_22075_97175_97294(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 97175, 97294);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_98397_98442(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 98397, 98442);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_98397_98462(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 98397, 98462);
return return_v;
}


int
f_22075_98494_98613(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 98494, 98613);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_99918_99963(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 99918, 99963);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_99918_99983(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 99918, 99983);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_100176_100221(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 100176, 100221);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_100176_100241(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 100176, 100241);
return return_v;
}


int
f_22075_100273_100392(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 100273, 100392);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_101997_102046(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 101997, 102046);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_101997_102066(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 101997, 102066);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_102272_102315(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 102272, 102315);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_102272_102335(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 102272, 102335);
return return_v;
}


int
f_22075_102367_102486(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 102367, 102486);
return 0;
}


int
f_22075_103818_103937(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 103818, 103937);
return 0;
}


int
f_22075_105799_105918(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 105799, 105918);
return 0;
}


int
f_22075_107082_107201(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 107082, 107201);
return 0;
}


int
f_22075_108760_108879(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 108760, 108879);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_109188_109222(string
text,string
filename)
{
var return_v = Parse( text, filename:filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109188, 109222);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22075_109260_109313(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109260, 109313);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
f_22075_109260_109348(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109260, 109348);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_109260_109356(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109260, 109356);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_22075_109515_109572(string
text)
{
var return_v = SyntaxFactory.ParseExpression( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109515, 109572);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
f_22075_109485_109573(params Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
nodesAndTokens)
{
var return_v = SyntaxFactory.NodeOrTokenList( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109485, 109573);
return return_v;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
f_22075_109439_109574(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
nodesAndTokens)
{
var return_v = SyntaxFactory.SeparatedList<ExpressionSyntax>( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109439, 109574);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_109394_109575(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
this_param,Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
sizes)
{
var return_v = this_param.WithSizes( sizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109394, 109575);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
f_22075_109603_109686(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
root,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
oldNode,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
newNode)
{
var return_v = root.ReplaceNode<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax>( (Microsoft.CodeAnalysis.SyntaxNode)oldNode, (Microsoft.CodeAnalysis.SyntaxNode)newNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 109603, 109686);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_109603_109697(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.SyntaxTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 109603, 109697);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_111779_111829(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 111779, 111829);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_111779_111848(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 111779, 111848);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_111779_111868(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 111779, 111868);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_112135_112222(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 112135, 112222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_112135_112245(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 112135, 112245);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_112135_112265(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 112135, 112265);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_112536_112614(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 112536, 112614);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_112536_112634(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 112536, 112634);
return return_v;
}


int
f_22075_112667_112800(Microsoft.CodeAnalysis.SyntaxTree[]
testSyntaxes,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSyntaxes, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 112667, 112800);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_113112_113146(string
text,string
filename)
{
var return_v = Parse( text, filename:filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113112, 113146);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22075_113184_113237(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113184, 113237);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
f_22075_113184_113272(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113184, 113272);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_113184_113280(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113184, 113280);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_22075_113439_113496(string
text)
{
var return_v = SyntaxFactory.ParseExpression( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113439, 113496);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
f_22075_113409_113497(params Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
nodesAndTokens)
{
var return_v = SyntaxFactory.NodeOrTokenList( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113409, 113497);
return return_v;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
f_22075_113363_113498(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
nodesAndTokens)
{
var return_v = SyntaxFactory.SeparatedList<ExpressionSyntax>( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113363, 113498);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_113318_113499(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
this_param,Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
sizes)
{
var return_v = this_param.WithSizes( sizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113318, 113499);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
f_22075_113527_113610(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
root,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
oldNode,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
newNode)
{
var return_v = root.ReplaceNode<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax>( (Microsoft.CodeAnalysis.SyntaxNode)oldNode, (Microsoft.CodeAnalysis.SyntaxNode)newNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 113527, 113610);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_113527_113621(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.SyntaxTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 113527, 113621);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_115703_115753(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 115703, 115753);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_115703_115772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 115703, 115772);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_115703_115792(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 115703, 115792);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_116058_116145(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116058, 116145);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_116058_116168(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116058, 116168);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_116058_116188(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116058, 116188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_116458_116536(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116458, 116536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_116458_116556(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116458, 116556);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_116762_116822(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116762, 116822);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_116762_116842(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116762, 116842);
return return_v;
}


int
f_22075_116874_117007(Microsoft.CodeAnalysis.SyntaxTree[]
testSyntaxes,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSyntaxes, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 116874, 117007);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_119391_119441(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 119391, 119441);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_119391_119460(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 119391, 119460);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_119391_119480(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 119391, 119480);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_119743_119858(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 119743, 119858);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_119743_119881(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 119743, 119881);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_119743_119900(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 119743, 119900);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_120168_120246(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 120168, 120246);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_120168_120266(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 120168, 120266);
return return_v;
}


int
f_22075_120298_120417(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 120298, 120417);
return 0;
}


int
f_22075_121510_121629(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 121510, 121629);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_123221_123271(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 123221, 123271);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_123221_123290(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 123221, 123290);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_123221_123310(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 123221, 123310);
return return_v;
}


int
f_22075_123342_123461(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 123342, 123461);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_124719_124765(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 124719, 124765);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_124719_124784(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 124719, 124784);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_124719_124804(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 124719, 124804);
return return_v;
}


int
f_22075_124836_124955(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 124836, 124955);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_126639_126685(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 126639, 126685);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_126639_126704(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 126639, 126704);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_126639_126724(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 126639, 126724);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_126879_126925(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 126879, 126925);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_126879_126944(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 126879, 126944);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_126879_126964(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 126879, 126964);
return return_v;
}


int
f_22075_126996_127115(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 126996, 127115);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_128098_128144(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 128098, 128144);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_128098_128163(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 128098, 128163);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_128098_128183(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 128098, 128183);
return return_v;
}


int
f_22075_128215_128334(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 128215, 128334);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_129507_129553(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 129507, 129553);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_129507_129572(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 129507, 129572);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_129507_129592(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 129507, 129592);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_129759_129805(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 129759, 129805);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_129759_129824(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 129759, 129824);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_129759_129844(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 129759, 129844);
return return_v;
}


int
f_22075_129876_129995(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 129876, 129995);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_131413_131459(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 131413, 131459);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_131413_131478(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 131413, 131478);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_131413_131498(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 131413, 131498);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_131641_131690(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 131641, 131690);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_131641_131710(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 131641, 131710);
return return_v;
}


int
f_22075_131742_131861(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 131742, 131861);
return 0;
}


int
f_22075_133091_133210(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 133091, 133210);
return 0;
}


int
f_22075_134973_135092(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 134973, 135092);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_135399_135433(string
text,string
filename)
{
var return_v = Parse( text, filename:filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135399, 135433);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
f_22075_135471_135524(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.DescendantNodes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135471, 135524);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
f_22075_135471_135559(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
source)
{
var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135471, 135559);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_135471_135567(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
source)
{
var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135471, 135567);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_22075_135726_135783(string
text)
{
var return_v = SyntaxFactory.ParseExpression( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135726, 135783);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
f_22075_135696_135784(params Microsoft.CodeAnalysis.SyntaxNodeOrToken[]
nodesAndTokens)
{
var return_v = SyntaxFactory.NodeOrTokenList( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135696, 135784);
return return_v;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
f_22075_135650_135785(Microsoft.CodeAnalysis.SyntaxNodeOrTokenList
nodesAndTokens)
{
var return_v = SyntaxFactory.SeparatedList<ExpressionSyntax>( nodesAndTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135650, 135785);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
f_22075_135605_135786(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
this_param,Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
sizes)
{
var return_v = this_param.WithSizes( sizes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135605, 135786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
f_22075_135814_135897(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
root,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
oldNode,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
newNode)
{
var return_v = root.ReplaceNode<Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax>( (Microsoft.CodeAnalysis.SyntaxNode)oldNode, (Microsoft.CodeAnalysis.SyntaxNode)newNode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 135814, 135897);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_22075_135814_135908(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
this_param)
{
var return_v = this_param.SyntaxTree;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22075, 135814, 135908);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_137860_137910(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 137860, 137910);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_137860_137929(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 137860, 137929);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_137860_137949(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 137860, 137949);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_138221_138299(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 138221, 138299);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_138221_138319(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 138221, 138319);
return return_v;
}


int
f_22075_138352_138485(Microsoft.CodeAnalysis.SyntaxTree[]
testSyntaxes,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<VariableDeclarationSyntax>( testSyntaxes, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 138352, 138485);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_139874_139925(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 139874, 139925);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_139874_139945(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 139874, 139945);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_139874_139965(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 139874, 139965);
return return_v;
}


int
f_22075_139997_140122(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 139997, 140122);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_141906_141957(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 141906, 141957);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_141906_141977(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 141906, 141977);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_141906_141997(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 141906, 141997);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_142177_142228(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 142177, 142228);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_142177_142248(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 142177, 142248);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_142177_142268(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 142177, 142268);
return return_v;
}


int
f_22075_142300_142425(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 142300, 142425);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_143792_143838(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 143792, 143838);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_143792_143857(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 143792, 143857);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_143792_143877(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 143792, 143877);
return return_v;
}


int
f_22075_143909_144034(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 143909, 144034);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_145843_145889(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 145843, 145889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_145843_145908(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 145843, 145908);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_145843_145928(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 145843, 145928);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_146076_146122(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 146076, 146122);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_146076_146141(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 146076, 146141);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_146076_146161(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 146076, 146161);
return return_v;
}


int
f_22075_146193_146318(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 146193, 146318);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_147462_147512(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 147462, 147512);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_147462_147532(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 147462, 147532);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_147687_147734(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 147687, 147734);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_147687_147754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 147687, 147754);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_147687_147774(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 147687, 147774);
return return_v;
}


int
f_22075_147806_147931(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 147806, 147931);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149281_149331(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149281, 149331);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149281_149351(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149281, 149351);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149511_149561(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149511, 149561);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149511_149581(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149511, 149581);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149740_149787(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149740, 149787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149740_149807(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149740, 149807);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149740_149827(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149740, 149827);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149986_150033(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149986, 150033);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149986_150053(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149986, 150053);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_149986_150073(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 149986, 150073);
return return_v;
}


int
f_22075_150105_150230(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 150105, 150230);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_151557_151607(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 151557, 151607);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_151557_151627(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 151557, 151627);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_151758_151807(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 151758, 151807);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_151758_151827(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 151758, 151827);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_151984_152033(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 151984, 152033);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_151984_152053(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 151984, 152053);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_152209_152256(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 152209, 152256);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_152209_152276(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 152209, 152276);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_152209_152296(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 152209, 152296);
return return_v;
}


int
f_22075_152328_152453(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 152328, 152453);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_154047_154106(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 154047, 154106);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_154047_154126(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 154047, 154126);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_154047_154146(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 154047, 154146);
return return_v;
}


int
f_22075_154178_154303(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 154178, 154303);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_156486_156545(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 156486, 156545);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_156486_156565(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 156486, 156565);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_156486_156585(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 156486, 156585);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_156776_156835(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 156776, 156835);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_156776_156855(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 156776, 156855);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_156776_156875(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 156776, 156875);
return return_v;
}


int
f_22075_156907_157032(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 156907, 157032);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_158456_158507(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 158456, 158507);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_158456_158527(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 158456, 158527);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_158456_158547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 158456, 158547);
return return_v;
}


int
f_22075_158579_158704(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 158579, 158704);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_160562_160613(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 160562, 160613);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_160562_160633(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 160562, 160633);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_160562_160653(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 160562, 160653);
return return_v;
}


int
f_22075_160685_160810(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<LocalDeclarationStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 160685, 160810);
return 0;
}


int
f_22075_163507_163604(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 163507, 163604);
return 0;
}


int
f_22075_164993_165090(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 164993, 165090);
return 0;
}


int
f_22075_167450_167547(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 167450, 167547);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_168097_168143(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 168097, 168143);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_168097_168162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 168097, 168162);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_168097_168182(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 168097, 168182);
return return_v;
}


int
f_22075_169070_169167(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 169070, 169167);
return 0;
}


int
f_22075_170442_170539(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 170442, 170539);
return 0;
}


int
f_22075_172910_173007(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 172910, 173007);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_173726_173771(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 173726, 173771);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_173726_173791(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 173726, 173791);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_173981_174035(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 173981, 174035);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_173981_174055(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 173981, 174055);
return return_v;
}


int
f_22075_174933_175030(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 174933, 175030);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_175570_175619(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 175570, 175619);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_175570_175639(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 175570, 175639);
return return_v;
}


int
f_22075_176503_176600(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 176503, 176600);
return 0;
}


int
f_22075_178358_178455(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 178358, 178455);
return 0;
}


int
f_22075_179987_180084(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 179987, 180084);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_180671_180744(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 180671, 180744);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_180671_180764(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 180671, 180764);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_180904_180952(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 180904, 180952);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_180904_180972(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 180904, 180972);
return return_v;
}


int
f_22075_182015_182112(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 182015, 182112);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_182719_182792(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 182719, 182792);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_182719_182812(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 182719, 182812);
return return_v;
}


int
f_22075_184146_184243(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 184146, 184243);
return 0;
}


int
f_22075_187363_187460(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 187363, 187460);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_188044_188104(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 188044, 188104);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_188044_188123(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 188044, 188123);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22075_188044_188142(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 188044, 188142);
return return_v;
}


int
f_22075_189113_189210(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22075, 189113, 189210);
return 0;
}

}
}
