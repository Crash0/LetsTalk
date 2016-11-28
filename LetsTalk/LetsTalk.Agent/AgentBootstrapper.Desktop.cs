// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AgentBootstrapper.Desktop.cs" company="GoDialog">
//   All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using Prism.Logging;

namespace LetsTalk.Agent
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    ///     TODO The agent bootstrapper.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public partial class AgentBootstrapper
    {
        /// <summary>
        ///     TODO The _logger.
        /// </summary>
        private readonly EnterpriseLibraryLoggerAdapter logger = new EnterpriseLibraryLoggerAdapter();

        /// <summary>
        ///     TODO The create logger.
        /// </summary>
        /// <returns>
        ///     The <see cref="ILoggerFacade" />.
        /// </returns>
        protected override ILoggerFacade CreateLogger()
        {
            return this.logger;
        }
    }
}