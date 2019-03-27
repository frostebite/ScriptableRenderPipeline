 

# Shader stripping 

 **Note:** This page is subject to change during the 2019.1 beta cycle. 

# Shader Stripping 

 Unity compiles many Shader Variants from a single Shader source file. The number of Shader Variants depends on how many Shader keywords you’ve included in the Shader. In the default Shaders, the Lightweight Render Pipeline uses a set of keywords for lighting and shadows. LWRP can exclude some Shader Variants, depending on which features are active in the [lwrp-asset.md](lwrp-asset.md). 

 When you disable [shader-stripping-keywords.md](shader-stripping-keywords.md) in the LWRP Asset, the pipeline "strips" the related Shader Variants from the build. Stripping your shaders gives you smaller build sizes and shorter build times. This is useful if your project is never going to use certain features or keywords. 

 For example, you might have a project where you never use shadows for directional lights. Without Shader stripping, Shader Variants with directional shadow support remain in the build. To strip these Shader Variants, uncheck **Cast Shadows** in the LWRP Asset for either main or additional direction lights. 

 For more information about stripping shader variants in Unity, see [this blog post by Christophe Riccio](https://blogs.unity3d.com/2018/05/14/stripping-scriptable-shader-variants/).