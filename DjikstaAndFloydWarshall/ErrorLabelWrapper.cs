using System.Drawing;
using System.Windows.Forms;

namespace DjikstaAndFloydWarshall
{
    public class ErrorLabelWrapper
    {
        private Label ErrorLabel { get; set; }

        public ErrorLabelWrapper(Label errorLabel)
        {
            ErrorLabel = errorLabel;
            Reset();
        }

        public void Write(string text)
        {
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Text = text;
        }

        public void Reset() => ErrorLabel.Text = string.Empty;
    }
}
