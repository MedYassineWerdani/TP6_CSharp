namespace RecipeNotebook.CategoryForms
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
            buttonSupprimer = new Button();
            buttonModifier = new Button();
            buttonAjouter = new Button();
            dataGridViewListe = new DataGridView();
            bindingSourceListe = new BindingSource(components);
            buttonActualiser = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceListe).BeginInit();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(800, 450);
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
            tableLayoutPanel2.Location = new Point(3, 383);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 64);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Dock = DockStyle.Fill;
            buttonSupprimer.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonSupprimer.Image = Properties.Resources.remove_icon;
            buttonSupprimer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSupprimer.Location = new Point(399, 3);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(192, 58);
            buttonSupprimer.TabIndex = 2;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            buttonModifier.Dock = DockStyle.Fill;
            buttonModifier.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonModifier.Image = Properties.Resources.pencil_small_icon;
            buttonModifier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModifier.Location = new Point(201, 3);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(192, 58);
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
            buttonAjouter.Location = new Point(3, 3);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(192, 58);
            buttonAjouter.TabIndex = 0;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListe
            // 
            dataGridViewListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListe.Dock = DockStyle.Fill;
            dataGridViewListe.Location = new Point(3, 3);
            dataGridViewListe.Name = "dataGridViewListe";
            dataGridViewListe.RowHeadersWidth = 51;
            dataGridViewListe.Size = new Size(794, 374);
            dataGridViewListe.TabIndex = 1;
            // 
            // buttonActualiser
            // 
            buttonActualiser.Dock = DockStyle.Fill;
            buttonActualiser.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold);
            buttonActualiser.Image = Properties.Resources.reload_icon;
            buttonActualiser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonActualiser.Location = new Point(597, 3);
            buttonActualiser.Name = "buttonActualiser";
            buttonActualiser.Size = new Size(194, 58);
            buttonActualiser.TabIndex = 4;
            buttonActualiser.Text = "Actualiser";
            buttonActualiser.UseVisualStyleBackColor = true;
            // 
            // CategoriesListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CategoriesListForm";
            Text = "Liste des Catégories";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListe).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSupprimer;
        private Button buttonModifier;
        private Button buttonAjouter;
        private DataGridView dataGridViewListe;
        private BindingSource bindingSourceListe;
        private Button buttonActualiser;
    }
}