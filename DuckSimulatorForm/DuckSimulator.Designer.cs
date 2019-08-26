namespace Duck_Simulation
{
    partial class DuckSimulator
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
            this.displayBtn = new System.Windows.Forms.Button();
            this.quackBtn = new System.Windows.Forms.Button();
            this.flyBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decoyRB = new System.Windows.Forms.RadioButton();
            this.rubberRB = new System.Windows.Forms.RadioButton();
            this.ReadheadRB = new System.Windows.Forms.RadioButton();
            this.mallardRB = new System.Windows.Forms.RadioButton();
            this.displayLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(359, 124);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(131, 46);
            this.displayBtn.TabIndex = 0;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // quackBtn
            // 
            this.quackBtn.Location = new System.Drawing.Point(359, 188);
            this.quackBtn.Name = "quackBtn";
            this.quackBtn.Size = new System.Drawing.Size(131, 46);
            this.quackBtn.TabIndex = 1;
            this.quackBtn.Text = "Quack";
            this.quackBtn.UseVisualStyleBackColor = true;
            this.quackBtn.Click += new System.EventHandler(this.QuackBtn_Click);
            // 
            // flyBtn
            // 
            this.flyBtn.Location = new System.Drawing.Point(359, 250);
            this.flyBtn.Name = "flyBtn";
            this.flyBtn.Size = new System.Drawing.Size(131, 46);
            this.flyBtn.TabIndex = 2;
            this.flyBtn.Text = "Fly";
            this.flyBtn.UseVisualStyleBackColor = true;
            this.flyBtn.Click += new System.EventHandler(this.FlyBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decoyRB);
            this.groupBox1.Controls.Add(this.rubberRB);
            this.groupBox1.Controls.Add(this.ReadheadRB);
            this.groupBox1.Controls.Add(this.mallardRB);
            this.groupBox1.Location = new System.Drawing.Point(64, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duck Type";
            // 
            // decoyRB
            // 
            this.decoyRB.AutoSize = true;
            this.decoyRB.Location = new System.Drawing.Point(6, 144);
            this.decoyRB.Name = "decoyRB";
            this.decoyRB.Size = new System.Drawing.Size(85, 17);
            this.decoyRB.TabIndex = 3;
            this.decoyRB.TabStop = true;
            this.decoyRB.Text = "Decoy Duck";
            this.decoyRB.UseVisualStyleBackColor = true;
            this.decoyRB.CheckedChanged += new System.EventHandler(this.DecoyRB_CheckedChanged);
            // 
            // rubberRB
            // 
            this.rubberRB.AutoSize = true;
            this.rubberRB.Location = new System.Drawing.Point(6, 104);
            this.rubberRB.Name = "rubberRB";
            this.rubberRB.Size = new System.Drawing.Size(89, 17);
            this.rubberRB.TabIndex = 2;
            this.rubberRB.TabStop = true;
            this.rubberRB.Text = "Rubber Duck";
            this.rubberRB.UseVisualStyleBackColor = true;
            this.rubberRB.CheckedChanged += new System.EventHandler(this.RubberRB_CheckedChanged);
            // 
            // ReadheadRB
            // 
            this.ReadheadRB.AutoSize = true;
            this.ReadheadRB.Location = new System.Drawing.Point(6, 64);
            this.ReadheadRB.Name = "ReadheadRB";
            this.ReadheadRB.Size = new System.Drawing.Size(104, 17);
            this.ReadheadRB.TabIndex = 1;
            this.ReadheadRB.TabStop = true;
            this.ReadheadRB.Text = "Readhead Duck";
            this.ReadheadRB.UseVisualStyleBackColor = true;
            this.ReadheadRB.CheckedChanged += new System.EventHandler(this.ReadheadRB_CheckedChanged);
            // 
            // mallardRB
            // 
            this.mallardRB.AutoSize = true;
            this.mallardRB.Location = new System.Drawing.Point(6, 24);
            this.mallardRB.Name = "mallardRB";
            this.mallardRB.Size = new System.Drawing.Size(88, 17);
            this.mallardRB.TabIndex = 0;
            this.mallardRB.TabStop = true;
            this.mallardRB.Text = "Mallard Duck";
            this.mallardRB.UseVisualStyleBackColor = true;
            this.mallardRB.CheckedChanged += new System.EventHandler(this.MallardRB_CheckedChanged);
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Location = new System.Drawing.Point(64, 323);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(0, 13);
            this.displayLbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duck Simulator";
            // 
            // DuckSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flyBtn);
            this.Controls.Add(this.quackBtn);
            this.Controls.Add(this.displayBtn);
            this.Name = "DuckSimulator";
            this.Text = "DuckSimulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button quackBtn;
        private System.Windows.Forms.Button flyBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decoyRB;
        private System.Windows.Forms.RadioButton rubberRB;
        private System.Windows.Forms.RadioButton ReadheadRB;
        private System.Windows.Forms.RadioButton mallardRB;
        private System.Windows.Forms.Label displayLbl;
        private System.Windows.Forms.Label label1;
    }
}