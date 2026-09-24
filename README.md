# HighLightActorsDemo

HighLightActors 插件的 Unreal Engine 5.8 测试项目。插件通过 Git 子模块从 [HighLightActors](https://github.com/GoldenDragons/HighLightActors) 仓库关联，不需要把插件源码重复复制到 Demo 仓库。

## 获取项目

需要递归克隆以同时获取插件子模块：

~~~bash
git clone --recurse-submodules https://github.com/GoldenDragons/HighLightActorsDemo.git
~~~

如果项目已克隆但插件目录为空：

~~~bash
git submodule update --init --recursive
~~~

用 Unreal Engine 5.8 打开 HighLightActorsDemo.uproject。首次打开 C++ 项目时，按 Unreal Editor 提示编译模块。

## 蓝图示例位置

蓝图示例位于主测试关卡的 **Level Blueprint**：

Content/MODERN_LUXURY_SOFA_2/LEVELS/SOFA2.umap

蓝图在鼠标命中 Actor 后调用 **Highlight Actor Outline**。节点把命中的 Actor 作为目标，并将轮廓颜色设为红色；线宽使用节点默认值。

> **截图待补充：** SOFA2 Level Blueprint 中的命中检测与高亮节点。

## 运行效果

运行 SOFA2 关卡并触发蓝图中的命中检测后，被命中的 Actor 会显示红色轮廓。切换目标时插件会恢复上一个 Actor 的 Custom Depth/Stencil 状态。

> **截图待补充：** SOFA2 运行时红色轮廓效果。

## 插件设置

插件由 Plugins/HighLightActors 子模块提供，已在 .uproject 中启用。项目配置开启了 Custom Stencil，并关闭 Custom Depth 的 TAA 抖动，以稳定后处理轮廓：

~~~ini
r.CustomDepth=3
r.CustomDepthTemporalAAJitter=0
~~~

关于插件安装、C++/蓝图接口和参数说明，请见 [插件 README](https://github.com/GoldenDragons/HighLightActors#readme)。
