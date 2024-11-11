namespace calculator
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.itog = new System.Windows.Forms.Button();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(401, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.subtraction);
            this.inputPanel.Controls.Add(this.multiplication);
            this.inputPanel.Controls.Add(this.division);
            this.inputPanel.Controls.Add(this.addition);
            this.inputPanel.Controls.Add(this.eight);
            this.inputPanel.Controls.Add(this.five);
            this.inputPanel.Controls.Add(this.six);
            this.inputPanel.Controls.Add(this.seven);
            this.inputPanel.Controls.Add(this.nine);
            this.inputPanel.Controls.Add(this.one);
            this.inputPanel.Controls.Add(this.two);
            this.inputPanel.Controls.Add(this.three);
            this.inputPanel.Controls.Add(this.four);
            this.inputPanel.Location = new System.Drawing.Point(36, 197);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(402, 334);
            this.inputPanel.TabIndex = 1;
            // 
            // subtraction
            // 
            this.subtraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.subtraction.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(307, 100);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(81, 69);
            this.subtraction.TabIndex = 12;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.multiplication.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(245, 175);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(81, 69);
            this.multiplication.TabIndex = 11;
            this.multiplication.Text = "*";
            this.multiplication.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // division
            // 
            this.division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.division.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(307, 250);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(81, 69);
            this.division.TabIndex = 10;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // addition
            // 
            this.addition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addition.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(245, 25);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(81, 69);
            this.addition.TabIndex = 9;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // eight
            // 
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(93, 204);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(68, 67);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // five
            // 
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(93, 138);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(68, 67);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.eight_Click);
            // 
            // six
            // 
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(159, 138);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(68, 67);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(27, 204);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(68, 67);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(159, 204);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(68, 67);
            this.nine.TabIndex = 4;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.eight_Click);
            // 
            // one
            // 
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(27, 72);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(68, 67);
            this.one.TabIndex = 3;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.eight_Click);
            // 
            // two
            // 
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(93, 72);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(68, 67);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.eight_Click);
            // 
            // three
            // 
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(159, 72);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(68, 67);
            this.three.TabIndex = 1;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.eight_Click);
            // 
            // four
            // 
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(27, 138);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(68, 67);
            this.four.TabIndex = 0;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.eight_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(36, 76);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(300, 50);
            this.display.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(397, 92);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 66);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // itog
            // 
            this.itog.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itog.Location = new System.Drawing.Point(45, 134);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(291, 57);
            this.itog.TabIndex = 4;
            this.itog.Text = "=";
            this.itog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itog.UseVisualStyleBackColor = true;
            this.itog.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.itog);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.display);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Form1";
            this.inputPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button itog;
    }
}

