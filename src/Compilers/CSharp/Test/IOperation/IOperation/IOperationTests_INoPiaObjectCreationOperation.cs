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
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NoPiaObjectCreation_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22053,526,3049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,656,1162);

string 
pia = @"
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: PrimaryInteropAssemblyAttribute(1,1)]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58279"")]
[CoClass(typeof(ClassITest33))]
public interface ITest33 : System.Collections.IEnumerable
{
    void Add(int x);
}

[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public abstract class ClassITest33
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,1178,1255);

var 
piaCompilation = f_22053_1199_1254(pia, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,1271,1304);

f_22053_1271_1303(this, piaCompilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,1320,1468);

string 
consumer = @"
class UsePia
{
    public void M1(ITest33 x, int y)
    {
	    x = /*<bind>*/new ITest33  { y }/*</bind>*/;
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,1484,2744);

string 
expectedOperationTree = @"
INoPiaObjectCreationOperation (OperationKind.None, Type: ITest33) (Syntax: 'new ITest33  { y }')
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: ITest33) (Syntax: '{ y }')
      Initializers(1):
          IInvocationOperation (virtual void ITest33.Add(System.Int32 x)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y')
            Instance Receiver: 
              IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: ITest33, IsImplicit) (Syntax: 'ITest33')
            Arguments(1):
                IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                  IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
                  InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                  OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,2758,2811);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,2827,3038);

f_22053_2827_3037(consumer, expectedOperationTree, expectedDiagnostics, references: new[] { f_22053_2974_3034(piaCompilation, embedInteropTypes: true)});
DynAbs.Tracing.TraceSender.TraceExitMethod(22053,526,3049);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22053,526,3049);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22053,526,3049);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NoPiaObjectCreation_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22053,3061,5212);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,3191,3665);

string 
pia = @"
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: PrimaryInteropAssemblyAttribute(1,1)]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58279"")]
[CoClass(typeof(ClassITest33))]
public interface ITest33
{
    int P {get; set;}
}

[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public abstract class ClassITest33
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,3681,3758);

var 
piaCompilation = f_22053_3702_3757(pia, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,3774,3807);

f_22053_3774_3806(this, piaCompilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,3823,3975);

string 
consumer = @"
class UsePia
{
    public void M1(ITest33 x, int y)
    {
	    x = /*<bind>*/new ITest33  { P = y }/*</bind>*/;
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,3991,4907);

string 
expectedOperationTree = @"
INoPiaObjectCreationOperation (OperationKind.None, Type: ITest33) (Syntax: 'new ITest33  { P = y }')
  Initializer: 
    IObjectOrCollectionInitializerOperation (OperationKind.ObjectOrCollectionInitializer, Type: ITest33) (Syntax: '{ P = y }')
      Initializers(1):
          ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P = y')
            Left: 
              IPropertyReferenceOperation: System.Int32 ITest33.P { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ImplicitReceiver) (OperationKind.InstanceReference, Type: ITest33, IsImplicit) (Syntax: 'P')
            Right: 
              IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,4921,4974);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,4990,5201);

f_22053_4990_5200(consumer, expectedOperationTree, expectedDiagnostics, references: new[] { f_22053_5137_5197(piaCompilation, embedInteropTypes: true)});
DynAbs.Tracing.TraceSender.TraceExitMethod(22053,3061,5212);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22053,3061,5212);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22053,3061,5212);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void NoPiaObjectCreation_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22053,5224,6584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,5354,5805);

string 
pia = @"
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: PrimaryInteropAssemblyAttribute(1,1)]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58279"")]
[CoClass(typeof(ClassITest33))]
public interface ITest33
{
}

[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public abstract class ClassITest33
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,5821,5898);

var 
piaCompilation = f_22053_5842_5897(pia, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,5914,5947);

f_22053_5914_5946(this, piaCompilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,5963,6106);

string 
consumer = @"
class UsePia
{
    public void M1(ITest33 x, int y)
    {
	    x = /*<bind>*/new ITest33()/*</bind>*/;
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,6122,6279);

string 
expectedOperationTree = @"
INoPiaObjectCreationOperation (OperationKind.None, Type: ITest33) (Syntax: 'new ITest33()')
  Initializer: 
    null
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,6293,6346);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,6362,6573);

f_22053_6362_6572(consumer, expectedOperationTree, expectedDiagnostics, references: new[] { f_22053_6509_6569(piaCompilation, embedInteropTypes: true)});
DynAbs.Tracing.TraceSender.TraceExitMethod(22053,5224,6584);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22053,5224,6584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22053,5224,6584);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoPiaObjectCreationFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22053,6596,10392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,6756,7262);

string 
pia = @"
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: PrimaryInteropAssemblyAttribute(1,1)]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58279"")]
[CoClass(typeof(ClassITest33))]
public interface ITest33 : System.Collections.IEnumerable
{
    void Add(int x);
}

[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public abstract class ClassITest33
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,7278,7355);

var 
piaCompilation = f_22053_7299_7354(pia, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,7371,7404);

f_22053_7371_7403(this, piaCompilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,7420,7568);

string 
consumer = @"
class UsePia
{
    /*<bind>*/public void M1(ITest33 x, int y)
    {
	    x = new ITest33  { y };
    }/*</bind>*/
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,7584,7637);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,7653,10171);

string 
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
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: ITest33) (Syntax: 'x')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new ITest33  { y }')
              Value: 
                INoPiaObjectCreationOperation (OperationKind.None, Type: ITest33) (Syntax: 'new ITest33  { y }')
                  Initializer: 
                    null

            IInvocationOperation (virtual void ITest33.Add(System.Int32 x)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y')
              Instance Receiver: 
                IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'new ITest33  { y }')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y')
                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = new ITest33  { y };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ITest33) (Syntax: 'x = new ITest33  { y }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'x')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'new ITest33  { y }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,10185,10381);

f_22053_10185_10380(consumer, expectedFlowGraph, expectedDiagnostics, references: new[] { f_22053_10317_10377(piaCompilation, embedInteropTypes: true)});
DynAbs.Tracing.TraceSender.TraceExitMethod(22053,6596,10392);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22053,6596,10392);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22053,6596,10392);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoPiaObjectCreationFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22053,10404,13849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,10564,11038);

string 
pia = @"
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: PrimaryInteropAssemblyAttribute(1,1)]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58279"")]
[CoClass(typeof(ClassITest33))]
public interface ITest33
{
    int P {get; set;}
}

[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public abstract class ClassITest33
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,11054,11131);

var 
piaCompilation = f_22053_11075_11130(pia, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,11147,11180);

f_22053_11147_11179(this, piaCompilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,11196,11348);

string 
consumer = @"
class UsePia
{
    /*<bind>*/public void M1(ITest33 x, int y)
    {
	    x = new ITest33  { P = y };
    }/*</bind>*/
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,11364,11417);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,11433,13628);

string 
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
        Statements (4)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: ITest33) (Syntax: 'x')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new ITest33  { P = y }')
              Value: 
                INoPiaObjectCreationOperation (OperationKind.None, Type: ITest33) (Syntax: 'new ITest33  { P = y }')
                  Initializer: 
                    null

            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'P = y')
              Left: 
                IPropertyReferenceOperation: System.Int32 ITest33.P { get; set; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'new ITest33  { P = y }')
              Right: 
                IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'y')

            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = new ITe ...  { P = y };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ITest33) (Syntax: 'x = new ITe ...   { P = y }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'x')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'new ITest33  { P = y }')

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,13642,13838);

f_22053_13642_13837(consumer, expectedFlowGraph, expectedDiagnostics, references: new[] { f_22053_13774_13834(piaCompilation, embedInteropTypes: true)});
DynAbs.Tracing.TraceSender.TraceExitMethod(22053,10404,13849);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22053,10404,13849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22053,10404,13849);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoPiaObjectCreationFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22053,13861,15924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,14021,14472);

string 
pia = @"
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: PrimaryInteropAssemblyAttribute(1,1)]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58279"")]
[CoClass(typeof(ClassITest33))]
public interface ITest33
{
}

[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public abstract class ClassITest33
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,14488,14565);

var 
piaCompilation = f_22053_14509_14564(pia, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,14581,14614);

f_22053_14581_14613(this, piaCompilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,14630,14773);

string 
consumer = @"
class UsePia
{
    /*<bind>*/public void M1(ITest33 x, int y)
    {
	    x = new ITest33();
    }/*</bind>*/
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,14789,14842);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,14858,15703);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = new ITest33();')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ITest33) (Syntax: 'x = new ITest33()')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: ITest33) (Syntax: 'x')
              Right: 
                INoPiaObjectCreationOperation (OperationKind.None, Type: ITest33) (Syntax: 'new ITest33()')
                  Initializer: 
                    null

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,15717,15913);

f_22053_15717_15912(consumer, expectedFlowGraph, expectedDiagnostics, references: new[] { f_22053_15849_15909(piaCompilation, embedInteropTypes: true)});
DynAbs.Tracing.TraceSender.TraceExitMethod(22053,13861,15924);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22053,13861,15924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22053,13861,15924);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void NoPiaObjectCreationFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22053,15936,21959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,16096,16605);

string 
pia = @"
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: PrimaryInteropAssemblyAttribute(1,1)]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

[ComImport()]
[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58279"")]
[CoClass(typeof(ClassITest33))]
public interface ITest33 : System.Collections.IEnumerable
{
    void Add(object x);
}

[Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58278"")]
public abstract class ClassITest33
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,16621,16698);

var 
piaCompilation = f_22053_16642_16697(pia, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,16714,16747);

f_22053_16714_16746(this, piaCompilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,16763,16933);

string 
consumer = @"
class UsePia
{
    /*<bind>*/public void M1(ITest33 x, object y1, object y2)
    {
	    x = new ITest33  { y1 ?? y2 };
    }/*</bind>*/
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,16949,17002);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,17018,21738);

string 
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
        Statements (2)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'x')
              Value: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: ITest33) (Syntax: 'x')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'new ITest33 ...  y1 ?? y2 }')
              Value: 
                INoPiaObjectCreationOperation (OperationKind.None, Type: ITest33) (Syntax: 'new ITest33 ...  y1 ?? y2 }')
                  Initializer: 
                    null

        Next (Regular) Block[B2]
            Entering: {R2} {R3}

    .locals {R2}
    {
        CaptureIds: [3]
        .locals {R3}
        {
            CaptureIds: [2]
            Block[B2] - Block
                Predecessors: [B1]
                Statements (1)
                    IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y1')
                      Value: 
                        IParameterReferenceOperation: y1 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'y1')

                Jump if True (Regular) to Block[B4]
                    IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'y1')
                      Operand: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y1')
                    Leaving: {R3}

                Next (Regular) Block[B3]
            Block[B3] - Block
                Predecessors: [B2]
                Statements (1)
                    IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y1')
                      Value: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y1')

                Next (Regular) Block[B5]
                    Leaving: {R3}
        }

        Block[B4] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'y2')
                  Value: 
                    IParameterReferenceOperation: y2 (OperationKind.ParameterReference, Type: System.Object) (Syntax: 'y2')

            Next (Regular) Block[B5]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IInvocationOperation (virtual void ITest33.Add(System.Object x)) (OperationKind.Invocation, Type: System.Void, IsImplicit) (Syntax: 'y1 ?? y2')
                  Instance Receiver: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'new ITest33 ...  y1 ?? y2 }')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsImplicit) (Syntax: 'y1 ?? y2')
                        IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Object, IsImplicit) (Syntax: 'y1 ?? y2')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

            Next (Regular) Block[B6]
                Leaving: {R2}
    }

    Block[B6] - Block
        Predecessors: [B5]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = new ITe ... y1 ?? y2 };')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: ITest33) (Syntax: 'x = new ITe ...  y1 ?? y2 }')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'x')
                  Right: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: ITest33, IsImplicit) (Syntax: 'new ITest33 ...  y1 ?? y2 }')

        Next (Regular) Block[B7]
            Leaving: {R1}
}

Block[B7] - Exit
    Predecessors: [B6]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22053,21752,21948);

f_22053_21752_21947(consumer, expectedFlowGraph, expectedDiagnostics, references: new[] { f_22053_21884_21944(piaCompilation, embedInteropTypes: true)});
DynAbs.Tracing.TraceSender.TraceExitMethod(22053,15936,21959);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22053,15936,21959);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22053,15936,21959);
}
		}

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22053_1199_1254(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 1199, 1254);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22053_1271_1303(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 1271, 1303);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22053_2974_3034(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 2974, 3034);
return return_v;
}


int
f_22053_2827_3037(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 2827, 3037);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22053_3702_3757(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 3702, 3757);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22053_3774_3806(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 3774, 3806);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22053_5137_5197(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 5137, 5197);
return return_v;
}


int
f_22053_4990_5200(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 4990, 5200);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22053_5842_5897(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 5842, 5897);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22053_5914_5946(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 5914, 5946);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22053_6509_6569(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 6509, 6569);
return return_v;
}


int
f_22053_6362_6572(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyOperationTreeAndDiagnosticsForTest<ObjectCreationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 6362, 6572);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22053_7299_7354(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 7299, 7354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22053_7371_7403(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 7371, 7403);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22053_10317_10377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 10317, 10377);
return return_v;
}


int
f_22053_10185_10380(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 10185, 10380);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22053_11075_11130(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 11075, 11130);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22053_11147_11179(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 11147, 11179);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22053_13774_13834(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 13774, 13834);
return return_v;
}


int
f_22053_13642_13837(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 13642, 13837);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22053_14509_14564(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 14509, 14564);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22053_14581_14613(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 14581, 14613);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22053_15849_15909(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 15849, 15909);
return return_v;
}


int
f_22053_15717_15912(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 15717, 15912);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22053_16642_16697(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 16642, 16697);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_22053_16714_16746(Microsoft.CodeAnalysis.CSharp.UnitTests.IOperationTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 16714, 16746);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_22053_21884_21944(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp,bool
embedInteropTypes)
{
var return_v = comp.EmitToImageReference( embedInteropTypes:embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 21884, 21944);
return return_v;
}


int
f_22053_21752_21947(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
VerifyFlowGraphAndDiagnosticsForTest<MethodDeclarationSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics, references:references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22053, 21752, 21947);
return 0;
}

}
}
