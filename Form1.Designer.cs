namespace stajornek1
{
    partial class Form1
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
            button1 = new Button();
            textBox1 = new TextBox();
            lblkayit1 = new Label();
            lblkayit2 = new Label();
            btnkayit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(161, 128);
            button1.Name = "button1";
            button1.Size = new Size(199, 40);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 23);
            textBox1.TabIndex = 1;
            // 
            // lblkayit1
            // 
            lblkayit1.AutoSize = true;
            lblkayit1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblkayit1.Location = new Point(771, 89);
            lblkayit1.Name = "lblkayit1";
            lblkayit1.Size = new Size(36, 28);
            lblkayit1.TabIndex = 2;
            lblkayit1.Text = "C#";
            // 
            // lblkayit2
            // 
            lblkayit2.AutoSize = true;
            lblkayit2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblkayit2.Location = new Point(771, 128);
            lblkayit2.Name = "lblkayit2";
            lblkayit2.Size = new Size(17, 28);
            lblkayit2.TabIndex = 3;
            lblkayit2.Text = " ";
            // 
            // btnkayit
            // 
            btnkayit.BackColor = Color.Black;
            btnkayit.ForeColor = Color.White;
            btnkayit.Location = new Point(655, 96);
            btnkayit.Name = "btnkayit";
            btnkayit.Size = new Size(87, 23);
            btnkayit.TabIndex = 4;
            btnkayit.Text = "Kaydet";
            btnkayit.UseVisualStyleBackColor = false;
            btnkayit.Click += btnkayit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gloucester MT Extra Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(233, 208);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 5;
            label1.Text = "Örnek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(897, 323);
            Controls.Add(label1);
            Controls.Add(btnkayit);
            Controls.Add(lblkayit2);
            Controls.Add(lblkayit1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label lblkayit1;
        private Label lblkayit2;
        private Button btnkayit;
        private Label label1;
    }
}