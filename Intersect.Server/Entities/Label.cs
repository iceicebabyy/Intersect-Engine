﻿using Newtonsoft.Json;

namespace Intersect.Server.Entities
{

    public partial struct Label
    {

        [JsonProperty("Label")] public string Text;

        public Color Color;

        public Label(string label, Color color)
        {
            Text = label;
            Color = color;
        }

    }

}
