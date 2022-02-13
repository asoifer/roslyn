// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class AssemblySymbol : Symbol, IAssemblySymbolInternal
    {
        private AssemblySymbol _corLibrary;

        internal AssemblySymbol CorLibrary
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 2385, 2455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 2421, 2440);

                    return _corLibrary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 2385, 2455);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 2326, 2466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 2326, 2466);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetCorLibrary(AssemblySymbol corLibrary)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 2695, 2866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 2774, 2816);

                f_10050_2774_2815((object)_corLibrary == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 2830, 2855);

                _corLibrary = corLibrary;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 2695, 2866);

                int
                f_10050_2774_2815(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 2774, 2815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 2695, 2866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 2695, 2866);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 3389, 3461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 3425, 3446);

                    return f_10050_3432_3445(f_10050_3432_3440());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 3389, 3461);

                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10050_3432_3440()
                    {
                        var return_v = Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 3432, 3440);
                        return return_v;
                    }


                    string
                    f_10050_3432_3445(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 3432, 3445);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 3337, 3472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 3337, 3472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract AssemblyIdentity Identity { get; }

        AssemblyIdentity IAssemblySymbolInternal.Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 3692, 3703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 3695, 3703);
                    return f_10050_3695_3703(); DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 3692, 3703);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 3692, 3703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 3692, 3703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract Version AssemblyVersionPattern { get; }

        internal Machine Machine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 4390, 4467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 4426, 4452);

                    return f_10050_4433_4451(f_10050_4433_4440()[0]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 4390, 4467);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10050_4433_4440()
                    {
                        var return_v = Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 4433, 4440);
                        return return_v;
                    }


                    System.Reflection.PortableExecutable.Machine
                    f_10050_4433_4451(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Machine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 4433, 4451);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 4341, 4478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 4341, 4478);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool Bit32Required
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 4757, 4840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 4793, 4825);

                    return f_10050_4800_4824(f_10050_4800_4807()[0]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 4757, 4840);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10050_4800_4807()
                    {
                        var return_v = Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 4800, 4807);
                        return return_v;
                    }


                    bool
                    f_10050_4800_4824(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Bit32Required;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 4800, 4824);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 4705, 4851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 4705, 4851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract NamespaceSymbol GlobalNamespace
        {
            get;
        }

        internal NamespaceSymbol GetAssemblyNamespace(NamespaceSymbol namespaceSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 5416, 6582);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 5519, 5633) || true) && (f_10050_5523_5556(namespaceSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 5519, 5633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 5590, 5618);

                    return f_10050_5597_5617(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 5519, 5633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 5649, 5713);

                NamespaceSymbol
                container = f_10050_5677_5712(namespaceSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 5729, 5835) || true) && ((object)container == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 5729, 5835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 5792, 5820);

                    return f_10050_5799_5819(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 5729, 5835);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 5851, 6095) || true) && (f_10050_5855_5884(namespaceSymbol) == NamespaceKind.Assembly && (DynAbs.Tracing.TraceSender.Expression_True(10050, 5855, 5956) && f_10050_5914_5948(namespaceSymbol) == this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 5851, 6095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 6057, 6080);

                    return namespaceSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 5851, 6095);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 6111, 6179);

                NamespaceSymbol
                assemblyContainer = f_10050_6147_6178(this, container)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 6195, 6375) || true) && ((object)assemblyContainer == (object)container)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 6195, 6375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 6337, 6360);

                    return namespaceSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 6195, 6375);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 6391, 6489) || true) && ((object)assemblyContainer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 6391, 6489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 6462, 6474);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 6391, 6489);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 6505, 6571);

                return f_10050_6512_6570(assemblyContainer, f_10050_6549_6569(namespaceSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 5416, 6582);

                bool
                f_10050_5523_5556(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 5523, 5556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10050_5597_5617(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 5597, 5617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10050_5677_5712(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 5677, 5712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10050_5799_5819(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 5799, 5819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NamespaceKind
                f_10050_5855_5884(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.NamespaceKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 5855, 5884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_5914_5948(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 5914, 5948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10050_6147_6178(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.GetAssemblyNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 6147, 6178);
                    return return_v;
                }


                string
                f_10050_6549_6569(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 6549, 6569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10050_6512_6570(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetNestedNamespace(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 6512, 6570);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 5416, 6582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 5416, 6582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ImmutableArray<ModuleSymbol> Modules { get; }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 6896, 7098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 7042, 7087);

                return f_10050_7049_7086<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 6896, 7098);

                TResult
                f_10050_7049_7086<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitAssembly(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 7049, 7086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 6896, 7098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 6896, 7098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 7110, 7230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 7191, 7219);

                f_10050_7191_7218(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 7110, 7230);

                int
                f_10050_7191_7218(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    this_param.VisitAssembly(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 7191, 7218);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 7110, 7230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 7110, 7230);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 7242, 7390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 7344, 7379);

                return f_10050_7351_7378<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 7242, 7390);

                TResult
                f_10050_7351_7378<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    var return_v = this_param.VisitAssembly(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 7351, 7378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 7242, 7390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 7242, 7390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 7465, 7543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 7501, 7528);

                    return SymbolKind.Assembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 7465, 7543);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 7402, 7554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 7402, 7554);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 7647, 7710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 7683, 7695);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 7647, 7710);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 7566, 7721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 7566, 7721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal AssemblySymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10050, 7791, 7838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 1800, 1811);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10050, 7791, 7838);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 7791, 7838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 7791, 7838);
            }
        }

        internal abstract bool IsMissing
        {
            get;
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 8124, 8210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 8160, 8195);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 8124, 8210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 8041, 8221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 8041, 8221);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 8294, 8358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 8330, 8343);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 8294, 8358);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 8233, 8369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 8233, 8369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 8443, 8507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 8479, 8492);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 8443, 8507);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 8381, 8518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 8381, 8518);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 8593, 8657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 8629, 8642);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 8593, 8657);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 8530, 8668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 8530, 8668);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 8743, 8807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 8779, 8792);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 8743, 8807);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 8680, 8818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 8680, 8818);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 8891, 8955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 8927, 8940);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 8891, 8955);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 8830, 8966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 8830, 8966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 9039, 9103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 9075, 9088);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 9039, 9103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 8978, 9114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 8978, 9114);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 9487, 9507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 9493, 9505);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 9487, 9507);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 9394, 9518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 9394, 9518);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 9628, 9724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 9664, 9709);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 9628, 9724);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 9530, 9735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 9530, 9735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsInteractive
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 9913, 9977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 9949, 9962);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 9913, 9977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 9855, 9988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 9855, 9988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 10071, 10134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 10107, 10119);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 10071, 10134);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 10000, 10145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 10000, 10145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol LookupTopLevelMetadataType(ref MetadataTypeName emittedName, bool digThroughForwardedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 10597, 10895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 10738, 10884);

                return f_10050_10745_10883(this, ref emittedName, visitedAssemblies: null, digThroughForwardedTypes: digThroughForwardedTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 10597, 10895);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_10745_10883(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                visitedAssemblies, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataTypeWithCycleDetection(ref emittedName, visitedAssemblies: visitedAssemblies, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 10745, 10883);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 10597, 10895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 10597, 10895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract NamedTypeSymbol LookupTopLevelMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies, bool digThroughForwardedTypes);

        public NamedTypeSymbol ResolveForwardedType(string fullyQualifiedMetadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 12000, 12430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 12103, 12258) || true) && (fullyQualifiedMetadataName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 12103, 12258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 12175, 12243);

                    throw f_10050_12181_12242(nameof(fullyQualifiedMetadataName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 12103, 12258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 12274, 12350);

                var
                emittedName = MetadataTypeName.FromFullName(fullyQualifiedMetadataName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 12364, 12419);

                return f_10050_12371_12418(this, ref emittedName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 12000, 12430);

                System.ArgumentNullException
                f_10050_12181_12242(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 12181, 12242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_12371_12418(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.TryLookupForwardedMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 12371, 12418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 12000, 12430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 12000, 12430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol TryLookupForwardedMetadataType(ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 12555, 12778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 12669, 12767);

                return f_10050_12676_12766(this, ref emittedName, visitedAssemblies: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 12555, 12778);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_12676_12766(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                visitedAssemblies)
                {
                    var return_v = this_param.TryLookupForwardedMetadataTypeWithCycleDetection(ref emittedName, visitedAssemblies: visitedAssemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 12676, 12766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 12555, 12778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 12555, 12778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual NamedTypeSymbol TryLookupForwardedMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 12903, 13110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 13087, 13099);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 12903, 13110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 12903, 13110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 12903, 13110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ErrorTypeSymbol CreateCycleInTypeForwarderErrorTypeSymbol(ref MetadataTypeName emittedName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 13122, 13490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 13247, 13369);

                DiagnosticInfo
                diagnosticInfo = f_10050_13279_13368(ErrorCode.ERR_CycleInTypeForwarder, emittedName.FullName, f_10050_13358_13367(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 13383, 13479);

                return f_10050_13390_13478(f_10050_13429_13441(this)[0], ref emittedName, diagnosticInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 13122, 13490);

                string
                f_10050_13358_13367(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 13358, 13367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10050_13279_13368(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 13279, 13368);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10050_13429_13441(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 13429, 13441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10050_13390_13478(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, Microsoft.CodeAnalysis.DiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName, errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 13390, 13478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 13122, 13490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 13122, 13490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ErrorTypeSymbol CreateMultipleForwardingErrorTypeSymbol(ref MetadataTypeName emittedName, ModuleSymbol forwardingModule, AssemblySymbol destination1, AssemblySymbol destination2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 13502, 14001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 13714, 13879);

                var
                diagnosticInfo = f_10050_13735_13878(ErrorCode.ERR_TypeForwardedToMultipleAssemblies, forwardingModule, this, emittedName.FullName, destination1, destination2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 13893, 13990);

                return f_10050_13900_13989(forwardingModule, ref emittedName, diagnosticInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 13502, 14001);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10050_13735_13878(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 13735, 13878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                f_10050_13900_13989(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                fullName, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 13900, 13989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 13502, 14001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 13502, 14001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract IEnumerable<NamedTypeSymbol> GetAllTopLevelForwardedTypes();

        internal abstract NamedTypeSymbol GetDeclaredSpecialType(SpecialType type);

        internal virtual void RegisterDeclaredSpecialType(NamedTypeSymbol corType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 14616, 14763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 14715, 14752);

                throw f_10050_14721_14751();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 14616, 14763);

                System.Exception
                f_10050_14721_14751()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 14721, 14751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 14616, 14763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 14616, 14763);
            }
        }

        internal virtual bool KeepLookingForDeclaredSpecialTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 15062, 15150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 15098, 15135);

                    throw f_10050_15104_15134();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 15062, 15150);

                    System.Exception
                    f_10050_15104_15134()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 15104, 15134);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 14981, 15161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 14981, 15161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual NamedTypeSymbol GetNativeIntegerType(NamedTypeSymbol underlyingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 15302, 15460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 15412, 15449);

                throw f_10050_15418_15448();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 15302, 15460);

                System.Exception
                f_10050_15418_15448()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 15418, 15448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 15302, 15460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 15302, 15460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool RuntimeSupportsDefaultInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 15696, 15819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 15699, 15819);
                    return f_10050_15699_15819(this, SpecialMember.System_Runtime_CompilerServices_RuntimeFeature__DefaultImplementationsOfInterfaces); DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 15696, 15819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 15608, 15831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 15608, 15831);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool RuntimeSupportsFeature(SpecialMember feature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 15843, 16287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 15926, 16069);

                f_10050_15926_16068((SpecialType)f_10050_15952_15989(feature).DeclaringTypeId == SpecialType.System_Runtime_CompilerServices_RuntimeFeature);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 16083, 16276);

                return f_10050_16090_16164(this, SpecialType.System_Runtime_CompilerServices_RuntimeFeature) is { TypeKind: TypeKind.Class, IsStatic: true } && (DynAbs.Tracing.TraceSender.Expression_True(10050, 16090, 16275) && f_10050_16236_16265(this, feature) is object);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 15843, 16287);

                Microsoft.CodeAnalysis.RuntimeMembers.MemberDescriptor
                f_10050_15952_15989(Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = SpecialMembers.GetDescriptor(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 15952, 15989);
                    return return_v;
                }


                int
                f_10050_15926_16068(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 15926, 16068);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_16090_16164(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 16090, 16164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10050_16236_16265(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.GetSpecialTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 16236, 16265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 15843, 16287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 15843, 16287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool RuntimeSupportsUnmanagedSignatureCallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 16377, 16501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 16380, 16501);
                    return f_10050_16380_16501(this, SpecialMember.System_Runtime_CompilerServices_RuntimeFeature__UnmanagedSignatureCallingConvention); DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 16377, 16501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 16377, 16501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 16377, 16501);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool RuntimeSupportsCovariantReturnsOfClasses
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 16738, 17164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 16862, 17149);

                    return
                    f_10050_16890_17001(this, SpecialMember.System_Runtime_CompilerServices_RuntimeFeature__CovariantReturnsOfClasses) && (DynAbs.Tracing.TraceSender.Expression_True(10050, 16890, 17148) && f_10050_17026_17116(this, SpecialType.System_Runtime_CompilerServices_PreserveBaseOverridesAttribute) is { TypeKind: TypeKind.Class });
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 16738, 17164);

                    bool
                    f_10050_16890_17001(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialMember
                    feature)
                    {
                        var return_v = this_param.RuntimeSupportsFeature(feature);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 16890, 17001);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10050_17026_17116(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 17026, 17116);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 16659, 17175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 16659, 17175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ImmutableArray<AssemblySymbol> GetNoPiaResolutionAssemblies();

        internal abstract void SetNoPiaResolutionAssemblies(ImmutableArray<AssemblySymbol> assemblies);

        internal abstract ImmutableArray<AssemblySymbol> GetLinkedReferencedAssemblies();

        internal abstract void SetLinkedReferencedAssemblies(ImmutableArray<AssemblySymbol> assemblies);

        internal abstract IEnumerable<ImmutableArray<byte>> GetInternalsVisibleToPublicKeys(string simpleName);

        internal abstract bool AreInternalsVisibleToThisAssembly(AssemblySymbol other);

        internal abstract bool IsLinked { get; }

        internal virtual bool GetGuidString(out string guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 18879, 19031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 18962, 19020);

                return f_10050_18969_19019(this, out guidString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 18879, 19031);

                bool
                f_10050_18969_19019(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, out string
                guidString)
                {
                    var return_v = this_param.GetGuidStringDefaultImplementation(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 18969, 19019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 18879, 19031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 18879, 19031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ICollection<string> TypeNames { get; }

        public abstract ICollection<string> NamespaceNames { get; }

        public abstract bool MightContainExtensionMethods { get; }

        internal NamedTypeSymbol GetSpecialType(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 20652, 20792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 20734, 20781);

                return f_10050_20741_20780(f_10050_20741_20751(), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 20652, 20792);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_20741_20751()
                {
                    var return_v = CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 20741, 20751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_20741_20780(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetDeclaredSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 20741, 20780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 20652, 20792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 20652, 20792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSymbol DynamicType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10050, 20867, 20952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 20903, 20937);

                    return DynamicTypeSymbol.Instance;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10050, 20867, 20952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 20804, 20963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 20804, 20963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol ObjectType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 21263, 21363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 21299, 21348);

                    return f_10050_21306_21347(this, SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 21263, 21363);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10050_21306_21347(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 21306, 21347);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 21203, 21374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 21203, 21374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol GetPrimitiveType(Microsoft.Cci.PrimitiveTypeCode type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 21591, 21772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 21695, 21761);

                return f_10050_21702_21760(this, f_10050_21717_21759(type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 21591, 21772);

                Microsoft.CodeAnalysis.SpecialType
                f_10050_21717_21759(Microsoft.Cci.PrimitiveTypeCode
                typeCode)
                {
                    var return_v = SpecialTypes.GetTypeFromMetadataName(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 21717, 21759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_21702_21760(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 21702, 21760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 21591, 21772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 21591, 21772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol GetTypeByMetadataName(string fullyQualifiedMetadataName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 22104, 22524);
                (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol) _ = default((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 22208, 22363) || true) && (fullyQualifiedMetadataName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 22208, 22363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 22280, 22348);

                    throw f_10050_22286_22347(nameof(fullyQualifiedMetadataName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 22208, 22363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 22379, 22513);

                return f_10050_22386_22512(this, fullyQualifiedMetadataName, includeReferences: false, isWellKnownType: false, conflicts: out _);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 22104, 22524);

                System.ArgumentNullException
                f_10050_22286_22347(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 22286, 22347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_22386_22512(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, string
                metadataName, bool
                includeReferences, bool
                isWellKnownType, out (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)
                conflicts)
                {
                    var return_v = this_param.GetTypeByMetadataName(metadataName, includeReferences: includeReferences, isWellKnownType: isWellKnownType, out conflicts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 22386, 22512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 22104, 22524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 22104, 22524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetTypeByMetadataName(
                    string metadataName,
                    bool includeReferences,
                    bool isWellKnownType,
                    out (AssemblySymbol, AssemblySymbol) conflicts,
                    bool useCLSCompliantNameArityEncoding = false,
                    DiagnosticBag warnings = null,
                    bool ignoreCorLibraryDuplicatedTypes = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 24230, 26214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 24632, 24653);

                NamedTypeSymbol
                type
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 24667, 24691);

                MetadataTypeName
                mdName
                = default(MetadataTypeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 24707, 26121) || true) && (f_10050_24711_24736(metadataName, '+') >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 24707, 26121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 24775, 24834);

                    var
                    parts = f_10050_24787_24833(metadataName, s_nestedTypeNameSeparators)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 24852, 24883);

                    f_10050_24852_24882(f_10050_24865_24877(parts) > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 24901, 24984);

                    mdName = MetadataTypeName.FromFullName(parts[0], useCLSCompliantNameArityEncoding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25002, 25275);

                    type = f_10050_25009_25274(this, ref mdName, assemblyOpt: null, includeReferences: includeReferences, isWellKnownType: isWellKnownType, conflicts: out conflicts, warnings: warnings, ignoreCorLibraryDuplicatedTypes: ignoreCorLibraryDuplicatedTypes);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25304, 25309);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25295, 25662) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10050, 25311, 25354) && !f_10050_25336_25354(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10050, 25311, 25374) && i < f_10050_25362_25374(parts)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25376, 25379)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 25295, 25662))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 25295, 25662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25421, 25470);

                            mdName = MetadataTypeName.FromTypeName(parts[i]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25492, 25551);

                            NamedTypeSymbol
                            temp = f_10050_25515_25550(type, ref mdName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25573, 25643);

                            type = (DynAbs.Tracing.TraceSender.Conditional_F1(10050, 25580, 25628) || (((!isWellKnownType || (DynAbs.Tracing.TraceSender.Expression_False(10050, 25581, 25627) || f_10050_25601_25627(this, temp))) && DynAbs.Tracing.TraceSender.Conditional_F2(10050, 25631, 25635)) || DynAbs.Tracing.TraceSender.Conditional_F3(10050, 25638, 25642))) ? temp : null;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10050, 1, 368);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10050, 1, 368);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 24707, 26121);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 24707, 26121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25728, 25815);

                    mdName = MetadataTypeName.FromFullName(metadataName, useCLSCompliantNameArityEncoding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 25833, 26106);

                    type = f_10050_25840_26105(this, ref mdName, assemblyOpt: null, includeReferences: includeReferences, isWellKnownType: isWellKnownType, conflicts: out conflicts, warnings: warnings, ignoreCorLibraryDuplicatedTypes: ignoreCorLibraryDuplicatedTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 24707, 26121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 26137, 26203);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10050, 26144, 26188) || ((((object)type == null || (DynAbs.Tracing.TraceSender.Expression_False(10050, 26145, 26187) || f_10050_26169_26187(type))) && DynAbs.Tracing.TraceSender.Conditional_F2(10050, 26191, 26195)) || DynAbs.Tracing.TraceSender.Conditional_F3(10050, 26198, 26202))) ? null : type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 24230, 26214);

                int
                f_10050_24711_24736(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 24711, 24736);
                    return return_v;
                }


                string[]
                f_10050_24787_24833(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 24787, 24833);
                    return return_v;
                }


                int
                f_10050_24865_24877(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 24865, 24877);
                    return return_v;
                }


                int
                f_10050_24852_24882(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 24852, 24882);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_25009_25274(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                metadataName, Microsoft.CodeAnalysis.AssemblyIdentity
                assemblyOpt, bool
                includeReferences, bool
                isWellKnownType, out (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)
                conflicts, Microsoft.CodeAnalysis.DiagnosticBag?
                warnings, bool
                ignoreCorLibraryDuplicatedTypes)
                {
                    var return_v = this_param.GetTopLevelTypeByMetadataName(ref metadataName, assemblyOpt: assemblyOpt, includeReferences: includeReferences, isWellKnownType: isWellKnownType, out conflicts, warnings: warnings, ignoreCorLibraryDuplicatedTypes: ignoreCorLibraryDuplicatedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 25009, 25274);
                    return return_v;
                }


                bool
                f_10050_25336_25354(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 25336, 25354);
                    return return_v;
                }


                int
                f_10050_25362_25374(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 25362, 25374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_25515_25550(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 25515, 25550);
                    return return_v;
                }


                bool
                f_10050_25601_25627(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                result)
                {
                    var return_v = this_param.IsValidWellKnownType(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 25601, 25627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_25840_26105(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                metadataName, Microsoft.CodeAnalysis.AssemblyIdentity
                assemblyOpt, bool
                includeReferences, bool
                isWellKnownType, out (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)
                conflicts, Microsoft.CodeAnalysis.DiagnosticBag?
                warnings, bool
                ignoreCorLibraryDuplicatedTypes)
                {
                    var return_v = this_param.GetTopLevelTypeByMetadataName(ref metadataName, assemblyOpt: assemblyOpt, includeReferences: includeReferences, isWellKnownType: isWellKnownType, out conflicts, warnings: warnings, ignoreCorLibraryDuplicatedTypes: ignoreCorLibraryDuplicatedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 25840, 26105);
                    return return_v;
                }


                bool
                f_10050_26169_26187(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 26169, 26187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 24230, 26214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 24230, 26214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_nestedTypeNameSeparators;

        internal TypeSymbol GetTypeByReflectionType(Type type, bool includeReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 26751, 31313);
                (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol) _ = default((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 26854, 26911);

                System.Reflection.TypeInfo
                typeInfo = f_10050_26892_26910(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 26927, 26959);

                f_10050_26927_26958(f_10050_26940_26957_M(!typeInfo.IsByRef));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27072, 27122);

                f_10050_27072_27121(f_10050_27085_27120_M(!typeInfo.ContainsGenericParameters));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27138, 31302) || true) && (f_10050_27142_27158(typeInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27138, 31302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27192, 27282);

                    TypeSymbol
                    symbol = f_10050_27212_27281(this, f_10050_27236_27261(typeInfo), includeReferences)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27300, 27399) || true) && ((object)symbol == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27300, 27399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27368, 27380);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27300, 27399);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27419, 27454);

                    int
                    rank = f_10050_27430_27453(typeInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27474, 27563);

                    return f_10050_27481_27562(this, TypeWithAnnotations.Create(symbol), rank);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27138, 31302);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27138, 31302);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27597, 31302) || true) && (f_10050_27601_27619(typeInfo))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27597, 31302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27653, 27743);

                        TypeSymbol
                        symbol = f_10050_27673_27742(this, f_10050_27697_27722(typeInfo), includeReferences)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27761, 27860) || true) && ((object)symbol == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27761, 27860);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27829, 27841);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27761, 27860);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27880, 27945);

                        return f_10050_27887_27944(TypeWithAnnotations.Create(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27597, 31302);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27597, 31302);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 27979, 31302) || true) && (f_10050_27983_28005(typeInfo) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27979, 31302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28047, 28079);

                            f_10050_28047_28078(f_10050_28060_28077_M(!typeInfo.IsArray));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28195, 28251);

                            Type[]
                            genericArguments = f_10050_28221_28250(typeInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28269, 28295);

                            int
                            typeArgumentIndex = 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28315, 28423);

                            var
                            currentTypeInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10050, 28337, 28359) || ((f_10050_28337_28359(typeInfo) && DynAbs.Tracing.TraceSender.Conditional_F2(10050, 28362, 28411)) || DynAbs.Tracing.TraceSender.Conditional_F3(10050, 28414, 28422))) ? f_10050_28362_28411(f_10050_28362_28397(typeInfo)) : typeInfo
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28441, 28514);

                            var
                            nestedTypes = f_10050_28459_28513()
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28532, 28977) || true) && (true)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 28532, 28977);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28585, 28673);

                                    f_10050_28585_28672(f_10050_28598_28637(currentTypeInfo) || (DynAbs.Tracing.TraceSender.Expression_False(10050, 28598, 28671) || f_10050_28641_28671_M(!currentTypeInfo.IsGenericType)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28697, 28730);

                                    f_10050_28697_28729(
                                                        nestedTypes, currentTypeInfo);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28752, 28872) || true) && (f_10050_28756_28785(currentTypeInfo) == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 28752, 28872);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10050, 28843, 28849);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 28752, 28872);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28896, 28958);

                                    currentTypeInfo = f_10050_28914_28957(f_10050_28914_28943(currentTypeInfo));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 28532, 28977);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10050, 28532, 28977);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10050, 28532, 28977);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 28997, 29027);

                            int
                            i = f_10050_29005_29022(nestedTypes) - 1
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29045, 29143);

                            var
                            symbol = (NamedTypeSymbol)f_10050_29075_29142(this, f_10050_29099_29122(f_10050_29099_29113(nestedTypes, i)), includeReferences)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29161, 29260) || true) && ((object)symbol == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 29161, 29260);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29229, 29241);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 29161, 29260);
                            }
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29280, 30077) || true) && (--i >= 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 29280, 30077);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29337, 29449);

                                    int
                                    forcedArity = f_10050_29355_29398(f_10050_29355_29391(f_10050_29355_29369(nestedTypes, i))) - f_10050_29401_29448(f_10050_29401_29441(f_10050_29401_29419(nestedTypes, i + 1)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29471, 29574);

                                    MetadataTypeName
                                    mdName = MetadataTypeName.FromTypeName(f_10050_29527_29546(f_10050_29527_29541(nestedTypes, i)), forcedArity: forcedArity)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29598, 29645);

                                    symbol = f_10050_29607_29644(symbol, ref mdName);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29667, 29802) || true) && ((object)symbol == null || (DynAbs.Tracing.TraceSender.Expression_False(10050, 29671, 29717) || f_10050_29697_29717(symbol)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 29667, 29802);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29767, 29779);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 29667, 29802);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29826, 29925);

                                    symbol = f_10050_29835_29924(this, symbol, genericArguments, ref typeArgumentIndex, includeReferences);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 29947, 30058) || true) && ((object)symbol == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 29947, 30058);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30023, 30035);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 29947, 30058);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 29280, 30077);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10050, 29280, 30077);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10050, 29280, 30077);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30097, 30116);

                            f_10050_30097_30115(
                                            nestedTypes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30134, 30193);

                            f_10050_30134_30192(typeArgumentIndex == f_10050_30168_30191(genericArguments));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30211, 30225);

                            return symbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27979, 31302);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 27979, 31302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30291, 30380);

                            AssemblyIdentity
                            assemblyId = f_10050_30321_30379(f_10050_30361_30378(typeInfo))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30400, 30634);

                            MetadataTypeName
                            mdName = MetadataTypeName.FromNamespaceAndTypeName(f_10050_30490_30508(typeInfo) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10050, 30490, 30524) ?? string.Empty), f_10050_30547_30560(typeInfo), forcedArity: f_10050_30596_30632(f_10050_30596_30625(typeInfo)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30654, 30798);

                            NamedTypeSymbol
                            symbol = f_10050_30679_30797(this, ref mdName, assemblyId, includeReferences, isWellKnownType: false, conflicts: out _)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30818, 30941) || true) && ((object)symbol == null || (DynAbs.Tracing.TraceSender.Expression_False(10050, 30822, 30868) || f_10050_30848_30868(symbol)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 30818, 30941);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30910, 30922);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 30818, 30941);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 30961, 30987);

                            int
                            typeArgumentIndex = 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31005, 31061);

                            Type[]
                            genericArguments = f_10050_31031_31060(typeInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31079, 31178);

                            symbol = f_10050_31088_31177(this, symbol, genericArguments, ref typeArgumentIndex, includeReferences);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31196, 31255);

                            f_10050_31196_31254(typeArgumentIndex == f_10050_31230_31253(genericArguments));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31273, 31287);

                            return symbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27979, 31302);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27597, 31302);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 27138, 31302);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 26751, 31313);

                System.Reflection.TypeInfo
                f_10050_26892_26910(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 26892, 26910);
                    return return_v;
                }


                bool
                f_10050_26940_26957_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 26940, 26957);
                    return return_v;
                }


                int
                f_10050_26927_26958(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 26927, 26958);
                    return 0;
                }


                bool
                f_10050_27085_27120_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 27085, 27120);
                    return return_v;
                }


                int
                f_10050_27072_27121(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27072, 27121);
                    return 0;
                }


                bool
                f_10050_27142_27158(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 27142, 27158);
                    return return_v;
                }


                System.Type?
                f_10050_27236_27261(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27236, 27261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10050_27212_27281(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, System.Type?
                type, bool
                includeReferences)
                {
                    var return_v = this_param.GetTypeByReflectionType(type, includeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27212, 27281);
                    return return_v;
                }


                int
                f_10050_27430_27453(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GetArrayRank();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27430, 27453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10050_27481_27562(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations, int
                rank)
                {
                    var return_v = ArrayTypeSymbol.CreateCSharpArray(declaringAssembly, elementTypeWithAnnotations, rank);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27481, 27562);
                    return return_v;
                }


                bool
                f_10050_27601_27619(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 27601, 27619);
                    return return_v;
                }


                System.Type?
                f_10050_27697_27722(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27697, 27722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10050_27673_27742(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, System.Type?
                type, bool
                includeReferences)
                {
                    var return_v = this_param.GetTypeByReflectionType(type, includeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27673, 27742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10050_27887_27944(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 27887, 27944);
                    return return_v;
                }


                System.Type?
                f_10050_27983_28005(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 27983, 28005);
                    return return_v;
                }


                bool
                f_10050_28060_28077_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 28060, 28077);
                    return return_v;
                }


                int
                f_10050_28047_28078(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 28047, 28078);
                    return 0;
                }


                System.Type[]
                f_10050_28221_28250(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GenericTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 28221, 28250);
                    return return_v;
                }


                bool
                f_10050_28337_28359(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 28337, 28359);
                    return return_v;
                }


                System.Type
                f_10050_28362_28397(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GetGenericTypeDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 28362, 28397);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10050_28362_28411(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 28362, 28411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                f_10050_28459_28513()
                {
                    var return_v = ArrayBuilder<System.Reflection.TypeInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 28459, 28513);
                    return return_v;
                }


                bool
                f_10050_28598_28637(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsGenericTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 28598, 28637);
                    return return_v;
                }


                bool
                f_10050_28641_28671_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 28641, 28671);
                    return return_v;
                }


                int
                f_10050_28585_28672(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 28585, 28672);
                    return 0;
                }


                int
                f_10050_28697_28729(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                this_param, System.Reflection.TypeInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 28697, 28729);
                    return 0;
                }


                System.Type?
                f_10050_28756_28785(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 28756, 28785);
                    return return_v;
                }


                System.Type
                f_10050_28914_28943(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 28914, 28943);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10050_28914_28957(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 28914, 28957);
                    return return_v;
                }


                int
                f_10050_29005_29022(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29005, 29022);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10050_29099_29113(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29099, 29113);
                    return return_v;
                }


                System.Type
                f_10050_29099_29122(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.AsType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 29099, 29122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10050_29075_29142(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, System.Type
                type, bool
                includeReferences)
                {
                    var return_v = this_param.GetTypeByReflectionType(type, includeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 29075, 29142);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10050_29355_29369(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29355, 29369);
                    return return_v;
                }


                System.Type[]
                f_10050_29355_29391(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GenericTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29355, 29391);
                    return return_v;
                }


                int
                f_10050_29355_29398(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29355, 29398);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10050_29401_29419(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29401, 29419);
                    return return_v;
                }


                System.Type[]
                f_10050_29401_29441(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GenericTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29401, 29441);
                    return return_v;
                }


                int
                f_10050_29401_29448(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29401, 29448);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10050_29527_29541(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29527, 29541);
                    return return_v;
                }


                string
                f_10050_29527_29546(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 29527, 29546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_29607_29644(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 29607, 29644);
                    return return_v;
                }


                bool
                f_10050_29697_29717(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 29697, 29717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_29835_29924(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, System.Type[]
                typeArguments, ref int
                currentTypeArgument, bool
                includeReferences)
                {
                    var return_v = this_param.ApplyGenericArguments(symbol, typeArguments, ref currentTypeArgument, includeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 29835, 29924);
                    return return_v;
                }


                int
                f_10050_30097_30115(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Reflection.TypeInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 30097, 30115);
                    return 0;
                }


                int
                f_10050_30168_30191(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 30168, 30191);
                    return return_v;
                }


                int
                f_10050_30134_30192(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 30134, 30192);
                    return 0;
                }


                System.Reflection.Assembly
                f_10050_30361_30378(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 30361, 30378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10050_30321_30379(System.Reflection.Assembly
                assembly)
                {
                    var return_v = AssemblyIdentity.FromAssemblyDefinition(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 30321, 30379);
                    return return_v;
                }


                string?
                f_10050_30490_30508(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Namespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 30490, 30508);
                    return return_v;
                }


                string
                f_10050_30547_30560(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 30547, 30560);
                    return return_v;
                }


                System.Type[]
                f_10050_30596_30625(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GenericTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 30596, 30625);
                    return return_v;
                }


                int
                f_10050_30596_30632(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 30596, 30632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_30679_30797(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                metadataName, Microsoft.CodeAnalysis.AssemblyIdentity
                assemblyOpt, bool
                includeReferences, bool
                isWellKnownType, out (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)
                conflicts)
                {
                    var return_v = this_param.GetTopLevelTypeByMetadataName(ref metadataName, assemblyOpt, includeReferences, isWellKnownType: isWellKnownType, out conflicts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 30679, 30797);
                    return return_v;
                }


                bool
                f_10050_30848_30868(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 30848, 30868);
                    return return_v;
                }


                System.Type[]
                f_10050_31031_31060(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.GenericTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 31031, 31060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_31088_31177(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, System.Type[]
                typeArguments, ref int
                currentTypeArgument, bool
                includeReferences)
                {
                    var return_v = this_param.ApplyGenericArguments(symbol, typeArguments, ref currentTypeArgument, includeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 31088, 31177);
                    return return_v;
                }


                int
                f_10050_31230_31253(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 31230, 31253);
                    return return_v;
                }


                int
                f_10050_31196_31254(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 31196, 31254);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 26751, 31313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 26751, 31313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol ApplyGenericArguments(NamedTypeSymbol symbol, Type[] typeArguments, ref int currentTypeArgument, bool includeReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 31325, 32551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31494, 31566);

                int
                remainingTypeArguments = f_10050_31523_31543(typeArguments) - currentTypeArgument
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31708, 31761);

                f_10050_31708_31760(remainingTypeArguments >= f_10050_31747_31759(symbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31777, 31871) || true) && (remainingTypeArguments == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 31777, 31871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31842, 31856);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 31777, 31871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31887, 31963);

                var
                length = symbol.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 31977, 32057);

                var
                typeArgumentSymbols = f_10050_32003_32056(length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32080, 32085);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32071, 32449) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32099, 32102)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 32071, 32449))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 32071, 32449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32136, 32233);

                        var
                        argSymbol = f_10050_32152_32232(this, typeArguments[currentTypeArgument++], includeReferences)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32251, 32353) || true) && ((object)argSymbol == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 32251, 32353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32322, 32334);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 32251, 32353);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32371, 32434);

                        f_10050_32371_32433(typeArgumentSymbols, TypeWithAnnotations.Create(argSymbol));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10050, 1, 379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10050, 1, 379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32465, 32540);

                return symbol.ConstructIfGeneric(f_10050_32498_32538(typeArgumentSymbols));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 31325, 32551);

                int
                f_10050_31523_31543(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 31523, 31543);
                    return return_v;
                }


                int
                f_10050_31747_31759(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 31747, 31759);
                    return return_v;
                }


                int
                f_10050_31708_31760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 31708, 31760);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10050_32003_32056(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 32003, 32056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10050_32152_32232(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, System.Type
                type, bool
                includeReferences)
                {
                    var return_v = this_param.GetTypeByReflectionType(type, includeReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 32152, 32232);
                    return return_v;
                }


                int
                f_10050_32371_32433(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 32371, 32433);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10050_32498_32538(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 32498, 32538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 31325, 32551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 31325, 32551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetTopLevelTypeByMetadataName(
                    ref MetadataTypeName metadataName,
                    AssemblyIdentity assemblyOpt,
                    bool includeReferences,
                    bool isWellKnownType,
                    out (AssemblySymbol, AssemblySymbol) conflicts,
                    DiagnosticBag warnings = null,
                    bool ignoreCorLibraryDuplicatedTypes = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 32563, 36457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 32970, 32990);

                conflicts = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33004, 33027);

                NamedTypeSymbol
                result
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33083, 33159);

                result = f_10050_33092_33158(this, ref metadataName, assemblyOpt);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33175, 33290) || true) && (isWellKnownType && (DynAbs.Tracing.TraceSender.Expression_True(10050, 33179, 33227) && !f_10050_33199_33227(this, result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 33175, 33290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33261, 33275);

                    result = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 33175, 33290);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33426, 33537) || true) && ((object)result != null || (DynAbs.Tracing.TraceSender.Expression_False(10050, 33430, 33474) || !includeReferences))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 33426, 33537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33508, 33522);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 33426, 33537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33553, 33707);

                f_10050_33553_33706(this is SourceAssemblySymbol, "Never include references for a non-source assembly, because they don't know about aliases.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33723, 33783);

                var
                assemblies = f_10050_33740_33782()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33890, 34184) || true) && (assemblyOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 33890, 34184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 33947, 34037);

                    f_10050_33947_34036(assemblies, f_10050_33967_34035(f_10050_33967_34014(f_10050_33967_33987())));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 33890, 34184);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 33890, 34184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34103, 34169);

                    f_10050_34103_34168(f_10050_34103_34123(), assemblies);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 33890, 34184);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34237, 36384);
                    foreach (var assembly in f_10050_34262_34272_I(assemblies))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 34237, 36384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34306, 34374);

                        f_10050_34306_34373(!(this is SourceAssemblySymbol && (DynAbs.Tracing.TraceSender.Expression_True(10050, 34321, 34371) && f_10050_34353_34371(assembly))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34447, 34546);

                        NamedTypeSymbol
                        candidate = f_10050_34475_34545(assembly, ref metadataName, assemblyOpt)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34566, 34699) || true) && (isWellKnownType && (DynAbs.Tracing.TraceSender.Expression_True(10050, 34570, 34621) && !f_10050_34590_34621(this, candidate)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 34566, 34699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34663, 34680);

                            candidate = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 34566, 34699);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34719, 34818) || true) && ((object)candidate == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 34719, 34818);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34790, 34799);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 34719, 34818);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34838, 34963) || true) && (f_10050_34842_34893(candidate))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 34838, 34963);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34935, 34944);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 34838, 34963);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 34983, 35072);

                        f_10050_34983_35071(!f_10050_34997_35070(candidate, result, TypeCompareKind.ConsiderEverything2));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35092, 36330) || true) && ((object)result != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 35092, 36330);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35194, 35714) || true) && (ignoreCorLibraryDuplicatedTypes)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 35194, 35714);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35279, 35447) || true) && (f_10050_35283_35304(this, candidate))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 35279, 35447);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35411, 35420);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 35279, 35447);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35473, 35691) || true) && (f_10050_35477_35495(this, result))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 35473, 35691);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35606, 35625);

                                    result = candidate;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35655, 35664);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 35473, 35691);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 35194, 35714);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35738, 36281) || true) && (warnings == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 35738, 36281);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35808, 35878);

                                conflicts = (f_10050_35821_35846(result), f_10050_35848_35876(candidate));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 35904, 35918);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 35738, 36281);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 35738, 36281);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36153, 36258);

                                f_10050_36153_36257(                        // The predefined type '{0}' is defined in multiple assemblies in the global alias; using definition from '{1}'
                                                        warnings, ErrorCode.WRN_MultiplePredefTypes, NoLocation.Singleton, result, f_10050_36231_36256(result));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 35738, 36281);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10050, 36305, 36311);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 35092, 36330);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36350, 36369);

                        result = candidate;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 34237, 36384);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10050, 1, 2148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10050, 1, 2148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36400, 36418);

                f_10050_36400_36417(
                            assemblies);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36432, 36446);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 32563, 36457);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_33092_33158(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, ref Microsoft.CodeAnalysis.MetadataTypeName
                metadataName, Microsoft.CodeAnalysis.AssemblyIdentity
                assemblyOpt)
                {
                    var return_v = GetTopLevelTypeByMetadataName(assembly, ref metadataName, assemblyOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 33092, 33158);
                    return return_v;
                }


                bool
                f_10050_33199_33227(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                result)
                {
                    var return_v = this_param.IsValidWellKnownType(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 33199, 33227);
                    return return_v;
                }


                int
                f_10050_33553_33706(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 33553, 33706);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10050_33740_33782()
                {
                    var return_v = ArrayBuilder<AssemblySymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 33740, 33782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10050_33967_33987()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 33967, 33987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                f_10050_33967_34014(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 33967, 34014);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10050_33967_34035(Microsoft.CodeAnalysis.CSharp.CSharpCompilation.ReferenceManager
                this_param)
                {
                    var return_v = this_param.ReferencedAssemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 33967, 34035);
                    return return_v;
                }


                int
                f_10050_33947_34036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 33947, 34036);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10050_34103_34123()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 34103, 34123);
                    return return_v;
                }


                int
                f_10050_34103_34168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                assemblies)
                {
                    this_param.GetUnaliasedReferencedAssemblies(assemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34103, 34168);
                    return 0;
                }


                bool
                f_10050_34353_34371(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 34353, 34371);
                    return return_v;
                }


                int
                f_10050_34306_34373(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34306, 34373);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_34475_34545(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, ref Microsoft.CodeAnalysis.MetadataTypeName
                metadataName, Microsoft.CodeAnalysis.AssemblyIdentity?
                assemblyOpt)
                {
                    var return_v = GetTopLevelTypeByMetadataName(assembly, ref metadataName, assemblyOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34475, 34545);
                    return return_v;
                }


                bool
                f_10050_34590_34621(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                result)
                {
                    var return_v = this_param.IsValidWellKnownType(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34590, 34621);
                    return return_v;
                }


                bool
                f_10050_34842_34893(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.IsHiddenByCodeAnalysisEmbeddedAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34842, 34893);
                    return return_v;
                }


                bool
                f_10050_34997_35070(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34997, 35070);
                    return return_v;
                }


                int
                f_10050_34983_35071(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34983, 35071);
                    return 0;
                }


                bool
                f_10050_35283_35304(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsInCorLib(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 35283, 35304);
                    return return_v;
                }


                bool
                f_10050_35477_35495(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.IsInCorLib(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 35477, 35495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_35821_35846(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 35821, 35846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_35848_35876(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 35848, 35876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_36231_36256(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 36231, 36256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10050_36153_36257(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 36153, 36257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10050_34262_34272_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 34262, 34272);
                    return return_v;
                }


                int
                f_10050_36400_36417(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 36400, 36417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 32563, 36457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 32563, 36457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsInCorLib(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 36469, 36603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36539, 36592);

                return (object)f_10050_36554_36577(type) == f_10050_36581_36591();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 36469, 36603);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_36554_36577(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 36554, 36577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_36581_36591()
                {
                    var return_v = CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 36581, 36591);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 36469, 36603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 36469, 36603);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsValidWellKnownType(NamedTypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 36615, 37141);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36697, 36822) || true) && ((object)result == null || (DynAbs.Tracing.TraceSender.Expression_False(10050, 36701, 36760) || f_10050_36727_36742(result) == TypeKind.Error))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 36697, 36822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36794, 36807);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 36697, 36822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 36838, 37018);

                f_10050_36838_37017((object)f_10050_36859_36880(result) == null || (DynAbs.Tracing.TraceSender.Expression_False(10050, 36851, 36935) || f_10050_36892_36935(this, f_10050_36913_36934(result))), "Checking the containing type is the caller's responsibility.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37034, 37130);

                return f_10050_37041_37069(result) == Accessibility.Public || (DynAbs.Tracing.TraceSender.Expression_False(10050, 37041, 37129) || f_10050_37097_37129(result, this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 36615, 37141);

                Microsoft.CodeAnalysis.TypeKind
                f_10050_36727_36742(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 36727, 36742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_36859_36880(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 36859, 36880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_36913_36934(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 36913, 36934);
                    return return_v;
                }


                bool
                f_10050_36892_36935(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                result)
                {
                    var return_v = this_param.IsValidWellKnownType(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 36892, 36935);
                    return return_v;
                }


                int
                f_10050_36838_37017(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 36838, 37017);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10050_37041_37069(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 37041, 37069);
                    return return_v;
                }


                bool
                f_10050_37097_37129(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                within)
                {
                    var return_v = IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 37097, 37129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 36615, 37141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 36615, 37141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NamedTypeSymbol GetTopLevelTypeByMetadataName(AssemblySymbol assembly, ref MetadataTypeName metadataName, AssemblyIdentity assemblyOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10050, 37153, 37740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37328, 37428);

                var
                result = f_10050_37341_37427(assembly, ref metadataName, digThroughForwardedTypes: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37442, 37557) || true) && (!f_10050_37447_37496(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 37442, 37557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37530, 37542);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 37442, 37557);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37573, 37699) || true) && (assemblyOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10050, 37577, 37638) && !f_10050_37601_37638(assemblyOpt, f_10050_37620_37637(assembly))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10050, 37573, 37699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37672, 37684);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10050, 37573, 37699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37715, 37729);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10050, 37153, 37740);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10050_37341_37427(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName, bool
                digThroughForwardedTypes)
                {
                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, digThroughForwardedTypes: digThroughForwardedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 37341, 37427);
                    return return_v;
                }


                bool
                f_10050_37447_37496(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                candidate)
                {
                    var return_v = IsAcceptableMatchForGetTypeByMetadataName(candidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 37447, 37496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10050_37620_37637(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 37620, 37637);
                    return return_v;
                }


                bool
                f_10050_37601_37638(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 37601, 37638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 37153, 37740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 37153, 37740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsAcceptableMatchForGetTypeByMetadataName(NamedTypeSymbol candidate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10050, 37752, 37967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 37865, 37956);

                return f_10050_37872_37886(candidate) != SymbolKind.ErrorType || (DynAbs.Tracing.TraceSender.Expression_False(10050, 37872, 37955) || !(candidate is MissingMetadataTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10050, 37752, 37967);

                Microsoft.CodeAnalysis.SymbolKind
                f_10050_37872_37886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 37872, 37886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 37752, 37967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 37752, 37967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual Symbol GetDeclaredSpecialTypeMember(SpecialMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 38170, 38292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 38269, 38281);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 38170, 38292);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 38170, 38292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 38170, 38292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual Symbol GetSpecialTypeMember(SpecialMember member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 38439, 38596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 38530, 38585);

                return f_10050_38537_38584(f_10050_38537_38547(), member);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 38439, 38596);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10050_38537_38547()
                {
                    var return_v = CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 38537, 38547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10050_38537_38584(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialMember
                member)
                {
                    var return_v = this_param.GetDeclaredSpecialTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 38537, 38584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 38439, 38596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 38439, 38596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract ImmutableArray<byte> PublicKey { get; }

        public abstract AssemblyMetadata GetMetadata();

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10050, 38972, 39103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 39039, 39092);

                return f_10050_39046_39091(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10050, 38972, 39103);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonSourceAssemblySymbol
                f_10050_39046_39091(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonSourceAssemblySymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 39046, 39091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10050, 38972, 39103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 38972, 39103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10050, 755, 39110);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10050, 26257, 26304);
            s_nestedTypeNameSeparators = new char[] { '+' }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10050, 755, 39110);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10050, 755, 39110);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10050, 755, 39110);

        Microsoft.CodeAnalysis.AssemblyIdentity
        f_10050_3695_3703()
        {
            var return_v = Identity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10050, 3695, 3703);
            return return_v;
        }


        bool
        f_10050_15699_15819(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialMember
        feature)
        {
            var return_v = this_param.RuntimeSupportsFeature(feature);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 15699, 15819);
            return return_v;
        }


        bool
        f_10050_16380_16501(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialMember
        feature)
        {
            var return_v = this_param.RuntimeSupportsFeature(feature);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10050, 16380, 16501);
            return return_v;
        }

    }
}
