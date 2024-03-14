namespace Statiq.Alerts
{
    /// <summary>
    /// Shortcode for warning messages.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;?# Warning ?&gt;
    /// This is a warning
    /// &lt;?#/ Warning ?&gt;
    /// </code>
    /// </example>
    public class WarningShortcode : AlertShortcode
    {
        /// <inheritdoc/>
        protected override string DefaultAlertClass => "alert-warning";

        /// <inheritdoc/>
        protected override string DefaultAlertIcon => "fa-circle-exclamation";

        /// <inheritdoc/>
        protected override string DefaultAlertTitle => "WARNING";
    }
}
