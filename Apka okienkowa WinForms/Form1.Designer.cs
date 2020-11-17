namespace Apka_okienkowa_WinForms
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.InputInfo = new System.Windows.Forms.Label();
            this.UserButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.CKey = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Sign = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.UserButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(22, 22);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(344, 23);
            this.UserInputText.TabIndex = 0;
            // 
            // InputInfo
            // 
            this.InputInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputInfo.AutoEllipsis = true;
            this.InputInfo.Location = new System.Drawing.Point(22, 56);
            this.InputInfo.Name = "InputInfo";
            this.InputInfo.Size = new System.Drawing.Size(352, 23);
            this.InputInfo.TabIndex = 1;
            this.InputInfo.Text = "enter eqausion and press enter to see results";
            // 
            // UserButtonPanel
            // 
            this.UserButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserButtonPanel.AutoSize = true;
            this.UserButtonPanel.ColumnCount = 4;
            this.UserButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserButtonPanel.Controls.Add(this.CEButton, 0, 0);
            this.UserButtonPanel.Controls.Add(this.CKey, 1, 0);
            this.UserButtonPanel.Controls.Add(this.Del, 2, 0);
            this.UserButtonPanel.Controls.Add(this.Division, 3, 0);
            this.UserButtonPanel.Controls.Add(this.One, 0, 1);
            this.UserButtonPanel.Controls.Add(this.Two, 1, 1);
            this.UserButtonPanel.Controls.Add(this.Three, 2, 1);
            this.UserButtonPanel.Controls.Add(this.Four, 0, 2);
            this.UserButtonPanel.Controls.Add(this.Five, 1, 2);
            this.UserButtonPanel.Controls.Add(this.Six, 2, 2);
            this.UserButtonPanel.Controls.Add(this.Seven, 0, 3);
            this.UserButtonPanel.Controls.Add(this.Eight, 1, 3);
            this.UserButtonPanel.Controls.Add(this.Nine, 2, 3);
            this.UserButtonPanel.Controls.Add(this.Multiply, 3, 1);
            this.UserButtonPanel.Controls.Add(this.Minus, 3, 2);
            this.UserButtonPanel.Controls.Add(this.Plus, 3, 3);
            this.UserButtonPanel.Controls.Add(this.Sign, 0, 4);
            this.UserButtonPanel.Controls.Add(this.Zero, 1, 4);
            this.UserButtonPanel.Controls.Add(this.Dot, 2, 4);
            this.UserButtonPanel.Controls.Add(this.Equals, 3, 4);
            this.UserButtonPanel.Location = new System.Drawing.Point(22, 78);
            this.UserButtonPanel.Name = "UserButtonPanel";
            this.UserButtonPanel.RowCount = 5;
            this.UserButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UserButtonPanel.Size = new System.Drawing.Size(342, 262);
            this.UserButtonPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(79, 46);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // CKey
            // 
            this.CKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CKey.Location = new System.Drawing.Point(88, 3);
            this.CKey.Name = "CKey";
            this.CKey.Size = new System.Drawing.Size(79, 46);
            this.CKey.TabIndex = 1;
            this.CKey.Text = "C";
            this.CKey.UseVisualStyleBackColor = true;
            this.CKey.Click += new System.EventHandler(this.CKey_Click);
            // 
            // Del
            // 
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.Location = new System.Drawing.Point(173, 3);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(79, 46);
            this.Del.TabIndex = 2;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Division
            // 
            this.Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Division.Location = new System.Drawing.Point(258, 3);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(81, 46);
            this.Division.TabIndex = 3;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // One
            // 
            this.One.Dock = System.Windows.Forms.DockStyle.Fill;
            this.One.Location = new System.Drawing.Point(3, 55);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(79, 46);
            this.One.TabIndex = 4;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Two.Location = new System.Drawing.Point(88, 55);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(79, 46);
            this.Two.TabIndex = 5;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Three.Location = new System.Drawing.Point(173, 55);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(79, 46);
            this.Three.TabIndex = 6;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Four.Location = new System.Drawing.Point(3, 107);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(79, 46);
            this.Four.TabIndex = 7;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Five.Location = new System.Drawing.Point(88, 107);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(79, 46);
            this.Five.TabIndex = 8;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Six.Location = new System.Drawing.Point(173, 107);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(79, 46);
            this.Six.TabIndex = 9;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seven.Location = new System.Drawing.Point(3, 159);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(79, 46);
            this.Seven.TabIndex = 10;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight.Location = new System.Drawing.Point(88, 159);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(79, 46);
            this.Eight.TabIndex = 11;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine.Location = new System.Drawing.Point(173, 159);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(79, 46);
            this.Nine.TabIndex = 12;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Multiply
            // 
            this.Multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiply.Location = new System.Drawing.Point(258, 55);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(81, 46);
            this.Multiply.TabIndex = 13;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Minus
            // 
            this.Minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minus.Location = new System.Drawing.Point(258, 107);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(81, 46);
            this.Minus.TabIndex = 14;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Plus
            // 
            this.Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus.Location = new System.Drawing.Point(258, 159);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(81, 46);
            this.Plus.TabIndex = 15;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Sign
            // 
            this.Sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sign.Location = new System.Drawing.Point(3, 211);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(79, 48);
            this.Sign.TabIndex = 16;
            this.Sign.Text = "Sign";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // Zero
            // 
            this.Zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zero.Location = new System.Drawing.Point(88, 211);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(79, 48);
            this.Zero.TabIndex = 17;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Dot
            // 
            this.Dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dot.Location = new System.Drawing.Point(173, 211);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(79, 48);
            this.Dot.TabIndex = 18;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Equals
            // 
            this.Equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equals.Location = new System.Drawing.Point(258, 211);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(81, 48);
            this.Equals.TabIndex = 19;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(378, 347);
            this.Controls.Add(this.UserButtonPanel);
            this.Controls.Add(this.InputInfo);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(299, 302);
            this.Name = "Form1";
            this.Text = " ";
            this.UserButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label InputInfo;
        private System.Windows.Forms.TableLayoutPanel UserButtonPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button CKey;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Equals;
    }
}

