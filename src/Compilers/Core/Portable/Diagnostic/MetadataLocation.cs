// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class MetadataLocation : Location, IEquatable<MetadataLocation?>
    {
        private readonly IModuleSymbolInternal _module;

        internal MetadataLocation(IModuleSymbolInternal module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(196, 593, 750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 573, 580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 673, 708);

                f_196_673_707(module != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 722, 739);

                _module = module;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(196, 593, 750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(196, 593, 750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(196, 593, 750);
            }
        }

        public override LocationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(196, 820, 861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 826, 859);

                    return LocationKind.MetadataFile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(196, 820, 861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(196, 762, 872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(196, 762, 872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IModuleSymbolInternal MetadataModuleInternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(196, 971, 994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 977, 992);

                    return _module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(196, 971, 994);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(196, 884, 1005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(196, 884, 1005);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(196, 1017, 1115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 1075, 1104);

                return f_196_1082_1103(_module);
                DynAbs.Tracing.TraceSender.TraceExitMethod(196, 1017, 1115);

                int
                f_196_1082_1103(Microsoft.CodeAnalysis.Symbols.IModuleSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(196, 1082, 1103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(196, 1017, 1115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(196, 1017, 1115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(196, 1127, 1242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 1192, 1231);

                return f_196_1199_1230(this, obj as MetadataLocation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(196, 1127, 1242);

                bool
                f_196_1199_1230(Microsoft.CodeAnalysis.MetadataLocation
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.MetadataLocation?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(196, 1199, 1230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(196, 1127, 1242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(196, 1127, 1242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(MetadataLocation? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(196, 1254, 1384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(196, 1322, 1373);

                return other is object && (DynAbs.Tracing.TraceSender.Expression_True(196, 1329, 1372) && other._module == _module);
                DynAbs.Tracing.TraceSender.TraceExitMethod(196, 1254, 1384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(196, 1254, 1384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(196, 1254, 1384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataLocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(196, 437, 1391);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(196, 437, 1391);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(196, 437, 1391);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(196, 437, 1391);

        static int
        f_196_673_707(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(196, 673, 707);
            return 0;
        }

    }
}
