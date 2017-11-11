// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailManagerBase.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The mail manager base.
    /// </summary>
    public abstract class MailManagerBase
    {
        protected readonly MailChimpOptions MailChimpOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public MailManagerBase(string apiKey) => MailChimpOptions = new MailChimpOptions
        {
            ApiKey = apiKey,
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MailManagerBase"/> class.
        /// </summary>
        protected MailManagerBase()
        {

        }
    }
}