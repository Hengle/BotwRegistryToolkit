﻿namespace BotwRegistryToolkit.Models
{
    public record CommandInfo(string Name, string Folder, string? FileExtensions, params (string Key, object Value)[] Flags);
    public class CommandsModel
    {
        // 
        // Aamp

        public static CommandInfo ConvertAampToYaml { get; set; } = new(
            "Convert Aamp To Yaml", "Aamp", null, ("deleteSource", SettingsFactory["AampDeleteSource"]!)
        );

        public static CommandInfo ConvertYamlToAamp { get; set; } = new(
            "Convert Yaml To Aamp", "Aamp", ".yml .yaml", ("deleteSource", SettingsFactory["AampDeleteSource"]!)
        );
    }
}
