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
        userList = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        columnHeader2 = new System.Windows.Forms.ColumnHeader();
        languageList = new System.Windows.Forms.ListView();
        columnHeader5 = new System.Windows.Forms.ColumnHeader();
        columnHeader6 = new System.Windows.Forms.ColumnHeader();
        registrationList = new System.Windows.Forms.ListView();
        columnHeader10 = new System.Windows.Forms.ColumnHeader();
        columnHeader11 = new System.Windows.Forms.ColumnHeader();
        columnHeader12 = new System.Windows.Forms.ColumnHeader();
        idInput = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        registerButton = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        errorText = new System.Windows.Forms.Label();
        deleteButton = new System.Windows.Forms.Button();
        infoLabel1 = new System.Windows.Forms.Label();
        infoLabel2 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // userList
        // 
        userList.BackColor = System.Drawing.Color.MistyRose;
        userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2 });
        userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
        userList.FullRowSelect = true;
        userList.Location = new System.Drawing.Point(14, 43);
        userList.Name = "userList";
        userList.Size = new System.Drawing.Size(250, 300);
        userList.TabIndex = 0;
        userList.UseCompatibleStateImageBehavior = false;
        userList.View = System.Windows.Forms.View.Details;
        userList.SelectedIndexChanged += userList_SelectedIndexChanged;
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
        // languageList
        // 
        languageList.BackColor = System.Drawing.Color.MistyRose;
        languageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader5, columnHeader6 });
        languageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
        languageList.FullRowSelect = true;
        languageList.Location = new System.Drawing.Point(270, 43);
        languageList.Name = "languageList";
        languageList.Size = new System.Drawing.Size(250, 300);
        languageList.TabIndex = 1;
        languageList.UseCompatibleStateImageBehavior = false;
        languageList.View = System.Windows.Forms.View.Details;
        languageList.SelectedIndexChanged += languageList_SelectedIndexChanged;
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
        // registrationList
        // 
        registrationList.BackColor = System.Drawing.Color.MistyRose;
        registrationList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12 });
        registrationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
        registrationList.Location = new System.Drawing.Point(526, 43);
        registrationList.Name = "registrationList";
        registrationList.Size = new System.Drawing.Size(250, 150);
        registrationList.TabIndex = 2;
        registrationList.UseCompatibleStateImageBehavior = false;
        registrationList.View = System.Windows.Forms.View.Details;
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
        // idInput
        // 
        idInput.BackColor = System.Drawing.Color.MistyRose;
        idInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        idInput.Location = new System.Drawing.Point(585, 256);
        idInput.Name = "idInput";
        idInput.PlaceholderText = "Id";
        idInput.Size = new System.Drawing.Size(147, 23);
        idInput.TabIndex = 3;
        idInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        idInput.KeyPress += idInput_KeyPress;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Transparent;
        label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        label1.Location = new System.Drawing.Point(585, 227);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(147, 26);
        label1.TabIndex = 4;
        label1.Text = "Delete registration";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // registerButton
        // 
        registerButton.BackColor = System.Drawing.Color.MistyRose;
        registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        registerButton.Location = new System.Drawing.Point(201, 373);
        registerButton.Name = "registerButton";
        registerButton.Size = new System.Drawing.Size(150, 50);
        registerButton.TabIndex = 6;
        registerButton.Text = "Register";
        registerButton.UseVisualStyleBackColor = false;
        registerButton.Click += registerButton_Click;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.MistyRose;
        button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
        errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
        errorText.ForeColor = System.Drawing.Color.Maroon;
        errorText.Location = new System.Drawing.Point(14, 392);
        errorText.Name = "errorText";
        errorText.Size = new System.Drawing.Size(150, 23);
        errorText.TabIndex = 9;
        // 
        // deleteButton
        // 
        deleteButton.BackColor = System.Drawing.Color.MistyRose;
        deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        deleteButton.Location = new System.Drawing.Point(585, 285);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new System.Drawing.Size(147, 30);
        deleteButton.TabIndex = 10;
        deleteButton.Text = "Delete Id";
        deleteButton.UseVisualStyleBackColor = false;
        deleteButton.Click += deleteButton_Click;
        // 
        // infoLabel1
        // 
        infoLabel1.BackColor = System.Drawing.Color.Transparent;
        infoLabel1.Location = new System.Drawing.Point(14, 346);
        infoLabel1.Name = "infoLabel1";
        infoLabel1.Size = new System.Drawing.Size(250, 23);
        infoLabel1.TabIndex = 11;
        // 
        // infoLabel2
        // 
        infoLabel2.BackColor = System.Drawing.Color.Transparent;
        infoLabel2.Location = new System.Drawing.Point(270, 346);
        infoLabel2.Name = "infoLabel2";
        infoLabel2.Size = new System.Drawing.Size(250, 23);
        infoLabel2.TabIndex = 12;
        // 
        // RegistrationView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        Controls.Add(label1);
        Controls.Add(infoLabel2);
        Controls.Add(infoLabel1);
        Controls.Add(deleteButton);
        Controls.Add(errorText);
        Controls.Add(button3);
        Controls.Add(registerButton);
        Controls.Add(idInput);
        Controls.Add(registrationList);
        Controls.Add(languageList);
        Controls.Add(userList);
        Size = new System.Drawing.Size(799, 450);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label infoLabel1;
    private System.Windows.Forms.Label infoLabel2;

    private System.Windows.Forms.TextBox idInput;

    private System.Windows.Forms.Label errorText;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.ColumnHeader columnHeader10;
    private System.Windows.Forms.ColumnHeader columnHeader11;
    private System.Windows.Forms.ColumnHeader columnHeader12;

    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;

    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;

    private System.Windows.Forms.Button registerButton;

    private System.Windows.Forms.Button deleteButton;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ListView languageList;
    private System.Windows.Forms.ListView registrationList;
    private System.Windows.Forms.Button DeleteIdButton;

    private System.Windows.Forms.ListView userList;

    #endregion
}