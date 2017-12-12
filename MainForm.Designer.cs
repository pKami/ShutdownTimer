namespace ShutdownTimer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnShutdown = new System.Windows.Forms.Button();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.cbForce = new System.Windows.Forms.CheckBox();
            this.cbRestart = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.nudHours = new ShutdownTimer.MyNumericUpDown();
            this.nudMinutes = new ShutdownTimer.MyNumericUpDown();
            this.nudSeconds = new ShutdownTimer.MyNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Firebrick;
            this.btnShutdown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShutdown.Location = new System.Drawing.Point(12, 43);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(238, 45);
            this.btnShutdown.TabIndex = 5;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Location = new System.Drawing.Point(235, 15);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(15, 17);
            this.lbSeconds.TabIndex = 20;
            this.lbSeconds.Text = "s";
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Location = new System.Drawing.Point(148, 15);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(19, 17);
            this.lbMinutes.TabIndex = 19;
            this.lbMinutes.Text = "m";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(62, 15);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(16, 17);
            this.lbHours.TabIndex = 22;
            this.lbHours.Text = "h";
            // 
            // cbForce
            // 
            this.cbForce.AutoSize = true;
            this.cbForce.Location = new System.Drawing.Point(263, 35);
            this.cbForce.Name = "cbForce";
            this.cbForce.Size = new System.Drawing.Size(62, 21);
            this.cbForce.TabIndex = 3;
            this.cbForce.Text = "force";
            this.cbForce.UseVisualStyleBackColor = true;
            // 
            // cbRestart
            // 
            this.cbRestart.AutoSize = true;
            this.cbRestart.Location = new System.Drawing.Point(263, 63);
            this.cbRestart.Name = "cbRestart";
            this.cbRestart.Size = new System.Drawing.Size(71, 21);
            this.cbRestart.TabIndex = 4;
            this.cbRestart.Text = "restart";
            this.cbRestart.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = global::ShutdownTimer.Properties.Resources.InfoIcon;
            this.btnAbout.Location = new System.Drawing.Point(308, 5);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(20, 20);
            this.btnAbout.TabIndex = 23;
            this.btnAbout.TabStop = false;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(13, 11);
            this.nudHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(45, 22);
            this.nudHours.TabIndex = 0;
            this.nudHours.Enter += new System.EventHandler(this.inputControl_SelectAllText);
            this.nudHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputControl_KeyPress);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(99, 11);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(45, 22);
            this.nudMinutes.TabIndex = 1;
            this.nudMinutes.Enter += new System.EventHandler(this.inputControl_SelectAllText);
            this.nudMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputControl_KeyPress);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(186, 11);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(45, 22);
            this.nudSeconds.TabIndex = 2;
            this.nudSeconds.Enter += new System.EventHandler(this.inputControl_SelectAllText);
            this.nudSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputControl_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 99);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.cbRestart);
            this.Controls.Add(this.cbForce);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.nudHours);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.btnShutdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShutdownTimer";
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShutdown;
        private ShutdownTimer.MyNumericUpDown nudSeconds;
        private ShutdownTimer.MyNumericUpDown nudMinutes;
        private ShutdownTimer.MyNumericUpDown nudHours;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.CheckBox cbForce;
        private System.Windows.Forms.CheckBox cbRestart;
        private System.Windows.Forms.Button btnAbout;
    }
}

