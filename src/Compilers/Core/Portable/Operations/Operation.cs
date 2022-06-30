// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class Operation : IOperation
    {
        protected static readonly IOperation s_unset;

        private readonly SemanticModel? _owningSemanticModelOpt;

        private IOperation? _parentDoNotAccessDirectly;

        protected Operation(SemanticModel? semanticModel, SyntaxNode syntax, bool isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(465, 1101, 2022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 874, 897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1062, 1088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 2566, 2597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 2873, 2906);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1222, 1826) || true) && (semanticModel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 1222, 1826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1281, 1339);

                    f_465_1281_1338(f_465_1294_1329(semanticModel) != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1357, 1811) || true) && (f_465_1361_1401(semanticModel))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 1357, 1811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1443, 1510);

                        f_465_1443_1509(f_465_1456_1491(semanticModel) == semanticModel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(465, 1357, 1811);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 1357, 1811);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1592, 1659);

                        f_465_1592_1658(f_465_1605_1640(semanticModel) != semanticModel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1681, 1792);

                        f_465_1681_1791(f_465_1694_1751(f_465_1694_1729(semanticModel)) == f_465_1755_1790(semanticModel));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(465, 1357, 1811);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(465, 1222, 1826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1848, 1888);

                _owningSemanticModelOpt = semanticModel;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1904, 1920);

                Syntax = syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1934, 1958);

                IsImplicit = isImplicit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 1974, 2011);

                _parentDoNotAccessDirectly = s_unset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(465, 1101, 2022);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 1101, 2022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 1101, 2022);
            }
        }

        public IOperation? Parent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 2190, 2411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 2226, 2344);

                    f_465_2226_2343(_parentDoNotAccessDirectly != s_unset, "Attempt to access parent node before construction is complete!");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 2362, 2396);

                    return _parentDoNotAccessDirectly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(465, 2190, 2411);

                    int
                    f_465_2226_2343(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 2226, 2343);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 2140, 2422);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 2140, 2422);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsImplicit { get; }

        public abstract OperationKind Kind { get; }

        public SyntaxNode Syntax { get; }

        public abstract ITypeSymbol? Type { get; }

        public string Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 3644, 3662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 3647, 3662);
                    return f_465_3647_3662(f_465_3647_3653()); DynAbs.Tracing.TraceSender.TraceExitMethod(465, 3644, 3662);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 3315, 3674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 3315, 3674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract CodeAnalysis.ConstantValue? OperationConstantValue { get; }

        public Optional<object?> ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 4150, 4441);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 4186, 4347) || true) && (f_465_4190_4212() == null || (DynAbs.Tracing.TraceSender.Expression_False(465, 4190, 4252) || f_465_4224_4252(f_465_4224_4246())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 4186, 4347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 4294, 4328);

                        return default(Optional<object?>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(465, 4186, 4347);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 4367, 4426);

                    return f_465_4374_4425(f_465_4396_4424(f_465_4396_4418()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(465, 4150, 4441);

                    Microsoft.CodeAnalysis.ConstantValue?
                    f_465_4190_4212()
                    {
                        var return_v = OperationConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 4190, 4212);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_465_4224_4246()
                    {
                        var return_v = OperationConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 4224, 4246);
                        return return_v;
                    }


                    bool
                    f_465_4224_4252(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.IsBad;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 4224, 4252);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_465_4396_4418()
                    {
                        var return_v = OperationConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 4396, 4418);
                        return return_v;
                    }


                    object?
                    f_465_4396_4424(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 4396, 4424);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Optional<object?>
                    f_465_4374_4425(object?
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Optional<object?>(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 4374, 4425);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 4087, 4452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 4087, 4452);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<IOperation> IOperation.Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 4636, 4659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 4639, 4659);
                    return f_465_4639_4659(this); DynAbs.Tracing.TraceSender.TraceExitMethod(465, 4636, 4659);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 4636, 4659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 4636, 4659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Operation.Enumerable ChildOperations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 4990, 5023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 4993, 5023);
                    return f_465_4993_5023(this); DynAbs.Tracing.TraceSender.TraceExitMethod(465, 4990, 5023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 4990, 5023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 4990, 5023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract IOperation GetCurrent(int slot, int index);

        protected abstract (bool hasNext, int nextSlot, int nextIndex) MoveNext(int previousSlot, int previousIndex);

        SemanticModel? IOperation.SemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 5269, 5318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 5272, 5318);
                    return f_465_5272_5318_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_owningSemanticModelOpt, 465, 5272, 5318)?.ContainingModelOrSelf); DynAbs.Tracing.TraceSender.TraceExitMethod(465, 5269, 5318);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 5269, 5318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 5269, 5318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SemanticModel? OwningSemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 5749, 5775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 5752, 5775);
                    return _owningSemanticModelOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(465, 5749, 5775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 5749, 5775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 5749, 5775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract void Accept(OperationVisitor visitor);

        public abstract TResult? Accept<TArgument, TResult>(OperationVisitor<TArgument, TResult> visitor, TArgument argument);

        protected void SetParentOperation(IOperation? parent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(465, 5984, 6407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 6062, 6114);

                f_465_6062_6113(_parentDoNotAccessDirectly == s_unset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 6128, 6160);

                f_465_6128_6159(parent != s_unset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 6174, 6210);

                _parentDoNotAccessDirectly = parent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 6301, 6396);

                f_465_6301_6395(parent == null || (DynAbs.Tracing.TraceSender.Expression_False(465, 6314, 6394) || f_465_6332_6371(((Operation)parent)) == f_465_6375_6394()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(465, 5984, 6407);

                int
                f_465_6062_6113(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 6062, 6113);
                    return 0;
                }


                int
                f_465_6128_6159(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 6128, 6159);
                    return 0;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_465_6332_6371(Microsoft.CodeAnalysis.Operation
                this_param)
                {
                    var return_v = this_param.OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 6332, 6371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel?
                f_465_6375_6394()
                {
                    var return_v = OwningSemanticModel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 6375, 6394);
                    return return_v;
                }


                int
                f_465_6301_6395(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 6301, 6395);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 5984, 6407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 5984, 6407);
            }
        }

        [return: NotNullIfNotNull("operation")]
        public static T? SetParentOperation<T>(T? operation, IOperation? parent) where T : IOperation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(465, 6419, 6886);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 6764, 6842) || true) && (operation is Operation op)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 6764, 6842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 6812, 6842);

                    f_465_6812_6841(op, parent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(465, 6764, 6842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 6858, 6875);

                return operation;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(465, 6419, 6886);

                int
                f_465_6812_6841(Microsoft.CodeAnalysis.Operation
                this_param, Microsoft.CodeAnalysis.IOperation?
                parent)
                {
                    this_param.SetParentOperation(parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 6812, 6841);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 6419, 6886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 6419, 6886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<T> SetParentOperation<T>(ImmutableArray<T> operations, IOperation? parent) where T : IOperation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(465, 6898, 7403);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7095, 7219) || true) && (operations.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 7095, 7219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7186, 7204);

                    return operations;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(465, 7095, 7219);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7235, 7358);
                    foreach (var operation in f_465_7261_7271_I(operations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 7235, 7358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7305, 7343);

                        f_465_7305_7342(operation, parent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(465, 7235, 7358);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(465, 1, 124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(465, 1, 124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7374, 7392);

                return operations;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(465, 6898, 7403);

                T?
                f_465_7305_7342(T
                operation, Microsoft.CodeAnalysis.IOperation?
                parent)
                {
                    var return_v = SetParentOperation(operation, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 7305, 7342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_465_7261_7271_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 7261, 7271);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 6898, 7403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 6898, 7403);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        internal static void VerifyParentOperation(IOperation? parent, IOperation child)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(465, 7415, 7677);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7552, 7666) || true) && (child is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 7552, 7666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7605, 7651);

                    f_465_7605_7650((object?)f_465_7627_7639(child) == parent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(465, 7552, 7666);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(465, 7415, 7677);

                Microsoft.CodeAnalysis.IOperation?
                f_465_7627_7639(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 7627, 7639);
                    return return_v;
                }


                int
                f_465_7605_7650(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 7605, 7650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 7415, 7677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 7415, 7677);
            }
        }

        [Conditional("DEBUG")]
        internal static void VerifyParentOperation<T>(IOperation? parent, ImmutableArray<T> children) where T : IOperation
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(465, 7689, 8035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7860, 7894);

                f_465_7860_7893(f_465_7873_7892_M(!children.IsDefault));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7908, 8024);
                    foreach (var child in f_465_7930_7938_I(children))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(465, 7908, 8024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 7972, 8009);

                        f_465_7972_8008(parent, child);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(465, 7908, 8024);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(465, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(465, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(465, 7689, 8035);

                bool
                f_465_7873_7892_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 7873, 7892);
                    return return_v;
                }


                int
                f_465_7860_7893(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 7860, 7893);
                    return 0;
                }


                int
                f_465_7972_8008(Microsoft.CodeAnalysis.IOperation?
                parent, T
                child)
                {
                    VerifyParentOperation(parent, (Microsoft.CodeAnalysis.IOperation)child);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 7972, 8008);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_465_7930_7938_I(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 7930, 7938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(465, 7689, 8035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 7689, 8035);
            }
        }

        private static readonly ObjectPool<Queue<IOperation>> s_queuePool;

        static Operation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(465, 641, 8204);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 749, 831);
            s_unset = f_465_759_831(semanticModel: null, syntax: null!, isImplicit: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(465, 8101, 8196);
            s_queuePool = f_465_8128_8196(() => new Queue<IOperation>(), 10); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(465, 641, 8204);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(465, 641, 8204);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(465, 641, 8204);

        static Microsoft.CodeAnalysis.Operations.EmptyOperation
        f_465_759_831(Microsoft.CodeAnalysis.SemanticModel?
        semanticModel, Microsoft.CodeAnalysis.SyntaxNode
        syntax, bool
        isImplicit)
        {
            var return_v = new Microsoft.CodeAnalysis.Operations.EmptyOperation(semanticModel: semanticModel, syntax, isImplicit: isImplicit);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 759, 831);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_465_1294_1329(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.ContainingModelOrSelf;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 1294, 1329);
            return return_v;
        }


        static int
        f_465_1281_1338(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 1281, 1338);
            return 0;
        }


        static bool
        f_465_1361_1401(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.IsSpeculativeSemanticModel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 1361, 1401);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_465_1456_1491(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.ContainingModelOrSelf;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 1456, 1491);
            return return_v;
        }


        static int
        f_465_1443_1509(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 1443, 1509);
            return 0;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_465_1605_1640(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.ContainingModelOrSelf;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 1605, 1640);
            return return_v;
        }


        static int
        f_465_1592_1658(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 1592, 1658);
            return 0;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_465_1694_1729(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.ContainingModelOrSelf;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 1694, 1729);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_465_1694_1751(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.ContainingModelOrSelf;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 1694, 1751);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SemanticModel
        f_465_1755_1790(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.ContainingModelOrSelf;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 1755, 1790);
            return return_v;
        }


        static int
        f_465_1681_1791(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 1681, 1791);
            return 0;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_465_3647_3653()
        {
            var return_v = Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 3647, 3653);
            return return_v;
        }


        string
        f_465_3647_3662(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.Language;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 3647, 3662);
            return return_v;
        }


        Microsoft.CodeAnalysis.Operation.Enumerable
        f_465_4639_4659(Microsoft.CodeAnalysis.Operation
        this_param)
        {
            var return_v = this_param.ChildOperations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 4639, 4659);
            return return_v;
        }


        Microsoft.CodeAnalysis.Operation.Enumerable
        f_465_4993_5023(Microsoft.CodeAnalysis.Operation
        operation)
        {
            var return_v = new Microsoft.CodeAnalysis.Operation.Enumerable(operation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 4993, 5023);
            return return_v;
        }


        Microsoft.CodeAnalysis.SemanticModel?
        f_465_5272_5318_M(Microsoft.CodeAnalysis.SemanticModel?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(465, 5272, 5318);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Queue<Microsoft.CodeAnalysis.IOperation>>
        f_465_8128_8196(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Queue<Microsoft.CodeAnalysis.IOperation>>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.Queue<Microsoft.CodeAnalysis.IOperation>>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(465, 8128, 8196);
            return return_v;
        }

    }
}
