// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ShooterSam : ModuleRules
{
	public ShooterSam(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { // Add other public dependencies that you statically link with here...
			"Core", // For core engine features
			"CoreUObject", // For UObject system
			"Engine", // For general engine features
			"InputCore", // For basic input
			"EnhancedInput", // For Enhanced Input
			"AIModule", // For AI
			"StateTreeModule", // For State Trees
			"GameplayStateTreeModule", // For Gameplay State Trees
			"UMG", // For UI
			"Slate" // For UI
		});

		PrivateDependencyModuleNames.AddRange(new string[] { }); // Add private dependencies that you statically link with here...

		PublicIncludePaths.AddRange(new string[] { // Add public include paths required here...
			"ShooterSam",
			"ShooterSam/Variant_Platforming",
			"ShooterSam/Variant_Platforming/Animation",
			"ShooterSam/Variant_Combat",
			"ShooterSam/Variant_Combat/AI",
			"ShooterSam/Variant_Combat/Animation",
			"ShooterSam/Variant_Combat/Gameplay",
			"ShooterSam/Variant_Combat/Interfaces",
			"ShooterSam/Variant_Combat/UI",
			"ShooterSam/Variant_SideScrolling",
			"ShooterSam/Variant_SideScrolling/AI",
			"ShooterSam/Variant_SideScrolling/Gameplay",
			"ShooterSam/Variant_SideScrolling/Interfaces",
			"ShooterSam/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
