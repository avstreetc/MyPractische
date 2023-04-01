namespace _5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ничегоНеДелатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ничегоНеДелатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ничегоНеДелатьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ничегоНеДелатьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandOneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandOneToolStripMenuItem,
            this.commandTwoToolStripMenuItem,
            this.commandOneToolStripMenuItem1});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // commandOneToolStripMenuItem
            // 
            resources.ApplyResources(this.commandOneToolStripMenuItem, "commandOneToolStripMenuItem");
            this.commandOneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ничегоНеДелатьToolStripMenuItem,
            this.ничегоНеДелатьToolStripMenuItem1});
            this.commandOneToolStripMenuItem.Name = "commandOneToolStripMenuItem";
            // 
            // ничегоНеДелатьToolStripMenuItem
            // 
            resources.ApplyResources(this.ничегоНеДелатьToolStripMenuItem, "ничегоНеДелатьToolStripMenuItem");
            this.ничегоНеДелатьToolStripMenuItem.Name = "ничегоНеДелатьToolStripMenuItem";
            // 
            // ничегоНеДелатьToolStripMenuItem1
            // 
            resources.ApplyResources(this.ничегоНеДелатьToolStripMenuItem1, "ничегоНеДелатьToolStripMenuItem1");
            this.ничегоНеДелатьToolStripMenuItem1.Name = "ничегоНеДелатьToolStripMenuItem1";
            // 
            // commandTwoToolStripMenuItem
            // 
            resources.ApplyResources(this.commandTwoToolStripMenuItem, "commandTwoToolStripMenuItem");
            this.commandTwoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ничегоНеДелатьToolStripMenuItem2,
            this.ничегоНеДелатьToolStripMenuItem3});
            this.commandTwoToolStripMenuItem.Name = "commandTwoToolStripMenuItem";
            // 
            // ничегоНеДелатьToolStripMenuItem2
            // 
            resources.ApplyResources(this.ничегоНеДелатьToolStripMenuItem2, "ничегоНеДелатьToolStripMenuItem2");
            this.ничегоНеДелатьToolStripMenuItem2.Name = "ничегоНеДелатьToolStripMenuItem2";
            // 
            // ничегоНеДелатьToolStripMenuItem3
            // 
            resources.ApplyResources(this.ничегоНеДелатьToolStripMenuItem3, "ничегоНеДелатьToolStripMenuItem3");
            this.ничегоНеДелатьToolStripMenuItem3.Name = "ничегоНеДелатьToolStripMenuItem3";
            // 
            // commandOneToolStripMenuItem1
            // 
            resources.ApplyResources(this.commandOneToolStripMenuItem1, "commandOneToolStripMenuItem1");
            this.commandOneToolStripMenuItem1.Name = "commandOneToolStripMenuItem1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ничегоНеДелатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ничегоНеДелатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ничегоНеДелатьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ничегоНеДелатьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem commandOneToolStripMenuItem1;
    }
}

