using System.ComponentModel;

namespace simpleDuolingo.Views;

partial class LoginView
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        LogInButton = new System.Windows.Forms.Button();
        PasswordLogin = new System.Windows.Forms.TextBox();
        errorText = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // LogInButton
        // 
        LogInButton.BackColor = System.Drawing.Color.MistyRose;
        LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        LogInButton.Location = new System.Drawing.Point(312, 221);
        LogInButton.Name = "LogInButton";
        LogInButton.Size = new System.Drawing.Size(150, 50);
        LogInButton.TabIndex = 0;
        LogInButton.Text = "Log In";
        LogInButton.UseVisualStyleBackColor = false;
        LogInButton.Click += LogInButton_Click;
        // 
        // PasswordLogin
        // 
        PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        PasswordLogin.Location = new System.Drawing.Point(312, 193);
        PasswordLogin.Name = "PasswordLogin";
        PasswordLogin.PlaceholderText = "Password";
        PasswordLogin.Size = new System.Drawing.Size(150, 23);
        PasswordLogin.TabIndex = 1;
        PasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        PasswordLogin.Enter += PasswordLogin_Enter_1;
        PasswordLogin.KeyPress += PasswordLogin_KeyPress_1;
        PasswordLogin.Leave += PasswordLogin_Leave_1;
        // 
        // errorText
        // 
        errorText.BackColor = System.Drawing.Color.Transparent;
        errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        errorText.ForeColor = System.Drawing.Color.Maroon;
        errorText.Location = new System.Drawing.Point(258, 274);
        errorText.Name = "errorText";
        errorText.Size = new System.Drawing.Size(249, 23);
        errorText.TabIndex = 2;
        errorText.Text = "\r\n";
        // 
        // LoginView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        Controls.Add(errorText);
        Controls.Add(PasswordLogin);
        Controls.Add(LogInButton);
        Size = new System.Drawing.Size(799, 450);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label errorText;

    private System.Windows.Forms.TextBox PasswordLogin;

    private System.Windows.Forms.Button LogInButton;

    #endregion
}