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
        [Fact, WorkItem(8884, "https://github.com/dotnet/roslyn/issues/8884")]
        public void FieldReference_Attribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 616, 1553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 812, 1004);

                string
                source = @"
using System.Diagnostics;

class C
{
    private const string field = nameof(field);

    [/*<bind>*/Conditional(field)/*</bind>*/]
    void M()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 1018, 1349);

                string
                expectedOperationTree = @"
IOperation:  (OperationKind.None, Type: null) (Syntax: 'Conditional(field)')
  Children(1):
      IFieldReferenceOperation: System.String C.field (Static) (OperationKind.FieldReference, Type: System.String, Constant: ""field"") (Syntax: 'field')
        Instance Receiver: 
          null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 1363, 1416);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 1432, 1542);

                f_22033_1432_1541(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 616, 1553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 616, 1553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 616, 1553);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReferenceExpression_OutVar_Script()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 1565, 2558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 1712, 1819);

                string
                source = @"
public void M2(out int i )
{
    i = 0;
}

M2(out /*<bind>*/int i/*</bind>*/);
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 1833, 2291);

                string
                expectedOperationTree = @"
IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i')
  IFieldReferenceOperation: System.Int32 Script.i (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
    Instance Receiver: 
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 2305, 2358);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 2374, 2547);

                f_22033_2374_2546(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Script);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 1565, 2558);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 1565, 2558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 1565, 2558);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReferenceExpression_DeconstructionDeclaration_Script()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 2570, 4194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 2736, 2807);

                string
                source = @"
/*<bind>*/(int i1, int i2)/*</bind>*/ = (1, 2);
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 2821, 3933);

                string
                expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(int i1, int i2)')
  NaturalType: (System.Int32 i1, System.Int32 i2)
  Elements(2):
      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i1')
        IFieldReferenceOperation: System.Int32 Script.i1 (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i1')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i1')
      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int i2')
        IFieldReferenceOperation: System.Int32 Script.i2 (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i2')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 3947, 4000);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 4016, 4183);

                f_22033_4016_4182(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Script);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 2570, 4194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 2570, 4194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 2570, 4194);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReferenceExpression_InferenceOutVar_Script()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 4206, 5208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 4362, 4469);

                string
                source = @"
public void M2(out int i )
{
    i = 0;
}

M2(out /*<bind>*/var i/*</bind>*/);
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 4483, 4941);

                string
                expectedOperationTree = @"
IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i')
  IFieldReferenceOperation: System.Int32 Script.i (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
    Instance Receiver: 
      IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 4955, 5008);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 5024, 5197);

                f_22033_5024_5196(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Script);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 4206, 5208);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 4206, 5208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 4206, 5208);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReferenceExpression_InferenceDeconstructionDeclaration_Script()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 5220, 6853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 5395, 5466);

                string
                source = @"
/*<bind>*/(var i1, var i2)/*</bind>*/ = (1, 2);
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 5480, 6592);

                string
                expectedOperationTree = @"
ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(var i1, var i2)')
  NaturalType: (System.Int32 i1, System.Int32 i2)
  Elements(2):
      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i1')
        IFieldReferenceOperation: System.Int32 Script.i1 (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i1')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i1')
      IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var i2')
        IFieldReferenceOperation: System.Int32 Script.i2 (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i2')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 6606, 6659);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 6675, 6842);

                f_22033_6675_6841(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Script);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 5220, 6853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 5220, 6853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 5220, 6853);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReferenceExpression_InferenceDeconstructionDeclaration_AlternateSyntax_Script()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 6865, 8420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 7056, 7123);

                string
                source = @"
/*<bind>*/var (i1, i2)/*</bind>*/ = (1, 2);
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 7137, 8153);

                string
                expectedOperationTree = @"
IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: 'var (i1, i2)')
  ITupleOperation (OperationKind.Tuple, Type: (System.Int32 i1, System.Int32 i2)) (Syntax: '(i1, i2)')
    NaturalType: (System.Int32 i1, System.Int32 i2)
    Elements(2):
        IFieldReferenceOperation: System.Int32 Script.i1 (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i1')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i1')
        IFieldReferenceOperation: System.Int32 Script.i2 (IsDeclaration: True) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i2')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: Script, IsImplicit) (Syntax: 'i2')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 8167, 8220);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 8236, 8409);

                f_22033_8236_8408(source, expectedOperationTree, expectedDiagnostics, parseOptions: TestOptions.Script);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 6865, 8420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 6865, 8420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 6865, 8420);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(7582, "https://github.com/dotnet/roslyn/issues/7582")]
        [Fact]
        public void IFieldReferenceExpression_ImplicitThis()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 8432, 9314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 8652, 8780);

                string
                source = @"
class C
{
    int i;
    void M()
    {
        /*<bind>*/i/*</bind>*/ = 1;
        i++;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 8794, 9105);

                string
                expectedOperationTree = @"
IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 9119, 9172);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 9188, 9303);

                f_22033_9188_9302(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 8432, 9314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 8432, 9314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 8432, 9314);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(7582, "https://github.com/dotnet/roslyn/issues/7582")]
        [Fact]
        public void IFieldReferenceExpression_ExplicitThis()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 9326, 10217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 9546, 9679);

                string
                source = @"
class C
{
    int i;
    void M()
    {
        /*<bind>*/this.i/*</bind>*/ = 1;
        i++;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 9693, 10000);

                string
                expectedOperationTree = @"
IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'this.i')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 10014, 10067);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 10083, 10206);

                f_22033_10083_10205(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 9326, 10217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 9326, 10217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 9326, 10217);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [WorkItem(7582, "https://github.com/dotnet/roslyn/issues/7582")]
        [Fact]
        public void IFieldReferenceExpression_base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 10229, 11141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 10441, 10603);

                string
                source = @"
class C
{
    protected int i;
}
class B : C
{
    void M()
    {
        /*<bind>*/base.i/*</bind>*/ = 1;
        i++;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 10617, 10924);

                string
                expectedOperationTree = @"
IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'base.i')
  Instance Receiver: 
    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'base')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 10938, 10991);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 11007, 11130);

                f_22033_11007_11129(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 10229, 11141);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 10229, 11141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 10229, 11141);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReferenceExpression_IndexingFixed_Unmovable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 11153, 12512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 11310, 11518);

                string
                source = @"

unsafe struct S1
{
    public fixed int field[10];
}

unsafe class C
{
    void M()
    {
        S1 s = default;

        /*<bind>*/ s.field[3] = 1; /*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 11532, 12249);

                string
                expectedOperationTree = @"
ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 's.field[3] = 1')
  Left: 
    IOperation:  (OperationKind.None, Type: null) (Syntax: 's.field[3]')
      Children(2):
          IFieldReferenceOperation: System.Int32* S1.field (OperationKind.FieldReference, Type: System.Int32*) (Syntax: 's.field')
            Instance Receiver: 
              ILocalReferenceOperation: s (OperationKind.LocalReference, Type: S1) (Syntax: 's')
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
  Right: 
    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 12263, 12316);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 12332, 12501);

                f_22033_12332_12500(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 11153, 12512);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 11153, 12512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 11153, 12512);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReferenceExpression_IndexingFixed_Movable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 12524, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 12679, 12883);

                string
                source = @"

unsafe struct S1
{
    public fixed int field[10];
}

unsafe class C
{
    S1 s = default;

    void M()
    {
        /*<bind>*/ s.field[3] = 1; /*</bind>*/
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 12897, 13812);

                string
                expectedOperationTree = @"
ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 's.field[3] = 1')
  Left: 
    IOperation:  (OperationKind.None, Type: null) (Syntax: 's.field[3]')
      Children(2):
          IFieldReferenceOperation: System.Int32* S1.field (OperationKind.FieldReference, Type: System.Int32*) (Syntax: 's.field')
            Instance Receiver: 
              IFieldReferenceOperation: S1 C.s (OperationKind.FieldReference, Type: S1) (Syntax: 's')
                Instance Receiver: 
                  IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 's')
          ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 3) (Syntax: '3')
  Right: 
    ILiteralOperation (OperationKind.Literal, Type: System.Int32, Constant: 1) (Syntax: '1')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 13826, 13879);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 13895, 14064);

                f_22033_13895_14063(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeDebugDll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 12524, 14075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 12524, 14075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 12524, 14075);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReference_StaticFieldWithInstanceReceiver()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 14087, 15505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 14242, 14412);

                string
                source = @"
class C
{
    static int i;

    public static void M()
    {
        var c = new C();
        var i1 = /*<bind>*/c.i/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 14426, 14715);

                string
                expectedOperationTree = @"
IFieldReferenceOperation: System.Int32 C.i (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'c.i')
  Instance Receiver: 
    ILocalReferenceOperation: c (OperationKind.LocalReference, Type: C, IsInvalid) (Syntax: 'c')
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 14729, 15355);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22033_14989_15079(f_22033_14989_15059(f_22033_14989_15038(ErrorCode.ERR_ObjectProhibited, "c.i"), "C.i"), 9, 28),
f_22033_15239_15339(f_22033_15239_15319(f_22033_15239_15293(ErrorCode.WRN_UnassignedInternalField, "i"), "C.i", "0"), 4, 16)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 15371, 15494);

                f_22033_15371_15493(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 14087, 15505);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 14087, 15505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 14087, 15505);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReference_StaticFieldInObjectInitializer_NoInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 15517, 16822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 15682, 15840);

                string
                source = @"
class C
{
    static int i1;
    public static void Main()
    {
        var c = new C { /*<bind>*/i1/*</bind>*/ = 1 };
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 15854, 16055);

                string
                expectedOperationTree = @"
IFieldReferenceOperation: System.Int32 C.i1 (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
  Instance Receiver: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 16069, 16680);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22033_16321_16426(f_22033_16321_16406(f_22033_16321_16384(ErrorCode.ERR_StaticMemberInObjectInitializer, "i1"), "C.i1"), 7, 35),
f_22033_16569_16664(f_22033_16569_16644(f_22033_16569_16622(ErrorCode.WRN_UnreferencedFieldAssg, "i1"), "C.i1"), 4, 16)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 16696, 16811);

                f_22033_16696_16810(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 15517, 16822);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 15517, 16822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 15517, 16822);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReference_StaticField()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 16834, 17811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 16969, 17113);

                string
                source = @"
class C
{
    static int i;

    public static void M()
    {
        var i1 = /*<bind>*/C.i/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 17127, 17317);

                string
                expectedOperationTree = @"
IFieldReferenceOperation: System.Int32 C.i (Static) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'C.i')
  Instance Receiver: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 17331, 17661);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22033_17545_17645(f_22033_17545_17625(f_22033_17545_17599(ErrorCode.WRN_UnassignedInternalField, "i"), "C.i", "0"), 4, 16)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 17677, 17800);

                f_22033_17677_17799(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 16834, 17811);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 16834, 17811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 16834, 17811);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IFieldReference_InstanceField_InvalidAccessOffOfClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 17823, 19095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 17984, 18121);

                string
                source = @"
class C
{
    int i;

    public static void M()
    {
        var i1 = /*<bind>*/C.i/*</bind>*/;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 18135, 18327);

                string
                expectedOperationTree = @"
IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'C.i')
  Instance Receiver: 
    null
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 18341, 18945);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22033_18589_18677(f_22033_18589_18657(f_22033_18589_18636(ErrorCode.ERR_ObjectRequired, "C.i"), "C.i"), 8, 28),
f_22033_18830_18929(f_22033_18830_18910(f_22033_18830_18884(ErrorCode.WRN_UnassignedInternalField, "i"), "C.i", "0"), 4, 9)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 18961, 19084);

                f_22033_18961_19083(source, expectedOperationTree, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 17823, 19095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 17823, 19095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 17823, 19095);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FieldReference_NoControlFlow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 19107, 22131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 19380, 19545);

                string
                source = @"
class C
{
    int i;
    static int j;
    void M(C c)
    /*<bind>*/{
        i = C.j;
        j = this.i + c.i;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 19559, 21939);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = C.j;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = C.j')
              Left: 
                IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'i')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'i')
              Right: 
                IFieldReferenceOperation: System.Int32 C.j (Static) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'C.j')
                  Instance Receiver: 
                    null

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = this.i + c.i;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = this.i + c.i')
              Left: 
                IFieldReferenceOperation: System.Int32 C.j (Static) (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'j')
                  Instance Receiver: 
                    null
              Right: 
                IBinaryOperation (BinaryOperatorKind.Add) (OperationKind.Binary, Type: System.Int32) (Syntax: 'this.i + c.i')
                  Left: 
                    IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'this.i')
                      Instance Receiver: 
                        IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C) (Syntax: 'this')
                  Right: 
                    IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: 'c.i')
                      Instance Receiver: 
                        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 21953, 22006);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 22022, 22120);

                f_22033_22022_22119(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 19107, 22131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 19107, 22131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 19107, 22131);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FieldReference_ControlFlowInReceiver()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 22143, 25775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 22313, 22466);

                string
                source = @"
class C
{
    public int i = 0;
    void M(C c1, C c2, int p)
    /*<bind>*/{
        p = (c1 ?? c2).i;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 22480, 25583);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    CaptureIds: [0] [2]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C) (Syntax: 'c2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = (c1 ?? c2).i;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'p = (c1 ?? c2).i')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'p')
                  Right: 
                    IFieldReferenceOperation: System.Int32 C.i (OperationKind.FieldReference, Type: System.Int32) (Syntax: '(c1 ?? c2).i')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 25597, 25650);

                var
                expectedDiagnostics = DiagnosticDescription.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 25666, 25764);

                f_22033_25666_25763(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 22143, 25775);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 22143, 25775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 22143, 25775);
            }
        }

        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void FieldReference_ControlFlowInReceiver_StaticField()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 25787, 28569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 25969, 26159);

                string
                source = @"
class C
{
    public static int i = 0;
    void M(C c1, C c2, int p1, int p2)
    /*<bind>*/{
        p1 = c1.i;
        p2 = (c1 ?? c2).i;
    }/*</bind>*/
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 26173, 27756);

                string
                expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p1 = c1.i;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'p1 = c1.i')
              Left: 
                IParameterReferenceOperation: p1 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p1')
              Right: 
                IFieldReferenceOperation: System.Int32 C.i (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: 'c1.i')
                  Instance Receiver: 
                    null

        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p2 = (c1 ?? c2).i;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'p2 = (c1 ?? c2).i')
              Left: 
                IParameterReferenceOperation: p2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'p2')
              Right: 
                IFieldReferenceOperation: System.Int32 C.i (Static) (OperationKind.FieldReference, Type: System.Int32, IsInvalid) (Syntax: '(c1 ?? c2).i')
                  Instance Receiver: 
                    null

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 27770, 28444);

                var
                expectedDiagnostics = new DiagnosticDescription[] {
f_22033_28027_28118(f_22033_28027_28098(f_22033_28027_28077(ErrorCode.ERR_ObjectProhibited, "c1.i"), "C.i"), 7, 14),
f_22033_28329_28428(f_22033_28329_28408(f_22033_28329_28387(ErrorCode.ERR_ObjectProhibited, "(c1 ?? c2).i"), "C.i"), 8, 14)            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 28460, 28558);

                f_22033_28460_28557(source, expectedFlowGraph, expectedDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 25787, 28569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 25787, 28569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 25787, 28569);
            }
        }

        [Fact]
        [WorkItem(38195, "https://github.com/dotnet/roslyn/issues/38195")]
        [CompilerTrait(CompilerFeature.IOperation, CompilerFeature.NullableReferenceTypes)]
        public void NullableFieldReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22033, 28581, 30222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 28827, 28960);

                var
                program = @"
class C<T>
{
    private C<T> _field;
    public static void M(C<T> p)
    {
        _ = p._field;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 28976, 29029);

                var
                compWithoutNullable = f_22033_29002_29028(program)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29043, 29124);

                var
                compWithNullable = f_22033_29066_29123(program, options: f_22033_29102_29122())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29140, 29170);

                f_22033_29140_29169(compWithoutNullable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29184, 29211);

                f_22033_29184_29210(compWithNullable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(22033, 28581, 30222);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 28581, 30222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 28581, 30222);
            }
        }

        int
        f_22033_1432_1541(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AttributeSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 1432, 1541);
            return 0;
        }


        int
        f_22033_2374_2546(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<DeclarationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 2374, 2546);
            return 0;
        }


        int
        f_22033_4016_4182(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 4016, 4182);
            return 0;
        }


        int
        f_22033_5024_5196(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<DeclarationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 5024, 5196);
            return 0;
        }


        int
        f_22033_6675_6841(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<TupleExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 6675, 6841);
            return 0;
        }


        int
        f_22033_8236_8408(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
        parseOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<DeclarationExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, parseOptions: parseOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 8236, 8408);
            return 0;
        }


        int
        f_22033_9188_9302(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 9188, 9302);
            return 0;
        }


        int
        f_22033_10083_10205(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 10083, 10205);
            return 0;
        }


        int
        f_22033_11007_11129(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 11007, 11129);
            return 0;
        }


        int
        f_22033_12332_12500(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        compilationOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions: compilationOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 12332, 12500);
            return 0;
        }


        int
        f_22033_13895_14063(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        compilationOptions)
        {
            VerifyOperationTreeAndDiagnosticsForTest<AssignmentExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions: compilationOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 13895, 14063);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_14989_15038(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 14989, 15038);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_14989_15059(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 14989, 15059);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_14989_15079(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 14989, 15079);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_15239_15293(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 15239, 15293);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_15239_15319(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 15239, 15319);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_15239_15339(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 15239, 15339);
            return return_v;
        }


        int
        f_22033_15371_15493(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 15371, 15493);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_16321_16384(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 16321, 16384);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_16321_16406(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 16321, 16406);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_16321_16426(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 16321, 16426);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_16569_16622(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 16569, 16622);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_16569_16644(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 16569, 16644);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_16569_16664(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 16569, 16664);
            return return_v;
        }


        int
        f_22033_16696_16810(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 16696, 16810);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_17545_17599(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 17545, 17599);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_17545_17625(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 17545, 17625);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_17545_17645(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 17545, 17645);
            return return_v;
        }


        int
        f_22033_17677_17799(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 17677, 17799);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_18589_18636(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 18589, 18636);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_18589_18657(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 18589, 18657);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_18589_18677(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 18589, 18677);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_18830_18884(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 18830, 18884);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_18830_18910(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 18830, 18910);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_18830_18929(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 18830, 18929);
            return return_v;
        }


        int
        f_22033_18961_19083(string
        testSrc, string
        expectedOperationTree, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyOperationTreeAndDiagnosticsForTest<MemberAccessExpressionSyntax>(testSrc, expectedOperationTree, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 18961, 19083);
            return 0;
        }


        int
        f_22033_22022_22119(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 22022, 22119);
            return 0;
        }


        int
        f_22033_25666_25763(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 25666, 25763);
            return 0;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_28027_28077(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 28027, 28077);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_28027_28098(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 28027, 28098);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_28027_28118(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 28027, 28118);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_28329_28387(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 28329, 28387);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_28329_28408(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 28329, 28408);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22033_28329_28428(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 28329, 28428);
            return return_v;
        }


        int
        f_22033_28460_28557(string
        testSrc, string
        expectedFlowGraph, Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expectedDiagnostics)
        {
            VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>(testSrc, expectedFlowGraph, expectedDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 28460, 28557);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22033_29002_29028(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29002, 29028);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_22033_29102_29122()
        {
            var return_v = WithNullableEnable();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29102, 29122);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22033_29066_29123(string
        source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        options)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29066, 29123);
            return return_v;
        }


        int
        f_22033_29140_29169(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        comp)
        {
            testCore(comp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29140, 29169);
            return 0;
        }


        int
        f_22033_29184_29210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        comp)
        {
            testCore(comp);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29184, 29210);
            return 0;
        }


        static void
        testCore(CSharpCompilation comp)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(22033, 29227, 30211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29304, 29341);

                var
                syntaxTree = f_22033_29321_29337(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29359, 29405);

                var
                model = f_22033_29371_29404(comp, syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29423, 29455);

                var
                root = f_22033_29434_29454(syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29473, 29554);

                var
                classDecl = f_22033_29489_29553(f_22033_29489_29544(f_22033_29489_29511(root)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29572, 29640);

                var
                classSym = (INamedTypeSymbol)f_22033_29605_29639(model, classDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29658, 29712);

                var
                fieldSym = f_22033_29673_29702(classSym, "_field").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29732, 29815);

                var
                methodDecl = f_22033_29749_29814(f_22033_29749_29805(f_22033_29749_29771(root)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29833, 29891);

                var
                methodBlockOperation = f_22033_29860_29890(model, methodDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 29909, 30018);

                var
                fieldReferenceOperation = f_22033_29939_30017(f_22033_29939_30008(f_22033_29939_29973(methodBlockOperation)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 30036, 30096);

                f_22033_30036_30095(f_22033_30048_30094(fieldSym, f_22033_30064_30093(fieldReferenceOperation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22033, 30114, 30196);

                f_22033_30114_30195(f_22033_30127_30149(fieldSym), f_22033_30151_30194(f_22033_30151_30180(fieldReferenceOperation)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(22033, 29227, 30211);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22033, 29227, 30211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22033, 29227, 30211);
            }
        }



        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
        f_22033_29321_29337(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.SyntaxTrees;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22033, 29321, 29337);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_22033_29371_29404(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29371, 29404);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_22033_29434_29454(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29434, 29454);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22033_29489_29511(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29489, 29511);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax>
        f_22033_29489_29544(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29489, 29544);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax
        f_22033_29489_29553(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29489, 29553);
            return return_v;
        }


        static Microsoft.CodeAnalysis.INamedTypeSymbol?
        f_22033_29605_29639(Microsoft.CodeAnalysis.SemanticModel
        semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax
        declarationSyntax)
        {
            var return_v = semanticModel.GetDeclaredSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)declarationSyntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29605, 29639);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        f_22033_29673_29702(Microsoft.CodeAnalysis.INamedTypeSymbol?
        this_param, string
        name)
        {
            var return_v = this_param.GetMembers(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29673, 29702);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22033_29749_29771(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29749, 29771);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        f_22033_29749_29805(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29749, 29805);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        f_22033_29749_29814(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29749, 29814);
            return return_v;
        }


        static Microsoft.CodeAnalysis.IOperation?
        f_22033_29860_29890(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29860, 29890);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
        f_22033_29939_29973(Microsoft.CodeAnalysis.IOperation?
        operation)
        {
            var return_v = operation.Descendants();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29939, 29973);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation>
        f_22033_29939_30008(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IOperation>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29939, 30008);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
        f_22033_29939_30017(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 29939, 30017);
            return return_v;
        }


        static Microsoft.CodeAnalysis.IFieldSymbol
        f_22033_30064_30093(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
        this_param)
        {
            var return_v = this_param.Field;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22033, 30064, 30093);
            return return_v;
        }


        static bool
        f_22033_30048_30094(Microsoft.CodeAnalysis.ISymbol
        this_param, Microsoft.CodeAnalysis.IFieldSymbol
        other)
        {
            var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 30048, 30094);
            return return_v;
        }


        static int
        f_22033_30036_30095(bool
        condition)
        {
            Assert.True(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 30036, 30095);
            return 0;
        }


        static int
        f_22033_30127_30149(Microsoft.CodeAnalysis.ISymbol
        this_param)
        {
            var return_v = this_param.GetHashCode();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 30127, 30149);
            return return_v;
        }


        static Microsoft.CodeAnalysis.IFieldSymbol
        f_22033_30151_30180(Microsoft.CodeAnalysis.Operations.IFieldReferenceOperation
        this_param)
        {
            var return_v = this_param.Field;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(22033, 30151, 30180);
            return return_v;
        }


        static int
        f_22033_30151_30194(Microsoft.CodeAnalysis.IFieldSymbol
        this_param)
        {
            var return_v = this_param.GetHashCode();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 30151, 30194);
            return return_v;
        }


        static int
        f_22033_30114_30195(int
        expected, int
        actual)
        {
            Assert.Equal(expected, actual);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22033, 30114, 30195);
            return 0;
        }

    }
}
