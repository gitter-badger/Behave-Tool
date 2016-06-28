using System.Drawing;
using System.Windows.Forms;

namespace Behave_Tool.Tools.Special
{
    public partial class CheckedListBox_With_Image : ListBox
    {
        public CheckedListBox_With_Image()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = 9;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;

            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawRectangle(Pens.Red, 2, e.Bounds.Y + 2, 14, 14); // Simulate an icon.

                var textRect = e.Bounds;
                textRect.X += 20;
                textRect.Width -= 20;
                string itemText = DesignMode ? "CheckedListBox" : Items[e.Index].ToString();
                TextRenderer.DrawText(e.Graphics, itemText, e.Font, textRect, e.ForeColor, flags);
                e.DrawFocusRectangle();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }
    }
}