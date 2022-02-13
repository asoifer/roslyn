// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class SingleNamespaceOrTypeDeclaration : Declaration
    {
        private readonly SyntaxReference _syntaxReference;

        private readonly SourceLocation _nameLocation;

        public readonly ImmutableArray<Diagnostic> Diagnostics;

        protected SingleNamespaceOrTypeDeclaration(
                    string name,
                    SyntaxReference syntaxReference,
                    SourceLocation nameLocation,
                    ImmutableArray<Diagnostic> diagnostics)
        : base(f_10399_1166_1170_C(name))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10399, 935, 1325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 436, 452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 495, 508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 1196, 1231);

                _syntaxReference = syntaxReference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 1245, 1274);

                _nameLocation = nameLocation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 1288, 1314);

                Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10399, 935, 1325);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10399, 935, 1325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10399, 935, 1325);
            }
        }

        public SourceLocation Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10399, 1392, 1491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 1428, 1476);

                    return f_10399_1435_1475(f_10399_1454_1474(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10399, 1392, 1491);

                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10399_1454_1474(Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.SyntaxReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10399, 1454, 1474);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceLocation
                    f_10399_1435_1475(Microsoft.CodeAnalysis.SyntaxReference
                    syntaxRef)
                    {
                        var return_v = new Microsoft.CodeAnalysis.SourceLocation(syntaxRef);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10399, 1435, 1475);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10399, 1337, 1502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10399, 1337, 1502);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SyntaxReference SyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10399, 1577, 1652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 1613, 1637);

                    return _syntaxReference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10399, 1577, 1652);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10399, 1514, 1663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10399, 1514, 1663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SourceLocation NameLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10399, 1734, 1806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 1770, 1791);

                    return _nameLocation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10399, 1734, 1806);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10399, 1675, 1817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10399, 1675, 1817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ImmutableArray<Declaration> GetDeclarationChildren()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10399, 1829, 2018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 1925, 2007);

                return f_10399_1932_2006(f_10399_1961_2005(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10399, 1829, 2018);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                f_10399_1961_2005(Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.GetNamespaceOrTypeDeclarationChildren();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10399, 1961, 2005);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10399_1932_2006(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                from)
                {
                    var return_v = StaticCast<Declaration>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10399, 1932, 2006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10399, 1829, 2018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10399, 1829, 2018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new ImmutableArray<SingleNamespaceOrTypeDeclaration> Children
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10399, 2123, 2226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10399, 2159, 2211);

                    return f_10399_2166_2210(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10399, 2123, 2226);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration>
                    f_10399_2166_2210(Microsoft.CodeAnalysis.CSharp.SingleNamespaceOrTypeDeclaration
                    this_param)
                    {
                        var return_v = this_param.GetNamespaceOrTypeDeclarationChildren();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10399, 2166, 2210);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10399, 2030, 2237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10399, 2030, 2237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected abstract ImmutableArray<SingleNamespaceOrTypeDeclaration> GetNamespaceOrTypeDeclarationChildren();

        static SingleNamespaceOrTypeDeclaration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10399, 316, 2364);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10399, 316, 2364);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10399, 316, 2364);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10399, 316, 2364);

        static string
        f_10399_1166_1170_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10399, 935, 1325);
            return return_v;
        }

    }
}
