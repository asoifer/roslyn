// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class ErrorTypeSymbol : NamedTypeSymbol
    {
        internal static readonly ErrorTypeSymbol UnknownResultType;

        private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

        internal abstract DiagnosticInfo? ErrorInfo { get; }

        internal virtual LookupResultKind ResultKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 1317, 1355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 1323, 1353);

                    return LookupResultKind.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 1317, 1355);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 1270, 1357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 1270, 1357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeWithAnnotations Substitute(AbstractTypeMap typeMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 1774, 1943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 1863, 1932);

                return TypeWithAnnotations.Create(f_10083_1897_1930(typeMap, this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 1774, 1943);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10083_1897_1930(Microsoft.CodeAnalysis.CSharp.Symbols.AbstractTypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 1897, 1930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 1774, 1943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 1774, 1943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual ImmutableArray<Symbol> CandidateSymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 2560, 2647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 2596, 2632);

                    return ImmutableArray<Symbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 2560, 2647);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 2481, 2658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 2481, 2658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CandidateReason CandidateReason
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 2934, 3350);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 2970, 3335) || true) && (f_10083_2974_2999_M(!f_10083_2975_2991().IsEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 2970, 3335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 3041, 3146);

                        f_10083_3041_3145(f_10083_3054_3064() != LookupResultKind.Viable, "Shouldn't have viable result kind on error symbol");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 3168, 3206);

                        return f_10083_3175_3205(f_10083_3175_3185());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 2970, 3335);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 2970, 3335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 3288, 3316);

                        return CandidateReason.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 2970, 3335);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 2934, 3350);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10083_2975_2991()
                    {
                        var return_v = CandidateSymbols;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 2975, 2991);
                        return return_v;
                    }


                    bool
                    f_10083_2974_2999_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 2974, 2999);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    f_10083_3054_3064()
                    {
                        var return_v = ResultKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 3054, 3064);
                        return return_v;
                    }


                    int
                    f_10083_3041_3145(bool
                    condition, string
                    message)
                    {
                        Debug.Assert(condition, message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 3041, 3145);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    f_10083_3175_3185()
                    {
                        var return_v = ResultKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 3175, 3185);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CandidateReason
                    f_10083_3175_3205(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    resultKind)
                    {
                        var return_v = resultKind.ToCandidateReason();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 3175, 3205);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 2871, 3361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 2871, 3361);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 3373, 3487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 3454, 3476);

                return f_10083_3461_3475(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 3373, 3487);

                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10083_3461_3475(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 3461, 3475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 3373, 3487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 3373, 3487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 3931, 3951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 3937, 3949);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 3931, 3951);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 3822, 3962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 3822, 3962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 4357, 4378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 4363, 4376);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 4357, 4378);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 4293, 4389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 4293, 4389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 4467, 4531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 4503, 4516);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 4467, 4531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 4401, 4542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 4401, 4542);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 4617, 4681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 4653, 4666);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 4617, 4681);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 4554, 4692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 4554, 4692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 4894, 5001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 4930, 4986);

                    return f_10083_4937_4985();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 4894, 5001);

                    System.Collections.Generic.IEnumerable<string>
                    f_10083_4937_4985()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerable<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 4937, 4985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 4822, 5012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 4822, 5012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 5310, 5686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 5386, 5623) || true) && (f_10083_5390_5401())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 5386, 5623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 5435, 5500);

                    var
                    result = f_10083_5448_5499(this, ImmutableArray<Symbol>.Empty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 5518, 5555);

                    f_10083_5518_5554(result is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 5573, 5608);

                    return f_10083_5580_5607(result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 5386, 5623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 5639, 5675);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 5310, 5686);

                bool
                f_10083_5390_5401()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 5390, 5401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10083_5448_5499(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                currentMembers)
                {
                    var return_v = this_param.AddOrWrapTupleMembers(currentMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 5448, 5499);
                    return return_v;
                }


                int
                f_10083_5518_5554(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 5518, 5554);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10083_5580_5607(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 5580, 5607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 5310, 5686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 5310, 5686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 6041, 6207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 6128, 6196);

                return f_10083_6135_6147(this).WhereAsArray((m, name) => m.Name == name, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 6041, 6207);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10083_6135_6147(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 6135, 6147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 6041, 6207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 6041, 6207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 6219, 6359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 6311, 6348);

                throw f_10083_6317_6347();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 6219, 6359);

                System.Exception
                f_10083_6317_6347()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 6317, 6347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 6219, 6359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 6219, 6359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 6371, 6516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 6471, 6505);

                return f_10083_6478_6504(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 6371, 6516);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10083_6478_6504(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 6478, 6504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 6371, 6516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 6371, 6516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 6528, 6679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 6639, 6668);

                return f_10083_6646_6667(this, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 6528, 6679);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10083_6646_6667(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 6646, 6667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 6528, 6679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 6528, 6679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 7012, 7157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 7101, 7146);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 7012, 7157);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 7012, 7157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 7012, 7157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 7580, 7736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 7680, 7725);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 7580, 7736);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 7580, 7736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 7580, 7736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 8174, 8341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 8285, 8330);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 8174, 8341);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 8174, 8341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 8174, 8341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 8506, 8585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 8542, 8570);

                    return SymbolKind.ErrorType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 8506, 8585);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 8443, 8596);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 8443, 8596);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 8761, 8834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 8797, 8819);

                    return TypeKind.Error;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 8761, 8834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 8696, 8845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 8696, 8845);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 8923, 8944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 8929, 8942);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 8923, 8944);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 8857, 8955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 8857, 8955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 9145, 9208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 9181, 9193);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 9145, 9208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 9080, 9219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 9080, 9219);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 9569, 9658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 9605, 9643);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 9569, 9658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 9494, 9669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 9494, 9669);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 9779, 9875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 9815, 9860);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 9779, 9875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 9681, 9886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 9681, 9886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 10131, 10191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 10167, 10176);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 10131, 10191);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 10081, 10202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 10081, 10202);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 10441, 10512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 10477, 10497);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 10441, 10512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 10389, 10523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 10389, 10523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 10950, 11043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 10986, 11028);

                    return f_10083_10993_11027(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 10950, 11043);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10083_10993_11027(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 10993, 11027);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 10823, 11054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 10823, 11054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 11344, 11724);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 11380, 11664) || true) && (_lazyTypeParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 11380, 11664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 11455, 11645);

                        f_10083_11455_11644(ref _lazyTypeParameters, f_10083_11553_11572(this), default(ImmutableArray<TypeParameterSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 11380, 11664);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 11682, 11709);

                    return _lazyTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 11344, 11724);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10083_11553_11572(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 11553, 11572);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10083_11455_11644(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 11455, 11644);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 11253, 11735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 11253, 11735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<TypeParameterSymbol> GetTypeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 11747, 12333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 11835, 11858);

                int
                arity = f_10083_11847_11857(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 11872, 12322) || true) && (arity == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 11872, 12322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 11920, 11969);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 11872, 12322);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 11872, 12322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 12035, 12080);

                    var
                    @params = new TypeParameterSymbol[arity]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 12107, 12112);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 12098, 12254) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 12125, 12128)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 12098, 12254))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 12098, 12254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 12170, 12235);

                            @params[i] = f_10083_12183_12234(this, string.Empty, i);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10083, 1, 157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10083, 1, 157);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 12272, 12307);

                    return f_10083_12279_12306(@params);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 11872, 12322);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 11747, 12333);

                int
                f_10083_11847_11857(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 11847, 11857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol.ErrorTypeParameterSymbol
                f_10083_12183_12234(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                container, string
                name, int
                ordinal)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol.ErrorTypeParameterSymbol(container, name, ordinal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 12183, 12234);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10083_12279_12306(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 12279, 12306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 11747, 12333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 11747, 12333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 12726, 12789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 12762, 12774);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 12726, 12789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 12654, 12800);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 12654, 12800);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 12900, 13103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 13046, 13092);

                return f_10083_13053_13091<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 12900, 13103);

                TResult
                f_10083_13053_13091<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitErrorType(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 13053, 13091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 12900, 13103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 12900, 13103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ErrorTypeSymbol(TupleExtraData? tupleData = null)
        : base(f_10083_13253_13262_C(tupleData))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10083, 13174, 13285);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10083, 13174, 13285);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 13174, 13285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 13174, 13285);
            }
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 13594, 13680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 13630, 13665);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 13594, 13680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 13511, 13691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 13511, 13691);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 13942, 14006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 13978, 13991);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 13942, 14006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 13881, 14017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 13881, 14017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 14395, 14459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 14431, 14444);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 14395, 14459);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 14332, 14470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 14332, 14470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 14931, 14995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 14967, 14980);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 14931, 14995);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 14870, 15006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 14870, 15006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15087, 15108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 15093, 15106);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15087, 15108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15018, 15119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15018, 15119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15212, 15276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 15248, 15261);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15212, 15276);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15131, 15287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15131, 15287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol? BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15363, 15370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 15366, 15370);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15363, 15370);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15363, 15370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15363, 15370);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasCodeAnalysisEmbeddedAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15439, 15447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 15442, 15447);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15439, 15447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15439, 15447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15439, 15447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol>? basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15460, 15663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 15607, 15652);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15460, 15663);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15460, 15663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15460, 15663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15675, 15827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 15771, 15816);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15675, 15827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15675, 15827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15675, 15827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol? GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15839, 15982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 15959, 15971);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15839, 15982);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15839, 15982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15839, 15982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 15994, 16187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 16131, 16176);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 15994, 16187);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 15994, 16187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 15994, 16187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override NamedTypeSymbol ConstructCore(ImmutableArray<TypeWithAnnotations> typeArguments, bool unbound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 16199, 16407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 16337, 16396);

                return f_10083_16344_16395(this, typeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 16199, 16407);

                Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedErrorTypeSymbol
                f_10083_16344_16395(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                constructedFrom, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedErrorTypeSymbol(constructedFrom, typeArgumentsWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 16344, 16395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 16199, 16407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 16199, 16407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 16419, 16776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 16512, 16544);

                f_10083_16512_16543(f_10083_16525_16542(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 16558, 16660);

                f_10083_16558_16659(f_10083_16571_16658(f_10083_16587_16614(newOwner), f_10083_16616_16657_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10083_16616_16637(this), 10083, 16616, 16657)?.OriginalDefinition)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 16674, 16765);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10083, 16681, 16702) || ((f_10083_16681_16702(newOwner) && DynAbs.Tracing.TraceSender.Conditional_F2(10083, 16705, 16709)) || DynAbs.Tracing.TraceSender.Conditional_F3(10083, 16712, 16764))) ? this : f_10083_16712_16764(newOwner, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 16419, 16776);

                bool
                f_10083_16525_16542(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 16525, 16542);
                    return return_v;
                }


                int
                f_10083_16512_16543(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 16512, 16543);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10083_16587_16614(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 16587, 16614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10083_16616_16637(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 16616, 16637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10083_16616_16657_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 16616, 16657);
                    return return_v;
                }


                bool
                f_10083_16571_16658(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 16571, 16658);
                    return return_v;
                }


                int
                f_10083_16558_16659(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 16558, 16659);
                    return 0;
                }


                bool
                f_10083_16681_16702(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 16681, 16702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNestedErrorTypeSymbol
                f_10083_16712_16764(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                originalDefinition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNestedErrorTypeSymbol(containingSymbol, originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 16712, 16764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 16419, 16776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 16419, 16776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool ShouldAddWinRTMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 16864, 16885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 16870, 16883);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 16864, 16885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 16788, 16896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 16788, 16896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 16985, 17006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 16991, 17004);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 16985, 17006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 16908, 17017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 16908, 17017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17096, 17131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 17102, 17129);

                    return default(TypeLayout);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17096, 17131);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17029, 17142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17029, 17142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet MarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17223, 17264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 17229, 17262);

                    return f_10083_17236_17261();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17223, 17264);

                    System.Runtime.InteropServices.CharSet
                    f_10083_17236_17261()
                    {
                        var return_v = DefaultMarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 17236, 17261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17154, 17275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17154, 17275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17354, 17375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 17360, 17373);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17354, 17375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17287, 17386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17287, 17386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17475, 17496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 17481, 17494);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17475, 17496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17398, 17507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17398, 17507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsComImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17585, 17606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 17591, 17604);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17585, 17606);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17519, 17617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17519, 17617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17723, 17743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 17729, 17741);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17723, 17743);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17629, 17754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17629, 17754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17766, 17933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 17885, 17922);

                throw f_10083_17891_17921();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17766, 17933);

                System.Exception
                f_10083_17891_17921()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 17891, 17921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17766, 17933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17766, 17933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 17945, 18095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18048, 18084);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 17945, 18095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 17945, 18095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 17945, 18095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 18107, 18234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18192, 18223);

                return AttributeUsageInfo.Null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 18107, 18234);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 18107, 18234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 18107, 18234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool Unreported
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 18303, 18324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18309, 18322);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 18303, 18324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 18246, 18335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 18246, 18335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 18415, 18460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18421, 18458);

                    throw f_10083_18427_18457();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 18415, 18460);

                    System.Exception
                    f_10083_18427_18457()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 18427, 18457);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 18347, 18471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 18347, 18471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 18535, 18574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18538, 18574);
                throw f_10083_18544_18574(); DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 18535, 18574);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 18535, 18574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 18535, 18574);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10083_18544_18574()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 18544, 18574);
                return return_v;
            }

        }

        internal override NamedTypeSymbol? NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 18650, 18657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18653, 18657);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 18650, 18657);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 18650, 18657);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 18650, 18657);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 18670, 18827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18744, 18816);

                return f_10083_18751_18815(this, f_10083_18789_18814());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 18670, 18827);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10083_18789_18814()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 18789, 18814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ErrorTypeSymbol
                f_10083_18751_18815(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ErrorTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 18751, 18815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 18670, 18827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 18670, 18827);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 18839, 19123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 18971, 19033);

                f_10083_18971_19032(nullableAnnotation != f_10083_19006_19031());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19047, 19112);

                return f_10083_19054_19111(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 18839, 19123);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10083_19006_19031()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 19006, 19031);
                    return return_v;
                }


                int
                f_10083_18971_19032(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 18971, 19032);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ErrorTypeSymbol
                f_10083_19054_19111(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ErrorTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 19054, 19111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 18839, 19123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 18839, 19123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 19174, 19182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19177, 19182);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 19174, 19182);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 19174, 19182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 19174, 19182);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 19257, 19265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19260, 19265);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 19257, 19265);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 19257, 19265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 19257, 19265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ErrorTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10083, 754, 19273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 877, 932);
            UnknownResultType = f_10083_897_932(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10083, 754, 19273);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 754, 19273);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10083, 754, 19273);

        static Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
        f_10083_897_932()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 897, 932);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        f_10083_13253_13262_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10083, 13174, 13285);
            return return_v;
        }

    }
    internal abstract class SubstitutedErrorTypeSymbol : ErrorTypeSymbol
    {
        private readonly ErrorTypeSymbol _originalDefinition;

        private int _hashCode;

        protected SubstitutedErrorTypeSymbol(ErrorTypeSymbol originalDefinition, TupleExtraData? tupleData = null)
        : base(f_10083_19590_19599_C(tupleData))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10083, 19463, 19677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19399, 19418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19441, 19450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19625, 19666);

                _originalDefinition = originalDefinition;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10083, 19463, 19677);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 19463, 19677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 19463, 19677);
            }
        }

        public override NamedTypeSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 19764, 19799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19770, 19797);

                    return _originalDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 19764, 19799);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 19689, 19810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 19689, 19810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 19880, 19926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 19886, 19924);

                    return f_10083_19893_19923(_originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 19880, 19926);

                    bool
                    f_10083_19893_19923(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MangleName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 19893, 19923);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 19822, 19937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 19822, 19937);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? ErrorInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20017, 20062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20023, 20060);

                    return f_10083_20030_20059(_originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20017, 20062);

                    Microsoft.CodeAnalysis.DiagnosticInfo?
                    f_10083_20030_20059(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ErrorInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 20030, 20059);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 19949, 20073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 19949, 20073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20135, 20176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20141, 20174);

                    return f_10083_20148_20173(_originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20135, 20176);

                    int
                    f_10083_20148_20173(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 20148, 20173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 20085, 20187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 20085, 20187);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20251, 20291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20257, 20289);

                    return f_10083_20264_20288(_originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20251, 20291);

                    string
                    f_10083_20264_20288(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 20264, 20288);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 20199, 20302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 20199, 20302);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20389, 20434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20395, 20432);

                    return f_10083_20402_20431(_originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20389, 20434);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10083_20402_20431(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 20402, 20431);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 20314, 20445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 20314, 20445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> CandidateSymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20537, 20589);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20543, 20587);

                    return f_10083_20550_20586(_originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20537, 20589);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10083_20550_20586(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.CandidateSymbols;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 20550, 20586);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 20457, 20600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 20457, 20600);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LookupResultKind ResultKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20682, 20728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20688, 20726);

                    return f_10083_20695_20725(_originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20682, 20728);

                    Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    f_10083_20695_20725(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ResultKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 20695, 20725);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 20612, 20739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 20612, 20739);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20751, 20893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20832, 20882);

                return f_10083_20839_20881(_originalDefinition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20751, 20893);

                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10083_20839_20881(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 20839, 20881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 20751, 20893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 20751, 20893);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 20905, 21107);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 20963, 21065) || true) && (_hashCode == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10083, 20963, 21065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 21015, 21050);

                    _hashCode = f_10083_21027_21049(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10083, 20963, 21065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 21079, 21096);

                return _hashCode;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 20905, 21107);

                int
                f_10083_21027_21049(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedErrorTypeSymbol
                type)
                {
                    var return_v = type.ComputeHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 21027, 21049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 20905, 21107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 20905, 21107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubstitutedErrorTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10083, 19281, 21114);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10083, 19281, 21114);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 19281, 21114);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10083, 19281, 21114);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        f_10083_19590_19599_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10083, 19463, 19677);
            return return_v;
        }

    }
    internal sealed class ConstructedErrorTypeSymbol : SubstitutedErrorTypeSymbol
    {
        private readonly ErrorTypeSymbol _constructedFrom;

        private readonly ImmutableArray<TypeWithAnnotations> _typeArgumentsWithAnnotations;

        private readonly TypeMap _map;

        public ConstructedErrorTypeSymbol(ErrorTypeSymbol constructedFrom, ImmutableArray<TypeWithAnnotations> typeArgumentsWithAnnotations, TupleExtraData? tupleData = null) : base(f_10083_21598_21649_C((ErrorTypeSymbol)f_10083_21615_21649(constructedFrom)), tupleData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10083, 21411, 21953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 21249, 21265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 21394, 21398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 21686, 21721);

                _constructedFrom = constructedFrom;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 21735, 21796);

                _typeArgumentsWithAnnotations = typeArgumentsWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 21810, 21942);

                _map = f_10083_21817_21941(f_10083_21829_21859(constructedFrom), f_10083_21861_21910(f_10083_21861_21895(constructedFrom)), typeArgumentsWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10083, 21411, 21953);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 21411, 21953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 21411, 21953);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 21965, 22184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 22066, 22173);

                return f_10083_22073_22172(_constructedFrom, _typeArgumentsWithAnnotations, tupleData: newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 21965, 22184);

                Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedErrorTypeSymbol
                f_10083_22073_22172(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                constructedFrom, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                tupleData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedErrorTypeSymbol(constructedFrom, typeArgumentsWithAnnotations, tupleData: tupleData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 22073, 22172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 21965, 22184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 21965, 22184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 22287, 22334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 22293, 22332);

                    return f_10083_22300_22331(_constructedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 22287, 22334);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10083_22300_22331(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 22300, 22331);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 22196, 22345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 22196, 22345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 22484, 22529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 22490, 22527);

                    return _typeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 22484, 22529);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 22357, 22540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 22357, 22540);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 22624, 22656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 22630, 22654);

                    return _constructedFrom;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 22624, 22656);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 22552, 22667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 22552, 22667);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 22744, 22793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 22750, 22791);

                    return f_10083_22757_22790(_constructedFrom);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 22744, 22793);

                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10083_22757_22790(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 22757, 22790);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 22679, 22804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 22679, 22804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeMap TypeSubstitution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 22883, 22903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 22889, 22901);

                    return _map;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 22883, 22903);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 22816, 22914);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 22816, 22914);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ConstructedErrorTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10083, 21122, 22921);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10083, 21122, 22921);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 21122, 22921);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10083, 21122, 22921);

        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10083_21615_21649(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 21615, 21649);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10083_21829_21859(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 21829, 21859);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10083_21861_21895(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 21861, 21895);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10083_21861_21910(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 21861, 21910);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10083_21817_21941(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        containingType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        typeArguments)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(containingType, typeParameters, typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 21817, 21941);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        f_10083_21598_21649_C(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10083, 21411, 21953);
            return return_v;
        }

    }
    internal sealed class SubstitutedNestedErrorTypeSymbol : SubstitutedErrorTypeSymbol
    {
        private readonly NamedTypeSymbol _containingSymbol;

        private readonly ImmutableArray<TypeParameterSymbol> _typeParameters;

        private readonly TypeMap _map;

        public SubstitutedNestedErrorTypeSymbol(NamedTypeSymbol containingSymbol, ErrorTypeSymbol originalDefinition) : base(f_10083_23341_23359_C(originalDefinition))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10083, 23211, 23551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 23062, 23079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 23194, 23198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 23385, 23422);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 23436, 23540);

                _map = f_10083_23443_23539(f_10083_23443_23476(containingSymbol), originalDefinition, this, out _typeParameters);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10083, 23211, 23551);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 23211, 23551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 23211, 23551);
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 23654, 23685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 23660, 23683);

                    return _typeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 23654, 23685);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 23563, 23696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 23563, 23696);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 23835, 23885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 23841, 23883);

                    return f_10083_23848_23882(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 23835, 23885);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10083_23848_23882(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNestedErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 23848, 23882);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 23708, 23896);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 23708, 23896);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 23980, 24000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 23986, 23998);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 23980, 24000);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 23908, 24011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 23908, 24011);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 24087, 24120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 24093, 24118);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 24087, 24120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 24023, 24131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 24023, 24131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeMap TypeSubstitution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 24210, 24230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 24216, 24228);

                    return _map;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 24210, 24230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 24143, 24241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 24143, 24241);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10083, 24343, 24382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10083, 24346, 24382);
                throw f_10083_24352_24382(); DynAbs.Tracing.TraceSender.TraceExitMethod(10083, 24343, 24382);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10083, 24343, 24382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 24343, 24382);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10083_24352_24382()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 24352, 24382);
                return return_v;
            }

        }

        static SubstitutedNestedErrorTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10083, 22929, 24390);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10083, 22929, 24390);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10083, 22929, 24390);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10083, 22929, 24390);

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10083_23443_23476(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeSubstitution;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10083, 23443, 23476);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10083_23443_23539(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        oldOwner, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNestedErrorTypeSymbol
        newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        newTypeParameters)
        {
            var return_v = this_param.WithAlphaRename((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner, out newTypeParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10083, 23443, 23539);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        f_10083_23341_23359_C(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10083, 23211, 23551);
            return return_v;
        }

    }
}
