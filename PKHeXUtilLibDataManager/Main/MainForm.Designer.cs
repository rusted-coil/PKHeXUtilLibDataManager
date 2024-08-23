namespace PKHeXUtilLibDataManager.Main
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
            menuStrip1 = new MenuStrip();
            pKHeXToolToolStripMenuItem = new ToolStripMenuItem();
            m_OpenNameParserDataEditButton = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pKHeXToolToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pKHeXToolToolStripMenuItem
            // 
            pKHeXToolToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { m_OpenNameParserDataEditButton });
            pKHeXToolToolStripMenuItem.Name = "pKHeXToolToolStripMenuItem";
            pKHeXToolToolStripMenuItem.Size = new Size(77, 20);
            pKHeXToolToolStripMenuItem.Text = "PKHeXTool";
            // 
            // m_OpenNameParserDataEditButton
            // 
            m_OpenNameParserDataEditButton.Name = "m_OpenNameParserDataEditButton";
            m_OpenNameParserDataEditButton.Size = new Size(180, 22);
            m_OpenNameParserDataEditButton.Text = "NameParserData";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pKHeXToolToolStripMenuItem;
        private ToolStripMenuItem m_OpenNameParserDataEditButton;
    }
}
