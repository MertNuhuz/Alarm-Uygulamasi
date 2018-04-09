namespace AlarmApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kronometre = new System.Windows.Forms.Timer(this.components);
            this.dakikaAyarla = new System.Windows.Forms.NumericUpDown();
            this.yenidenKur = new System.Windows.Forms.Button();
            this.onDakikaButton = new System.Windows.Forms.Button();
            this.otuzDakikaButton = new System.Windows.Forms.Button();
            this.saat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dakikaAyarla)).BeginInit();
            this.SuspendLayout();
            // 
            // kronometre
            // 
            this.kronometre.Tick += new System.EventHandler(this.kronometre_Tick);
            // 
            // dakikaAyarla
            // 
            resources.ApplyResources(this.dakikaAyarla, "dakikaAyarla");
            this.dakikaAyarla.Name = "dakikaAyarla";
            // 
            // yenidenKur
            // 
            resources.ApplyResources(this.yenidenKur, "yenidenKur");
            this.yenidenKur.Name = "yenidenKur";
            this.yenidenKur.UseVisualStyleBackColor = true;
            this.yenidenKur.Click += new System.EventHandler(this.yenidenKur_Click);
            // 
            // onDakikaButton
            // 
            resources.ApplyResources(this.onDakikaButton, "onDakikaButton");
            this.onDakikaButton.Name = "onDakikaButton";
            this.onDakikaButton.UseVisualStyleBackColor = true;
            this.onDakikaButton.Click += new System.EventHandler(this.onDakikaButton_Click);
            // 
            // otuzDakikaButton
            // 
            resources.ApplyResources(this.otuzDakikaButton, "otuzDakikaButton");
            this.otuzDakikaButton.Name = "otuzDakikaButton";
            this.otuzDakikaButton.UseVisualStyleBackColor = true;
            this.otuzDakikaButton.Click += new System.EventHandler(this.otuzDakikaButton_Click);
            // 
            // saat
            // 
            resources.ApplyResources(this.saat, "saat");
            this.saat.Name = "saat";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.otuzDakikaButton);
            this.Controls.Add(this.onDakikaButton);
            this.Controls.Add(this.yenidenKur);
            this.Controls.Add(this.dakikaAyarla);
            this.Controls.Add(this.saat);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dakikaAyarla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer kronometre;
        private System.Windows.Forms.NumericUpDown dakikaAyarla;
        private System.Windows.Forms.Button yenidenKur;
        private System.Windows.Forms.Button onDakikaButton;
        private System.Windows.Forms.Button otuzDakikaButton;
        private System.Windows.Forms.Label saat;
    }
}

