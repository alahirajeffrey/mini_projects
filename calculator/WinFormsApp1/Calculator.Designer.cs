namespace WinFormsApp1
{
    partial class Calculator
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
            textBox = new TextBox();
            clearBtn = new Button();
            percentBtn = new Button();
            divideBtn = new Button();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            multiplyBtn = new Button();
            fourBtn = new Button();
            fiveBtn = new Button();
            sixBtn = new Button();
            subtractBtn = new Button();
            oneBtn = new Button();
            twoBtn = new Button();
            threeBtn = new Button();
            addBtn = new Button();
            equalBtn = new Button();
            decimalBtn = new Button();
            zeroBtn = new Button();
            plusMinusBtn = new Button();
            textLabel = new Label();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            textBox.Location = new Point(25, 21);
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(364, 38);
            textBox.TabIndex = 0;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(25, 107);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 41);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // percentBtn
            // 
            percentBtn.Location = new Point(224, 107);
            percentBtn.Name = "percentBtn";
            percentBtn.Size = new Size(75, 41);
            percentBtn.TabIndex = 3;
            percentBtn.Text = "%";
            percentBtn.UseVisualStyleBackColor = true;
            percentBtn.Click += percentBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.Location = new Point(314, 107);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(75, 41);
            divideBtn.TabIndex = 4;
            divideBtn.Text = "/";
            divideBtn.UseVisualStyleBackColor = true;
            divideBtn.Click += divideBtn_Click;
            // 
            // sevenBtn
            // 
            sevenBtn.Location = new Point(25, 182);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(75, 41);
            sevenBtn.TabIndex = 5;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = true;
            sevenBtn.Click += sevenBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.Location = new Point(127, 182);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(75, 41);
            eightBtn.TabIndex = 6;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = true;
            eightBtn.Click += eightBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.Location = new Point(224, 182);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(75, 41);
            nineBtn.TabIndex = 7;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = true;
            nineBtn.Click += nineBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.Location = new Point(314, 182);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(75, 41);
            multiplyBtn.TabIndex = 8;
            multiplyBtn.Text = "x";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.Location = new Point(25, 258);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(75, 41);
            fourBtn.TabIndex = 9;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += button9_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.Location = new Point(127, 258);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(75, 41);
            fiveBtn.TabIndex = 10;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = true;
            fiveBtn.Click += fiveBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.Location = new Point(224, 258);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(75, 41);
            sixBtn.TabIndex = 11;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = true;
            sixBtn.Click += button11_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            subtractBtn.Location = new Point(314, 258);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(75, 41);
            subtractBtn.TabIndex = 12;
            subtractBtn.Text = "-";
            subtractBtn.UseVisualStyleBackColor = true;
            subtractBtn.Click += subtractBtn_Click;
            // 
            // oneBtn
            // 
            oneBtn.Location = new Point(25, 330);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(75, 41);
            oneBtn.TabIndex = 13;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += oneBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.Location = new Point(127, 330);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(75, 41);
            twoBtn.TabIndex = 14;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += twoBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.Location = new Point(224, 330);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(75, 41);
            threeBtn.TabIndex = 15;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += threeBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(314, 330);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 41);
            addBtn.TabIndex = 16;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.Location = new Point(314, 397);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(75, 41);
            equalBtn.TabIndex = 20;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = true;
            equalBtn.Click += equalBtn_Click;
            // 
            // decimalBtn
            // 
            decimalBtn.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            decimalBtn.Location = new Point(224, 397);
            decimalBtn.Name = "decimalBtn";
            decimalBtn.Size = new Size(75, 41);
            decimalBtn.TabIndex = 19;
            decimalBtn.Text = ".";
            decimalBtn.UseVisualStyleBackColor = true;
            decimalBtn.Click += decimalBtn_Click;
            // 
            // zeroBtn
            // 
            zeroBtn.Location = new Point(127, 397);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(75, 41);
            zeroBtn.TabIndex = 18;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = true;
            zeroBtn.Click += button19_Click;
            // 
            // plusMinusBtn
            // 
            plusMinusBtn.Location = new Point(25, 397);
            plusMinusBtn.Name = "plusMinusBtn";
            plusMinusBtn.Size = new Size(75, 41);
            plusMinusBtn.TabIndex = 17;
            plusMinusBtn.Text = "+/-";
            plusMinusBtn.UseVisualStyleBackColor = true;
            plusMinusBtn.Click += plusMinusBtn_Click;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            textLabel.Location = new Point(121, 455);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(178, 24);
            textLabel.TabIndex = 21;
            textLabel.Text = "World Best Calculator";
            textLabel.TextAlign = ContentAlignment.MiddleCenter;
            textLabel.Click += label1_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 506);
            Controls.Add(textLabel);
            Controls.Add(equalBtn);
            Controls.Add(decimalBtn);
            Controls.Add(zeroBtn);
            Controls.Add(plusMinusBtn);
            Controls.Add(addBtn);
            Controls.Add(threeBtn);
            Controls.Add(twoBtn);
            Controls.Add(oneBtn);
            Controls.Add(subtractBtn);
            Controls.Add(sixBtn);
            Controls.Add(fiveBtn);
            Controls.Add(fourBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sevenBtn);
            Controls.Add(divideBtn);
            Controls.Add(percentBtn);
            Controls.Add(clearBtn);
            Controls.Add(textBox);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "Calculator";
            Text = "Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button clearBtn;
        private Button percentBtn;
        private Button divideBtn;
        private Button sevenBtn;
        private Button eightBtn;
        private Button nineBtn;
        private Button multiplyBtn;
        private Button fourBtn;
        private Button fiveBtn;
        private Button sixBtn;
        private Button subtractBtn;
        private Button oneBtn;
        private Button twoBtn;
        private Button threeBtn;
        private Button addBtn;
        private Button equalBtn;
        private Button decimalBtn;
        private Button zeroBtn;
        private Button plusMinusBtn;
        private Label textLabel;
    }
}