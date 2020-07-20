namespace BudgetMinecraft
{
    partial class Inventory
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
            this.listBoxChest = new System.Windows.Forms.ListBox();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxChest
            // 
            this.listBoxChest.BackColor = System.Drawing.Color.SaddleBrown;
            this.listBoxChest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxChest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxChest.FormattingEnabled = true;
            this.listBoxChest.ItemHeight = 20;
            this.listBoxChest.Location = new System.Drawing.Point(520, 223);
            this.listBoxChest.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxChest.Name = "listBoxChest";
            this.listBoxChest.Size = new System.Drawing.Size(237, 362);
            this.listBoxChest.TabIndex = 0;
            this.listBoxChest.SelectedIndexChanged += new System.EventHandler(this.listBoxChest_SelectedIndexChanged);
            // 
            // listBoxMain
            // 
            this.listBoxMain.BackColor = System.Drawing.Color.SaddleBrown;
            this.listBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.ItemHeight = 20;
            this.listBoxMain.Location = new System.Drawing.Point(92, 223);
            this.listBoxMain.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(237, 362);
            this.listBoxMain.TabIndex = 1;
            this.listBoxMain.SelectedIndexChanged += new System.EventHandler(this.listBoxMain_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main inventory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(526, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chest inventory:";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(792, 553);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 43);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(792, 620);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "PRINT FILE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BudgetMinecraft.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.listBoxChest);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventory_FormClosed);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.ListBox listBoxChest;
        public System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Button button1;
    }
}