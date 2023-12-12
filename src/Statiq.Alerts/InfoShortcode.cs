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
        protected override string DefaultAlertClass => "alert-info";

        protected override string DefaultAlertIcon => "fa-circle-info";

        protected override string DefaultAlertTitle => "INFO";
    }
}
