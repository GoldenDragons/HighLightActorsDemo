// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HighLightActorsDemo : ModuleRules
{
	public HighLightActorsDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore",
			"EnhancedInput" , "HighLightActors" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		}
}
