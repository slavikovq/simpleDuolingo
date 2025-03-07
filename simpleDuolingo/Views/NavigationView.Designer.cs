using System.ComponentModel;

namespace simpleDuolingo.Views;

partial class NavigationView
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationView));
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.MistyRose;
        button1.Font = new System.Drawing.Font("Monocraft", 10F);
        button1.Location = new System.Drawing.Point(312, 154);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(150, 50);
        button1.TabIndex = 1;
        button1.Text = "User";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.MistyRose;
        button2.Font = new System.Drawing.Font("Monocraft", 10F);
        button2.Location = new System.Drawing.Point(312, 221);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(150, 50);
        button2.TabIndex = 2;
        button2.Text = "Language";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.MistyRose;
        button3.Font = new System.Drawing.Font("Monocraft", 10F);
        button3.Location = new System.Drawing.Point(312, 286);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(150, 50);
        button3.TabIndex = 3;
        button3.Text = "Registration";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = System.Drawing.Color.Transparent;
        pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(345, 87);
        pictureBox1.Margin = new System.Windows.Forms.Padding(0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(84, 77);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        // 
        // NavigationView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Size = new System.Drawing.Size(799, 450);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    #endregion
}