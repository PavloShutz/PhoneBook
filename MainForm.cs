using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel;
using System.Diagnostics;

namespace Phone_Book
{
    public partial class MainForm : Form
    {
        public CallersContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        [Conditional("DEBUG")]
        private void SetDebugMode(ref bool isDebug)
        {
            isDebug = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.dbContext = new CallersContext();

            bool isDebug = false;
            SetDebugMode(ref isDebug);

            if (isDebug)
            {
                this.dbContext.Database.EnsureDeleted();
            }
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Categories.Load();
            this.dbContext.Callers.Load();

            this.categoryBindingSource.DataSource = this.dbContext.Categories.Local.ToBindingList();
            this.callersBindingSource.DataSource = this.dbContext.Callers.Local.ToBindingList();

            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.comboBoxCategory.SelectedItem = this.dbContext.Categories.Single(c => c.CategoryId == 1);

            AddColumns();
        }

        private void dataGridViewCallers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = this.dataGridViewCallers.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = this.dataGridViewCallers.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn && this.dataGridViewCallers.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            try
            {
                this.dataGridViewCallers.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
            }
            catch (System.ArgumentException)
            {

            }
        }

        private void dataGridViewCallers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in this.dataGridViewCallers.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        #region Helper Methods

        /// <summary>
        /// Updates callers list according to current search options.
        /// </summary>
        public void UpdateCallersList()
        {
            if (this.dbContext != null)
            {
                // Start with the base query
                var callersQuery = this.dbContext.Callers.AsQueryable();

                // Apply name filter
                string nameFilter = this.textBoxName.Text.ToLower();
                callersQuery = callersQuery.Where(c => c.Name.ToLower().Contains(nameFilter));

                // Apply number filter
                string numberFilter = this.textBoxNumber.Text.ToLower();
                callersQuery = callersQuery.Where(c => c.Number.ToLower().Contains(numberFilter));

                // Apply address filter
                string addressFilter = this.textBoxAddress.Text.ToLower();
                callersQuery = callersQuery.Where(c => c.Address.ToLower().Contains(addressFilter));

                // Apply email filter
                string emailFilter = this.textBoxEmail.Text.ToLower();
                callersQuery = callersQuery.Where(c => c.Email.ToLower().Contains(emailFilter));

                // Apply category filter
                if (this.comboBoxCategory.SelectedValue != null)
                {
                    int selectedCategoryId = (int)this.comboBoxCategory.SelectedValue;
                    if (selectedCategoryId != 1)
                    {
                        callersQuery = callersQuery.Where(c => c.CategoryId == selectedCategoryId);
                    }
                }

                // Update the DataSource with the refined results
                var bindingList = new SortableBindingList<Caller>(callersQuery.ToList());
                var source = new BindingSource(bindingList, null);
                this.dataGridViewCallers.DataSource = source;
            }
        }

        /// <summary>
        /// Adds 'Edit' and 'Delete' buttons to each record.
        /// </summary>
        private void AddColumns()
        {
            DataGridViewButtonColumn buttonEditColumn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn buttonDeleteColumn = new DataGridViewButtonColumn();

            buttonEditColumn.HeaderText = "";
            buttonEditColumn.Name = "Edit Request";
            buttonEditColumn.Text = "📝";
            buttonEditColumn.UseColumnTextForButtonValue = true;

            buttonDeleteColumn.HeaderText = "";
            buttonDeleteColumn.Name = "Delete Request";
            buttonDeleteColumn.Text = "🗑️";
            buttonDeleteColumn.UseColumnTextForButtonValue = true;

            this.dataGridViewCallers.Columns.Add(buttonEditColumn);
            this.dataGridViewCallers.Columns.Add(buttonDeleteColumn);

            this.dataGridViewCallers.CellClick +=
                new DataGridViewCellEventHandler(dataGridViewCallers_CellClick);
        }

        #endregion

        #region SearchCallerEvent Handlers

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            UpdateCallersList();
        }

        private void comboBoxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateCallersList();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            UpdateCallersList();
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            UpdateCallersList();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateCallersList();
        }

        #endregion

        #region ButtonClick Handlers

        private void buttonAddCaller_Click(object sender, EventArgs e)
        {
            AddCallerForm addCallerForm = new AddCallerForm(this);
            addCallerForm.ShowDialog();
        }

        private void dataGridViewCallers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || (e.ColumnIndex != this.dataGridViewCallers.Columns["Edit Request"].Index
                && e.ColumnIndex != this.dataGridViewCallers.Columns["Delete Request"].Index))
                return;

            int callerId = (int)dataGridViewCallers[0, e.RowIndex].Value;

            if (e.ColumnIndex == this.dataGridViewCallers.Columns["Delete Request"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що бажаєте видалити даного користувача?", "Запит на видалення", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    var callerToDelete = this.dbContext.Callers.Single(c => c.CallerId == callerId);

                    if (callerToDelete != null)
                    {
                        this.dbContext.Callers.Remove(callerToDelete);
                        this.dbContext.SaveChanges();
                        UpdateCallersList();
                    }
                }
            }
            else
            {
                CallerEditForm callerEditForm = new CallerEditForm(this, callerId);
                callerEditForm.ShowDialog();
            }
        }

        #endregion
    }
}
