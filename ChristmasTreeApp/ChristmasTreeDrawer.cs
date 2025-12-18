using System.Text;

namespace ChristmasTreeApp
{
    /// <summary>
    /// Responsible for building a textual Christmas tree representation.
    /// </summary>
    public class ChristmasTreeDrawer
    {
        /// <summary>
        /// Builds a string representing a Christmas tree of the given height.
        /// </summary>
        /// <param name="height">The number of levels in the tree (must be positive).</param>
        /// <returns>The complete Christmas tree as a string.</returns>
        public string BuildTree(int height)
        {
            if (height <= 0)
                throw new ArgumentException("Height must be a positive integer.");

            StringBuilder sb = new StringBuilder();
            int maxWidth = (height * 2) - 1;

            // Top wreath emoji
            sb.AppendLine(CenterText("@", maxWidth));

            // Draw the tree foliage
            for (int i = 1; i <= height; i++)
            {
                int starCount = (i * 2) - 1;
                string stars = new string('*', starCount);
                sb.AppendLine(CenterText(stars, maxWidth));
            }

            // Draw the trunk (always centered, 1 character wide)
            sb.AppendLine(CenterText("|", maxWidth));

            return sb.ToString();
        }

        /// <summary>
        /// Helper method that centers a text within a given width.
        /// </summary>
        private string CenterText(string text, int totalWidth)
        {
            int padding = (totalWidth - text.Length) / 2;
            return new string(' ', padding) + text;
        }
    }
}
