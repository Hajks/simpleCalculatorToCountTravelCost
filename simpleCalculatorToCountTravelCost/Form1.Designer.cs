namespace simpleCalculatorToCountTravelCost
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
            this.startNumber = new System.Windows.Forms.NumericUpDown();
            this.endNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountToReturn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // startNumber
            // 
            this.startNumber.Location = new System.Drawing.Point(142, 39);
            this.startNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNumber.Name = "startNumber";
            this.startNumber.Size = new System.Drawing.Size(120, 20);
            this.startNumber.TabIndex = 0;
            this.startNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endNumber
            // 
            this.endNumber.Location = new System.Drawing.Point(142, 69);
            this.endNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.endNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumber.Name = "endNumber";
            this.endNumber.Size = new System.Drawing.Size(120, 20);
            this.endNumber.TabIndex = 1;
            this.endNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Początkowy stan licznika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Końcowy stan licznika:";
            // 
            // amountToReturn
            // 
            this.amountToReturn.AutoSize = true;
            this.amountToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amountToReturn.Location = new System.Drawing.Point(153, 104);
            this.amountToReturn.Name = "amountToReturn";
            this.amountToReturn.Size = new System.Drawing.Size(0, 20);
            this.amountToReturn.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Oblicz kwotę do zwrotu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pokaż ilość przejechanych kilometrów";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountToReturn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endNumber);
            this.Controls.Add(this.startNumber);
            this.Name = "Form1";
            this.Text = "Kalkulator odległości";
            ((System.ComponentModel.ISupportInitialize)(this.startNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown startNumber;
        private System.Windows.Forms.NumericUpDown endNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amountToReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

