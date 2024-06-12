namespace UniversityLIst
{
    partial class Form1
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
            this.addbtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbtn.Location = new System.Drawing.Point(33, 50);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(356, 47);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add Students";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showbtn
            // 
            this.showbtn.BackColor = System.Drawing.Color.Cyan;
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showbtn.Location = new System.Drawing.Point(33, 123);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(356, 47);
            this.showbtn.TabIndex = 1;
            this.showbtn.Text = "See Students";
            this.showbtn.UseVisualStyleBackColor = false;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(33, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(356, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(419, 475);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.addbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button button3;
    }
}

