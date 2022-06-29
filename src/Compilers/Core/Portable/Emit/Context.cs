// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Emit
{

    internal struct EmitContext
    {

        public readonly CommonPEModuleBuilder Module;

        public readonly SyntaxNode SyntaxNodeOpt;

        public readonly DiagnosticBag Diagnostics;

        private readonly Flags _flags;

        public bool IncludePrivateMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(287, 597, 643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 600, 643);
                    return (_flags & Flags.IncludePrivateMembers) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(287, 597, 643);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(287, 597, 643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(287, 597, 643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MetadataOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(287, 679, 716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 682, 716);
                    return (_flags & Flags.MetadataOnly) != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(287, 679, 716);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(287, 679, 716);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(287, 679, 716);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsRefAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(287, 753, 794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 756, 794);
                    return MetadataOnly && (DynAbs.Tracing.TraceSender.Expression_True(287, 756, 794) && f_287_772_794_M(!IncludePrivateMembers)); DynAbs.Tracing.TraceSender.TraceExitMethod(287, 753, 794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(287, 753, 794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(287, 753, 794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public EmitContext(CommonPEModuleBuilder module, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool metadataOnly, bool includePrivateMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(287, 807, 1552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 980, 1009);

                f_287_980_1008(module != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1023, 1057);

                f_287_1023_1056(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1071, 1123);

                f_287_1071_1122(includePrivateMembers || (DynAbs.Tracing.TraceSender.Expression_False(287, 1084, 1121) || metadataOnly));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1139, 1155);

                Module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1169, 1199);

                SyntaxNodeOpt = syntaxNodeOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1213, 1239);

                Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1255, 1280);

                Flags
                flags = Flags.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1294, 1387) || true) && (metadataOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(287, 1294, 1387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1344, 1372);

                    flags |= Flags.MetadataOnly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(287, 1294, 1387);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1401, 1512) || true) && (includePrivateMembers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(287, 1401, 1512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1460, 1497);

                    flags |= Flags.IncludePrivateMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(287, 1401, 1512);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(287, 1526, 1541);

                _flags = flags;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(287, 807, 1552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(287, 807, 1552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(287, 807, 1552);
            }
        }

        [Flags]
        private enum Flags
        {
            None = 0,
            MetadataOnly = 1,
            IncludePrivateMembers = 2,
        }
        static EmitContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(287, 319, 1722);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(287, 319, 1722);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(287, 319, 1722);
        }

        bool
        f_287_772_794_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(287, 772, 794);
            return return_v;
        }


        static int
        f_287_980_1008(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(287, 980, 1008);
            return 0;
        }


        static int
        f_287_1023_1056(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(287, 1023, 1056);
            return 0;
        }


        static int
        f_287_1071_1122(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(287, 1071, 1122);
            return 0;
        }

    }
}
