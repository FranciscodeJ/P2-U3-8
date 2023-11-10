namespace Práctica_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label5 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.NavajoWhite;
            button1.Location = new Point(102, 214);
            button1.Name = "button1";
            button1.Size = new Size(254, 60);
            button1.TabIndex = 0;
            button1.Text = "Listar Números";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.BlanchedAlmond;
            label5.Location = new Point(259, 30);
            label5.Name = "label5";
            label5.Size = new Size(347, 35);
            label5.TabIndex = 14;
            label5.Text = "Este progrma escribe del 1 al 5";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PaleGoldenrod;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 34;
            listBox1.Location = new Point(418, 157);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(169, 272);
            listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(882, 529);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private ListBox listBox1;
    }
}