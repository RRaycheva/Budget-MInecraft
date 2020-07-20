namespace BudgetMinecraft.Properties
{
    partial class About_Items
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.searchResults = new System.Windows.Forms.ListView();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Clear_Buttom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(154, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchResults
            // 
            this.searchResults.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResults.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.searchResults.HideSelection = false;
            this.searchResults.Location = new System.Drawing.Point(17, 66);
            this.searchResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(224, 166);
            this.searchResults.TabIndex = 16;
            this.searchResults.UseCompatibleStateImageBehavior = false;
            this.searchResults.View = System.Windows.Forms.View.List;
            this.searchResults.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // searchInput
            // 
            this.searchInput.BackColor = System.Drawing.SystemColors.Info;
            this.searchInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.searchInput.Location = new System.Drawing.Point(28, 29);
            this.searchInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(121, 20);
            this.searchInput.TabIndex = 17;
            // 
            // Clear_Buttom
            // 
            this.Clear_Buttom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clear_Buttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Buttom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_Buttom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clear_Buttom.Location = new System.Drawing.Point(154, 249);
            this.Clear_Buttom.Name = "Clear_Buttom";
            this.Clear_Buttom.Size = new System.Drawing.Size(86, 28);
            this.Clear_Buttom.TabIndex = 18;
            this.Clear_Buttom.Text = "Clear";
            this.Clear_Buttom.UseVisualStyleBackColor = false;
            this.Clear_Buttom.Click += new System.EventHandler(this.Clear_Buttom_Click);
            // 
            // About_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::BudgetMinecraft.Properties.Resources.minecraft_2053886_1280_min;
            this.ClientSize = new System.Drawing.Size(259, 298);
            this.Controls.Add(this.Clear_Buttom);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "About_Items";
            this.Text = "About_Items";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.About_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView searchResults;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button Clear_Buttom;
    }
}