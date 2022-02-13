// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    public partial class GenericNameSyntax
    {
        public bool IsUnboundGenericName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10769, 592, 718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10769, 628, 703);

                    return f_10769_635_656(this).Arguments.Any(SyntaxKind.OmittedTypeArgument);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10769, 592, 718);

                    Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
                    f_10769_635_656(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10769, 635, 656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10769, 535, 729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10769, 535, 729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override string ErrorDisplayName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10769, 741, 1006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10769, 809, 852);

                var
                pb = f_10769_818_851()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10769, 866, 953);

                f_10769_866_952(f_10769_866_940(f_10769_866_917(f_10769_866_905(pb.Builder, f_10769_884_894().ValueText), "<"), ',', f_10769_930_935() - 1), ">");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10769, 967, 995);

                return f_10769_974_994(pb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10769, 741, 1006);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10769_818_851()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10769, 818, 851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10769_884_894()
                {
                    var return_v = Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10769, 884, 894);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10769_866_905(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10769, 866, 905);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10769_866_917(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10769, 866, 917);
                    return return_v;
                }


                int
                f_10769_930_935()
                {
                    var return_v = Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10769, 930, 935);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10769_866_940(System.Text.StringBuilder
                this_param, char
                value, int
                repeatCount)
                {
                    var return_v = this_param.Append(value, repeatCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10769, 866, 940);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10769_866_952(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10769, 866, 952);
                    return return_v;
                }


                string
                f_10769_974_994(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10769, 974, 994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10769, 741, 1006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10769, 741, 1006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GenericNameSyntax()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10769, 480, 1013);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10769, 480, 1013);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10769, 480, 1013);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10769, 480, 1013);
    }
}
