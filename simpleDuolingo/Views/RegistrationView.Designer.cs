using System.ComponentModel;

namespace simpleDuolingo.Views;

partial class RegistrationView
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
        listView1 = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        columnHeader2 = new System.Windows.Forms.ColumnHeader();
        listView2 = new System.Windows.Forms.ListView();
        columnHeader5 = new System.Windows.Forms.ColumnHeader();
        columnHeader6 = new System.Windows.Forms.ColumnHeader();
        listView3 = new System.Windows.Forms.ListView();
        columnHeader10 = new System.Windows.Forms.ColumnHeader();
        columnHeader11 = new System.Windows.Forms.ColumnHeader();
        columnHeader12 = new System.Windows.Forms.ColumnHeader();
        DeleteInput = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        errorText = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.BackColor = System.Drawing.Color.MistyRose;
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
        listView1.Font = new System.Drawing.Font("Monocraft", 9F);
        listView1.Location = new System.Drawing.Point(14, 43);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(250, 300);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Text = "Id";
        columnHeader1.Width = 93;
        // 
        // columnHeader2
        // 
        columnHeader2.Name = "columnHeader2";
        columnHeader2.Text = "Username";
        columnHeader2.Width = 150;
        // 
        // listView2
        // 
        listView2.BackColor = System.Drawing.Color.MistyRose;
        listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader5, columnHeader6 });
        listView2.Font = new System.Drawing.Font("Monocraft", 9F);
        listView2.Location = new System.Drawing.Point(270, 43);
        listView2.Name = "listView2";
        listView2.Size = new System.Drawing.Size(250, 300);
        listView2.TabIndex = 1;
        listView2.UseCompatibleStateImageBehavior = false;
        listView2.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader5
        // 
        columnHeader5.Name = "columnHeader5";
        columnHeader5.Text = "Id";
        columnHeader5.Width = 68;
        // 
        // columnHeader6
        // 
        columnHeader6.Name = "columnHeader6";
        columnHeader6.Text = "Name";
        columnHeader6.Width = 176;
        // 
        // listView3
        // 
        listView3.BackColor = System.Drawing.Color.MistyRose;
        listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12 });
        listView3.Font = new System.Drawing.Font("Monocraft", 9F);
        listView3.Location = new System.Drawing.Point(526, 43);
        listView3.Name = "listView3";
        listView3.Size = new System.Drawing.Size(250, 150);
        listView3.TabIndex = 2;
        listView3.UseCompatibleStateImageBehavior = false;
        listView3.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader10
        // 
        columnHeader10.Name = "columnHeader10";
        columnHeader10.Text = "Id";
        columnHeader10.Width = 50;
        // 
        // columnHeader11
        // 
        columnHeader11.Name = "columnHeader11";
        columnHeader11.Text = "User Id";
        columnHeader11.Width = 89;
        // 
        // columnHeader12
        // 
        columnHeader12.Name = "columnHeader12";
        columnHeader12.Text = "Language Id";
        columnHeader12.Width = 107;
        // 
        // DeleteInput
        // 
        DeleteInput.BackColor = System.Drawing.Color.MistyRose;
        DeleteInput.Font = new System.Drawing.Font("Monocraft", 10F);
        DeleteInput.Location = new System.Drawing.Point(629, 221);
        DeleteInput.Name = "DeleteInput";
        DeleteInput.PlaceholderText = "Id";
        DeleteInput.Size = new System.Drawing.Size(147, 22);
        DeleteInput.TabIndex = 3;
        DeleteInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Transparent;
        label1.Font = new System.Drawing.Font("Monocraft", 10F);
        label1.Location = new System.Drawing.Point(558, 222);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(65, 23);
        label1.TabIndex = 4;
        label1.Text = "Delete";
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.MistyRose;
        button2.Font = new System.Drawing.Font("Monocraft", 10F);
        button2.Location = new System.Drawing.Point(201, 365);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(150, 50);
        button2.TabIndex = 6;
        button2.Text = "Register";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.MistyRose;
        button3.Font = new System.Drawing.Font("Monocraft", 10F);
        button3.Location = new System.Drawing.Point(14, 9);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(130, 28);
        button3.TabIndex = 7;
        button3.Text = "Back";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // errorText
        // 
        errorText.Font = new System.Drawing.Font("Monocraft", 8F);
        errorText.ForeColor = System.Drawing.Color.Maroon;
        errorText.Location = new System.Drawing.Point(14, 392);
        errorText.Name = "errorText";
        errorText.Size = new System.Drawing.Size(150, 23);
        errorText.TabIndex = 9;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.MistyRose;
        button1.Font = new System.Drawing.Font("Monocraft", 10F);
        button1.Location = new System.Drawing.Point(629, 248);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(147, 30);
        button1.TabIndex = 10;
        button1.Text = "Delete Id";
        button1.UseVisualStyleBackColor = false;
        // 
        // RegistrationView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        Controls.Add(button1);
        Controls.Add(errorText);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(label1);
        Controls.Add(DeleteInput);
        Controls.Add(listView3);
        Controls.Add(listView2);
        Controls.Add(listView1);
        Size = new System.Drawing.Size(799, 450);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox DeleteInput;

    private System.Windows.Forms.Label errorText;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ColumnHeader columnHeader10;
    private System.Windows.Forms.ColumnHeader columnHeader11;
    private System.Windows.Forms.ColumnHeader columnHeader12;

    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;

    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ListView listView2;
    private System.Windows.Forms.ListView listView3;
    private System.Windows.Forms.Button DeleteIdButton;

    private System.Windows.Forms.ListView listView1;

    #endregion
}