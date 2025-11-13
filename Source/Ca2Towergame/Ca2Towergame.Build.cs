// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Ca2Towergame : ModuleRules
{
	public Ca2Towergame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Ca2Towergame",
			"Ca2Towergame/Variant_Strategy",
			"Ca2Towergame/Variant_Strategy/UI",
			"Ca2Towergame/Variant_TwinStick",
			"Ca2Towergame/Variant_TwinStick/AI",
			"Ca2Towergame/Variant_TwinStick/Gameplay",
			"Ca2Towergame/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
