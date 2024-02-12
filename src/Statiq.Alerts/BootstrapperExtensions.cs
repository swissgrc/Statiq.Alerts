namespace Statiq.Alerts
{
    /// <summary>
    /// Extensions for <see cref="Bootstrapper"/>."/>
    /// </summary>
    public static class BootstrapperExtensions
    {
        /// <summary>
        /// Registers alert shortcodes.
        /// </summary>
        /// <param name="bootstrapper">Bootstrapper instance on which shortcodes should be registered.</param>
        /// <param name="tipShortcode">Identifier for the shortcode for tips. Default value is <c>Tip</c>.</param>
        /// <param name="infoShortcode">Identifier for the shortcode for info messages. Default value is <c>Info</c>.</param>
        /// <param name="noteShortcode">Identifier for the shortcode for notes. Default value is <c>Note</c>.</param>
        /// <param name="warningShortcode">Identifier for the shortcode for warnings. Default value is <c>Warning</c>.</param>
        /// <param name="importantShortcode">Identifier for the shortcode for important messages. Default value is <c>Important</c>.</param>
        /// <returns>Bootstrapper instance.</returns>
        public static Bootstrapper AddAlertShortCodes(
            this Bootstrapper bootstrapper,
            string tipShortcode = "Tip",
            string infoShortcode = "Info",
            string noteShortcode = "Note",
            string warningShortcode = "Warning",
            string importantShortcode = "Important"
            )
        {
            bootstrapper.AddShortcode<TipShortcode>(tipShortcode);
            bootstrapper.AddShortcode<InfoShortcode>(infoShortcode);
            bootstrapper.AddShortcode<NoteShortcode>(noteShortcode);
            bootstrapper.AddShortcode<WarningShortcode>(warningShortcode);
            bootstrapper.AddShortcode<ImportantShortcode>(importantShortcode);

            return bootstrapper;
        }
    }
}