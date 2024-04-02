using Semver;

namespace EnKdev.ItemTrackers.Core.Version;

/// <summary>
/// Class that handles everything related to semantic versioning.
/// </summary>
public static class Versioner
{
    /// <summary>
    /// Generates a version string for a given application.
    /// </summary>
    /// <param name="appName">The name of the application.</param>
    /// <param name="major">The major version number.</param>
    /// <param name="minor">The minor version number.</param>
    /// <param name="patch">The patch version number.</param>
    /// <param name="prerelease">The prerelease label (optional).</param>
    /// <param name="metadata">The metadata (optional).</param>
    /// <returns>The version string in the format: appName + V{major.minor.patch-prerelease+metadata}</returns>
    public static string VersionString(string appName, int major, int minor, int patch, string prerelease = "",
        string metadata = "")
    {
        return appName + " V" + SemVersion.ParsedFrom(major, minor, patch, prerelease, metadata);
    }
}