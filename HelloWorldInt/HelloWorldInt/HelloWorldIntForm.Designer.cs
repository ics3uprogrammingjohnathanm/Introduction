namespace HelloWorldInt
{
    partial class frmHelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorld));
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radBengali = new System.Windows.Forms.RadioButton();
            this.radChinese = new System.Windows.Forms.RadioButton();
            this.radGerman = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloWorld.Font = new System.Drawing.Font("Tekton Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.Red;
            this.lblHelloWorld.Location = new System.Drawing.Point(230, 55);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(350, 78);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.BackColor = System.Drawing.Color.Transparent;
            this.radEnglish.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.ForeColor = System.Drawing.SystemColors.Control;
            this.radEnglish.Location = new System.Drawing.Point(33, 12);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(113, 37);
            this.radEnglish.TabIndex = 1;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = false;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.radEnglish_CheckedChanged);
            // 
            // radBengali
            // 
            this.radBengali.AutoSize = true;
            this.radBengali.BackColor = System.Drawing.Color.Transparent;
            this.radBengali.Font = new System.Drawing.Font("Tekton Pro Ext", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBengali.ForeColor = System.Drawing.SystemColors.Control;
            this.radBengali.Location = new System.Drawing.Point(33, 55);
            this.radBengali.Name = "radBengali";
            this.radBengali.Size = new System.Drawing.Size(137, 37);
            this.radBengali.TabIndex = 2;
            this.radBengali.TabStop = true;
            this.radBengali.Text = "Bengali";
            this.radBengali.UseVisualStyleBackColor = false;
            this.radBengali.CheckedChanged += new System.EventHandler(this.radBengali_CheckedChanged);
            // 
            // radChinese
            // 
            this.radChinese.AutoSize = true;
            this.radChinese.BackColor = System.Drawing.Color.Transparent;
            this.radChinese.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChinese.ForeColor = System.Drawing.SystemColors.Control;
            this.radChinese.Location = new System.Drawing.Point(33, 98);
            this.radChinese.Name = "radChinese";
            this.radChinese.Size = new System.Drawing.Size(120, 37);
            this.radChinese.TabIndex = 3;
            this.radChinese.TabStop = true;
            this.radChinese.Text = "Chinese";
            this.radChinese.UseVisualStyleBackColor = false;
            this.radChinese.CheckedChanged += new System.EventHandler(this.radChinese_CheckedChanged);
            // 
            // radGerman
            // 
            this.radGerman.AutoSize = true;
            this.radGerman.BackColor = System.Drawing.Color.Transparent;
            this.radGerman.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGerman.ForeColor = System.Drawing.SystemColors.Control;
            this.radGerman.Location = new System.Drawing.Point(33, 141);
            this.radGerman.Name = "radGerman";
            this.radGerman.Size = new System.Drawing.Size(120, 37);
            this.radGerman.TabIndex = 4;
            this.radGerman.TabStop = true;
            this.radGerman.Text = "German";
            this.radGerman.UseVisualStyleBackColor = false;
            this.radGerman.CheckedChanged += new System.EventHandler(this.radGerman_CheckedChanged);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 361);
            this.Controls.Add(this.radGerman);
            this.Controls.Add(this.radChinese);
            this.Controls.Add(this.radBengali);
            this.Controls.Add(this.radEnglish);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World International";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radBengali;
        private System.Windows.Forms.RadioButton radChinese;
        private System.Windows.Forms.RadioButton radGerman;
    }
}

