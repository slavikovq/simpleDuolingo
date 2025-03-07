using System.ComponentModel;

namespace simpleDuolingo.Views;

partial class LanguageView
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        listView1 = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        columnHeader2 = new System.Windows.Forms.ColumnHeader();
        columnHeader3 = new System.Windows.Forms.ColumnHeader();
        columnHeader4 = new System.Windows.Forms.ColumnHeader();
        columnHeader5 = new System.Windows.Forms.ColumnHeader();
        button3 = new System.Windows.Forms.Button();
        errorText = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Monocraft", 10F);
        label1.Location = new System.Drawing.Point(64, 126);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(53, 23);
        label1.TabIndex = 0;
        label1.Text = "Name";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Monocraft", 10F);
        label2.Location = new System.Drawing.Point(53, 228);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(64, 23);
        label2.TabIndex = 1;
        label2.Text = "Delete";
        // 
        // listView1
        // 
        listView1.BackColor = System.Drawing.Color.MistyRose;
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
        listView1.Font = new System.Drawing.Font("Monocraft", 8F);
        listView1.Location = new System.Drawing.Point(279, 22);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(497, 400);
        listView1.TabIndex = 6;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Text = "Id";
        // 
        // columnHeader2
        // 
        columnHeader2.Name = "columnHeader2";
        columnHeader2.Text = "Name";
        columnHeader2.Width = 91;
        // 
        // columnHeader3
        // 
        columnHeader3.Name = "columnHeader3";
        columnHeader3.Text = "Difficulty";
        columnHeader3.Width = 103;
        // 
        // columnHeader4
        // 
        columnHeader4.Name = "columnHeader4";
        columnHeader4.Text = "Date Created";
        columnHeader4.Width = 113;
        // 
        // columnHeader5
        // 
        columnHeader5.Name = "columnHeader5";
        columnHeader5.Text = "Date Modified";
        columnHeader5.Width = 126;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.MistyRose;
        button3.Font = new System.Drawing.Font("Monocraft", 10F);
        button3.Location = new System.Drawing.Point(12, 12);
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
        errorText.Location = new System.Drawing.Point(127, 394);
        errorText.Name = "errorText";
        errorText.Size = new System.Drawing.Size(150, 23);
        errorText.TabIndex = 8;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.MistyRose;
        button1.Font = new System.Drawing.Font("Monocraft", 10F);
        button1.Location = new System.Drawing.Point(123, 155);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(130, 28);
        button1.TabIndex = 10;
        button1.Text = "Back";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.MistyRose;
        button2.Font = new System.Drawing.Font("Monocraft", 10F);
        button2.Location = new System.Drawing.Point(123, 257);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(130, 28);
        button2.TabIndex = 11;
        button2.Text = "Back";
        button2.UseVisualStyleBackColor = false;
        // 
        // textBox1
        // 
        textBox1.BackColor = System.Drawing.Color.MistyRose;
        textBox1.Font = new System.Drawing.Font("Monocraft", 10F);
        textBox1.Location = new System.Drawing.Point(123, 127);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(130, 22);
        textBox1.TabIndex = 12;
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.Color.MistyRose;
        textBox2.Font = new System.Drawing.Font("Monocraft", 10F);
        textBox2.Location = new System.Drawing.Point(123, 229);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(130, 22);
        textBox2.TabIndex = 13;
        // 
        // LanguageView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(errorText);
        Controls.Add(button3);
        Controls.Add(listView1);
        Controls.Add(label2);
        Controls.Add(label1);
        Size = new System.Drawing.Size(799, 450);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Label errorText;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.TextBox Delete;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}