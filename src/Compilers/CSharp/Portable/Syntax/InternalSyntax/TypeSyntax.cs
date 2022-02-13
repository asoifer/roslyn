// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal abstract partial class TypeSyntax
    {
        public bool IsVar
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10835, 376, 402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10835, 379, 402);
                    return f_10835_379_402(this, "var"); DynAbs.Tracing.TraceSender.TraceExitMethod(10835, 376, 402);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10835, 376, 402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 376, 402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsUnmanaged
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10835, 437, 469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10835, 440, 469);
                    return f_10835_440_469(this, "unmanaged"); DynAbs.Tracing.TraceSender.TraceExitMethod(10835, 437, 469);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10835, 437, 469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 437, 469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10835, 502, 532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10835, 505, 532);
                    return f_10835_505_532(this, "notnull"); DynAbs.Tracing.TraceSender.TraceExitMethod(10835, 502, 532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10835, 502, 532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 502, 532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10835, 562, 589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10835, 565, 589);
                    return f_10835_565_589(this, "nint"); DynAbs.Tracing.TraceSender.TraceExitMethod(10835, 562, 589);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10835, 562, 589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 562, 589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNuint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10835, 620, 648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10835, 623, 648);
                    return f_10835_623_648(this, "nuint"); DynAbs.Tracing.TraceSender.TraceExitMethod(10835, 620, 648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10835, 620, 648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 620, 648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool IsIdentifierName(string id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10835, 702, 774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10835, 705, 774);
                return this is IdentifierNameSyntax name && (DynAbs.Tracing.TraceSender.Expression_True(10835, 705, 774) && f_10835_742_768(f_10835_742_757(name)) == id); DynAbs.Tracing.TraceSender.TraceExitMethod(10835, 702, 774);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10835, 702, 774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 702, 774);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
            f_10835_742_757(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.IdentifierNameSyntax
            this_param)
            {
                var return_v = this_param.Identifier;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10835, 742, 757);
                return return_v;
            }


            string
            f_10835_742_768(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10835, 742, 768);
                return return_v;
            }

        }

        public bool IsRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10835, 805, 834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10835, 808, 834);
                    return f_10835_808_812() == SyntaxKind.RefType; DynAbs.Tracing.TraceSender.TraceExitMethod(10835, 805, 834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10835, 805, 834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 805, 834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static TypeSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10835, 299, 842);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10835, 299, 842);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10835, 299, 842);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10835, 299, 842);

        bool
        f_10835_379_402(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
        this_param, string
        id)
        {
            var return_v = this_param.IsIdentifierName(id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10835, 379, 402);
            return return_v;
        }


        bool
        f_10835_440_469(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
        this_param, string
        id)
        {
            var return_v = this_param.IsIdentifierName(id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10835, 440, 469);
            return return_v;
        }


        bool
        f_10835_505_532(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
        this_param, string
        id)
        {
            var return_v = this_param.IsIdentifierName(id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10835, 505, 532);
            return return_v;
        }


        bool
        f_10835_565_589(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
        this_param, string
        id)
        {
            var return_v = this_param.IsIdentifierName(id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10835, 565, 589);
            return return_v;
        }


        bool
        f_10835_623_648(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.TypeSyntax
        this_param, string
        id)
        {
            var return_v = this_param.IsIdentifierName(id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10835, 623, 648);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntaxKind
        f_10835_808_812()
        {
            var return_v = Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10835, 808, 812);
            return return_v;
        }

    }
}
