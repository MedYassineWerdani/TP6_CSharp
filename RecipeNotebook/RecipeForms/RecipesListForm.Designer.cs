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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            instructionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preparationTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            servingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Dock = DockStyle.Fill;
            buttonSupprimer.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonSupprimer.Image = Properties.Resources.remove_icon;
            buttonSupprimer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSupprimer.Location = new Point(349, 2);
            buttonSupprimer.Margin = new Padding(3, 2, 3, 2);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(167, 44);
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
            buttonAjouter.Location = new Point(3, 2);
            buttonAjouter.Margin = new Padding(3, 2, 3, 2);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(167, 44);
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
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(700, 338);
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
            tableLayoutPanel2.Location = new Point(3, 288);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(694, 48);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonActualiser
            // 
            buttonActualiser.Dock = DockStyle.Fill;
            buttonActualiser.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonActualiser.Image = Properties.Resources.reload_icon;
            buttonActualiser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonActualiser.Location = new Point(522, 2);
            buttonActualiser.Margin = new Padding(3, 2, 3, 2);
            buttonActualiser.Name = "buttonActualiser";
            buttonActualiser.Size = new Size(169, 44);
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
            buttonModifier.Location = new Point(176, 2);
            buttonModifier.Margin = new Padding(3, 2, 3, 2);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(167, 44);
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
            dataGridViewListe.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, instructionsDataGridViewTextBoxColumn, preparationTimeDataGridViewTextBoxColumn, servingsDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridViewListe.DataSource = recipeBindingSource;
            dataGridViewListe.Dock = DockStyle.Fill;
            dataGridViewListe.Location = new Point(3, 2);
            dataGridViewListe.Margin = new Padding(3, 2, 3, 2);
            dataGridViewListe.Name = "dataGridViewListe";
            dataGridViewListe.ReadOnly = true;
            dataGridViewListe.RowHeadersWidth = 51;
            dataGridViewListe.Size = new Size(694, 282);
            dataGridViewListe.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // instructionsDataGridViewTextBoxColumn
            // 
            instructionsDataGridViewTextBoxColumn.DataPropertyName = "Instructions";
            instructionsDataGridViewTextBoxColumn.HeaderText = "Instructions";
            instructionsDataGridViewTextBoxColumn.Name = "instructionsDataGridViewTextBoxColumn";
            instructionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preparationTimeDataGridViewTextBoxColumn
            // 
            preparationTimeDataGridViewTextBoxColumn.DataPropertyName = "PreparationTime";
            preparationTimeDataGridViewTextBoxColumn.HeaderText = "PreparationTime";
            preparationTimeDataGridViewTextBoxColumn.Name = "preparationTimeDataGridViewTextBoxColumn";
            preparationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servingsDataGridViewTextBoxColumn
            // 
            servingsDataGridViewTextBoxColumn.DataPropertyName = "Servings";
            servingsDataGridViewTextBoxColumn.HeaderText = "Servings";
            servingsDataGridViewTextBoxColumn.Name = "servingsDataGridViewTextBoxColumn";
            servingsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Data.Entities.Recipe);
            // 
            // RecipesListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RecipesListForm";
            Text = "Liste des recettes";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).EndInit();
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn instructionsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preparationTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn servingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private BindingSource recipeBindingSource;
    }
}