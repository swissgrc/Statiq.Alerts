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
        protected override string DefaultAlertClass => "alert-danger";

        protected override string DefaultAlertIcon => "fa-triangle-exclamation";

        protected override string DefaultAlertTitle => "IMPORTANT";
    }
}
