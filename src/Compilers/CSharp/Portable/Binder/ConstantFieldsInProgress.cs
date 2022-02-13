// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ConstantFieldsInProgress
    {
        private readonly SourceFieldSymbol _fieldOpt;

        private readonly HashSet<SourceFieldSymbolWithSyntaxReference> _dependencies;

        internal static readonly ConstantFieldsInProgress Empty;

        internal ConstantFieldsInProgress(
                    SourceFieldSymbol fieldOpt,
                    HashSet<SourceFieldSymbolWithSyntaxReference> dependencies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10327, 969, 1217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10327, 749, 758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10327, 832, 845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10327, 1142, 1163);

                _fieldOpt = fieldOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10327, 1177, 1206);

                _dependencies = dependencies;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10327, 969, 1217);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10327, 969, 1217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10327, 969, 1217);
            }
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10327, 1273, 1314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10327, 1279, 1312);

                    return (object)_fieldOpt == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10327, 1273, 1314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10327, 1229, 1325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10327, 1229, 1325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void AddDependency(SourceFieldSymbolWithSyntaxReference field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10327, 1337, 1469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10327, 1433, 1458);

                f_10327_1433_1457(_dependencies, field);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10327, 1337, 1469);

                bool
                f_10327_1433_1457(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10327, 1433, 1457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10327, 1337, 1469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10327, 1337, 1469);
            }
        }

        static ConstantFieldsInProgress()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10327, 651, 1476);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10327, 908, 956);
            Empty = f_10327_916_956(null, null); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10327, 651, 1476);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10327, 651, 1476);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10327, 651, 1476);

        static Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
        f_10327_916_956(Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbol
        fieldOpt, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.SourceFieldSymbolWithSyntaxReference>
        dependencies)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress(fieldOpt, dependencies);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10327, 916, 956);
            return return_v;
        }

    }
}
