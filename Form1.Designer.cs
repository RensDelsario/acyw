namespace activiti2
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
            chCheese = new CheckBox();
            chPepperoni = new CheckBox();
            chBacon = new CheckBox();
            chBellpepper = new CheckBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            rbHawaiian = new RadioButton();
            rbItalian = new RadioButton();
            rbOverload = new RadioButton();
            txtTotal = new TextBox();
            txtAmount = new TextBox();
            txtChange = new TextBox();
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            btnClear = new Button();
            btnChange = new Button();
            btnTotal = new Button();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            btnStart = new Button();
            btnEnd = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // chCheese
            // 
            chCheese.AutoSize = true;
            chCheese.Location = new Point(66, 32);
            chCheese.Name = "chCheese";
            chCheese.Size = new Size(87, 19);
            chCheese.TabIndex = 0;
            chCheese.Text = "Cheese - 50";
            chCheese.UseVisualStyleBackColor = true;
            // 
            // chPepperoni
            // 
            chPepperoni.AutoSize = true;
            chPepperoni.Location = new Point(66, 75);
            chPepperoni.Name = "chPepperoni";
            chPepperoni.Size = new Size(103, 19);
            chPepperoni.TabIndex = 1;
            chPepperoni.Text = "Pepperoni - 50";
            chPepperoni.UseVisualStyleBackColor = true;
            // 
            // chBacon
            // 
            chBacon.AutoSize = true;
            chBacon.Location = new Point(231, 75);
            chBacon.Name = "chBacon";
            chBacon.Size = new Size(82, 19);
            chBacon.TabIndex = 2;
            chBacon.Text = "Bacon - 75";
            chBacon.UseVisualStyleBackColor = true;
            // 
            // chBellpepper
            // 
            chBellpepper.AutoSize = true;
            chBellpepper.Location = new Point(231, 32);
            chBellpepper.Name = "chBellpepper";
            chBellpepper.Size = new Size(105, 19);
            chBellpepper.TabIndex = 3;
            chBellpepper.Text = "Bellpepper - 50";
            chBellpepper.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 10;
            label1.Text = "Pizza type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 14);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 12;
            label3.Text = "ADD on toppings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 8);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 13;
            label4.Text = "PAYMENT INFORMATION";
            // 
            // rbHawaiian
            // 
            rbHawaiian.AutoSize = true;
            rbHawaiian.Location = new Point(13, 46);
            rbHawaiian.Name = "rbHawaiian";
            rbHawaiian.Size = new Size(118, 19);
            rbHawaiian.TabIndex = 14;
            rbHawaiian.TabStop = true;
            rbHawaiian.Text = "Hawaiian - 200.00";
            rbHawaiian.UseVisualStyleBackColor = true;
            // 
            // rbItalian
            // 
            rbItalian.AutoSize = true;
            rbItalian.Location = new Point(156, 46);
            rbItalian.Name = "rbItalian";
            rbItalian.Size = new Size(101, 19);
            rbItalian.TabIndex = 15;
            rbItalian.TabStop = true;
            rbItalian.Text = "Italian - 250.00";
            rbItalian.UseVisualStyleBackColor = true;
            rbItalian.CheckedChanged += rbItalian_CheckedChanged;
            // 
            // rbOverload
            // 
            rbOverload.AutoSize = true;
            rbOverload.Location = new Point(288, 46);
            rbOverload.Name = "rbOverload";
            rbOverload.Size = new Size(117, 19);
            rbOverload.TabIndex = 16;
            rbOverload.TabStop = true;
            rbOverload.Text = "Overload - 300.00";
            rbOverload.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(156, 32);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 17;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(156, 61);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 18;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(156, 90);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(100, 23);
            txtChange.TabIndex = 19;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(13, 54);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(77, 19);
            rbSmall.TabIndex = 20;
            rbSmall.TabStop = true;
            rbSmall.Text = "Small +50";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(132, 54);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(99, 19);
            rbMedium.TabIndex = 21;
            rbMedium.TabStop = true;
            rbMedium.Text = "Medium +100";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(274, 54);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(83, 19);
            rbLarge.TabIndex = 22;
            rbLarge.TabStop = true;
            rbLarge.Text = "Large +150";
            rbLarge.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(rbHawaiian);
            panel1.Controls.Add(rbItalian);
            panel1.Controls.Add(rbOverload);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(97, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 91);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rbSmall);
            panel2.Controls.Add(rbLarge);
            panel2.Controls.Add(rbMedium);
            panel2.Location = new Point(97, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 86);
            panel2.TabIndex = 24;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 16);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "Pizza type";
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(chCheese);
            panel3.Controls.Add(chPepperoni);
            panel3.Controls.Add(chBellpepper);
            panel3.Controls.Add(chBacon);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(97, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 114);
            panel3.TabIndex = 25;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnChange);
            panel4.Controls.Add(btnTotal);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtTotal);
            panel4.Controls.Add(txtAmount);
            panel4.Controls.Add(txtChange);
            panel4.Location = new Point(97, 360);
            panel4.Name = "panel4";
            panel4.Size = new Size(421, 125);
            panel4.TabIndex = 26;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Firebrick;
            btnClear.Location = new Point(274, 89);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 23);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Blue;
            btnChange.Location = new Point(274, 60);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(112, 24);
            btnChange.TabIndex = 31;
            btnChange.Text = "Compute Change";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnTotal
            // 
            btnTotal.BackColor = Color.Green;
            btnTotal.Location = new Point(274, 31);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(112, 23);
            btnTotal.TabIndex = 30;
            btnTotal.Text = " Compute Total";
            btnTotal.UseVisualStyleBackColor = false;
            btnTotal.Click += btnTotal_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 93);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 29;
            label7.Text = "Change";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 69);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 28;
            label6.Text = "Amount Paid";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 40);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 27;
            label2.Text = "Total Amount";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Green;
            btnStart.Location = new Point(97, 491);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(421, 38);
            btnStart.TabIndex = 33;
            btnStart.Text = "START TRANSACTION";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Firebrick;
            btnEnd.Location = new Point(97, 535);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(421, 38);
            btnEnd.TabIndex = 34;
            btnEnd.Text = "END TRANSACTION";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(22, 21);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 17;
            label8.Text = "Duyag, Lorens F.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(596, 585);
            Controls.Add(label8);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chCheese;
        private CheckBox chPepperoni;
        private CheckBox chBacon;
        private CheckBox chBellpepper;
        private Label label1;
        private Label label3;
        private Label label4;
        private RadioButton rbHawaiian;
        private RadioButton rbItalian;
        private RadioButton rbOverload;
        private TextBox txtTotal;
        private TextBox txtAmount;
        private TextBox txtChange;
        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private RadioButton rbLarge;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Panel panel4;
        private Button btnClear;
        private Button btnChange;
        private Button btnTotal;
        private Label label7;
        private Label label6;
        private Label label2;
        private Button btnStart;
        private Button btnEnd;
        private Label label8;
    }
}
