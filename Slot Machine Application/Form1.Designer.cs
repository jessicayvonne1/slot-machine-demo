
namespace Slot_Machine_Application
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.moneyInsertedTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount inserted: $";
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(220, 293);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(139, 40);
            this.spinButton.TabIndex = 1;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(420, 293);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // moneyInsertedTextBox
            // 
            this.moneyInsertedTextBox.Location = new System.Drawing.Point(403, 250);
            this.moneyInsertedTextBox.Name = "moneyInsertedTextBox";
            this.moneyInsertedTextBox.Size = new System.Drawing.Size(139, 22);
            this.moneyInsertedTextBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBox3);
            this.panel1.Controls.Add(this.picBox2);
            this.panel1.Controls.Add(this.picBox1);
            this.panel1.Controls.Add(this.spinButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.moneyInsertedTextBox);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 415);
            this.panel1.TabIndex = 4;
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(492, 32);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(189, 191);
            this.picBox3.TabIndex = 6;
            this.picBox3.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(297, 32);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(189, 191);
            this.picBox2.TabIndex = 5;
            this.picBox2.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(102, 32);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(189, 191);
            this.picBox1.TabIndex = 4;
            this.picBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cherries.png");
            this.imageList1.Images.SetKeyName(1, "Coins.png");
            this.imageList1.Images.SetKeyName(2, "Diamond.png");
            this.imageList1.Images.SetKeyName(3, "Grapes.png");
            this.imageList1.Images.SetKeyName(4, "Jackpot.png");
            this.imageList1.Images.SetKeyName(5, "Lucky_Seven.png");
            this.imageList1.Images.SetKeyName(6, "Orange.png");
            this.imageList1.Images.SetKeyName(7, "Pear.png");
            this.imageList1.Images.SetKeyName(8, "Strawberry.png");
            this.imageList1.Images.SetKeyName(9, "Watermelon.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox moneyInsertedTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

