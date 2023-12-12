namespace Statiq.Alerts.Tests
{
    internal class FakeAlertShortcode : AlertShortcode
    {
        protected override string DefaultAlertClass => "DefaultAlertClass";

        protected override string DefaultAlertIcon => "DefaultAlertIcon";

        protected override string DefaultAlertTitle => "DefaultAlertTitle";
    }
}
