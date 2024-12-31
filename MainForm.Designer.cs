namespace SD1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runStudentasMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runStudentasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            
            
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileMenuItem,
                this.toolsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;

            
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.openMenuItem,
                this.saveMenuItem,
                this.exitMenuItem});
            this.fileMenuItem.Text = "Failas";

            
            this.openMenuItem.Text = "Atidaryti";
            this.openMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);

            
            this.saveMenuItem.Text = "Išsaugoti";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveFileMenuItem_Click);

            
            this.exitMenuItem.Text = "Išeiti";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);

            
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.runStudentasMenuItem});
            this.toolsMenuItem.Text = "Įrankiai";

            
            this.runStudentasMenuItem.Text = "Paleisti Studentas";
            this.runStudentasMenuItem.Click += new System.EventHandler(this.RunStudentasMenuItem_Click);

            
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Size = new System.Drawing.Size(776, 411);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";

           
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SD1 Programa";
        }
    }
}
