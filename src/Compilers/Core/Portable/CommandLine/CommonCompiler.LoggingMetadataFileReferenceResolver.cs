// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class CommonCompiler
    {
        internal sealed class LoggingMetadataFileReferenceResolver : MetadataReferenceResolver, IEquatable<LoggingMetadataFileReferenceResolver>
        {
            private readonly TouchedFileLogger? _logger;

            private readonly RelativePathResolver _pathResolver;

            private readonly Func<string, MetadataReferenceProperties, PortableExecutableReference> _provider;

            public LoggingMetadataFileReferenceResolver(RelativePathResolver pathResolver, Func<string, MetadataReferenceProperties, PortableExecutableReference> provider, TouchedFileLogger? logger)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(129, 792, 1233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 590, 597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 650, 663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 766, 775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1011, 1046);

                    f_129_1011_1045(pathResolver != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1064, 1095);

                    f_129_1064_1094(provider != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1115, 1144);

                    _pathResolver = pathResolver;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1162, 1183);

                    _provider = provider;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1201, 1218);

                    _logger = logger;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(129, 792, 1233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 792, 1233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 792, 1233);
                }
            }

            public override ImmutableArray<PortableExecutableReference> ResolveReference(string reference, string? baseFilePath, MetadataReferenceProperties properties)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(129, 1249, 1811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1438, 1507);

                    string
                    fullPath = f_129_1456_1506(_pathResolver, reference, baseFilePath)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1527, 1719) || true) && (fullPath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 1527, 1719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1589, 1616);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_logger, 129, 1589, 1615)?.AddRead(fullPath), 129, 1597, 1615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1638, 1700);

                        return f_129_1645_1699(f_129_1667_1698(this, fullPath, properties));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(129, 1527, 1719);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1739, 1796);

                    return ImmutableArray<PortableExecutableReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(129, 1249, 1811);

                    string
                    f_129_1456_1506(Microsoft.CodeAnalysis.RelativePathResolver
                    this_param, string
                    reference, string?
                    baseFilePath)
                    {
                        var return_v = this_param.ResolvePath(reference, baseFilePath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 1456, 1506);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PortableExecutableReference
                    f_129_1667_1698(Microsoft.CodeAnalysis.CommonCompiler.LoggingMetadataFileReferenceResolver
                    this_param, string
                    arg1, Microsoft.CodeAnalysis.MetadataReferenceProperties
                    arg2)
                    {
                        var return_v = this_param._provider(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 1667, 1698);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PortableExecutableReference>
                    f_129_1645_1699(Microsoft.CodeAnalysis.PortableExecutableReference
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 1645, 1699);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 1249, 1811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 1249, 1811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(129, 1827, 1944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1893, 1929);

                    throw f_129_1899_1928();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(129, 1827, 1944);

                    System.NotImplementedException
                    f_129_1899_1928()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 1899, 1928);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 1827, 1944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 1827, 1944);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(LoggingMetadataFileReferenceResolver? other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(129, 1960, 2107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2056, 2092);

                    throw f_129_2062_2091();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(129, 1960, 2107);

                    System.NotImplementedException
                    f_129_2062_2091()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 2062, 2091);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 1960, 2107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 1960, 2107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(129, 2164, 2233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2167, 2233);
                    return obj is LoggingMetadataFileReferenceResolver other && (DynAbs.Tracing.TraceSender.Expression_True(129, 2167, 2233) && f_129_2220_2233(this, other)); DynAbs.Tracing.TraceSender.TraceExitMethod(129, 2164, 2233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 2164, 2233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 2164, 2233);
                }
                throw new System.Exception("Slicer error: unreachable code");

                bool
                f_129_2220_2233(Microsoft.CodeAnalysis.CommonCompiler.LoggingMetadataFileReferenceResolver
                this_param, Microsoft.CodeAnalysis.CommonCompiler.LoggingMetadataFileReferenceResolver
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 2220, 2233);
                    return return_v;
                }

            }

            static LoggingMetadataFileReferenceResolver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(129, 393, 2245);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(129, 393, 2245);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 393, 2245);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(129, 393, 2245);

            static int
            f_129_1011_1045(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 1011, 1045);
                return 0;
            }


            static int
            f_129_1064_1094(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 1064, 1094);
                return 0;
            }

        }
    }
}
