
namespace Phone_Book
{
    partial class CallerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallerEditForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddress = new TextBox();
            comboBoxCategory = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            buttonSave = new Button();
            maskedTextBoxNumber = new MaskedTextBox();
            toolTip1 = new ToolTip(components);
            pictureBoxIcon = new PictureBox();
            openFileDialogIcon = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(76, 141);
            label1.Name = "label1";
            label1.Size = new Size(59, 35);
            label1.TabIndex = 0;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(76, 241);
            label2.Name = "label2";
            label2.Size = new Size(94, 35);
            label2.TabIndex = 1;
            label2.Text = "Номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(76, 333);
            label3.Name = "label3";
            label3.Size = new Size(226, 35);
            label3.TabIndex = 2;
            label3.Text = "Електронна пошта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(76, 423);
            label4.Name = "label4";
            label4.Size = new Size(250, 35);
            label4.TabIndex = 3;
            label4.Text = "Адреса проживання";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(76, 519);
            label5.Name = "label5";
            label5.Size = new Size(125, 35);
            label5.TabIndex = 4;
            label5.Text = "Категорія";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 15F);
            textBoxName.Location = new Point(76, 179);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 41);
            textBoxName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 15F);
            textBoxEmail.Location = new Point(76, 371);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 41);
            textBoxEmail.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 15F);
            textBoxAddress.Location = new Point(76, 461);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 41);
            textBoxAddress.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DataSource = categoryBindingSource;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.Font = new Font("Segoe UI", 15F);
            comboBoxCategory.Location = new Point(76, 557);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(250, 43);
            comboBoxCategory.TabIndex = 0;
            comboBoxCategory.ValueMember = "CategoryId";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 15F);
            buttonSave.Location = new Point(76, 639);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(250, 49);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // maskedTextBoxNumber
            // 
            maskedTextBoxNumber.Font = new Font("Segoe UI", 15F);
            maskedTextBoxNumber.Location = new Point(76, 279);
            maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            maskedTextBoxNumber.Size = new Size(250, 41);
            maskedTextBoxNumber.TabIndex = 10;
            maskedTextBoxNumber.MaskInputRejected += maskedTextBoxNumber_MaskInputRejected;
            maskedTextBoxNumber.KeyDown += maskedTextBoxNumber_KeyDown;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(141, 12);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(128, 128);
            pictureBoxIcon.TabIndex = 11;
            pictureBoxIcon.TabStop = false;
            pictureBoxIcon.Click += pictureBoxIcon_Click;
            // 
            // openFileDialogIcon
            // 
            openFileDialogIcon.FileName = "openFileDialog1";
            // 
            // CallerEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 716);
            Controls.Add(pictureBoxIcon);
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
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CallerEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редагування користувача";
            HelpButtonClicked += CallerEditForm_HelpButtonClicked;
            Load += CallerEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxAddress;
        private ComboBox comboBoxCategory;
        private Button buttonSave;
        private BindingSource categoryBindingSource;
        private MaskedTextBox maskedTextBoxNumber;
        private ToolTip toolTip1;
        private PictureBox pictureBoxIcon;
        private OpenFileDialog openFileDialogIcon;
    }
}