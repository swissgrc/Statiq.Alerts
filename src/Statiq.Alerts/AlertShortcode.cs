namespace Statiq.Alerts
{
    using Statiq.Common;
    using System.Collections.Generic;

    /// <summary>
    /// Base class for alert shortcodes.
    /// </summary>
    public abstract class AlertShortcode : SyncShortcode
    {
        /// <summary>
        /// Name of the shortcode argument that specifies the CSS class of the alert.
        /// </summary>
        protected const string Class = nameof(Class);

        /// <summary>
        /// Name of the shortcode argument that specifies the icon of the alert.
        /// </summary>
        protected const string Icon = nameof(Icon);

        /// <summary>
        /// Name of the shortcode argument that specifies the title of the alert.
        /// </summary>
        protected const string Title = nameof(Title);

        /// <summary>
        /// Gets the default CSS class of the alert.
        /// </summary>
        /// <remarks>
        /// The <c>alert</c> class will always be set in addition.
        /// </remarks>
        protected abstract string DefaultAlertClass { get; }

        /// <summary>
        /// Gets the default icon of the alert.
        /// Any FontAwesome icon can be used.
        /// An empty string will result in no icon being displayed.
        /// </summary>
        /// <remarks>
        /// The <c>fa-solid</c> class will always be set in addition.
        /// </remarks>
        protected abstract string DefaultAlertIcon { get; }

        /// <summary>
        /// Gets the default title of the alert.
        /// An empty string will result in no title being displayed.
        /// </summary>
        protected abstract string DefaultAlertTitle { get; }

        /// <inheritdoc/>
        public override ShortcodeResult Execute(
            KeyValuePair<string, string>[] args,
            string content,
            IDocument document,
            IExecutionContext context)
        {
            var arguments = args.ToDictionary(Class, Icon, Title);

            var alertClass = DefaultAlertClass;
            if (arguments.ContainsKey(Class))
            {
                alertClass = arguments.GetString(Class);
            }

            var alertIcon = DefaultAlertIcon;
            if (arguments.ContainsKey(Icon))
            {
                alertIcon = arguments.GetString(Icon);
            }

            var alertTitle = DefaultAlertTitle;
            if (arguments.ContainsKey(Title))
            {
                alertTitle = arguments.GetString(Title);
            }

            var result = $"<div class=\"alert {alertClass}\" role=\"alert\">";

            if (!string.IsNullOrWhiteSpace(alertIcon))
            {
                result += $"<i class=\"fa-solid {alertIcon}\" aria-hidden=\"true\"></i>";
            }

            if (!string.IsNullOrWhiteSpace(alertTitle))
            {
                if (!string.IsNullOrWhiteSpace(alertIcon))
                {
                    result += "&nbsp;";
                }

                result += $"<strong>{alertTitle}</strong>";
            }

            if (!string.IsNullOrWhiteSpace(alertIcon) || !string.IsNullOrWhiteSpace(alertTitle))
            {
                result += "<hr/>";
            }

            result += $"{content}</div>";

            return result;
        }
    }
}
