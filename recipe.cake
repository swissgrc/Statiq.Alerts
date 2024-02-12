#load nuget:?package=Cake.Recipe&version=3.1.1

Environment.SetVariableNames();

BuildParameters.SetParameters(
    context: Context,
    buildSystem: BuildSystem,
    sourceDirectoryPath: "./src",
    title: "Statiq.Alerts",
    masterBranchName: "main",
    repositoryOwner: "swissgrc",
    repositoryName: "Statiq.Alerts",
    shouldRunDotNetCorePack: true,
    shouldUseDeterministicBuilds: true,
    shouldGenerateDocumentation: false, // docs folder does not contain a Wyam project
    preferredBuildProviderType: BuildProviderType.GitHubActions,
    preferredBuildAgentOperatingSystem: PlatformFamily.Linux);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);

Build.RunDotNetCore();
