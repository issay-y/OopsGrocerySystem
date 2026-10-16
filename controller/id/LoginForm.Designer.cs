#nullable disable
namespace OopsGrocerySystem.controller.id
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlBrand = new System.Windows.Forms.Panel();
            icoBasket = new OopsGrocerySystem.util.IconBox();
            lblBrand = new System.Windows.Forms.Label();
            pnlAccent = new System.Windows.Forms.Panel();
            lblTagline = new System.Windows.Forms.Label();
            lblFooter = new System.Windows.Forms.Label();
            pnlForm = new System.Windows.Forms.Panel();
            lblWelcome = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            boxUsername = new OopsGrocerySystem.util.RoundedPanel();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            boxPassword = new OopsGrocerySystem.util.RoundedPanel();
            txtPassword = new System.Windows.Forms.TextBox();
            icoEye = new OopsGrocerySystem.util.IconBox();
            pnlNotice = new OopsGrocerySystem.util.RoundedPanel();
            icoNotice = new OopsGrocerySystem.util.IconBox();
            lblNoticeTitle = new System.Windows.Forms.Label();
            lblNoticeText = new System.Windows.Forms.Label();
            btnLogin = new OopsGrocerySystem.util.RoundedButton();
            lblHelp = new System.Windows.Forms.Label();

            pnlBrand.SuspendLayout();
            pnlForm.SuspendLayout();
            boxUsername.SuspendLayout();
            boxPassword.SuspendLayout();
            pnlNotice.SuspendLayout();
            SuspendLayout();

            // pnlBrand (left green panel)
            pnlBrand.BackColor = System.Drawing.Color.FromArgb(26, 82, 48);
            pnlBrand.Controls.Add(icoBasket);
            pnlBrand.Controls.Add(lblBrand);
            pnlBrand.Controls.Add(pnlAccent);
            pnlBrand.Controls.Add(lblTagline);
            pnlBrand.Controls.Add(lblFooter);
            pnlBrand.Dock = System.Windows.Forms.DockStyle.Left;
            pnlBrand.Name = "pnlBrand";
            pnlBrand.Size = new System.Drawing.Size(390, 516);
            pnlBrand.TabIndex = 0;

            // icoBasket
            icoBasket.ForeColor = System.Drawing.Color.FromArgb(255, 202, 40);
            icoBasket.Kind = OopsGrocerySystem.util.IconKind.Basket;
            icoBasket.Location = new System.Drawing.Point(35, 42);
            icoBasket.Name = "icoBasket";
            icoBasket.Size = new System.Drawing.Size(39, 39);
            icoBasket.Stroke = 1.95F;

            // lblBrand
            lblBrand.AutoSize = true;
            lblBrand.BackColor = System.Drawing.Color.Transparent;
            lblBrand.Font = new System.Drawing.Font("Lora", 25.5F, System.Drawing.FontStyle.Bold);
            lblBrand.ForeColor = System.Drawing.Color.FromArgb(243, 232, 204);
            lblBrand.Location = new System.Drawing.Point(28, 105);
            lblBrand.Name = "lblBrand";
            lblBrand.Text = "OOPs OOPs\r\nOOPs Grocery";

            // pnlAccent (yellow divider)
            pnlAccent.BackColor = System.Drawing.Color.FromArgb(255, 202, 40);
            pnlAccent.Location = new System.Drawing.Point(38, 231);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new System.Drawing.Size(54, 5);

            // lblTagline
            lblTagline.AutoSize = true;
            lblTagline.BackColor = System.Drawing.Color.Transparent;
            lblTagline.Font = new System.Drawing.Font("Inter", 13.5F);
            lblTagline.ForeColor = System.Drawing.Color.FromArgb(243, 232, 204);
            lblTagline.Location = new System.Drawing.Point(34, 255);
            lblTagline.Name = "lblTagline";
            lblTagline.Text = "Good groceries.\r\nBetter days.";

            // lblFooter
            lblFooter.AutoSize = true;
            lblFooter.BackColor = System.Drawing.Color.Transparent;
            lblFooter.Font = new System.Drawing.Font("Inter", 11.25F);
            lblFooter.ForeColor = System.Drawing.Color.FromArgb(243, 232, 204);
            lblFooter.Location = new System.Drawing.Point(35, 443);
            lblFooter.Name = "lblFooter";
            lblFooter.Text = "Your neighborhood store,\r\nall in one dependable workspace.";

            // pnlForm (right white panel)
            pnlForm.BackColor = System.Drawing.Color.White;
            pnlForm.Controls.Add(lblWelcome);
            pnlForm.Controls.Add(lblSubtitle);
            pnlForm.Controls.Add(lblUsername);
            pnlForm.Controls.Add(boxUsername);
            pnlForm.Controls.Add(lblPassword);
            pnlForm.Controls.Add(boxPassword);
            pnlForm.Controls.Add(pnlNotice);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Controls.Add(lblHelp);
            pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlForm.Name = "pnlForm";
            pnlForm.TabIndex = 1;

            // lblWelcome
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = System.Drawing.Color.Transparent;
            lblWelcome.Font = new System.Drawing.Font("Lora", 19.5F, System.Drawing.FontStyle.Bold);
            lblWelcome.ForeColor = System.Drawing.Color.FromArgb(26, 82, 48);
            lblWelcome.Location = new System.Drawing.Point(35, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Text = "Welcome back";

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            lblSubtitle.Font = new System.Drawing.Font("Inter", 11.25F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 108, 102);
            lblSubtitle.Location = new System.Drawing.Point(39, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Sign in with your store account to begin your shift.";

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.BackColor = System.Drawing.Color.Transparent;
            lblUsername.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(30, 38, 33);
            lblUsername.Location = new System.Drawing.Point(39, 138);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username";

            // boxUsername (green border, as in the mockup)
            boxUsername.BackColor = System.Drawing.Color.White;
            boxUsername.BorderColor = System.Drawing.Color.FromArgb(221, 224, 220);
            boxUsername.BorderWidth = 1.5F;
            boxUsername.Controls.Add(txtUsername);
            boxUsername.FillColor = System.Drawing.Color.White;
            boxUsername.Location = new System.Drawing.Point(42, 162);
            boxUsername.Name = "boxUsername";
            boxUsername.Radius = 9;
            boxUsername.Size = new System.Drawing.Size(450, 44);
            boxUsername.TabIndex = 0;

            // txtUsername
            txtUsername.BackColor = System.Drawing.Color.White;
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUsername.Font = new System.Drawing.Font("Inter", 12.75F);
            txtUsername.ForeColor = System.Drawing.Color.FromArgb(30, 38, 33);
            txtUsername.Location = new System.Drawing.Point(15, 10);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(420, 24);
            txtUsername.TabIndex = 0;

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.BackColor = System.Drawing.Color.Transparent;
            lblPassword.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(30, 38, 33);
            lblPassword.Location = new System.Drawing.Point(39, 228);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Password";

            // boxPassword
            boxPassword.BackColor = System.Drawing.Color.White;
            boxPassword.BorderColor = System.Drawing.Color.FromArgb(221, 224, 220);
            boxPassword.BorderWidth = 1.5F;
            boxPassword.Controls.Add(txtPassword);
            boxPassword.Controls.Add(icoEye);
            boxPassword.FillColor = System.Drawing.Color.White;
            boxPassword.Location = new System.Drawing.Point(42, 252);
            boxPassword.Name = "boxPassword";
            boxPassword.Radius = 9;
            boxPassword.Size = new System.Drawing.Size(450, 44);
            boxPassword.TabIndex = 1;

            // txtPassword
            txtPassword.BackColor = System.Drawing.Color.White;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Inter", 12.75F);
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(30, 38, 33);
            txtPassword.Location = new System.Drawing.Point(15, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(378, 24);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;

            // icoEye
            icoEye.ForeColor = System.Drawing.Color.FromArgb(100, 108, 102);
            icoEye.Kind = OopsGrocerySystem.util.IconKind.Eye;
            icoEye.Location = new System.Drawing.Point(410, 9);
            icoEye.Name = "icoEye";
            icoEye.Size = new System.Drawing.Size(26, 26);
            icoEye.Stroke = 2.25F;

            // pnlNotice (role-based workspace note)
            pnlNotice.AccentColor = System.Drawing.Color.FromArgb(26, 82, 48);
            pnlNotice.AccentWidth = 5;
            pnlNotice.BackColor = System.Drawing.Color.White;
            pnlNotice.BorderWidth = 0F;
            pnlNotice.Controls.Add(icoNotice);
            pnlNotice.Controls.Add(lblNoticeTitle);
            pnlNotice.Controls.Add(lblNoticeText);
            pnlNotice.FillColor = System.Drawing.Color.FromArgb(243, 232, 204);
            pnlNotice.Location = new System.Drawing.Point(42, 314);
            pnlNotice.Name = "pnlNotice";
            pnlNotice.Radius = 5;
            pnlNotice.Size = new System.Drawing.Size(450, 63);

            // icoNotice
            icoNotice.ForeColor = System.Drawing.Color.FromArgb(26, 82, 48);
            icoNotice.Kind = OopsGrocerySystem.util.IconKind.Info;
            icoNotice.Location = new System.Drawing.Point(17, 12);
            icoNotice.Name = "icoNotice";
            icoNotice.Size = new System.Drawing.Size(20, 20);
            icoNotice.Stroke = 2.55F;

            // lblNoticeTitle
            lblNoticeTitle.AutoSize = true;
            lblNoticeTitle.BackColor = System.Drawing.Color.Transparent;
            lblNoticeTitle.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold);
            lblNoticeTitle.ForeColor = System.Drawing.Color.FromArgb(26, 82, 48);
            lblNoticeTitle.Location = new System.Drawing.Point(45, 9);
            lblNoticeTitle.Name = "lblNoticeTitle";
            lblNoticeTitle.Text = "Role-based workspace";

            // lblNoticeText
            lblNoticeText.AutoEllipsis = true;
            lblNoticeText.BackColor = System.Drawing.Color.Transparent;
            lblNoticeText.Font = new System.Drawing.Font("Inter", 9.75F);
            lblNoticeText.ForeColor = System.Drawing.Color.FromArgb(50, 58, 52);
            lblNoticeText.Location = new System.Drawing.Point(45, 32);
            lblNoticeText.Name = "lblNoticeText";
            lblNoticeText.Size = new System.Drawing.Size(400, 23);
            lblNoticeText.Text = "Your account role determines the tools you can access.";

            // btnLogin
            btnLogin.BackColor = System.Drawing.Color.White;
            btnLogin.Font = new System.Drawing.Font("Inter", 12.75F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.FromArgb(26, 82, 48);
            btnLogin.Icon = OopsGrocerySystem.util.IconKind.Login;
            btnLogin.Location = new System.Drawing.Point(42, 398);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalColor = System.Drawing.Color.FromArgb(255, 202, 40);
            btnLogin.Radius = 8;
            btnLogin.ShowIcon = true;
            btnLogin.Size = new System.Drawing.Size(450, 44);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;

            // lblHelp
            lblHelp.AutoSize = false;
            lblHelp.BackColor = System.Drawing.Color.Transparent;
            lblHelp.Font = new System.Drawing.Font("Inter", 10.5F);
            lblHelp.ForeColor = System.Drawing.Color.FromArgb(100, 108, 102);
            lblHelp.Location = new System.Drawing.Point(42, 459);
            lblHelp.Name = "lblHelp";
            lblHelp.Size = new System.Drawing.Size(450, 24);
            lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblHelp.Text = "Need access? Contact your store administrator.";

            // LoginForm
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(924, 516);
            Controls.Add(pnlForm);
            Controls.Add(pnlBrand);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "OOPs OOPs OOPs Grocery - Login";

            pnlBrand.ResumeLayout(false);
            pnlBrand.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            boxUsername.ResumeLayout(false);
            boxUsername.PerformLayout();
            boxPassword.ResumeLayout(false);
            boxPassword.PerformLayout();
            pnlNotice.ResumeLayout(false);
            pnlNotice.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBrand;
        private OopsGrocerySystem.util.IconBox icoBasket;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private OopsGrocerySystem.util.RoundedPanel boxUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private OopsGrocerySystem.util.RoundedPanel boxPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private OopsGrocerySystem.util.IconBox icoEye;
        private OopsGrocerySystem.util.RoundedPanel pnlNotice;
        private OopsGrocerySystem.util.IconBox icoNotice;
        private System.Windows.Forms.Label lblNoticeTitle;
        private System.Windows.Forms.Label lblNoticeText;
        private OopsGrocerySystem.util.RoundedButton btnLogin;
        private System.Windows.Forms.Label lblHelp;
    }
}