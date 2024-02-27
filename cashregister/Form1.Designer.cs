namespace cashregister
{
    partial class Storefront
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storefront));
            this.nameLabel = new System.Windows.Forms.Label();
            this.glowstickLabel = new System.Windows.Forms.Label();
            this.shutGlasLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.stickInput = new System.Windows.Forms.TextBox();
            this.shutterInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.givenLabel = new System.Windows.Forms.Label();
            this.givenInput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Ravie", 25.25F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.nameLabel.Location = new System.Drawing.Point(107, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(420, 103);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Sasha\'s Party House";
            // 
            // glowstickLabel
            // 
            this.glowstickLabel.AutoSize = true;
            this.glowstickLabel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glowstickLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.glowstickLabel.Location = new System.Drawing.Point(30, 140);
            this.glowstickLabel.Name = "glowstickLabel";
            this.glowstickLabel.Size = new System.Drawing.Size(174, 22);
            this.glowstickLabel.TabIndex = 1;
            this.glowstickLabel.Text = "# of glowsticks";
            // 
            // shutGlasLabel
            // 
            this.shutGlasLabel.AutoSize = true;
            this.shutGlasLabel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutGlasLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.shutGlasLabel.Location = new System.Drawing.Point(30, 196);
            this.shutGlasLabel.Name = "shutGlasLabel";
            this.shutGlasLabel.Size = new System.Drawing.Size(222, 22);
            this.shutGlasLabel.TabIndex = 2;
            this.shutGlasLabel.Text = "# of shutterglasses";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.drinkLabel.Location = new System.Drawing.Point(30, 251);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(152, 22);
            this.drinkLabel.TabIndex = 3;
            this.drinkLabel.Text = "cups of drink";
            // 
            // stickInput
            // 
            this.stickInput.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stickInput.Location = new System.Drawing.Point(258, 142);
            this.stickInput.Name = "stickInput";
            this.stickInput.Size = new System.Drawing.Size(51, 30);
            this.stickInput.TabIndex = 4;
            this.stickInput.Text = "0";
            // 
            // shutterInput
            // 
            this.shutterInput.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutterInput.Location = new System.Drawing.Point(258, 199);
            this.shutterInput.Name = "shutterInput";
            this.shutterInput.Size = new System.Drawing.Size(51, 30);
            this.shutterInput.TabIndex = 5;
            this.shutterInput.Text = "0";
            // 
            // drinkInput
            // 
            this.drinkInput.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkInput.Location = new System.Drawing.Point(258, 250);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(51, 30);
            this.drinkInput.TabIndex = 6;
            this.drinkInput.Text = "0";
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.DarkViolet;
            this.totalButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalButton.Location = new System.Drawing.Point(94, 301);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(158, 27);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "total it";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.subtotalLabel.Location = new System.Drawing.Point(3, 352);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(111, 21);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "sub total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.taxLabel.Location = new System.Drawing.Point(56, 373);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(75, 21);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "taxes:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.totalLabel.Location = new System.Drawing.Point(90, 394);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(70, 21);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "total:";
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.GhostWhite;
            this.receiptLabel.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.ForeColor = System.Drawing.Color.Navy;
            this.receiptLabel.Location = new System.Drawing.Point(533, 99);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(251, 295);
            this.receiptLabel.TabIndex = 11;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // givenLabel
            // 
            this.givenLabel.AutoSize = true;
            this.givenLabel.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.givenLabel.Location = new System.Drawing.Point(377, 141);
            this.givenLabel.Name = "givenLabel";
            this.givenLabel.Size = new System.Drawing.Size(108, 21);
            this.givenLabel.TabIndex = 12;
            this.givenLabel.Text = "tendered:";
            // 
            // givenInput
            // 
            this.givenInput.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenInput.Location = new System.Drawing.Point(405, 165);
            this.givenInput.Name = "givenInput";
            this.givenInput.Size = new System.Drawing.Size(51, 28);
            this.givenInput.TabIndex = 13;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.changeLabel.Location = new System.Drawing.Point(389, 231);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(85, 21);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "change:";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkViolet;
            this.changeButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeButton.Location = new System.Drawing.Point(361, 194);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(134, 27);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "change me";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.DarkViolet;
            this.printButton.Enabled = false;
            this.printButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printButton.Location = new System.Drawing.Point(349, 301);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(158, 36);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Visible = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Aquamarine;
            this.doneButton.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.doneButton.Location = new System.Drawing.Point(588, 411);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(158, 27);
            this.doneButton.TabIndex = 17;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // Storefront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.givenInput);
            this.Controls.Add(this.givenLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.shutterInput);
            this.Controls.Add(this.stickInput);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.shutGlasLabel);
            this.Controls.Add(this.glowstickLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Storefront";
            this.Text = "SPH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label glowstickLabel;
        private System.Windows.Forms.Label shutGlasLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.TextBox stickInput;
        private System.Windows.Forms.TextBox shutterInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label givenLabel;
        private System.Windows.Forms.TextBox givenInput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button doneButton;
    }
}

