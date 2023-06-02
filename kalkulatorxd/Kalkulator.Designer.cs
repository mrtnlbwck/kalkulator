namespace kalkulatorxd
{
    partial class Kalkulator
    {

        Cyfrowy okno2;
        Analogowy okno4;
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trybToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybDarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zegarAnalogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zegarCyfrowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOperationFirst = new System.Windows.Forms.Label();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trybToolStripMenuItem,
            this.zegarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trybToolStripMenuItem
            // 
            this.trybToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trybDarkToolStripMenuItem,
            this.trybLightToolStripMenuItem});
            this.trybToolStripMenuItem.Name = "trybToolStripMenuItem";
            this.trybToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.trybToolStripMenuItem.Text = "Tryb";
            // 
            // trybDarkToolStripMenuItem
            // 
            this.trybDarkToolStripMenuItem.Name = "trybDarkToolStripMenuItem";
            this.trybDarkToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.trybDarkToolStripMenuItem.Text = "Tryb ciemny";
            this.trybDarkToolStripMenuItem.Click += new System.EventHandler(this.trybDarkToolStripMenuItem_Click);
            // 
            // trybLightToolStripMenuItem
            // 
            this.trybLightToolStripMenuItem.Name = "trybLightToolStripMenuItem";
            this.trybLightToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.trybLightToolStripMenuItem.Text = "Tryb jasny";
            this.trybLightToolStripMenuItem.Click += new System.EventHandler(this.trybLightToolStripMenuItem_Click);
            // 
            // zegarToolStripMenuItem
            // 
            this.zegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zegarAnalogowyToolStripMenuItem,
            this.zegarCyfrowyToolStripMenuItem});
            this.zegarToolStripMenuItem.Name = "zegarToolStripMenuItem";
            this.zegarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.zegarToolStripMenuItem.Text = "Zegar";
            // 
            // zegarAnalogowyToolStripMenuItem
            // 
            this.zegarAnalogowyToolStripMenuItem.Name = "zegarAnalogowyToolStripMenuItem";
            this.zegarAnalogowyToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.zegarAnalogowyToolStripMenuItem.Text = "Zegar analogowy";
            this.zegarAnalogowyToolStripMenuItem.Click += new System.EventHandler(this.zegarAnalogowyToolStripMenuItem_Click);
            // 
            // zegarCyfrowyToolStripMenuItem
            // 
            this.zegarCyfrowyToolStripMenuItem.Name = "zegarCyfrowyToolStripMenuItem";
            this.zegarCyfrowyToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.zegarCyfrowyToolStripMenuItem.Text = "Zegar cyfrowy";
            this.zegarCyfrowyToolStripMenuItem.Click += new System.EventHandler(this.zegarCyfrowyToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumberClickButton);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(98, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumberClickButton);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(184, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumberClickButton);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumberClickButton);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(98, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumberClickButton);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Snow;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(185, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumberClickButton);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Snow;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(12, 203);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumberClickButton);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Snow;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(98, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumberClickButton);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Snow;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(184, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 80);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumberClickButton);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LavenderBlush;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(185, 119);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 80);
            this.button10.TabIndex = 10;
            this.button10.Text = "%";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.operationClickButton);
            this.button10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LavenderBlush;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(270, 119);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 80);
            this.button11.TabIndex = 11;
            this.button11.Text = "/";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.operationClickButton);
            this.button11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LavenderBlush;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(270, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 80);
            this.button12.TabIndex = 12;
            this.button12.Text = "x";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.operationClickButton);
            this.button12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LavenderBlush;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(271, 289);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 80);
            this.button13.TabIndex = 13;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.operationClickButton);
            this.button13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LavenderBlush;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(270, 375);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 80);
            this.button14.TabIndex = 14;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.operationClickButton);
            this.button14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Pink;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(270, 461);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 80);
            this.button15.TabIndex = 15;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.ResultButtonClick);
            this.button15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LavenderBlush;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(184, 461);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 80);
            this.button16.TabIndex = 16;
            this.button16.Text = ",";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.NumberClickButton);
            this.button16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Snow;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(13, 461);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(166, 80);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.NumberClickButton);
            this.button17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kalkulator_KeyPress);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LavenderBlush;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.Location = new System.Drawing.Point(12, 117);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 80);
            this.button18.TabIndex = 18;
            this.button18.Text = "CE";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.CEButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(13, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(337, 68);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LavenderBlush;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.Location = new System.Drawing.Point(99, 117);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(80, 80);
            this.button20.TabIndex = 21;
            this.button20.Text = "C";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.ClearAllButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 25;
            // 
            // labelOperationFirst
            // 
            this.labelOperationFirst.AutoSize = true;
            this.labelOperationFirst.BackColor = System.Drawing.Color.Snow;
            this.labelOperationFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOperationFirst.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelOperationFirst.Location = new System.Drawing.Point(14, 45);
            this.labelOperationFirst.Name = "labelOperationFirst";
            this.labelOperationFirst.Size = new System.Drawing.Size(0, 25);
            this.labelOperationFirst.TabIndex = 26;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Control;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentOperation.ForeColor = System.Drawing.Color.Silver;
            this.labelCurrentOperation.Location = new System.Drawing.Point(20, 52);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 20);
            this.labelCurrentOperation.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(358, 549);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.labelOperationFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trybToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybDarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zegarAnalogowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zegarCyfrowyToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOperationFirst;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}