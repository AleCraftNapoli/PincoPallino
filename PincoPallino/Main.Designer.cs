namespace PincoPallino
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Name2 = new System.Windows.Forms.TextBox();
            this.Play = new System.Windows.Forms.Button();
            this.N1 = new System.Windows.Forms.Label();
            this.N2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(73, 96);
            this.Name1.MaxLength = 32;
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(134, 20);
            this.Name1.TabIndex = 0;
            // 
            // Name2
            // 
            this.Name2.Location = new System.Drawing.Point(73, 153);
            this.Name2.MaxLength = 32;
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(134, 20);
            this.Name2.TabIndex = 1;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(105, 210);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "Gioca!";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // N1
            // 
            this.N1.AutoSize = true;
            this.N1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N1.Location = new System.Drawing.Point(70, 78);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(110, 15);
            this.N1.TabIndex = 4;
            this.N1.Text = "Nome Giocatore 1:";
            // 
            // N2
            // 
            this.N2.AutoSize = true;
            this.N2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2.Location = new System.Drawing.Point(70, 135);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(110, 15);
            this.N2.TabIndex = 5;
            this.N2.Text = "Nome Giocatore 2:";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(267, 36);
            this.Title.TabIndex = 6;
            this.Title.Text = "PINCO PALLINO";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 262);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Pinco Pallino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Name2;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label N1;
        private System.Windows.Forms.Label N2;
        private System.Windows.Forms.Label Title;
    }
}