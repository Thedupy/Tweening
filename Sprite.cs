using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pandemie
{
    public class Sprite
    {
        public TweenPosition TPosition;
        public Texture2D Texture;
        public Vector2 Position;
        public Rectangle Hitbox
        {
            get { return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height); }
        }
        //public Vector2 Origin
        //{
        //    get { return new Vector2((Position.X + Texture.Width) / 2, (Position.Y + Texture.Height) / 2); }
        //}

        public Sprite(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
            TPosition = new TweenPosition(this);
        }

        public virtual void Update(float time)
        {
            TPosition.Update(time, ref Position);
        }

        public virtual void Draw(SpriteBatch batch)
        {
            //batch.Draw(Texture, Position, Color.White);

            ////DECOMMENTER SI BESOIN DE DESSINER LES HITBOX
            //Texture2D tex = Assets.CreateTexture(hitbox.Width, hitbox.Height, new Color(255, 0, 0, 50));
            //if (tex != null)
            //    batch.Draw(tex, hitbox, Color.White);
        }

    }
}
