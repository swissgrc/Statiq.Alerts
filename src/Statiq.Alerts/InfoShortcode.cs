namespace Statiq.Alerts
{
    /// <summary>
    /// Shortcode for info messages.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;?# Info ?&gt;
    /// This is an info message
    /// &lt;?#/ Info ?&gt;
    /// </code>
    /// </example>
    public class InfoShortcode : AlertShortcode
    {
        /// <inheritdoc/>
        protected override string DefaultAlertClass => "alert-info";

        /// <inheritdoc/>
        protected override string DefaultAlertIcon => "fa-circle-info";

        /// <inheritdoc/>
        protected override string DefaultAlertTitle => "INFO";
    }
}
