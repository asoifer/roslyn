// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class PreprocessingSymbol : IPreprocessingSymbol
    {
        private readonly string _name;

        internal PreprocessingSymbol(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10654, 528, 618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 510, 515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 594, 607);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10654, 528, 618);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 528, 618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 528, 618);
            }
        }

        ISymbol ISymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 665, 672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 668, 672);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 665, 672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 665, 672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 665, 672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ISymbol ISymbol.ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 718, 725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 721, 725);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 718, 725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 718, 725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 718, 725);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamedTypeSymbol ISymbol.ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 778, 785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 781, 785);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 778, 785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 778, 785);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 778, 785);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 798, 906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 863, 895);

                return f_10654_870_894(this._name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 798, 906);

                int
                f_10654_870_894(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 870, 894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 798, 906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 798, 906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 918, 1359);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 982, 1073) || true) && (f_10654_986_1012(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10654, 982, 1073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1046, 1058);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10654, 982, 1073);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1089, 1181) || true) && (f_10654_1093_1119(obj, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10654, 1089, 1181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1153, 1166);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10654, 1089, 1181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1197, 1252);

                PreprocessingSymbol
                other = obj as PreprocessingSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1268, 1348);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10654, 1275, 1347) && f_10654_1317_1347(this._name, other._name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 918, 1359);

                bool
                f_10654_986_1012(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                objA, object
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 986, 1012);
                    return return_v;
                }


                bool
                f_10654_1093_1119(object
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 1093, 1119);
                    return return_v;
                }


                bool
                f_10654_1317_1347(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 1317, 1347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 918, 1359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 918, 1359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IEquatable<ISymbol>.Equals(ISymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 1371, 1479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1442, 1468);

                return f_10654_1449_1467(this, other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 1371, 1479);

                bool
                f_10654_1449_1467(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                this_param, Microsoft.CodeAnalysis.ISymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 1449, 1467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 1371, 1479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 1371, 1479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ISymbol.Equals(ISymbol other, CodeAnalysis.SymbolEqualityComparer equalityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 1491, 1641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1604, 1630);

                return f_10654_1611_1629(this, other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 1491, 1641);

                bool
                f_10654_1611_1629(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                this_param, Microsoft.CodeAnalysis.ISymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 1611, 1629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 1491, 1641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 1491, 1641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<Location> ISymbol.Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 1696, 1729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1699, 1729);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 1696, 1729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 1696, 1729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 1696, 1729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<SyntaxReference> ISymbol.DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 1808, 1848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1811, 1848);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 1808, 1848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 1808, 1848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 1808, 1848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<AttributeData> ISymbol.GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 1915, 1953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 1918, 1953);
                return ImmutableArray<AttributeData>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 1915, 1953);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 1915, 1953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 1915, 1953);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Accessibility ISymbol.DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2010, 2040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2013, 2040);
                    return Accessibility.NotApplicable; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2010, 2040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2010, 2040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2010, 2040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void ISymbol.Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2096, 2139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2099, 2139);
                throw f_10654_2105_2139(); DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2096, 2139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2096, 2139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2096, 2139);
            }

            System.NotSupportedException
            f_10654_2105_2139()
            {
                var return_v = new System.NotSupportedException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 2105, 2139);
                return return_v;
            }

        }

        TResult ISymbol.Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2216, 2259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2219, 2259);
                throw f_10654_2225_2259<TResult>(); DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2216, 2259);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2216, 2259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2216, 2259);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.NotSupportedException
            f_10654_2225_2259<TResult>()
            {
                var return_v = new System.NotSupportedException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 2225, 2259);
                return return_v;
            }

        }

        string ISymbol.GetDocumentationCommentId()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2315, 2322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2318, 2322);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2315, 2322);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2315, 2322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2315, 2322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string ISymbol.GetDocumentationCommentXml(CultureInfo preferredCulture, bool expandIncludes, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2465, 2472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2468, 2472);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2465, 2472);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2465, 2472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2465, 2472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string ISymbol.ToDisplayString(SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2485, 2630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2568, 2619);

                return f_10654_2575_2618(this, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2485, 2630);

                string
                f_10654_2575_2618(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayString((Microsoft.CodeAnalysis.ISymbol)symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 2575, 2618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2485, 2630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2485, 2630);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<SymbolDisplayPart> ISymbol.ToDisplayParts(SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2642, 2812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2751, 2801);

                return f_10654_2758_2800(this, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2642, 2812);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10654_2758_2800(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayParts((Microsoft.CodeAnalysis.ISymbol)symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 2758, 2800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2642, 2812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2642, 2812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string ISymbol.ToMinimalDisplayString(SemanticModel semanticModel, int position, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 2824, 3082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 2957, 3071);

                return f_10654_2964_3070(this, f_10654_3007_3051(semanticModel), position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 2824, 3082);

                Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                f_10654_3007_3051(Microsoft.CodeAnalysis.SemanticModel
                semanticModel)
                {
                    var return_v = Symbol.GetCSharpSemanticModel(semanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 3007, 3051);
                    return return_v;
                }


                string
                f_10654_2964_3070(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayString((Microsoft.CodeAnalysis.ISymbol)symbol, (Microsoft.CodeAnalysis.SemanticModel)semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 2964, 3070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 2824, 3082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 2824, 3082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<SymbolDisplayPart> ISymbol.ToMinimalDisplayParts(SemanticModel semanticModel, int position, SymbolDisplayFormat format)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3094, 3377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3253, 3366);

                return f_10654_3260_3365(this, f_10654_3302_3346(semanticModel), position, format);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3094, 3377);

                Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                f_10654_3302_3346(Microsoft.CodeAnalysis.SemanticModel
                semanticModel)
                {
                    var return_v = Symbol.GetCSharpSemanticModel(semanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 3302, 3346);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SymbolDisplayPart>
                f_10654_3260_3365(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToMinimalDisplayParts((Microsoft.CodeAnalysis.ISymbol)symbol, (Microsoft.CodeAnalysis.SemanticModel)semanticModel, position, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 3260, 3365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3094, 3377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3094, 3377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        SymbolKind ISymbol.Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3413, 3440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3416, 3440);
                    return SymbolKind.Preprocessing; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3413, 3440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3413, 3440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3413, 3440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbol.Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3477, 3500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3480, 3500);
                    return LanguageNames.CSharp; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3477, 3500);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3477, 3500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3477, 3500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbol.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3533, 3541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3536, 3541);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3533, 3541);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3533, 3541);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3533, 3541);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string ISymbol.MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3582, 3590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3585, 3590);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3582, 3590);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3582, 3590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3582, 3590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IAssemblySymbol ISymbol.ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3646, 3653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3649, 3653);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3646, 3653);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3646, 3653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3646, 3653);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IModuleSymbol ISymbol.ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3705, 3712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3708, 3712);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3705, 3712);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3705, 3712);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3705, 3712);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceSymbol ISymbol.ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3770, 3777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3773, 3777);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3770, 3777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3770, 3777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3770, 3777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3816, 3823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3819, 3823);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3816, 3823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3816, 3823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3816, 3823);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3858, 3866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3861, 3866);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3858, 3866);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3858, 3866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3858, 3866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3902, 3910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3905, 3910);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3902, 3910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3902, 3910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3902, 3910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3947, 3955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3950, 3955);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3947, 3955);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3947, 3955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3947, 3955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 3992, 4000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 3995, 4000);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 3992, 4000);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 3992, 4000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 3992, 4000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 4035, 4043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 4038, 4043);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 4035, 4043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 4035, 4043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 4035, 4043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 4078, 4086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 4081, 4086);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 4078, 4086);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 4078, 4086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 4078, 4086);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 4133, 4141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 4136, 4141);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 4133, 4141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 4133, 4141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 4133, 4141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.CanBeReferencedByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 4189, 4287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 4192, 4287);
                    return f_10654_4192_4228(_name) && (DynAbs.Tracing.TraceSender.Expression_True(10654, 4192, 4287) && !f_10654_4233_4287(_name)); DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 4189, 4287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 4189, 4287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 4189, 4287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISymbol.HasUnsupportedMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 4336, 4344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 4339, 4344);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 4336, 4344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 4336, 4344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 4336, 4344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10654, 4357, 4476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10654, 4422, 4465);

                return f_10654_4429_4464(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10654, 4357, 4476);

                string
                f_10654_4429_4464(Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.PreprocessingSymbol
                symbol)
                {
                    var return_v = SymbolDisplay.ToDisplayString((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 4429, 4464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10654, 4357, 4476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 4357, 4476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PreprocessingSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10654, 405, 4483);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10654, 405, 4483);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10654, 405, 4483);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10654, 405, 4483);

        bool
        f_10654_4192_4228(string
        name)
        {
            var return_v = SyntaxFacts.IsValidIdentifier(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 4192, 4228);
            return return_v;
        }


        bool
        f_10654_4233_4287(string
        name)
        {
            var return_v = SyntaxFacts.ContainsDroppedIdentifierCharacters(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10654, 4233, 4287);
            return return_v;
        }

    }
}
