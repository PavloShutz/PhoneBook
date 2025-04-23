namespace Phone_Book
{
    partial class AddCallerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCallerForm));
            maskedTextBoxNumber = new MaskedTextBox();
            buttonSave = new Button();
            comboBoxCategory = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            textBoxAddress = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            buttonAddCategory = new Button();
            pictureBoxIcon = new PictureBox();
            openFileDialogIcon = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBoxNumber
            // 
            maskedTextBoxNumber.Font = new Font("Segoe UI", 15F);
            maskedTextBoxNumber.Location = new Point(72, 307);
            maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            maskedTextBoxNumber.Size = new Size(250, 41);
            maskedTextBoxNumber.TabIndex = 21;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.Location = new Point(72, 667);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(250, 49);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DataSource = categoryBindingSource;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.Font = new Font("Segoe UI", 15F);
            comboBoxCategory.Location = new Point(72, 585);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(250, 43);
            comboBoxCategory.TabIndex = 11;
            comboBoxCategory.ValueMember = "CategoryId";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 15F);
            textBoxAddress.Location = new Point(72, 489);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 41);
            textBoxAddress.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 15F);
            textBoxEmail.Location = new Point(72, 399);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 41);
            textBoxEmail.TabIndex = 18;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 15F);
            textBoxName.Location = new Point(72, 207);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 41);
            textBoxName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(72, 547);
            label5.Name = "label5";
            label5.Size = new Size(125, 35);
            label5.TabIndex = 16;
            label5.Text = "Категорія";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(72, 451);
            label4.Name = "label4";
            label4.Size = new Size(250, 35);
            label4.TabIndex = 15;
            label4.Text = "Адреса проживання";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(72, 361);
            label3.Name = "label3";
            label3.Size = new Size(226, 35);
            label3.TabIndex = 14;
            label3.Text = "Електронна пошта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(72, 269);
            label2.Name = "label2";
            label2.Size = new Size(94, 35);
            label2.TabIndex = 13;
            label2.Text = "Номер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(72, 169);
            label1.Name = "label1";
            label1.Size = new Size(59, 35);
            label1.TabIndex = 12;
            label1.Text = "Ім'я";
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonAddCategory.Location = new Point(328, 585);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(52, 43);
            buttonAddCategory.TabIndex = 22;
            buttonAddCategory.Text = "+";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(132, 12);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(128, 128);
            pictureBoxIcon.TabIndex = 23;
            pictureBoxIcon.TabStop = false;
            pictureBoxIcon.Click += pictureBoxIcon_Click;
            // 
            // openFileDialogIcon
            // 
            openFileDialogIcon.FileName = "openFileDialog1";
            // 
            // AddCallerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 730);
            Controls.Add(pictureBoxIcon);
            Controls.Add(buttonAddCategory);
            Controls.Add(maskedTextBoxNumber);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCallerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Створення запису";
            Load += AddCallerForm_Load;
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBoxNumber;
        private Button buttonSave;
        private ComboBox comboBoxCategory;
        private TextBox textBoxAddress;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource categoryBindingSource;
        private ToolTip toolTip1;
        private Button buttonAddCategory;
        private PictureBox pictureBoxIcon;
        private OpenFileDialog openFileDialogIcon;
    }
}