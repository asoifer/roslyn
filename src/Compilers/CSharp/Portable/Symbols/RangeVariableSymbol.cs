// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class RangeVariableSymbol : Symbol
    {
        private readonly string _name;

        private readonly ImmutableArray<Location> _locations;

        private readonly Symbol _containingSymbol;

        internal RangeVariableSymbol(string Name, Symbol containingSymbol, Location location, bool isTransparent = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10149, 961, 1292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 828, 833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 931, 948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1304, 1340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1099, 1112);

                _name = Name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1126, 1163);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1177, 1232);

                _locations = f_10149_1190_1231(location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1246, 1281);

                this.IsTransparent = isTransparent;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10149, 961, 1292);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 961, 1292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 961, 1292);
            }
        }

        internal bool IsTransparent { get; }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 1404, 1468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1440, 1453);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 1404, 1468);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 1352, 1479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 1352, 1479);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 1547, 1630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1583, 1615);

                    return SymbolKind.RangeVariable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 1547, 1630);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 1491, 1641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 1491, 1641);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 1728, 1797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1764, 1782);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 1728, 1797);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 1653, 1808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 1653, 1808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 1918, 2437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 1954, 2064);

                    SyntaxToken
                    token = (SyntaxToken)f_10149_1987_2063(f_10149_1987_2021(f_10149_1987_2011(_locations[0])), _locations[0].SourceSpan.Start)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2082, 2139);

                    f_10149_2082_2138(token.Kind() == SyntaxKind.IdentifierToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2157, 2212);

                    CSharpSyntaxNode
                    node = (CSharpSyntaxNode)token.Parent
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2230, 2337);

                    f_10149_2230_2336(node is QueryClauseSyntax || (DynAbs.Tracing.TraceSender.Expression_False(10149, 2243, 2303) || node is QueryContinuationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10149, 2243, 2335) || node is JoinIntoClauseSyntax));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2355, 2422);

                    return f_10149_2362_2421(f_10149_2401_2420(node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 1918, 2437);

                    Microsoft.CodeAnalysis.SyntaxTree?
                    f_10149_1987_2011(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.SourceTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10149, 1987, 2011);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10149_1987_2021(Microsoft.CodeAnalysis.SyntaxTree?
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 1987, 2021);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10149_1987_2063(Microsoft.CodeAnalysis.SyntaxNode
                    this_param, int
                    position)
                    {
                        var return_v = this_param.FindToken(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 1987, 2063);
                        return return_v;
                    }


                    int
                    f_10149_2082_2138(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 2082, 2138);
                        return 0;
                    }


                    int
                    f_10149_2230_2336(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 2230, 2336);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10149_2401_2420(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 2401, 2420);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10149_2362_2421(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create<SyntaxReference>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 2362, 2421);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 1820, 2448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 1820, 2448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 2514, 2578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2550, 2563);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 2514, 2578);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 2460, 2589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 2460, 2589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 2655, 2719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2691, 2704);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 2655, 2719);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 2601, 2730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 2601, 2730);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 2798, 2862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2834, 2847);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 2798, 2862);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 2742, 2873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 2742, 2873);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 2941, 3005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 2977, 2990);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 2941, 3005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 2885, 3016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 2885, 3016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 3083, 3147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 3119, 3132);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 3083, 3147);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 3028, 3158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 3028, 3158);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 3224, 3288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 3260, 3273);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 3224, 3288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 3170, 3299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 3170, 3299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 3672, 3692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 3678, 3690);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 3672, 3692);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 3579, 3703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 3579, 3703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 3791, 3877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 3827, 3862);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 3791, 3877);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 3715, 3888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 3715, 3888);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 3964, 4040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4000, 4025);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 3964, 4040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 3900, 4051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 3900, 4051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArg, TResult>(CSharpSymbolVisitor<TArg, TResult> visitor, TArg a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 4063, 4241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4187, 4230);

                return f_10149_4194_4229<TResult, TArg>(visitor, this, a);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 4063, 4241);

                TResult
                f_10149_4194_4229<TResult, TArg>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArg, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                symbol, TArg
                argument)
                {
                    var return_v = this_param.VisitRangeVariable(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 4194, 4229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 4063, 4241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 4063, 4241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 4253, 4378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4334, 4367);

                f_10149_4334_4366(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 4253, 4378);

                int
                f_10149_4334_4366(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                symbol)
                {
                    this_param.VisitRangeVariable(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 4334, 4366);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 4253, 4378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 4253, 4378);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 4390, 4543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4492, 4532);

                return f_10149_4499_4531<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 4390, 4543);

                TResult
                f_10149_4499_4531<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                symbol)
                {
                    var return_v = this_param.VisitRangeVariable(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 4499, 4531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 4390, 4543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 4390, 4543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 4555, 4989);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4648, 4732) || true) && (obj == (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10149, 4648, 4732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4705, 4717);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10149, 4648, 4732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4748, 4788);

                var
                symbol = obj as RangeVariableSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 4802, 4978);

                return (object)symbol != null
                && (DynAbs.Tracing.TraceSender.Expression_True(10149, 4809, 4894) && f_10149_4852_4894(symbol._locations[0], _locations[0])) && (DynAbs.Tracing.TraceSender.Expression_True(10149, 4809, 4977) && f_10149_4915_4977(_containingSymbol, f_10149_4940_4963(symbol), compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 4555, 4989);

                bool
                f_10149_4852_4894(Microsoft.CodeAnalysis.Location
                this_param, Microsoft.CodeAnalysis.Location
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 4852, 4894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10149_4940_4963(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10149, 4940, 4963);
                    return return_v;
                }


                bool
                f_10149_4915_4977(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 4915, 4977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 4555, 4989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 4555, 4989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 5001, 5152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 5059, 5141);

                return f_10149_5066_5140(f_10149_5079_5106(_locations[0]), f_10149_5108_5139(_containingSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 5001, 5152);

                int
                f_10149_5079_5106(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 5079, 5106);
                    return return_v;
                }


                int
                f_10149_5108_5139(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 5108, 5139);
                    return return_v;
                }


                int
                f_10149_5066_5140(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 5066, 5140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 5001, 5152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 5001, 5152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10149, 5164, 5291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10149, 5231, 5280);

                return f_10149_5238_5279(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10149, 5164, 5291);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.RangeVariableSymbol
                f_10149_5238_5279(Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.RangeVariableSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 5238, 5279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10149, 5164, 5291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 5164, 5291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RangeVariableSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10149, 744, 5298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10149, 744, 5298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10149, 744, 5298);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10149, 744, 5298);

        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10149_1190_1231(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create<Location>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10149, 1190, 1231);
            return return_v;
        }

    }
}
