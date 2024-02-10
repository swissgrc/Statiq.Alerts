namespace Statiq.Alerts
{
    /// <summary>
    /// Shortcode for important messages.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;?# Important ?&gt;
    /// This is an important message
    /// &lt;?#/ Important ?&gt;
    /// </code>
    /// </example>
    public class ImportantShortcode : AlertShortcode
    {
        /// <inheritdoc/>
        protected override string DefaultAlertClass => "alert-danger";

        /// <inheritdoc/>
        protected override string DefaultAlertIcon => "fa-triangle-exclamation";

        /// <inheritdoc/>
        protected override string DefaultAlertTitle => "IMPORTANT";
    }
}
