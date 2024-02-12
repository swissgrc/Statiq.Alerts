namespace Statiq.Alerts.Tests
{
    public class TipShortcodeTests
    {
        [Fact]
        public void Should_Return_Correct_Default_Values()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args = Array.Empty<KeyValuePair<string, string>>();
            var shortcode = new TipShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                """<div class="alert alert-success" role="alert"><i class="fa-solid fa-lightbulb" aria-hidden="true"></i>&nbsp;<strong>TIP</strong><hr/>Foo</div>""",
                StringCompareShould.IgnoreLineEndings);
        }
    }
}