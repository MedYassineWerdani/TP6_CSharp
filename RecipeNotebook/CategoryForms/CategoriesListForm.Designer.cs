﻿namespace RecipeNotebook.CategoryForms
{
    partial class CategoriesListForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonActualiser = new Button();
            buttonSupprimer = new Button();
            buttonModifier = new Button();
            buttonAjouter = new Button();
            dataGridViewListe = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(700, 338);
            tableLayoutPanel1.TabIndex = 0;
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
            // dataGridViewListe
            // 
            dataGridViewListe.AllowUserToAddRows = false;
            dataGridViewListe.AllowUserToDeleteRows = false;
            dataGridViewListe.AutoGenerateColumns = false;
            dataGridViewListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListe.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, recipesDataGridViewTextBoxColumn });
            dataGridViewListe.DataSource = categoryBindingSource;
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
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
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
            // recipesDataGridViewTextBoxColumn
            // 
            recipesDataGridViewTextBoxColumn.DataPropertyName = "Recipes";
            recipesDataGridViewTextBoxColumn.HeaderText = "Recipes";
            recipesDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipesDataGridViewTextBoxColumn.Name = "recipesDataGridViewTextBoxColumn";
            recipesDataGridViewTextBoxColumn.ReadOnly = true;
            recipesDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entities.Category);
            // 
            // CategoriesListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoriesListForm";
            Text = "Liste des Catégories";
            Load += CategoriesListForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSupprimer;
        private Button buttonModifier;
        private Button buttonAjouter;
        private DataGridView dataGridViewListe;
        private Button buttonActualiser;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipesDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
    }
}