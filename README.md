# HighLightActorsDemo

English | [简体中文](README.zh-CN.md)

An Unreal Engine 5.8 test project for the HighLightActors outline plugin. The plugin is linked as a Git submodule from [HighLightActors](https://github.com/GoldenDragons/HighLightActors), rather than duplicated in this repository.

## Get the Project

Clone recursively to fetch the plugin submodule:

~~~bash
git clone --recurse-submodules https://github.com/GoldenDragons/HighLightActorsDemo.git
~~~

If the project is already cloned but the plugin folder is empty:

~~~bash
git submodule update --init --recursive
~~~

Open HighLightActorsDemo.uproject with Unreal Engine 5.8. Compile the C++ modules when prompted.

## Blueprint Example

The example is in the Level Blueprint for the main test map:

Content/MODERN_LUXURY_SOFA_2/LEVELS/SOFA2.umap

The Blueprint traces under the mouse cursor and calls **Highlight Actor Outline** on the hit actor. It sets the outline color to red and uses the node's default width.

<img width="1928" height="1040" alt="SOFA2 Level Blueprint hit test and outline nodes" src="https://github.com/user-attachments/assets/13b0b3ab-fa39-47be-ab1b-1d52e637ac48" />

## Runtime Result

Run the SOFA2 map and trigger the hit test to see a red outline on the hit actor. When the target changes, the plugin restores the previous actor's Custom Depth/Stencil state.

<img width="1920" height="1032" alt="SOFA2 runtime red outline" src="https://github.com/user-attachments/assets/4f8bd625-071c-448c-b8ac-01306ff794b2" />

## Plugin Settings

The plugin is enabled in the project descriptor and provided by the Plugins/HighLightActors submodule. The project enables Custom Stencil and disables Custom Depth temporal jitter to stabilize the post-process outline:

~~~ini
r.CustomDepth=3
r.CustomDepthTemporalAAJitter=0
~~~

See the [plugin README](https://github.com/GoldenDragons/HighLightActors#readme) for installation steps and the C++ and Blueprint APIs.
