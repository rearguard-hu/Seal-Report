namespace SealWebServer.Models.Configuration
{
    public class Authentication
    {
        public string Id4EndPoint { get; set; }
        public string AccessKeySecret { get; set; }
        public string ClientId { get; set; }

        public string ResponseType { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// The callback address
        /// </summary>
        public string CallbackPath { get; set; }

        /// <summary>
        /// Scope
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Whether to enable the configuration
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// If true, only this authentication is enabled
        /// </summary>
        public bool Unique { get; set; }
    }
}