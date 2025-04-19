using Google.Apis.PeopleService.v1.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.VisualBasic;

namespace Phone_Book
{
    public partial class AddCallerForm : Form
    {
        private MainForm? mainForm = null;

        public AddCallerForm(MainForm form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            updateCategoryComboBoxList(-1);
            this.comboBoxCategory.SelectedText = "-";

            this.maskedTextBoxNumber.Text = "(+00)-000-000-0000";

            base.OnLoad(e);
        }

        private void AddCallerForm_Load(object sender, EventArgs e)
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

            else if (this.comboBoxCategory.SelectedIndex == -1)
            {
                this.toolTip1.ToolTipTitle = "Відхилено - Не вказано категорію";
                this.toolTip1.Show("Ви не можете додавати користувача, не вказавши категорію.", this.comboBoxCategory, 0, -20, 5000);
                return;
            }

            addNewRecordToDb();

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

        /// <summary>
        /// Creates and saves new caller to db.
        /// </summary>
        private void addNewRecordToDb()
        {
            var caller = new Caller();

            caller.Name = this.textBoxName.Text.ToString();
            caller.Email = this.textBoxEmail.Text.ToString();
            caller.Address = this.textBoxAddress.Text.ToString();
            caller.Number = this.maskedTextBoxNumber.Text.ToString();
            caller.CategoryId = (int)this.comboBoxCategory.SelectedValue;
            caller.Category = (Category)this.comboBoxCategory.SelectedItem;

            mainForm.dbContext.Add(caller);
            mainForm.dbContext.SaveChanges();
        }

        private void updateCategoryComboBoxList(int selectedIndex)
        {
            var categoriesBindingList = new SortableBindingList<Category>(mainForm.dbContext.Categories.Where(c => c.CategoryId != 1).ToList());
            var source = new BindingSource(categoriesBindingList, null);
            this.categoryBindingSource.DataSource = source;
            this.comboBoxCategory.SelectedIndex = selectedIndex;
        }

        #endregion

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Введіть нову категорію", "Нова категорія");
            if (string.IsNullOrEmpty(input.Trim()))
            {
                MessageBox.Show("Дане поле не можна залишати пустим!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool exists = mainForm.dbContext.Categories.Where(c => c.Name.ToLower() == input.Trim().ToLower()).Any();

            if (!exists)
            {
                mainForm.dbContext.Categories.Add(new Category { Name = input });
                mainForm.dbContext.SaveChanges();
                updateCategoryComboBoxList(this.comboBoxCategory.Items.Count);
            }
        }
    }
}
