// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    [CompilerTrait(CompilerFeature.IOperation)]
    public partial class IOperationTests : SemanticModelTestBase
    {
        [Fact]
        public void RegularMethodBody_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 593, 1188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 712, 789);

                string
                source = @"
abstract class C
{
    public abstract void M();
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 803, 847);

                var
                compilation = f_22049_821_846(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 863, 895);

                f_22049_863_894(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 911, 955);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 969, 1016);

                var
                model = f_22049_981_1015(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1032, 1124);

                var
                node1 = f_22049_1044_1123(f_22049_1044_1114(f_22049_1044_1076(f_22049_1044_1058(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1138, 1177);

                f_22049_1138_1176(f_22049_1150_1175(model, node1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 593, 1188);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 593, 1188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 593, 1188);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 1200, 3443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1364, 1443);

                string
                source = @"
class C
{
    public void M()
    { throw null; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1457, 1501);

                var
                compilation = f_22049_1475_1500(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1517, 1549);

                f_22049_1517_1548(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1565, 1609);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1623, 1715);

                var
                node1 = f_22049_1635_1714(f_22049_1635_1705(f_22049_1635_1667(f_22049_1635_1649(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 1731, 2595);

                f_22049_1731_2594(
                            compilation, node1, expectedOperationTree:
                @"
    IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'public void ... row null; }')
      BlockBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ throw null; }')
          IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null;')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
      ExpressionBody: 
        null
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 2611, 3432);

                f_22049_2611_3431(compilation, node1, expectedFlowGraph:
                @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B2] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 1200, 3443);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 1200, 3443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 1200, 3443);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 3455, 5870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 3624, 3703);

                string
                source = @"
class C
{
    public void M() 
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 3717, 3761);

                var
                compilation = f_22049_3735_3760(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 3777, 3809);

                f_22049_3777_3808(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 3825, 3869);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 3883, 3975);

                var
                node1 = f_22049_3895_3974(f_22049_3895_3965(f_22049_3895_3927(f_22049_3895_3909(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 3991, 5022);

                f_22049_3991_5021(
                            compilation, node1, expectedOperationTree:
                @"
    IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'public void ... throw null;')
      BlockBody: 
        null
      ExpressionBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> throw null')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'throw null')
            Expression: 
              IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 5038, 5859);

                f_22049_5038_5858(compilation, node1, expectedFlowGraph:
                @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    Block[B2] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 3455, 5870);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 3455, 5870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 3455, 5870);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 5882, 10087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 6061, 6160);

                string
                source = @"
class C
{
    public void M()
    { throw null; }
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 6174, 6218);

                var
                compilation = f_22049_6192_6217(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 6234, 6575);

                f_22049_6234_6574(
                            compilation, f_22049_6423_6555(f_22049_6423_6536(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public void M()
    { throw null; }
    => throw null;"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 6591, 6635);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 6649, 6741);

                var
                node1 = f_22049_6661_6740(f_22049_6661_6731(f_22049_6661_6693(f_22049_6661_6675(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 6757, 8516);

                f_22049_6757_8515(
                            compilation, node1, expectedOperationTree:
                @"
    IMethodBodyOperation (OperationKind.MethodBody, Type: null, IsInvalid) (Syntax: 'public void ... throw null;')
      BlockBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ throw null; }')
          IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null;')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
      ExpressionBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> throw null')
          IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw null')
            Expression: 
              IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 8532, 10076);

                f_22049_8532_10075(compilation, node1, expectedFlowGraph:
                @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B1]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Throw) Block[null]
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                (ImplicitReference)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    .erroneous body {R1}
    {
        Block[B2] - Block [UnReachable]
            Predecessors (0)
            Statements (0)
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    }
    Block[B3] - Exit [UnReachable]
        Predecessors (0)
        Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 5882, 10087);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 5882, 10087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 5882, 10087);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 10099, 11474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 10278, 10364);

                string
                source = @"
class C
{
    public void M(int i, int j)
    { j = i; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 10378, 10422);

                var
                compilation = f_22049_10396_10421(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 10438, 10470);

                f_22049_10438_10469(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 10486, 10530);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 10544, 10636);

                var
                node1 = f_22049_10556_10635(f_22049_10556_10626(f_22049_10556_10588(f_22049_10556_10570(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 10652, 11463);

                f_22049_10652_11462(compilation, node1, expectedFlowGraph:
                @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'j = i;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = i')
              Left: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
              Right: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 10099, 11474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 10099, 11474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 10099, 11474);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 11486, 12876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 11670, 11755);

                string
                source = @"
class C
{
    public void M(int i, int j)
    => j = i;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 11769, 11813);

                var
                compilation = f_22049_11787_11812(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 11829, 11861);

                f_22049_11829_11860(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 11877, 11921);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 11935, 12027);

                var
                node1 = f_22049_11947_12026(f_22049_11947_12017(f_22049_11947_11979(f_22049_11947_11961(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 12043, 12865);

                f_22049_12043_12864(compilation, node1, expectedFlowGraph:
                @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'j = i')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'j = i')
              Left: 
                IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
              Right: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 11486, 12876);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 11486, 12876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 11486, 12876);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 12888, 15494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 13082, 13205);

                string
                source = @"
class C
{
    public void M(int i1, int i2, int j1, int j2)
    { i1 = j1; }
    => i2 = j2;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 13219, 13263);

                var
                compilation = f_22049_13237_13262(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 13279, 13638);

                f_22049_13279_13637(
                            compilation, f_22049_13480_13636(f_22049_13480_13617(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public void M(int i1, int i2, int j1, int j2)
    { i1 = j1; }
    => i2 = j2;"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 13654, 13698);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 13712, 13804);

                var
                node1 = f_22049_13724_13803(f_22049_13724_13794(f_22049_13724_13756(f_22049_13724_13738(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 13820, 15483);

                f_22049_13820_15482(compilation, node1, expectedFlowGraph:
                @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'i1 = j1;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i1 = j1')
              Left: 
                IParameterReferenceOperation: i1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i1')
              Right: 
                IParameterReferenceOperation: j1 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'j1')

    Next (Regular) Block[B3]

.erroneous body {R1}
{
    Block[B2] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'i2 = j2')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32, IsInvalid) (Syntax: 'i2 = j2')
                  Left: 
                    IParameterReferenceOperation: i2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'i2')
                  Right: 
                    IParameterReferenceOperation: j2 (OperationKind.ParameterReference, Type: System.Int32, IsInvalid) (Syntax: 'j2')

        Next (Regular) Block[B3]
            Leaving: {R1}
}

Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 12888, 15494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 12888, 15494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 12888, 15494);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_08()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 15506, 17445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 15845, 15940);

                string
                source = @"
class C
{
    public void M()
    { return; }
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 15954, 15998);

                var
                compilation = f_22049_15972_15997(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 16014, 16333);

                f_22049_16014_16332(
                            compilation, f_22049_16203_16331(f_22049_16203_16312(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public void M()
    { return; }
    => throw null;"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 16349, 16393);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 16407, 16499);

                var
                node1 = f_22049_16419_16498(f_22049_16419_16489(f_22049_16419_16451(f_22049_16419_16433(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 16515, 17434);

                f_22049_16515_17433(compilation, node1, expectedFlowGraph:
                @"
    Block[B0] - Entry
        Statements (0)
        Next (Regular) Block[B2]
    .erroneous body {R1}
    {
        Block[B1] - Block [UnReachable]
            Predecessors (0)
            Statements (0)
            Next (Throw) Block[null]
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                  Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    (ImplicitReference)
                  Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    }
    Block[B2] - Exit
        Predecessors: [B0]
        Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 15506, 17445);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 15506, 17445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 15506, 17445);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_09()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 17457, 19760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 17640, 17757);

                string
                source = @"
class C
{
    public void M()
    => M2(out int x);

    void M2(out int x) => x = 0;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 17771, 17815);

                var
                compilation = f_22049_17789_17814(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 17831, 17863);

                f_22049_17831_17862(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 17879, 17923);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 17937, 18028);

                var
                node1 = f_22049_17949_18027(f_22049_17949_18019(f_22049_17949_17981(f_22049_17949_17963(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 18044, 19749);

                f_22049_18044_19748(compilation, node1, expectedFlowGraph:
                @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 x]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'M2(out int x)')
              Expression: 
                IInvocationOperation ( void C.M2(out System.Int32 x)) (OperationKind.Invocation, Type: System.Void) (Syntax: 'M2(out int x)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'M2')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null) (Syntax: 'out int x')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'int x')
                          ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'x')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 17457, 19760);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 17457, 19760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 17457, 19760);
            }
        }

        [CompilerTrait(CompilerFeature.Dataflow)]
        [Fact]
        public void RegularMethodBody_10()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 19772, 22448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 19970, 20096);

                string
                source = @"
class C
{
    public void M()
    { }
    => M2(out int x);

    void M2(out int x) => x = 0;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 20110, 20154);

                var
                compilation = f_22049_20128_20153(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 20170, 20484);

                f_22049_20170_20483(
                            compilation, f_22049_20359_20482(f_22049_20359_20463(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public void M()
    { }
    => M2(out int x);"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 20500, 20544);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 20558, 20649);

                var
                node1 = f_22049_20570_20648(f_22049_20570_20640(f_22049_20570_20602(f_22049_20570_20584(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 20665, 22437);

                f_22049_20665_22436(compilation, node1, expectedFlowGraph:
                @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B2]

.erroneous body {R1}
{
    Locals: [System.Int32 x]
    Block[B1] - Block [UnReachable]
        Predecessors (0)
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'M2(out int x)')
              Expression: 
                IInvocationOperation ( void C.M2(out System.Int32 x)) (OperationKind.Invocation, Type: System.Void, IsInvalid) (Syntax: 'M2(out int x)')
                  Instance Receiver: 
                    IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsInvalid, IsImplicit) (Syntax: 'M2')
                  Arguments(1):
                      IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: x) (OperationKind.Argument, Type: null, IsInvalid) (Syntax: 'out int x')
                        IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32, IsInvalid) (Syntax: 'int x')
                          ILocalReferenceOperation: x (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32, IsInvalid) (Syntax: 'x')
                        InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                        OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)

        Next (Regular) Block[B2]
            Leaving: {R1}
}

Block[B2] - Exit
    Predecessors: [B0] [B1]
    Statements (0)
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 19772, 22448);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 19772, 22448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 19772, 22448);
            }
        }

        [Fact]
        public void OperatorBody_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 22460, 23345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 22530, 22615);

                string
                source = @"
abstract class C
{
    public static C operator ! (C x);
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 22629, 22673);

                var
                compilation = f_22049_22647_22672(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 22689, 23052);

                f_22049_22689_23051(
                            compilation, f_22049_22929_23032(f_22049_22929_23012(f_22049_22929_22979(ErrorCode.ERR_ConcreteMissingBody, "!"), "C.operator !(C)"), 4, 30));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23068, 23112);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23126, 23173);

                var
                model = f_22049_23138_23172(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23189, 23281);

                var
                node1 = f_22049_23201_23280(f_22049_23201_23271(f_22049_23201_23233(f_22049_23201_23215(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23295, 23334);

                f_22049_23295_23333(f_22049_23307_23332(model, node1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 22460, 23345);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 22460, 23345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 22460, 23345);
            }
        }

        [Fact]
        public void OperatorMethodBody_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 23357, 24692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23433, 23529);

                string
                source = @"
class C
{
    public static C operator ! (C x)
    { throw null; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23543, 23587);

                var
                compilation = f_22049_23561_23586(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23603, 23635);

                f_22049_23603_23634(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23651, 23695);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23709, 23801);

                var
                node1 = f_22049_23721_23800(f_22049_23721_23791(f_22049_23721_23753(f_22049_23721_23735(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 23817, 24681);

                f_22049_23817_24680(
                            compilation, node1, expectedOperationTree:
                @"
    IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'public stat ... row null; }')
      BlockBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ throw null; }')
          IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null;')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
      ExpressionBody: 
        null
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 23357, 24692);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 23357, 24692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 23357, 24692);
            }
        }

        [Fact]
        public void OperatorMethodBody_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 24704, 26525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 24780, 24875);

                string
                source = @"
class C
{
    public static C operator ! (C x)
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 24889, 24933);

                var
                compilation = f_22049_24907_24932(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 24949, 24981);

                f_22049_24949_24980(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 24997, 25041);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 25055, 25147);

                var
                node1 = f_22049_25067_25146(f_22049_25067_25137(f_22049_25067_25099(f_22049_25067_25081(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 25163, 26514);

                f_22049_25163_26513(
                            compilation, node1, expectedOperationTree:
                @"
    IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'public stat ... throw null;')
      BlockBody: 
        null
      ExpressionBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> throw null')
          IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'throw null')
            ReturnedValue: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsImplicit) (Syntax: 'throw null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 24704, 26525);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 24704, 26525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 24704, 26525);
            }
        }

        [Fact]
        public void OperatorMethodBody_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 26537, 29461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 26613, 26729);

                string
                source = @"
class C
{
    public static C operator ! (C x)
    { throw null; }
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 26743, 26787);

                var
                compilation = f_22049_26761_26786(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 26803, 27178);

                f_22049_26803_27177(
                            compilation, f_22049_27009_27158(f_22049_27009_27139(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public static C operator ! (C x)
    { throw null; }
    => throw null;"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 27194, 27238);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 27252, 27344);

                var
                node1 = f_22049_27264_27343(f_22049_27264_27334(f_22049_27264_27296(f_22049_27264_27278(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 27360, 29450);

                f_22049_27360_29449(
                            compilation, node1, expectedOperationTree:
                @"
    IMethodBodyOperation (OperationKind.MethodBody, Type: null, IsInvalid) (Syntax: 'public stat ... throw null;')
      BlockBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ throw null; }')
          IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null;')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
              Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
              Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
      ExpressionBody: 
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> throw null')
          IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw null')
            ReturnedValue: 
              IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: C, IsInvalid, IsImplicit) (Syntax: 'throw null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                  IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null')
                    IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                      Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                      Operand: 
                        ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 26537, 29461);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 26537, 29461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 26537, 29461);
            }
        }

        [Fact]
        public void ConversionBody_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 29473, 30400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 29545, 29638);

                string
                source = @"
abstract class C
{
    public static implicit operator int(C x);
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 29652, 29696);

                var
                compilation = f_22049_29670_29695(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 29712, 30107);

                f_22049_29712_30106(
                            compilation, f_22049_29971_30087(f_22049_29971_30067(f_22049_29971_30023(ErrorCode.ERR_ConcreteMissingBody, "int"), "C.implicit operator int(C)"), 4, 37));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30123, 30167);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30181, 30228);

                var
                model = f_22049_30193_30227(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30244, 30336);

                var
                node1 = f_22049_30256_30335(f_22049_30256_30326(f_22049_30256_30288(f_22049_30256_30270(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30350, 30389);

                f_22049_30350_30388(f_22049_30362_30387(model, node1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 29473, 30400);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 29473, 30400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 29473, 30400);
            }
        }

        [Fact]
        public void ConversionMethodBody_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 30412, 31727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30490, 30594);

                string
                source = @"
class C
{
    public static implicit operator int(C x)
    { throw null; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30608, 30652);

                var
                compilation = f_22049_30626_30651(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30668, 30700);

                f_22049_30668_30699(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30716, 30760);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30774, 30866);

                var
                node1 = f_22049_30786_30865(f_22049_30786_30856(f_22049_30786_30818(f_22049_30786_30800(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 30882, 31716);

                f_22049_30882_31715(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'public stat ... row null; }')
    BlockBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ throw null; }')
        IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null;')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    ExpressionBody: 
    null
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 30412, 31727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 30412, 31727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 30412, 31727);
            }
        }

        [Fact]
        public void ConversionMethodBody_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 31739, 33535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 31817, 31920);

                string
                source = @"
class C
{
    public static implicit operator int(C x)
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 31934, 31978);

                var
                compilation = f_22049_31952_31977(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 31994, 32026);

                f_22049_31994_32025(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 32042, 32086);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 32100, 32192);

                var
                node1 = f_22049_32112_32191(f_22049_32112_32182(f_22049_32112_32144(f_22049_32112_32126(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 32208, 33524);

                f_22049_32208_33523(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'public stat ... throw null;')
    BlockBody: 
    null
    ExpressionBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> throw null')
        IReturnOperation (OperationKind.Return, Type: null, IsImplicit) (Syntax: 'throw null')
        ReturnedValue: 
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsImplicit) (Syntax: 'throw null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
                IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 31739, 33535);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 31739, 33535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 31739, 33535);
            }
        }

        [Fact]
        public void ConversionMethodBody_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 33547, 36448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 33625, 33749);

                string
                source = @"
class C
{
    public static implicit operator int(C x)
    { throw null; }
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 33763, 33807);

                var
                compilation = f_22049_33781_33806(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 33823, 34214);

                f_22049_33823_34213(
                            compilation, f_22049_34037_34194(f_22049_34037_34175(ErrorCode.ERR_BlockBodyAndExpressionBody, @"public static implicit operator int(C x)
    { throw null; }
    => throw null;"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 34230, 34274);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 34288, 34380);

                var
                node1 = f_22049_34300_34379(f_22049_34300_34370(f_22049_34300_34332(f_22049_34300_34314(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 34396, 36437);

                f_22049_34396_36436(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null, IsInvalid) (Syntax: 'public stat ... throw null;')
    BlockBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ throw null; }')
        IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null;')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    ExpressionBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> throw null')
        IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw null')
        ReturnedValue: 
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Int32, IsInvalid, IsImplicit) (Syntax: 'throw null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
                IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null')
                IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                    Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                    Operand: 
                    ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 33547, 36448);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 33547, 36448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 33547, 36448);
            }
        }

        [Fact]
        public void DestructorBody_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 36460, 37271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 36532, 36589);

                string
                source = @"
abstract class C
{
    ~C();
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 36603, 36647);

                var
                compilation = f_22049_36621_36646(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 36663, 36978);

                f_22049_36663_36977(
                            compilation, f_22049_36865_36958(f_22049_36865_36939(f_22049_36865_36915(ErrorCode.ERR_ConcreteMissingBody, "C"), "C.~C()"), 4, 6));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 36994, 37038);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37052, 37099);

                var
                model = f_22049_37064_37098(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37115, 37207);

                var
                node1 = f_22049_37127_37206(f_22049_37127_37197(f_22049_37127_37159(f_22049_37127_37141(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37221, 37260);

                f_22049_37221_37259(f_22049_37233_37258(model, node1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 36460, 37271);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 36460, 37271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 36460, 37271);
            }
        }

        [Fact]
        public void DestructorBody_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 37283, 38549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37355, 37423);

                string
                source = @"
class C
{
    ~C()
    { throw null; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37437, 37481);

                var
                compilation = f_22049_37455_37480(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37497, 37529);

                f_22049_37497_37528(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37545, 37589);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37603, 37695);

                var
                node1 = f_22049_37615_37694(f_22049_37615_37685(f_22049_37615_37647(f_22049_37615_37629(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 37711, 38538);

                f_22049_37711_38537(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: '~C() ... row null; }')
    BlockBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ throw null; }')
        IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null;')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    ExpressionBody: 
    null
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 37283, 38549);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 37283, 38549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 37283, 38549);
            }
        }

        [Fact]
        public void DestructorBody_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 38561, 39987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 38633, 38700);

                string
                source = @"
class C
{
    ~C()
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 38714, 38758);

                var
                compilation = f_22049_38732_38757(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 38774, 38806);

                f_22049_38774_38805(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 38822, 38866);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 38880, 38972);

                var
                node1 = f_22049_38892_38971(f_22049_38892_38962(f_22049_38892_38924(f_22049_38892_38906(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 38988, 39976);

                f_22049_38988_39975(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: '~C() ... throw null;')
    BlockBody: 
    null
    ExpressionBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> throw null')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'throw null')
        Expression: 
            IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 38561, 39987);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 38561, 39987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 38561, 39987);
            }
        }

        [Fact]
        public void DestructorBody_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 39999, 42447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 40071, 40159);

                string
                source = @"
class C
{
    ~C()
    { throw null; }
    => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 40173, 40217);

                var
                compilation = f_22049_40191_40216(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 40233, 40552);

                f_22049_40233_40551(
                            compilation, f_22049_40411_40532(f_22049_40411_40513(ErrorCode.ERR_BlockBodyAndExpressionBody, @"~C()
    { throw null; }
    => throw null;"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 40568, 40612);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 40626, 40718);

                var
                node1 = f_22049_40638_40717(f_22049_40638_40708(f_22049_40638_40670(f_22049_40638_40652(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 40734, 42436);

                f_22049_40734_42435(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null, IsInvalid) (Syntax: '~C() ... throw null;')
    BlockBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ throw null; }')
        IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null;')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    ExpressionBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> throw null')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw null')
        Expression: 
            IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 39999, 42447);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 39999, 42447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 39999, 42447);
            }
        }

        [Fact]
        public void AccessorBody_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 42459, 43011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 42529, 42614);

                string
                source = @"
abstract class C
{
    abstract protected int P { get; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 42628, 42672);

                var
                compilation = f_22049_42646_42671(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 42688, 42720);

                f_22049_42688_42719(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 42736, 42780);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 42794, 42841);

                var
                model = f_22049_42806_42840(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 42857, 42947);

                var
                node1 = f_22049_42869_42946(f_22049_42869_42937(f_22049_42869_42901(f_22049_42869_42883(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 42961, 43000);

                f_22049_42961_42999(f_22049_42973_42998(model, node1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 42459, 43011);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 42459, 43011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 42459, 43011);
            }
        }

        [Fact]
        public void AccessorBody_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 43023, 44318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 43093, 43195);

                string
                source = @"
class C
{
    int P 
    { 
        set
        { throw null; }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 43209, 43253);

                var
                compilation = f_22049_43227_43252(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 43269, 43301);

                f_22049_43269_43300(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 43317, 43361);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 43375, 43465);

                var
                node1 = f_22049_43387_43464(f_22049_43387_43455(f_22049_43387_43419(f_22049_43387_43401(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 43481, 44307);

                f_22049_43481_44306(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'set ... row null; }')
    BlockBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ throw null; }')
        IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null;')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
    ExpressionBody: 
    null
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 43023, 44318);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 43023, 44318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 43023, 44318);
            }
        }

        [Fact]
        public void AccessorBody_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 44330, 45818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 44400, 44536);

                string
                source = @"
class C
{
    event System.Action E
    {
        add => throw null;
        remove {throw null;}
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 44550, 44594);

                var
                compilation = f_22049_44568_44593(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 44610, 44642);

                f_22049_44610_44641(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 44658, 44702);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 44716, 44805);

                var
                node1 = f_22049_44728_44804(f_22049_44728_44796(f_22049_44728_44760(f_22049_44728_44742(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 44821, 45807);

                f_22049_44821_45806(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null) (Syntax: 'add => throw null;')
    BlockBody: 
    null
    ExpressionBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '=> throw null')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsImplicit) (Syntax: 'throw null')
        Expression: 
            IThrowOperation (OperationKind.Throw, Type: null) (Syntax: 'throw null')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 44330, 45818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 44330, 45818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 44330, 45818);
            }
        }

        [Fact]
        public void AccessorBody_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 45830, 48377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 45900, 46072);

                string
                source = @"
class C
{
    event System.Action E
    {
        remove 
        { throw null; }
        => throw null;
        add { throw null;}
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 46086, 46130);

                var
                compilation = f_22049_46104_46129(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 46146, 46483);

                f_22049_46146_46482(
                            compilation, f_22049_46331_46463(f_22049_46331_46444(ErrorCode.ERR_BlockBodyAndExpressionBody, @"remove 
        { throw null; }
        => throw null;"), 6, 9));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 46499, 46543);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 46557, 46646);

                var
                node1 = f_22049_46569_46645(f_22049_46569_46637(f_22049_46569_46601(f_22049_46569_46583(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 46662, 48366);

                f_22049_46662_48365(
                            compilation, node1, expectedOperationTree:
                @"
IMethodBodyOperation (OperationKind.MethodBody, Type: null, IsInvalid) (Syntax: 'remove ... throw null;')
    BlockBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ throw null; }')
        IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null;')
        IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
            ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
    ExpressionBody: 
    IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '=> throw null')
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid, IsImplicit) (Syntax: 'throw null')
        Expression: 
            IThrowOperation (OperationKind.Throw, Type: null, IsInvalid) (Syntax: 'throw null')
            IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.Exception, Constant: null, IsInvalid, IsImplicit) (Syntax: 'null')
                Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: True, IsUserDefined: False) (MethodSymbol: null)
                Operand: 
                ILiteralOperation (OperationKind.Literal, Type: null, Constant: null, IsInvalid) (Syntax: 'null')
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 45830, 48377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 45830, 48377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 45830, 48377);
            }
        }

        [Fact]
        public void AccessorBody_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(22049, 48389, 49232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 48459, 48540);

                string
                source = @"
abstract class C
{
    int P { get; } => throw null;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 48554, 48598);

                var
                compilation = f_22049_48572_48597(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 48614, 48941);

                f_22049_48614_48940(
                            compilation, f_22049_48817_48921(f_22049_48817_48902(ErrorCode.ERR_BlockBodyAndExpressionBody, "int P { get; } => throw null;"), 4, 5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 48957, 49001);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 49015, 49062);

                var
                model = f_22049_49027_49061(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 49078, 49168);

                var
                node1 = f_22049_49090_49167(f_22049_49090_49158(f_22049_49090_49122(f_22049_49090_49104(tree))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(22049, 49182, 49221);

                f_22049_49182_49220(f_22049_49194_49219(model, node1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(22049, 48389, 49232);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22049, 48389, 49232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22049, 48389, 49232);
            }
        }

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_821_846(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 821, 846);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_863_894(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 863, 894);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22049_981_1015(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 981, 1015);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_1044_1058(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1044, 1058);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_1044_1076(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1044, 1076);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_1044_1114(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1044, 1114);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_1044_1123(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1044, 1123);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22049_1150_1175(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1150, 1175);
            return return_v;
        }


        int
        f_22049_1138_1176(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1138, 1176);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_1475_1500(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1475, 1500);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_1517_1548(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1517, 1548);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_1635_1649(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1635, 1649);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_1635_1667(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1635, 1667);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_1635_1705(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1635, 1705);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_1635_1714(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1635, 1714);
            return return_v;
        }


        int
        f_22049_1731_2594(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 1731, 2594);
            return 0;
        }


        int
        f_22049_2611_3431(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 2611, 3431);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_3735_3760(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 3735, 3760);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_3777_3808(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 3777, 3808);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_3895_3909(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 3895, 3909);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_3895_3927(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 3895, 3927);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_3895_3965(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 3895, 3965);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_3895_3974(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 3895, 3974);
            return return_v;
        }


        int
        f_22049_3991_5021(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 3991, 5021);
            return 0;
        }


        int
        f_22049_5038_5858(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 5038, 5858);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_6192_6217(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6192, 6217);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_6423_6536(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6423, 6536);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_6423_6555(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6423, 6555);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_6234_6574(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6234, 6574);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_6661_6675(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6661, 6675);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_6661_6693(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6661, 6693);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_6661_6731(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6661, 6731);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_6661_6740(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6661, 6740);
            return return_v;
        }


        int
        f_22049_6757_8515(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 6757, 8515);
            return 0;
        }


        int
        f_22049_8532_10075(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 8532, 10075);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_10396_10421(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 10396, 10421);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_10438_10469(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 10438, 10469);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_10556_10570(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 10556, 10570);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_10556_10588(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 10556, 10588);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_10556_10626(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 10556, 10626);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_10556_10635(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 10556, 10635);
            return return_v;
        }


        int
        f_22049_10652_11462(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 10652, 11462);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_11787_11812(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 11787, 11812);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_11829_11860(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 11829, 11860);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_11947_11961(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 11947, 11961);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_11947_11979(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 11947, 11979);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_11947_12017(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 11947, 12017);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_11947_12026(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 11947, 12026);
            return return_v;
        }


        int
        f_22049_12043_12864(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 12043, 12864);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_13237_13262(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13237, 13262);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_13480_13617(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13480, 13617);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_13480_13636(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13480, 13636);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_13279_13637(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13279, 13637);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_13724_13738(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13724, 13738);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_13724_13756(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13724, 13756);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_13724_13794(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13724, 13794);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_13724_13803(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13724, 13803);
            return return_v;
        }


        int
        f_22049_13820_15482(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 13820, 15482);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_15972_15997(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 15972, 15997);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_16203_16312(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16203, 16312);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_16203_16331(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16203, 16331);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_16014_16332(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16014, 16332);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_16419_16433(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16419, 16433);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_16419_16451(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16419, 16451);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_16419_16489(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16419, 16489);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_16419_16498(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16419, 16498);
            return return_v;
        }


        int
        f_22049_16515_17433(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 16515, 17433);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_17789_17814(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 17789, 17814);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_17831_17862(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 17831, 17862);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_17949_17963(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 17949, 17963);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_17949_17981(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 17949, 17981);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_17949_18019(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 17949, 18019);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_17949_18027(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 17949, 18027);
            return return_v;
        }


        int
        f_22049_18044_19748(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 18044, 19748);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_20128_20153(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20128, 20153);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_20359_20463(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20359, 20463);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_20359_20482(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20359, 20482);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_20170_20483(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20170, 20483);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_20570_20584(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20570, 20584);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_20570_20602(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20570, 20602);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_20570_20640(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20570, 20640);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_20570_20648(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20570, 20648);
            return return_v;
        }


        int
        f_22049_20665_22436(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        syntaxNode, string
        expectedFlowGraph)
        {
            VerifyFlowGraph(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNode, expectedFlowGraph: expectedFlowGraph);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 20665, 22436);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_22647_22672(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 22647, 22672);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_22929_22979(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 22929, 22979);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_22929_23012(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 22929, 23012);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_22929_23032(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 22929, 23032);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_22689_23051(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 22689, 23051);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22049_23138_23172(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23138, 23172);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_23201_23215(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23201, 23215);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_23201_23233(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23201, 23233);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_23201_23271(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23201, 23271);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_23201_23280(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23201, 23280);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22049_23307_23332(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23307, 23332);
            return return_v;
        }


        int
        f_22049_23295_23333(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23295, 23333);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_23561_23586(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23561, 23586);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_23603_23634(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23603, 23634);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_23721_23735(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23721, 23735);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_23721_23753(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23721, 23753);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_23721_23791(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23721, 23791);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_23721_23800(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23721, 23800);
            return return_v;
        }


        int
        f_22049_23817_24680(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 23817, 24680);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_24907_24932(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 24907, 24932);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_24949_24980(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 24949, 24980);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_25067_25081(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 25067, 25081);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_25067_25099(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 25067, 25099);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_25067_25137(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 25067, 25137);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_25067_25146(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 25067, 25146);
            return return_v;
        }


        int
        f_22049_25163_26513(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 25163, 26513);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_26761_26786(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 26761, 26786);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_27009_27139(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 27009, 27139);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_27009_27158(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 27009, 27158);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_26803_27177(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 26803, 27177);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_27264_27278(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 27264, 27278);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_27264_27296(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 27264, 27296);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_27264_27334(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 27264, 27334);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_27264_27343(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 27264, 27343);
            return return_v;
        }


        int
        f_22049_27360_29449(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 27360, 29449);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_29670_29695(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 29670, 29695);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_29971_30023(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 29971, 30023);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_29971_30067(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 29971, 30067);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_29971_30087(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 29971, 30087);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_29712_30106(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 29712, 30106);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22049_30193_30227(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30193, 30227);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_30256_30270(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30256, 30270);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_30256_30288(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30256, 30288);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_30256_30326(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30256, 30326);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_30256_30335(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30256, 30335);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22049_30362_30387(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30362, 30387);
            return return_v;
        }


        int
        f_22049_30350_30388(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30350, 30388);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_30626_30651(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30626, 30651);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_30668_30699(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30668, 30699);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_30786_30800(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30786, 30800);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_30786_30818(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30786, 30818);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_30786_30856(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30786, 30856);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_30786_30865(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30786, 30865);
            return return_v;
        }


        int
        f_22049_30882_31715(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 30882, 31715);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_31952_31977(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 31952, 31977);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_31994_32025(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 31994, 32025);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_32112_32126(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 32112, 32126);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_32112_32144(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 32112, 32144);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_32112_32182(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 32112, 32182);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_32112_32191(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 32112, 32191);
            return return_v;
        }


        int
        f_22049_32208_33523(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 32208, 33523);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_33781_33806(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 33781, 33806);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_34037_34175(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 34037, 34175);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_34037_34194(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 34037, 34194);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_33823_34213(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 33823, 34213);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_34300_34314(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 34300, 34314);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_34300_34332(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 34300, 34332);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_34300_34370(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 34300, 34370);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_34300_34379(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 34300, 34379);
            return return_v;
        }


        int
        f_22049_34396_36436(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 34396, 36436);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_36621_36646(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 36621, 36646);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_36865_36915(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 36865, 36915);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_36865_36939(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, params object[]
        arguments)
        {
            var return_v = this_param.WithArguments(arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 36865, 36939);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_36865_36958(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 36865, 36958);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_36663_36977(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 36663, 36977);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22049_37064_37098(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37064, 37098);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_37127_37141(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37127, 37141);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_37127_37159(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37127, 37159);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_37127_37197(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37127, 37197);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_37127_37206(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37127, 37206);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22049_37233_37258(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37233, 37258);
            return return_v;
        }


        int
        f_22049_37221_37259(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37221, 37259);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_37455_37480(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37455, 37480);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_37497_37528(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37497, 37528);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_37615_37629(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37615, 37629);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_37615_37647(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37615, 37647);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_37615_37685(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37615, 37685);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_37615_37694(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37615, 37694);
            return return_v;
        }


        int
        f_22049_37711_38537(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 37711, 38537);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_38732_38757(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 38732, 38757);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_38774_38805(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 38774, 38805);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_38892_38906(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 38892, 38906);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_38892_38924(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 38892, 38924);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_38892_38962(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 38892, 38962);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_38892_38971(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 38892, 38971);
            return return_v;
        }


        int
        f_22049_38988_39975(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 38988, 39975);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_40191_40216(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40191, 40216);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_40411_40513(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40411, 40513);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_40411_40532(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40411, 40532);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_40233_40551(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40233, 40551);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_40638_40652(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40638, 40652);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_40638_40670(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40638, 40670);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        f_22049_40638_40708(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40638, 40708);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        f_22049_40638_40717(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40638, 40717);
            return return_v;
        }


        int
        f_22049_40734_42435(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 40734, 42435);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_42646_42671(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42646, 42671);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_42688_42719(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42688, 42719);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22049_42806_42840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42806, 42840);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_42869_42883(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42869, 42883);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_42869_42901(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42869, 42901);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        f_22049_42869_42937(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42869, 42937);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_22049_42869_42946(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42869, 42946);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22049_42973_42998(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42973, 42998);
            return return_v;
        }


        int
        f_22049_42961_42999(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 42961, 42999);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_43227_43252(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 43227, 43252);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_43269_43300(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 43269, 43300);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_43387_43401(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 43387, 43401);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_43387_43419(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 43387, 43419);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        f_22049_43387_43455(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 43387, 43455);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_22049_43387_43464(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 43387, 43464);
            return return_v;
        }


        int
        f_22049_43481_44306(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 43481, 44306);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_44568_44593(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 44568, 44593);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_44610_44641(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 44610, 44641);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_44728_44742(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 44728, 44742);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_44728_44760(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 44728, 44760);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        f_22049_44728_44796(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 44728, 44796);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_22049_44728_44804(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        source)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 44728, 44804);
            return return_v;
        }


        int
        f_22049_44821_45806(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 44821, 45806);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_46104_46129(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46104, 46129);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_46331_46444(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46331, 46444);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_46331_46463(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46331, 46463);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_46146_46482(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46146, 46482);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_46569_46583(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46569, 46583);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_46569_46601(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46569, 46601);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        f_22049_46569_46637(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46569, 46637);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_22049_46569_46645(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        source)
        {
            var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46569, 46645);
            return return_v;
        }


        int
        f_22049_46662_48365(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        node, string
        expectedOperationTree)
        {
            compilation.VerifyOperationTree((Microsoft.CodeAnalysis.SyntaxNode)node, expectedOperationTree: expectedOperationTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 46662, 48365);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_48572_48597(string
        source)
        {
            var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 48572, 48597);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_48817_48902(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, string
        squiggledText)
        {
            var return_v = Diagnostic((object)code, squiggledText);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 48817, 48902);
            return return_v;
        }


        Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        f_22049_48817_48921(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
        this_param, int
        line, int
        column)
        {
            var return_v = this_param.WithLocation(line, column);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 48817, 48921);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_22049_48614_48940(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 48614, 48940);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel
        f_22049_49027_49061(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetSemanticModel(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 49027, 49061);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_22049_49090_49104(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 49090, 49104);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        f_22049_49090_49122(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.DescendantNodes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 49090, 49122);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        f_22049_49090_49158(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
        source)
        {
            var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 49090, 49158);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        f_22049_49090_49167(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 49090, 49167);
            return return_v;
        }


        Microsoft.CodeAnalysis.IOperation?
        f_22049_49194_49219(Microsoft.CodeAnalysis.SemanticModel
        this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
        node)
        {
            var return_v = this_param.GetOperation((Microsoft.CodeAnalysis.SyntaxNode)node);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 49194, 49219);
            return return_v;
        }


        int
        f_22049_49182_49220(Microsoft.CodeAnalysis.IOperation?
        @object)
        {
            Assert.Null((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(22049, 49182, 49220);
            return 0;
        }

    }
}
