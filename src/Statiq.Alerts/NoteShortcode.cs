namespace Statiq.Alerts
{
    /// <summary>
    /// Shortcode for notes.
    /// </summary>
    /// <example>
    /// <code>
    /// &lt;?# Note ?&gt;
    /// This is a note
    /// &lt;?#/ Note ?&gt;
    /// </code>
    /// </example>
    public class NoteShortcode : AlertShortcode
    {
        protected override string DefaultAlertClass => "alert-primary";

        protected override string DefaultAlertIcon => "fa-pen-to-square";

        protected override string DefaultAlertTitle => "NOTE";
    }
}
