using System.Drawing;
using System.Windows.Forms;

namespace SanaPass_EBAAMS.Helpers
{
    public static class NavigationButtonHelper
    {
        public static void HighlightButton(
            Button[] navigationButtons,
            Button activeButton)
        {
            if (navigationButtons == null)
            {
                return;
            }

            Color normalColor = Color.Transparent;
            Color highlightColor = Color.FromArgb(180, 0, 0);

            foreach (Button button in navigationButtons)
            {
                if (button == null)
                {
                    continue;
                }

                button.BackColor = button == activeButton
                    ? highlightColor
                    : normalColor;
            }
        }
    }
}