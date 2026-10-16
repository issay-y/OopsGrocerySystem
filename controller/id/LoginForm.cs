using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using OopsGrocerySystem.util;

namespace OopsGrocerySystem.controller.id
{
    public partial class LoginForm : Form
    {
        private static readonly Color Green = Color.FromArgb(26, 82, 48);
        private static readonly Color BorderIdle = Color.FromArgb(221, 224, 220);

        public LoginForm()
        {
            InitializeComponent();
            ApplyFontFallbacks(this);

            // Input boxes are normal until touched; green only while focused.
            WireFocus(boxUsername, txtUsername);
            WireFocus(boxPassword, txtPassword);

            // Show / hide password (eye icon).
            icoEye.Cursor = Cursors.Hand;
            icoEye.Click += (_, _) => TogglePassword();

            // Start with nothing focused (no highlighted field, no caret).
            Shown += (_, _) => ActiveControl = null;
        }

        private void TogglePassword()
        {
            bool reveal = txtPassword.UseSystemPasswordChar;      // currently hidden -> show it
            txtPassword.UseSystemPasswordChar = !reveal;
            icoEye.Kind = reveal ? IconKind.EyeOff : IconKind.Eye;

            txtPassword.Focus();                                   // keep typing where you left off
            txtPassword.SelectionStart = txtPassword.TextLength;
        }

        private static void WireFocus(RoundedPanel box, TextBox input)
        {
            input.Enter += (_, _) => SetFocused(box, true);
            input.Leave += (_, _) => SetFocused(box, false);
            box.Click += (_, _) => input.Focus();   // clicking the rounded box focuses its field
        }

        private static void SetFocused(RoundedPanel box, bool focused)
        {
            box.BorderColor = focused ? Green : BorderIdle;
            box.BorderWidth = focused ? 2.5f : 1.5f;
        }

        private static void ApplyFontFallbacks(Control root)
        {
            using var installed = new InstalledFontCollection();
            bool hasLora = installed.Families.Any(f => f.Name.Equals("Lora", StringComparison.OrdinalIgnoreCase));
            bool hasInter = installed.Families.Any(f => f.Name.Equals("Inter", StringComparison.OrdinalIgnoreCase));

            void Walk(Control c)
            {
                if (c.Font.Name == "Lora" && !hasLora)
                    c.Font = new Font("Georgia", c.Font.Size, c.Font.Style);
                else if (c.Font.Name == "Inter" && !hasInter)
                    c.Font = new Font("Segoe UI", c.Font.Size, c.Font.Style);

                foreach (Control child in c.Controls) Walk(child);
            }
            Walk(root);
        }
    }
}