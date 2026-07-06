// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CaosSA : ModuleRules
{
	public CaosSA(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CaosSA",
			"CaosSA/Variant_Platforming",
			"CaosSA/Variant_Platforming/Animation",
			"CaosSA/Variant_Combat",
			"CaosSA/Variant_Combat/AI",
			"CaosSA/Variant_Combat/Animation",
			"CaosSA/Variant_Combat/Gameplay",
			"CaosSA/Variant_Combat/Interfaces",
			"CaosSA/Variant_Combat/UI",
			"CaosSA/Variant_SideScrolling",
			"CaosSA/Variant_SideScrolling/AI",
			"CaosSA/Variant_SideScrolling/Gameplay",
			"CaosSA/Variant_SideScrolling/Interfaces",
			"CaosSA/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
