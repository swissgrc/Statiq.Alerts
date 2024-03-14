# Statiq.Alerts

[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](https://github.com/swissgrc/Statiq.Alerts/blob/main/LICENSE)
[![Build](https://img.shields.io/github/actions/workflow/status/swissgrc/Statiq.Alerts/build.yml?branch=develop&style=flat-square)](https://github.com/swissgrc/Statiq.Alerts/actions/workflows/build.yml)
[![Downloads](https://img.shields.io/nuget/dt/Statiq.Alerts?style=flat-square)](https://www.nuget.org/packages/Statiq.Alerts)

Extension for [Statiq site generator] to add alerts.

## Table of Contents

<!-- - [Security](#security)
- [Background](#background) -->
- [Install](#install)
- [Usage](#usage)
- [API](#api)
- [Contributing](#contributing)
- [License](#license)

## Install

1. Add the `Statiq.Alerts` NuGet package to the Statiq project
2. Call `.AddAlertShortCodes()` on the bootstrapper

### Requirements

The extension requires that [Bootstrap] and [FontAwesome] are loaded by the Statiq theme.

## Usage

See [Using Shortcodes] for detailed instructions how to use shortcodes in Statiq.

### Tip

```markdown
<?# Tip ?>
This is a tip
<?#/ Tip ?>
```

Shows a tip alert:

![Tip alert](https://media.githubusercontent.com/media/swissgrc/Statiq.Alerts/develop/docs/tip.png)

### Info

```markdown
<?# Info ?>
This is an info message
<?#/ Info ?>
```

Shows an info message:

![Info alert](https://media.githubusercontent.com/media/swissgrc/Statiq.Alerts/develop/docs/info.png)

### Note

```markdown
<?# Note ?>
This is a note
<?#/ Note ?>
```

Shows a note:

![Note alert](https://media.githubusercontent.com/media/swissgrc/Statiq.Alerts/develop/docs/note.png)

### Warning

```markdown
<?# Warning ?>
This is a warning
<?#/ Warning ?>
```

Shows a warning:

![Warning alert](https://media.githubusercontent.com/media/swissgrc/Statiq.Alerts/develop/docs/warning.png)

### Important

```markdown
<?# Important ?>
This is an important message
<?#/ Important ?>
```

Shows an important message:

![Important alert](https://media.githubusercontent.com/media/swissgrc/Statiq.Alerts/develop/docs/important.png)

## API

### Custom Shortcuts

Additional custom shortcuts can be implemented by inheriting from the `AlertShortcode` class and
define the `DefaultAlertClass`, `DefaultAlertIcon` and `DefaultAlertTitle` properties.
See [Parameters](#Parameters) for documentation about possible values.

### Parameters

The following parameters are available on all shortcuts and allow to override the default styling.

#### Class

The `Class` parameter allows to override the CSS class of the alert `div` element:

```markdown
<?# Note Class="alert-secondary"?>
This is a note rendered in the secondary color
<?#/ Note ?>
```

The `alert` class will always be set.

#### Icon

##### Changing the icon

The `Icon` parameters allows to override the icon of the alert:

```markdown
<?# Note Title="fa-check"?>
This is a note with a different icon
<?#/ Note ?>
```

Any [Fontawesome] icon can be used.
The `fa-solid` class will always be set.

##### Removing the icon

To remove the icon the `Icon` parameter can be set to an empty string:

```markdown
<?# Note Iocn=""?>
This is a note without an icon
<?#/ Note ?>
```

#### Title

##### Changing the title

The `Title` parameters allows to override the title of the alert:

```markdown
<?# Note Title="Custom Title"?>
This is a note with a custom title
<?#/ Note ?>
```

##### Removing the title

To remove the title the `Title` parameter can be set to an empty string:

```markdown
<?# Note Title=""?>
This is a note without a title
<?#/ Note ?>
```

## Contributing

We accept Pull Requests

## License

[MIT © Swiss GRC AG](LICENSE)

[Statiq site generator]: https://www.statiq.dev/
[Bootstrap]: https://getbootstrap.com/
[FontAwesome]: https://fontawesome.com/
[Using Shortcodes]: https://www.statiq.dev/guide/content-and-data/shortcodes#using-shortcodes
