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
        protected override string DefaultAlertClass => "alert-success";

        protected override string DefaultAlertIcon => "fa-lightbulb";

        protected override string DefaultAlertTitle => "TIP";
    }
}
