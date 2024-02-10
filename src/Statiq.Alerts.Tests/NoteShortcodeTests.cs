namespace Statiq.Alerts.Tests
{
    public class NoteShortcodeTests
    {
        [Fact]
        public void Should_Return_Correct_Default_Values()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args = Array.Empty<KeyValuePair<string, string>>();
            var shortcode = new NoteShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert alert-primary\" role=\"alert\"><i class=\"fa-solid fa-pen-to-square\" aria-hidden=\"true\"></i>&nbsp;<strong>NOTE</strong><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }
    }
}