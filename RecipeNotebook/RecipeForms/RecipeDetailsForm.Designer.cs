namespace RecipeNotebook.RecipeForms
{
    partial class RecipeDetailsForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonOK = new Button();
            buttonCancel = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            recipeBindingSource = new BindingSource(components);
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Size = new Size(983, 648);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonOK);
            flowLayoutPanel1.Controls.Add(buttonCancel);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(3, 582);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(977, 63);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.AutoSize = true;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Image = Properties.Resources.tick_icon;
            buttonOK.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOK.Location = new Point(835, 3);
            buttonOK.MinimumSize = new Size(0, 59);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(139, 72);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "Valider";
            buttonOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Segoe UI", 9.07563F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.Image = Properties.Resources.cancel_icon;
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(682, 3);
            buttonCancel.MinimumSize = new Size(0, 59);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(147, 72);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Annuler";
            buttonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(977, 573);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recipe";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(comboBox1, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.028939F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.293438F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 39.10928F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5920963F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.97625F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(971, 547);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 36);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", recipeBindingSource, "Title", true));
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(142, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(826, 27);
            textBox1.TabIndex = 1;
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Data.Entities.Recipe);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(133, 134);
            label2.TabIndex = 2;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", recipeBindingSource, "Description", true));
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(142, 40);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(826, 126);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 170);
            label3.Name = "label3";
            label3.Size = new Size(133, 200);
            label3.TabIndex = 4;
            label3.Text = "Instructions";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", recipeBindingSource, "Instructions", true));
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(142, 174);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(826, 192);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 370);
            label4.Name = "label4";
            label4.Size = new Size(133, 54);
            label4.TabIndex = 6;
            label4.Text = "PreparationTime";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", recipeBindingSource, "PreparationTime", true));
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(142, 374);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(826, 46);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 424);
            label5.Name = "label5";
            label5.Size = new Size(133, 87);
            label5.TabIndex = 8;
            label5.Text = "Servings";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", recipeBindingSource, "Servings", true));
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(142, 428);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(826, 79);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 511);
            label6.Name = "label6";
            label6.Size = new Size(133, 36);
            label6.TabIndex = 10;
            label6.Text = "Category";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", recipeBindingSource, "Category", true));
            comboBox1.DataSource = categoryBindingSource;
            comboBox1.DisplayMember = "Name";
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 514);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(826, 28);
            comboBox1.TabIndex = 11;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entities.Category);
            // 
            // RecipeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 648);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RecipeDetailsForm";
            ShowIcon = false;
            Text = "Details";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonOK;
        private Button buttonCancel;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private BindingSource recipeBindingSource;
        private ComboBox comboBox1;
        private BindingSource categoryBindingSource;
    }
}