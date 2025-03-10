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
        languageList = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        columnHeader2 = new System.Windows.Forms.ColumnHeader();
        columnHeader3 = new System.Windows.Forms.ColumnHeader();
        columnHeader4 = new System.Windows.Forms.ColumnHeader();
        columnHeader5 = new System.Windows.Forms.ColumnHeader();
        button3 = new System.Windows.Forms.Button();
        errorText = new System.Windows.Forms.Label();
        createInput = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        nameInput = new System.Windows.Forms.TextBox();
        idInput = new System.Windows.Forms.TextBox();
        difficultyInput = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        label1.Location = new System.Drawing.Point(45, 130);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(72, 23);
        label1.TabIndex = 0;
        label1.Text = "Language";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        label2.Location = new System.Drawing.Point(3, 245);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(114, 23);
        label2.TabIndex = 1;
        label2.Text = "Delete language";
        // 
        // languageList
        // 
        languageList.BackColor = System.Drawing.Color.MistyRose;
        languageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
        languageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        languageList.Location = new System.Drawing.Point(279, 22);
        languageList.Name = "languageList";
        languageList.Size = new System.Drawing.Size(497, 400);
        languageList.TabIndex = 6;
        languageList.UseCompatibleStateImageBehavior = false;
        languageList.View = System.Windows.Forms.View.Details;
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
        button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
        errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        errorText.ForeColor = System.Drawing.Color.Maroon;
        errorText.Location = new System.Drawing.Point(114, 204);
        errorText.Name = "errorText";
        errorText.Size = new System.Drawing.Size(150, 23);
        errorText.TabIndex = 8;
        // 
        // createInput
        // 
        createInput.BackColor = System.Drawing.Color.MistyRose;
        createInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        createInput.Location = new System.Drawing.Point(123, 155);
        createInput.Name = "createInput";
        createInput.Size = new System.Drawing.Size(130, 28);
        createInput.TabIndex = 10;
        createInput.Text = "Create";
        createInput.UseVisualStyleBackColor = false;
        createInput.Click += createInput_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.MistyRose;
        button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        button2.Location = new System.Drawing.Point(123, 270);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(130, 28);
        button2.TabIndex = 11;
        button2.Text = "Delete";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // nameInput
        // 
        nameInput.BackColor = System.Drawing.Color.MistyRose;
        nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        nameInput.Location = new System.Drawing.Point(123, 127);
        nameInput.Name = "nameInput";
        nameInput.Size = new System.Drawing.Size(130, 23);
        nameInput.TabIndex = 12;
        nameInput.KeyPress += nameInput_KeyPress;
        // 
        // idInput
        // 
        idInput.BackColor = System.Drawing.Color.MistyRose;
        idInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        idInput.Location = new System.Drawing.Point(123, 242);
        idInput.Name = "idInput";
        idInput.PlaceholderText = "Id";
        idInput.Size = new System.Drawing.Size(130, 23);
        idInput.TabIndex = 13;
        idInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        idInput.KeyPress += idInput_KeyPress;
        // 
        // difficultyInput
        // 
        difficultyInput.BackColor = System.Drawing.Color.MistyRose;
        difficultyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        difficultyInput.Location = new System.Drawing.Point(123, 98);
        difficultyInput.Name = "difficultyInput";
        difficultyInput.PlaceholderText = "Difficulty level";
        difficultyInput.Size = new System.Drawing.Size(130, 23);
        difficultyInput.TabIndex = 14;
        difficultyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        label3.Location = new System.Drawing.Point(53, 98);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(64, 23);
        label3.TabIndex = 15;
        label3.Text = "Difficulty";
        // 
        // LanguageView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        Controls.Add(label3);
        Controls.Add(difficultyInput);
        Controls.Add(idInput);
        Controls.Add(nameInput);
        Controls.Add(button2);
        Controls.Add(createInput);
        Controls.Add(errorText);
        Controls.Add(button3);
        Controls.Add(languageList);
        Controls.Add(label2);
        Controls.Add(label1);
        Size = new System.Drawing.Size(799, 450);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox difficultyInput;

    private System.Windows.Forms.TextBox idInput;

    private System.Windows.Forms.Label errorText;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;

    private System.Windows.Forms.ListView languageList;

    private System.Windows.Forms.TextBox Delete;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox nameInput;
    private System.Windows.Forms.Button createInput;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}