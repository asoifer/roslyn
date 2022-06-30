// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public sealed class SyntaxAnnotation : IObjectWritable, IEquatable<SyntaxAnnotation?>
    {
        static SyntaxAnnotation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(672, 758, 907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1072, 1155);
                ElasticAnnotation = f_672_1132_1154(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1341, 1349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 808, 896);

                f_672_808_895(typeof(SyntaxAnnotation), r => new SyntaxAnnotation(r));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(672, 758, 907);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 758, 907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 758, 907);
            }
        }

        public static SyntaxAnnotation ElasticAnnotation { get; }

        private readonly long _id;

        private static long s_nextId;

        public string? Kind { get; }

        public string? Data { get; }

        public SyntaxAnnotation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(672, 1558, 1678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1307, 1310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1480, 1508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1518, 1546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1608, 1667);

                _id = f_672_1614_1666(ref s_nextId);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(672, 1558, 1678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 1558, 1678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 1558, 1678);
            }
        }

        public SyntaxAnnotation(string? kind)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(672, 1690, 1802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1774, 1791);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(672, 1690, 1802);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 1690, 1802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 1690, 1802);
            }
        }

        public SyntaxAnnotation(string? kind, string? data)
        : this(f_672_1886_1890_C(kind))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(672, 1814, 1944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1916, 1933);

                this.Data = data;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(672, 1814, 1944);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 1814, 1944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 1814, 1944);
            }
        }

        private SyntaxAnnotation(ObjectReader reader)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(672, 1956, 2154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1307, 1310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1480, 1508);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 1518, 1546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2026, 2051);

                _id = f_672_2032_2050(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2065, 2097);

                this.Kind = f_672_2077_2096(reader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2111, 2143);

                this.Data = f_672_2123_2142(reader);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(672, 1956, 2154);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 1956, 2154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 1956, 2154);
            }
        }

        bool IObjectWritable.ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(672, 2214, 2221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2217, 2221);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(672, 2214, 2221);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 2214, 2221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 2214, 2221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void IObjectWritable.WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(672, 2234, 2430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2308, 2331);

                f_672_2308_2330(writer, _id);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2345, 2375);

                f_672_2345_2374(writer, f_672_2364_2373(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2389, 2419);

                f_672_2389_2418(writer, f_672_2408_2417(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(672, 2234, 2430);

                int
                f_672_2308_2330(Roslyn.Utilities.ObjectWriter
                this_param, long
                value)
                {
                    this_param.WriteInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2308, 2330);
                    return 0;
                }


                string?
                f_672_2364_2373(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(672, 2364, 2373);
                    return return_v;
                }


                int
                f_672_2345_2374(Roslyn.Utilities.ObjectWriter
                this_param, string?
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2345, 2374);
                    return 0;
                }


                string?
                f_672_2408_2417(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(672, 2408, 2417);
                    return return_v;
                }


                int
                f_672_2389_2418(Roslyn.Utilities.ObjectWriter
                this_param, string?
                value)
                {
                    this_param.WriteString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2389, 2418);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 2234, 2430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 2234, 2430);
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(672, 2442, 2605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2502, 2594);

                return f_672_2509_2593("Annotation: Kind='{0}' Data='{1}'", f_672_2560_2569(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(672, 2560, 2575) ?? ""), f_672_2577_2586(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(672, 2577, 2592) ?? ""));
                DynAbs.Tracing.TraceSender.TraceExitMethod(672, 2442, 2605);

                string?
                f_672_2560_2569(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(672, 2560, 2569);
                    return return_v;
                }


                string?
                f_672_2577_2586(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(672, 2577, 2586);
                    return return_v;
                }


                string
                f_672_2509_2593(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2509, 2593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 2442, 2605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 2442, 2605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SyntaxAnnotation? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(672, 2617, 2739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2685, 2728);

                return other is object && (DynAbs.Tracing.TraceSender.Expression_True(672, 2692, 2727) && _id == other._id);
                DynAbs.Tracing.TraceSender.TraceExitMethod(672, 2617, 2739);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 2617, 2739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 2617, 2739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(SyntaxAnnotation? left, SyntaxAnnotation? right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(672, 2751, 2994);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2855, 2941) || true) && (left is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(672, 2855, 2941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2905, 2926);

                    return right is null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(672, 2855, 2941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 2957, 2983);

                return f_672_2964_2982(left, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(672, 2751, 2994);

                bool
                f_672_2964_2982(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param, Microsoft.CodeAnalysis.SyntaxAnnotation?
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2964, 2982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 2751, 2994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 2751, 2994);
            }
        }

        public static bool operator !=(SyntaxAnnotation? left, SyntaxAnnotation? right) =>
            !(left == right);

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(672, 3131, 3251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 3196, 3240);

                return f_672_3203_3239(this, obj as SyntaxAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(672, 3131, 3251);

                bool
                f_672_3203_3239(Microsoft.CodeAnalysis.SyntaxAnnotation
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.SyntaxAnnotation?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 3203, 3239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 3131, 3251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 3131, 3251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(672, 3263, 3357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(672, 3321, 3346);

                return f_672_3328_3345(_id);
                DynAbs.Tracing.TraceSender.TraceExitMethod(672, 3263, 3357);

                int
                f_672_3328_3345(long
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 3328, 3345);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(672, 3263, 3357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(672, 3263, 3357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(672, 603, 3364);

        static int
        f_672_808_895(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 808, 895);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxAnnotation
        f_672_1132_1154()
        {
            var return_v = new Microsoft.CodeAnalysis.SyntaxAnnotation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 1132, 1154);
            return return_v;
        }


        static long
        f_672_1614_1666(ref long
        location)
        {
            var return_v = System.Threading.Interlocked.Increment(ref location);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 1614, 1666);
            return return_v;
        }


        static string?
        f_672_1886_1890_C(string?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(672, 1814, 1944);
            return return_v;
        }


        static long
        f_672_2032_2050(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadInt64();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2032, 2050);
            return return_v;
        }


        static string
        f_672_2077_2096(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2077, 2096);
            return return_v;
        }


        static string
        f_672_2123_2142(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(672, 2123, 2142);
            return return_v;
        }

    }
}
