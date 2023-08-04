namespace Dice
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lb1Dice1 = new System.Windows.Forms.Label();
            this.lb1Dice2 = new System.Windows.Forms.Label();
            this.pbxDice1 = new System.Windows.Forms.PictureBox();
            this.pbxDice2 = new System.Windows.Forms.PictureBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(102, 49);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(93, 33);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lb1Dice1
            // 
            this.lb1Dice1.AutoSize = true;
            this.lb1Dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1Dice1.Location = new System.Drawing.Point(46, 99);
            this.lb1Dice1.Name = "lb1Dice1";
            this.lb1Dice1.Size = new System.Drawing.Size(50, 20);
            this.lb1Dice1.TabIndex = 1;
            this.lb1Dice1.Text = "Dice1";
            // 
            // lb1Dice2
            // 
            this.lb1Dice2.AutoSize = true;
            this.lb1Dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1Dice2.Location = new System.Drawing.Point(164, 99);
            this.lb1Dice2.Name = "lb1Dice2";
            this.lb1Dice2.Size = new System.Drawing.Size(50, 20);
            this.lb1Dice2.TabIndex = 2;
            this.lb1Dice2.Text = "Dice2";
            // 
            // pbxDice1
            // 
            this.pbxDice1.Location = new System.Drawing.Point(31, 128);
            this.pbxDice1.Name = "pbxDice1";
            this.pbxDice1.Size = new System.Drawing.Size(88, 80);
            this.pbxDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxDice1.TabIndex = 3;
            this.pbxDice1.TabStop = false;
            // 
            // pbxDice2
            // 
            this.pbxDice2.Location = new System.Drawing.Point(154, 128);
            this.pbxDice2.Name = "pbxDice2";
            this.pbxDice2.Size = new System.Drawing.Size(86, 78);
            this.pbxDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxDice2.TabIndex = 4;
            this.pbxDice2.TabStop = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(168, 225);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(72, 29);
            this.txtAnswer.TabIndex = 5;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(93, 272);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(121, 32);
            this.btnAnswer.TabIndex = 6;
            this.btnAnswer.Text = "Submit Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "= ?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "The Answer is:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "I Enjoy Learning Mathematics!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total times tried: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(206, 325);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(108, 24);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total Times";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correct answer times :";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(236, 357);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(78, 24);
            this.lblCorrect.TabIndex = 14;
            this.lblCorrect.Text = "Correct";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 390);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.pbxDice2);
            this.Controls.Add(this.pbxDice1);
            this.Controls.Add(this.lb1Dice2);
            this.Controls.Add(this.lb1Dice1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "My Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lb1Dice1;
        private System.Windows.Forms.Label lb1Dice2;
        private System.Windows.Forms.PictureBox pbxDice1;
        private System.Windows.Forms.PictureBox pbxDice2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCorrect;
    }
}

