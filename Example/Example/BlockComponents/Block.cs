using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Example.BlockComponents
{
    class Block : IBlock
    {
        public Texture2D Texture { get; set; }

        private Vector2 position;

        public Block(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            this.position = position;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(983, 10, 16, 16);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 32, 32);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, sourceRectangle, destinationRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
