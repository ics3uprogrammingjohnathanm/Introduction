namespace HelloWorldInt
{
    partial class HelloWorldIntForm
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
            System.Windows.Forms.Label lblHelloWorld;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloWorldIntForm));
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radBengali = new System.Windows.Forms.RadioButton();
            this.radRussian = new System.Windows.Forms.RadioButton();
            this.radSwedish = new System.Windows.Forms.RadioButton();
            lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.BackColor = System.Drawing.Color.Transparent;
            lblHelloWorld.Font = new System.Drawing.Font("SansSerif", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            lblHelloWorld.ForeColor = System.Drawing.Color.DodgerBlue;
            lblHelloWorld.Location = new System.Drawing.Point(276, 73);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new System.Drawing.Size(363, 74);
            lblHelloWorld.TabIndex = 4;
            lblHelloWorld.Text = "Hello World";
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.BackColor = System.Drawing.Color.Transparent;
            this.radEnglish.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.ForeColor = System.Drawing.SystemColors.Window;
            this.radEnglish.Location = new System.Drawing.Point(48, 51);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(88, 28);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = false;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radBengali
            // 
            this.radBengali.AutoSize = true;
            this.radBengali.BackColor = System.Drawing.Color.Transparent;
            this.radBengali.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBengali.ForeColor = System.Drawing.SystemColors.Window;
            this.radBengali.Location = new System.Drawing.Point(48, 85);
            this.radBengali.Name = "radBengali";
            this.radBengali.Size = new System.Drawing.Size(90, 28);
            this.radBengali.TabIndex = 1;
            this.radBengali.TabStop = true;
            this.radBengali.Text = "Bengali";
            this.radBengali.UseVisualStyleBackColor = false;
            this.radBengali.CheckedChanged += new System.EventHandler(this.radBengali_CheckedChanged);
            // 
            // radRussian
            // 
            this.radRussian.AutoSize = true;
            this.radRussian.BackColor = System.Drawing.Color.Transparent;
            this.radRussian.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRussian.ForeColor = System.Drawing.SystemColors.Window;
            this.radRussian.Location = new System.Drawing.Point(48, 119);
            this.radRussian.Name = "radRussian";
            this.radRussian.Size = new System.Drawing.Size(92, 28);
            this.radRussian.TabIndex = 2;
            this.radRussian.TabStop = true;
            this.radRussian.Text = "Russian";
            this.radRussian.UseVisualStyleBackColor = false;
            this.radRussian.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radSwedish
            // 
            this.radSwedish.AutoSize = true;
            this.radSwedish.BackColor = System.Drawing.Color.Transparent;
            this.radSwedish.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSwedish.ForeColor = System.Drawing.SystemColors.Window;
            this.radSwedish.Location = new System.Drawing.Point(50, 153);
            this.radSwedish.Name = "radSwedish";
            this.radSwedish.Size = new System.Drawing.Size(97, 28);
            this.radSwedish.TabIndex = 3;
            this.radSwedish.TabStop = true;
            this.radSwedish.Text = "Swedish";
            this.radSwedish.UseVisualStyleBackColor = false;
            this.radSwedish.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // HelloWorldIntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 397);
            this.Controls.Add(lblHelloWorld);
            this.Controls.Add(this.radSwedish);
            this.Controls.Add(this.radRussian);
            this.Controls.Add(this.radBengali);
            this.Controls.Add(this.radEnglish);
            this.Name = "HelloWorldIntForm";
            this.Text = "Hello World! International";
            this.Load += new System.EventHandler(this.HelloWorldIntForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radBengali;
        private System.Windows.Forms.RadioButton radRussian;
        private System.Windows.Forms.RadioButton radSwedish;
    }
}

