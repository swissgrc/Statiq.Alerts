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
        /// <inheritdoc/>
        protected override string DefaultAlertClass => "alert-primary";

        /// <inheritdoc/>
        protected override string DefaultAlertIcon => "fa-pen-to-square";

        /// <inheritdoc/>
        protected override string DefaultAlertTitle => "NOTE";
    }
}
