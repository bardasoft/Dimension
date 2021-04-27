using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace nugetTest
{
    public class DrawTest : MonoGameControl
    {

        public string MenuMessage;

        public Color background;
        public Color textColor;

        protected override void Initialize()
        {
            background = Color.CornflowerBlue;
            MenuMessage = "Text";
            textColor = Color.White;

            base.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw()
        {
            base.Draw();
            GraphicsDevice.Clear(background);

            Editor.spriteBatch.Begin();

            Editor.spriteBatch.DrawString(Editor.Font, MenuMessage, new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(MenuMessage).X / 2),
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2)),
                textColor);

            Editor.spriteBatch.End();
        }
    }
}