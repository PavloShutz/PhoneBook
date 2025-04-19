using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Phone_Book
{
    public partial class CallerEditForm : Form
    {
        private MainForm? mainForm = null;
        private readonly int _callerId;

        public CallerEditForm(MainForm form, int callerId)
        {
            this.mainForm = form;
            _callerId = callerId;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var categoriesBindingList = new SortableBindingList<Category>(mainForm.dbContext.Categories.Where(c => c.CategoryId != 1).ToList());
            var source = new BindingSource(categoriesBindingList, null);
            this.categoryBindingSource.DataSource = source;

            var caller = mainForm.dbContext.Callers.Single(c => c.CallerId == _callerId);

            this.textBoxName.Text = caller.Name.ToString();
            this.maskedTextBoxNumber.Text = caller.Number.ToString();
            this.textBoxEmail.Text = caller.Email.ToString();
            this.textBoxAddress.Text = caller.Address.ToString();
            this.comboBoxCategory.SelectedItem = mainForm.dbContext.Categories.Single(c => c.CategoryId == caller.CategoryId);

            base.OnLoad(e);
        }

        private void CallerEditForm_Load(object sender, EventArgs e)
        {
            this.maskedTextBoxNumber.Mask = "(+00)-000-000-0000";

            this.maskedTextBoxNumber.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBoxNumber_MaskInputRejected);
            this.maskedTextBoxNumber.KeyDown += new KeyEventHandler(maskedTextBoxNumber_KeyDown);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.maskedTextBoxNumber.MaskCompleted)
            {
                this.toolTip1.ToolTipTitle = "Відхилено - Недостатньо данних";
                this.toolTip1.Show("Заповніть дане поле до кінця.", this.maskedTextBoxNumber, 0, -20, 5000);
                return;
            }

            else if (string.IsNullOrEmpty(this.textBoxName.Text.ToString().Trim()))
            {
                showWarningAboutEmptyField(this.textBoxName);
                return;
            }

            else if (string.IsNullOrEmpty(this.textBoxEmail.Text.ToString().Trim()))
            {
                showWarningAboutEmptyField(this.textBoxEmail);
                return;
            }

            else if (string.IsNullOrEmpty(this.textBoxAddress.Text.ToString().Trim()))
            {
                showWarningAboutEmptyField(this.textBoxAddress);
                return;
            }

            var caller = mainForm.dbContext.Callers.Single(c => c.CallerId == _callerId);

            caller.Name = this.textBoxName.Text.ToString();
            caller.Email = this.textBoxEmail.Text.ToString();
            caller.Address = this.textBoxAddress.Text.ToString();
            caller.Number = this.maskedTextBoxNumber.Text.ToString();
            caller.CategoryId = (int)this.comboBoxCategory.SelectedValue;
            caller.Category = (Category)this.comboBoxCategory.SelectedItem;
            
            mainForm.dbContext.SaveChanges();

            mainForm.UpdateCallersList();

            this.Close();
        }

        private void maskedTextBoxNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (this.maskedTextBoxNumber.MaskFull)
            {
                this.toolTip1.ToolTipTitle = "Відхилено - Занадто багато даних";
                this.toolTip1.Show("Ви більше не можете уводити нові дані. Видаліть символи, щоб ввести дані.", this.maskedTextBoxNumber, 0, -20, 5000);
            }
            else if (e.Position == this.maskedTextBoxNumber.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Відхилено - Кінець поля";
                this.toolTip1.Show("You cannot add extra characters to the end of this date field.", this.maskedTextBoxNumber, 0, -20, 5000);
            }
            else
            {
                this.toolTip1.ToolTipTitle = "Відхилено";
                this.toolTip1.Show("You can only add numeric characters (0-9) into this date field.", this.maskedTextBoxNumber, 0, -20, 5000);
            }
        }

        private void maskedTextBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            this.toolTip1.Hide(this.maskedTextBoxNumber);
        }

        #region HelperMethods

        /// <summary>
        /// Displays warning about field being empty of space filled only.
        /// </summary>
        /// <param name="textBox">Text box nearby which the warning is showed.</param>
        private void showWarningAboutEmptyField(TextBox textBox)
        {
            this.toolTip1.ToolTipTitle = "Відхилено - Недостатньо данних";
            this.toolTip1.Show("Пустим данне поле не можна залишати.", textBox, 0, -20, 5000);
        }

        #endregion
    }
}
