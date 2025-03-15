using System;

namespace PanzerCustomEscapes.Models
{
    using UnityEngine;

    public class CustomEscapeHandle
    {
        public Vector3 Position { get; set; }
        public EscapeHandle[] Handles { get; set; } = Array.Empty<EscapeHandle>();
    }
}