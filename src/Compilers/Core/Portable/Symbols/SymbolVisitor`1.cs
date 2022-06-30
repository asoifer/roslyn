// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    public abstract class SymbolVisitor<TResult>
    {
        public virtual TResult? Visit(ISymbol? symbol)
        {
            return symbol == null
                ? default(TResult?)
                : symbol.Accept(this);
        }

        public virtual TResult? DefaultVisit(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 502, 615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 579, 604);

                return default(TResult?);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 502, 615);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 502, 615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 502, 615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitAlias(IAliasSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitArrayType(IArrayTypeSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitAssembly(IAssemblySymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitDiscard(IDiscardSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitDynamicType(IDynamicTypeSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitEvent(IEventSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitField(IFieldSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitLabel(ILabelSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitLocal(ILocalSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitMethod(IMethodSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitModule(IModuleSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitNamedType(INamedTypeSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitNamespace(INamespaceSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitParameter(IParameterSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitPointerType(IPointerTypeSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitFunctionPointerType(IFunctionPointerTypeSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitProperty(IPropertySymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitRangeVariable(IRangeVariableSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public virtual TResult? VisitTypeParameter(ITypeParameterSymbol symbol)
        {
            return DefaultVisit(symbol);
        }

        public SymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(645, 249, 3247);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(645, 249, 3247);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 249, 3247);
        }


        static SymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(645, 249, 3247);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(645, 249, 3247);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 249, 3247);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(645, 249, 3247);
    }
}
