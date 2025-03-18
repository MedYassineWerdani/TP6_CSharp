namespace RecipeNotebook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            recettesToolStripMenuItem = new ToolStripMenuItem();
            catégoriesToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { recettesToolStripMenuItem, catégoriesToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(947, 28);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "menuStrip1";
            // 
            // recettesToolStripMenuItem
            // 
            recettesToolStripMenuItem.Name = "recettesToolStripMenuItem";
            recettesToolStripMenuItem.Size = new Size(79, 24);
            recettesToolStripMenuItem.Text = "Recettes";
            recettesToolStripMenuItem.Click += recettesToolStripMenuItem_Click;
            // 
            // catégoriesToolStripMenuItem
            // 
            catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            catégoriesToolStripMenuItem.Size = new Size(94, 24);
            catégoriesToolStripMenuItem.Text = "Catégories";
            catégoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 524);
            Controls.Add(menuStripMain);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
            Text = "Recipe Notebook";
            WindowState = FormWindowState.Maximized;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem catégoriesToolStripMenuItem;
        private ToolStripMenuItem recettesToolStripMenuItem;
    }
}
