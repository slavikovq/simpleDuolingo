using System.ComponentModel;

namespace simpleDuolingo.Views;

partial class UserView
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
        columnHeader3 = new System.Windows.Forms.ColumnHeader();
        columnHeader4 = new System.Windows.Forms.ColumnHeader();
        label1 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        nameInput = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        button3 = new System.Windows.Forms.Button();
        errorText = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.BackColor = System.Drawing.Color.MistyRose;
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
        listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
        listView1.Location = new System.Drawing.Point(304, 24);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(472, 400);
        listView1.TabIndex = 3;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Text = "Id";
        columnHeader1.Width = 72;
        // 
        // columnHeader2
        // 
        columnHeader2.Name = "columnHeader2";
        columnHeader2.Text = "Username";
        columnHeader2.Width = 121;
        // 
        // columnHeader3
        // 
        columnHeader3.Name = "columnHeader3";
        columnHeader3.Text = "Date Created";
        columnHeader3.Width = 137;
        // 
        // columnHeader4
        // 
        columnHeader4.Name = "columnHeader4";
        columnHeader4.Text = "Date Modified";
        columnHeader4.Width = 135;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        label1.ForeColor = System.Drawing.Color.Black;
        label1.Location = new System.Drawing.Point(59, 133);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(83, 23);
        label1.TabIndex = 6;
        label1.Text = "Username";
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.MistyRose;
        button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        button2.Location = new System.Drawing.Point(148, 158);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(150, 28);
        button2.TabIndex = 7;
        button2.Text = "Create";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // nameInput
        // 
        nameInput.BackColor = System.Drawing.Color.MistyRose;
        nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        nameInput.Location = new System.Drawing.Point(148, 130);
        nameInput.Name = "nameInput";
        nameInput.Size = new System.Drawing.Size(150, 23);
        nameInput.TabIndex = 8;
        nameInput.KeyPress += nameInput_KeyPress;
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.Color.MistyRose;
        textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        textBox2.Location = new System.Drawing.Point(148, 234);
        textBox2.Name = "textBox2";
        textBox2.PlaceholderText = "Id";
        textBox2.Size = new System.Drawing.Size(150, 23);
        textBox2.TabIndex = 9;
        textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.MistyRose;
        button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        button1.Location = new System.Drawing.Point(148, 262);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(150, 28);
        button1.TabIndex = 10;
        button1.Text = "Create";
        button1.UseVisualStyleBackColor = false;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        label2.ForeColor = System.Drawing.Color.Black;
        label2.Location = new System.Drawing.Point(77, 233);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(65, 23);
        label2.TabIndex = 11;
        label2.Text = "Delete";
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.MistyRose;
        button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        button3.Location = new System.Drawing.Point(12, 15);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(130, 28);
        button3.TabIndex = 12;
        button3.Text = "Back";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // errorText
        // 
        errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        errorText.ForeColor = System.Drawing.Color.Maroon;
        errorText.Location = new System.Drawing.Point(148, 198);
        errorText.Name = "errorText";
        errorText.Size = new System.Drawing.Size(150, 23);
        errorText.TabIndex = 13;
        // 
        // UserView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        Controls.Add(errorText);
        Controls.Add(button3);
        Controls.Add(label2);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(nameInput);
        Controls.Add(button2);
        Controls.Add(label1);
        Controls.Add(listView1);
        Size = new System.Drawing.Size(799, 450);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label errorText;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox nameInput;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListView listView1;

    #endregion
}