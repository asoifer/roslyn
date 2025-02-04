﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Options;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    /// <summary>
    /// Analyzer options with workspace.
    /// These are used to fetch the workspace options by our internal analyzers (e.g. simplification analyzer).
    /// </summary>
    internal sealed class WorkspaceAnalyzerOptions : AnalyzerOptions
    {
        private readonly Solution _solution;

        // IDE options for each encountered language
        private ImmutableDictionary<string, IdeAnalyzerOptions> _ideOptionsCache;

        public WorkspaceAnalyzerOptions(AnalyzerOptions options, Solution solution)
            : base(options.AdditionalFiles, options.AnalyzerConfigOptionsProvider)
        {
            _solution = solution;
            _ideOptionsCache = ImmutableDictionary<string, IdeAnalyzerOptions>.Empty;
        }

        public IdeAnalyzerOptions GetIdeOptions(string language)
            => ImmutableInterlocked.GetOrAdd(
                ref _ideOptionsCache,
                language,
                static (language, solution) => new IdeAnalyzerOptions(
                    FadeOutUnusedImports: solution.Options.GetOption(Fading.FadingOptions.Metadata.FadeOutUnusedImports, language),
                    FadeOutUnreachableCode: solution.Options.GetOption(Fading.FadingOptions.Metadata.FadeOutUnreachableCode, language),
                    ReportInvalidPlaceholdersInStringDotFormatCalls: solution.Options.GetOption(ValidateFormatString.ValidateFormatStringOption.ReportInvalidPlaceholdersInStringDotFormatCalls, language),
                    ReportInvalidRegexPatterns: solution.Options.GetOption(Features.EmbeddedLanguages.RegularExpressions.LanguageServices.RegularExpressionsOptions.ReportInvalidRegexPatterns, language)),
                _solution);

        public HostWorkspaceServices Services => _solution.Workspace.Services;

        [PerformanceSensitive("https://github.com/dotnet/roslyn/issues/23582", OftenCompletesSynchronously = true)]
        public async ValueTask<OptionSet> GetDocumentOptionSetAsync(SyntaxTree syntaxTree, CancellationToken cancellationToken)
        {
            var documentId = _solution.GetDocumentId(syntaxTree);
            if (documentId == null)
            {
                return _solution.Options;
            }

            var document = _solution.GetDocument(documentId);
            if (document == null)
            {
                return _solution.Options;
            }

            return await document.GetOptionsAsync(_solution.Options, cancellationToken).ConfigureAwait(false);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is WorkspaceAnalyzerOptions other &&
                _solution.WorkspaceVersion == other._solution.WorkspaceVersion &&
                _solution.Workspace == other._solution.Workspace &&
                base.Equals(other);
        }

        public override int GetHashCode()
            => Hash.Combine(_solution.Workspace,
               Hash.Combine(_solution.WorkspaceVersion, base.GetHashCode()));
    }
}
