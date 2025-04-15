namespace RecipeNotebook.RecipeForms
{
    partial class RecipesListForm
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
            buttonSupprimer = new Button();
            buttonAjouter = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonActualiser = new Button();
            buttonModifier = new Button();
            dataGridViewListe = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            recipeBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            instructionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preparationTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            servingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Dock = DockStyle.Fill;
            buttonSupprimer.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonSupprimer.Image = Properties.Resources.remove_icon;
            buttonSupprimer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSupprimer.Location = new Point(477, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(231, 57);
            buttonSupprimer.TabIndex = 2;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Dock = DockStyle.Fill;
            buttonAjouter.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouter.Image = Properties.Resources.add_icon;
            buttonAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAjouter.Location = new Point(3, 3);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(231, 57);
            buttonAjouter.TabIndex = 0;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridViewListe, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(956, 451);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9981289F));
            tableLayoutPanel2.Controls.Add(buttonActualiser, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonSupprimer, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonModifier, 1, 0);
            tableLayoutPanel2.Controls.Add(buttonAjouter, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 385);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(950, 63);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonActualiser
            // 
            buttonActualiser.Dock = DockStyle.Fill;
            buttonActualiser.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonActualiser.Image = Properties.Resources.reload_icon;
            buttonActualiser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonActualiser.Location = new Point(714, 3);
            buttonActualiser.Name = "buttonActualiser";
            buttonActualiser.Size = new Size(233, 57);
            buttonActualiser.TabIndex = 4;
            buttonActualiser.Text = "Actualiser";
            buttonActualiser.UseVisualStyleBackColor = true;
            buttonActualiser.Click += buttonActualiser_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.Dock = DockStyle.Fill;
            buttonModifier.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonModifier.Image = Properties.Resources.pencil_small_icon;
            buttonModifier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModifier.Location = new Point(240, 3);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(231, 57);
            buttonModifier.TabIndex = 1;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = true;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // dataGridViewListe
            // 
            dataGridViewListe.AllowUserToAddRows = false;
            dataGridViewListe.AllowUserToDeleteRows = false;
            dataGridViewListe.AutoGenerateColumns = false;
            dataGridViewListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListe.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, instructionsDataGridViewTextBoxColumn, preparationTimeDataGridViewTextBoxColumn, servingsDataGridViewTextBoxColumn, Category });
            dataGridViewListe.DataSource = recipeBindingSource;
            dataGridViewListe.Dock = DockStyle.Fill;
            dataGridViewListe.Location = new Point(3, 3);
            dataGridViewListe.Name = "dataGridViewListe";
            dataGridViewListe.ReadOnly = true;
            dataGridViewListe.RowHeadersWidth = 51;
            dataGridViewListe.Size = new Size(950, 376);
            dataGridViewListe.TabIndex = 1;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entities.Category);
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Data.Entities.Recipe);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // instructionsDataGridViewTextBoxColumn
            // 
            instructionsDataGridViewTextBoxColumn.DataPropertyName = "Instructions";
            instructionsDataGridViewTextBoxColumn.HeaderText = "Instructions";
            instructionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            instructionsDataGridViewTextBoxColumn.Name = "instructionsDataGridViewTextBoxColumn";
            instructionsDataGridViewTextBoxColumn.ReadOnly = true;
            instructionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // preparationTimeDataGridViewTextBoxColumn
            // 
            preparationTimeDataGridViewTextBoxColumn.DataPropertyName = "PreparationTime";
            preparationTimeDataGridViewTextBoxColumn.HeaderText = "PreparationTime";
            preparationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            preparationTimeDataGridViewTextBoxColumn.Name = "preparationTimeDataGridViewTextBoxColumn";
            preparationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            preparationTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // servingsDataGridViewTextBoxColumn
            // 
            servingsDataGridViewTextBoxColumn.DataPropertyName = "Servings";
            servingsDataGridViewTextBoxColumn.HeaderText = "Servings";
            servingsDataGridViewTextBoxColumn.MinimumWidth = 6;
            servingsDataGridViewTextBoxColumn.Name = "servingsDataGridViewTextBoxColumn";
            servingsDataGridViewTextBoxColumn.ReadOnly = true;
            servingsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // RecipesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 451);
            Controls.Add(tableLayoutPanel1);
            Name = "RecipesListForm";
            Text = "Liste des recettes";
            Load += RecipesListForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSupprimer;
        private Button buttonAjouter;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonModifier;
        private DataGridView dataGridViewListe;
        private Button buttonActualiser;
        private BindingSource recipeBindingSource;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn instructionsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preparationTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn servingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Category;
    }
}