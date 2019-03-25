namespace UnityEngine.Rendering.LWRP
{
    /// <!-- Badly formed XML comment ignored for member "T:UnityEngine.Rendering.LWRP.ScriptableRendererFeature" -->
            public abstract class ScriptableRendererFeature : ScriptableObject
    {
        ///     <summary>
                ///     Initializes this feature's resources.
                ///     </summary>
                        public abstract void Create();

        /// <!-- Badly formed XML comment ignored for member "M:UnityEngine.Rendering.LWRP.ScriptableRendererFeature.AddRenderPasses(UnityEngine.Rendering.LWRP.ScriptableRenderer,UnityEngine.Rendering.LWRP.RenderingData@)" -->
                        public abstract void AddRenderPasses(ScriptableRenderer renderer,
            ref RenderingData renderingData);

        void OnEnable()
        {
            Create();
        }

        void OnValidate()
        {
            Create();
        }
    }
}
