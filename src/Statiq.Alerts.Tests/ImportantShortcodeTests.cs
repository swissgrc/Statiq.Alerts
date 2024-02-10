namespace Statiq.Alerts.Tests
{
    public class ImportantShortcodeTests
    {
        [Fact]
        public void Should_Return_Correct_Default_Values()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args = Array.Empty<KeyValuePair<string, string>>();
            var shortcode = new ImportantShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                """<div class="alert alert-danger" role="alert"><i class="fa-solid fa-triangle-exclamation" aria-hidden="true"></i>&nbsp;<strong>IMPORTANT</strong><hr/>Foo</div>""",
                StringCompareShould.IgnoreLineEndings);
        }
    }
}