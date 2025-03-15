using System;

namespace PanzerCustomEscapes
{
    using Exiled.API.Features;

    public class Plugin : Plugin<Config>
    {
        private EventHandler? eventHandler;

        public static Plugin Instance { get; private set; } = null!;

        public override string Name { get; } = "PanzerCustomEscapes";
        public override string Author { get; } = "Panzer VI Tiger II";
        public override Version RequiredExiledVersion { get; } = new(9, 5, 1);

        public override void OnEnabled()
        {
            Instance = this;
            eventHandler = new();
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            eventHandler = null;
            Instance = null!;
            
            base.OnDisabled();
        }
    }
}