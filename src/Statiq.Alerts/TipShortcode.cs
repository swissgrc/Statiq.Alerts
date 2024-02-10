namespace Statiq.Alerts
{
    /// <summary>
    /// Shortcode for tips.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;?# Tip ?&gt;
    /// This is a tip
    /// &lt;?#/ Tip ?&gt;
    /// </code>
    /// </example>
    public class TipShortcode : AlertShortcode
    {
        /// <inheritdoc/>
        protected override string DefaultAlertClass => "alert-success";

        /// <inheritdoc/>
        protected override string DefaultAlertIcon => "fa-lightbulb";

        /// <inheritdoc/>
        protected override string DefaultAlertTitle => "TIP";
    }
}
