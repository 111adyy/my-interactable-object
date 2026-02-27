// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyInteractiveObject : ModuleRules
{
	public MyInteractiveObject(ReadOnlyTargetRules Target) : base(Target)
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
			"MyInteractiveObject",
			"MyInteractiveObject/Variant_Horror",
			"MyInteractiveObject/Variant_Horror/UI",
			"MyInteractiveObject/Variant_Shooter",
			"MyInteractiveObject/Variant_Shooter/AI",
			"MyInteractiveObject/Variant_Shooter/UI",
			"MyInteractiveObject/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
