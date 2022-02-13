// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class SyntaxDiagnosticInfo : DiagnosticInfo
    {
        static SyntaxDiagnosticInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10034, 415, 576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 469, 565);

                f_10034_469_564(typeof(SyntaxDiagnosticInfo), r => new SyntaxDiagnosticInfo(r));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10034, 415, 576);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 415, 576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 415, 576);
            }
        }

        internal readonly int Offset;

        internal readonly int Width;

        internal SyntaxDiagnosticInfo(int offset, int width, ErrorCode code, params object[] args)
        : base(f_10034_778_809_C(CSharp.MessageProvider.Instance), (int)code, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10034, 667, 956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 610, 616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 649, 654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 852, 877);

                f_10034_852_876(width >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 891, 912);

                this.Offset = offset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 926, 945);

                this.Width = width;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10034, 667, 956);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 667, 956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 667, 956);
            }
        }

        internal SyntaxDiagnosticInfo(int offset, int width, ErrorCode code)
        : this(f_10034_1057_1063_C(offset), width, code, f_10034_1078_1099())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10034, 968, 1122);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10034, 968, 1122);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 968, 1122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 968, 1122);
            }
        }

        internal SyntaxDiagnosticInfo(ErrorCode code, params object[] args)
        : this(f_10034_1222_1223_C(0), 0, code, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10034, 1134, 1261);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10034, 1134, 1261);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 1134, 1261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 1134, 1261);
            }
        }

        internal SyntaxDiagnosticInfo(ErrorCode code)
        : this(f_10034_1339_1340_C(0), 0, code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10034, 1273, 1372);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10034, 1273, 1372);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 1273, 1372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 1273, 1372);
            }
        }

        public SyntaxDiagnosticInfo WithOffset(int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10034, 1384, 1560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 1459, 1549);

                return f_10034_1466_1548(offset, this.Width, f_10034_1522_1531(this), f_10034_1533_1547(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10034, 1384, 1560);

                int
                f_10034_1522_1531(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10034, 1522, 1531);
                    return return_v;
                }


                object[]
                f_10034_1533_1547(Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10034, 1533, 1547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
                f_10034_1466_1548(int
                offset, int
                width, int
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo(offset, width, (Microsoft.CodeAnalysis.CSharp.ErrorCode)code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 1466, 1548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 1384, 1560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 1384, 1560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10034, 1605, 1803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 1682, 1703);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10034, 1682, 1702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 1717, 1748);

                f_10034_1717_1747(writer, this.Offset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 1762, 1792);

                f_10034_1762_1791(writer, this.Width);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10034, 1605, 1803);

                int
                f_10034_1717_1747(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 1717, 1747);
                    return 0;
                }


                int
                f_10034_1762_1791(Roslyn.Utilities.ObjectWriter
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 1762, 1791);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 1605, 1803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 1605, 1803);
            }
        }

        protected SyntaxDiagnosticInfo(ObjectReader reader)
        : base(f_10034_1887_1893_C(reader))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10034, 1815, 2009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 610, 616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 649, 654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 1919, 1952);

                this.Offset = f_10034_1933_1951(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10034, 1966, 1998);

                this.Width = f_10034_1979_1997(reader);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10034, 1815, 2009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10034, 1815, 2009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10034, 1815, 2009);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10034, 346, 2038);

        static int
        f_10034_469_564(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 469, 564);
            return 0;
        }


        int
        f_10034_852_876(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 852, 876);
            return 0;
        }


        static Microsoft.CodeAnalysis.CommonMessageProvider
        f_10034_778_809_C(Microsoft.CodeAnalysis.CommonMessageProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10034, 667, 956);
            return return_v;
        }


        static object[]
        f_10034_1078_1099()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 1078, 1099);
            return return_v;
        }


        static int
        f_10034_1057_1063_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10034, 968, 1122);
            return return_v;
        }


        static int
        f_10034_1222_1223_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10034, 1134, 1261);
            return return_v;
        }


        static int
        f_10034_1339_1340_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10034, 1273, 1372);
            return return_v;
        }


        int
        f_10034_1933_1951(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 1933, 1951);
            return return_v;
        }


        int
        f_10034_1979_1997(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10034, 1979, 1997);
            return return_v;
        }


        static Roslyn.Utilities.ObjectReader
        f_10034_1887_1893_C(Roslyn.Utilities.ObjectReader
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10034, 1815, 2009);
            return return_v;
        }

    }
}
