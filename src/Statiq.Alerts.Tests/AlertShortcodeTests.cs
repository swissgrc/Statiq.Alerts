namespace Statiq.Alerts.Tests
{
    public class AlertShortcodeTests
    {
        [Fact]
        public void Should_Return_Correct_Result_When_Called_Without_Parameter()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args = Array.Empty<KeyValuePair<string, string>>();
            var shortcode = new FakeAlertShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert DefaultAlertClass\" role=\"alert\"><i class=\"fa-solid DefaultAlertIcon\" aria-hidden=\"true\"></i>&nbsp;<strong>DefaultAlertTitle</strong><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }

        [Fact]
        public void Should_Return_Correct_Result_When_Class_Parameter_Is_Passed()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args =
                new KeyValuePair<string, string>[] 
                { 
                    new("Class", "CustomClass") 
                };
            var shortcode = new FakeAlertShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert CustomClass\" role=\"alert\"><i class=\"fa-solid DefaultAlertIcon\" aria-hidden=\"true\"></i>&nbsp;<strong>DefaultAlertTitle</strong><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }

        [Fact]
        public void Should_Return_Correct_Result_When_Icon_Parameter_Is_Passed()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args =
                new KeyValuePair<string, string>[]
                {
                    new("Icon", "CustomIcon")
                };
            var shortcode = new FakeAlertShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert DefaultAlertClass\" role=\"alert\"><i class=\"fa-solid CustomIcon\" aria-hidden=\"true\"></i>&nbsp;<strong>DefaultAlertTitle</strong><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Should_Not_Render_Icon_If_Null_Empty_Or_Whitespace_Is_Passed(string value)
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args =
                new KeyValuePair<string, string>[]
                {
                    new("Icon", value)
                };
            var shortcode = new FakeAlertShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert DefaultAlertClass\" role=\"alert\"><strong>DefaultAlertTitle</strong><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }

        [Fact]
        public void Should_Return_Correct_Result_When_Title_Parameter_Is_Passed()
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args =
                new KeyValuePair<string, string>[]
                {
                    new("Title", "CustomTitle")
                };
            var shortcode = new FakeAlertShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert DefaultAlertClass\" role=\"alert\"><i class=\"fa-solid DefaultAlertIcon\" aria-hidden=\"true\"></i>&nbsp;<strong>CustomTitle</strong><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Should_Not_Render_Title_If_Null_Empty_Or_Whitespace_Is_Passed(string value)
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args =
                new KeyValuePair<string, string>[]
                {
                    new("Title", value)
                };
            var shortcode = new FakeAlertShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert DefaultAlertClass\" role=\"alert\"><i class=\"fa-solid DefaultAlertIcon\" aria-hidden=\"true\"></i><hr/>Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Should_Not_Render_Title_If_Icon_And_Title_Are_Null_Empty_Or_Whitespace(string value)
        {
            // Given
            var context = new TestExecutionContext();
            var document = new TestDocument();
            var content = @"Foo";
            var args =
                new KeyValuePair<string, string>[]
                {
                    new("Icon", value),
                    new("Title", value)
                };  
            var shortcode = new FakeAlertShortcode();

            // When
            var result = shortcode.Execute(args, content, document, context);

            // Then
            result.ContentProvider.GetStream().ReadToEnd().ShouldBe(
                "<div class=\"alert DefaultAlertClass\" role=\"alert\">Foo</div>",
                StringCompareShould.IgnoreLineEndings);
        }
    }
}