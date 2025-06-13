
namespace RCRP_CLT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.rbChatlog = new System.Windows.Forms.RichTextBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbTimestamp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Names (seperated by commas):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chatlog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created by Zodiac for RC-RP";
            // 
            // txtNames
            // 
            this.txtNames.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNames.Location = new System.Drawing.Point(137, 39);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(527, 20);
            this.txtNames.TabIndex = 0;
            // 
            // rbChatlog
            // 
            this.rbChatlog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChatlog.Location = new System.Drawing.Point(39, 91);
            this.rbChatlog.Name = "rbChatlog";
            this.rbChatlog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rbChatlog.Size = new System.Drawing.Size(723, 235);
            this.rbChatlog.TabIndex = 1;
            this.rbChatlog.Text = "";
            // 
            // btnTrim
            // 
            this.btnTrim.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnTrim.Location = new System.Drawing.Point(291, 355);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(104, 45);
            this.btnTrim.TabIndex = 2;
            this.btnTrim.Text = "TRIM";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(405, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbTimestamp
            // 
            this.cbTimestamp.AutoSize = true;
            this.cbTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimestamp.Location = new System.Drawing.Point(117, 367);
            this.cbTimestamp.Name = "cbTimestamp";
            this.cbTimestamp.Size = new System.Drawing.Size(149, 20);
            this.cbTimestamp.TabIndex = 7;
            this.cbTimestamp.Text = "Without Timestamps";
            this.cbTimestamp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTimestamp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.rbChatlog);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chatlog Trimmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.RichTextBox rbChatlog;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbTimestamp;
    }
}

