using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Example.BlockComponents
{
    public interface IBlock
    {
        Texture2D Texture { get; set; }
        void Draw(SpriteBatch spriteBatch);
    }
}
