namespace Statiq.Alerts.Tests
{
    using Shouldly;
    using Statiq.Testing;

    public class InfoShortcodeTests
    {
        [Fact]
        public void Should_Return_Correct_Default_Values()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args = Array.Empty<KeyValuePair<string, string>>();
            var shortcode = new InfoShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert alert-info\" role=\"alert\"><i class=\"fa-solid fa-circle-info\" aria-hidden=\"true\"></i>&nbsp;<strong>INFO</strong><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }
    }
}