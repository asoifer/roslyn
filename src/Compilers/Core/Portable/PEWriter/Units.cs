// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    /// <summary>
    /// A reference to a .NET assembly.
    /// </summary>
    internal interface IAssemblyReference : IModuleReference
    {

        AssemblyIdentity Identity { get; }

        Version? AssemblyVersionPattern { get; }
    }

    [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
    internal struct DefinitionWithLocation : IEquatable<DefinitionWithLocation>
    {

        public readonly IDefinition Definition;

        public readonly int StartLine;

        public readonly int StartColumn;

        public readonly int EndLine;

        public readonly int EndColumn;

        public DefinitionWithLocation(IDefinition definition,
                    int startLine, int startColumn, int endLine, int endColumn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(522, 1147, 1651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1298, 1327);

                f_522_1298_1326(startLine >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1341, 1372);

                f_522_1341_1371(startColumn >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1386, 1413);

                f_522_1386_1412(endLine >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1427, 1456);

                f_522_1427_1455(endColumn >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1472, 1496);

                Definition = definition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1510, 1532);

                StartLine = startLine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1546, 1572);

                StartColumn = startColumn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1586, 1604);

                EndLine = endLine;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1618, 1640);

                EndColumn = endColumn;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(522, 1147, 1651);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(522, 1147, 1651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(522, 1147, 1651);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(522, 1712, 1788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1715, 1788);
                return $"{Definition} => ({StartLine},{StartColumn}) - ({EndLine}, {EndColumn})"; DynAbs.Tracing.TraceSender.TraceExitMethod(522, 1712, 1788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(522, 1712, 1788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(522, 1712, 1788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(522, 1801, 1937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 1866, 1926);

                return obj is DefinitionWithLocation other && (DynAbs.Tracing.TraceSender.Expression_True(522, 1873, 1925) && Equals(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(522, 1801, 1937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(522, 1801, 1937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(522, 1801, 1937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(DefinitionWithLocation other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(522, 1949, 2199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 2022, 2188);

                return Definition == other.Definition && (DynAbs.Tracing.TraceSender.Expression_True(522, 2029, 2091) && StartLine == other.StartLine) && (DynAbs.Tracing.TraceSender.Expression_True(522, 2029, 2127) && StartColumn == other.StartColumn) && (DynAbs.Tracing.TraceSender.Expression_True(522, 2029, 2155) && EndLine == other.EndLine) && (DynAbs.Tracing.TraceSender.Expression_True(522, 2029, 2187) && EndColumn == other.EndColumn);
                DynAbs.Tracing.TraceSender.TraceExitMethod(522, 1949, 2199);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(522, 1949, 2199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(522, 1949, 2199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(522, 2211, 2365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(522, 2269, 2354);

                return f_522_2276_2353(f_522_2289_2327(Definition), f_522_2329_2352(StartLine));
                DynAbs.Tracing.TraceSender.TraceExitMethod(522, 2211, 2365);

                int
                f_522_2289_2327(Microsoft.Cci.IDefinition
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(522, 2289, 2327);
                    return return_v;
                }


                int
                f_522_2329_2352(int
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(522, 2329, 2352);
                    return return_v;
                }


                int
                f_522_2276_2353(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(522, 2276, 2353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(522, 2211, 2365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(522, 2211, 2365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static DefinitionWithLocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(522, 792, 2372);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(522, 792, 2372);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(522, 792, 2372);
        }

        static int
        f_522_1298_1326(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(522, 1298, 1326);
            return 0;
        }


        static int
        f_522_1341_1371(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(522, 1341, 1371);
            return 0;
        }


        static int
        f_522_1386_1412(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(522, 1386, 1412);
            return 0;
        }


        static int
        f_522_1427_1455(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(522, 1427, 1455);
            return 0;
        }

    }

    /// <summary>
    /// A reference to a .NET module.
    /// </summary>
    internal interface IModuleReference : IUnitReference
    {

        IAssemblyReference GetContainingAssembly(EmitContext context);
    }

    /// <summary>
    /// A unit of metadata stored as a single artifact and potentially produced and revised independently from other units.
    /// Examples of units include .NET assemblies and modules, as well C++ object files and compiled headers.
    /// </summary>
    internal interface IUnit : IUnitReference, IDefinition
    {
    }

    /// <summary>
    /// A reference to a instance of <see cref="IUnit"/>.
    /// </summary>
    internal interface IUnitReference : IReference, INamedEntity
    {
    }
}
