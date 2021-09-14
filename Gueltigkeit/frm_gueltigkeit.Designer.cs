
namespace Gueltigkeit
{
    partial class frm_gueltigkeit
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_gueltigkeit_1 = new System.Windows.Forms.Button();
            this.btn_gueltigkeit_2 = new System.Windows.Forms.Button();
            this.lbl_gueltigkeit_1 = new System.Windows.Forms.Label();
            this.lbl_gueltigkeit_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gueltigkeit_1
            // 
            this.btn_gueltigkeit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gueltigkeit_1.Location = new System.Drawing.Point(12, 111);
            this.btn_gueltigkeit_1.Name = "btn_gueltigkeit_1";
            this.btn_gueltigkeit_1.Size = new System.Drawing.Size(395, 67);
            this.btn_gueltigkeit_1.TabIndex = 0;
            this.btn_gueltigkeit_1.Text = "Anzeige Gültigkeitsbereich 1";
            this.btn_gueltigkeit_1.UseVisualStyleBackColor = true;
            this.btn_gueltigkeit_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_gueltigkeit_2
            // 
            this.btn_gueltigkeit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gueltigkeit_2.Location = new System.Drawing.Point(12, 196);
            this.btn_gueltigkeit_2.Name = "btn_gueltigkeit_2";
            this.btn_gueltigkeit_2.Size = new System.Drawing.Size(395, 67);
            this.btn_gueltigkeit_2.TabIndex = 1;
            this.btn_gueltigkeit_2.Text = "Anzeige Gültigkeitsbereich 2";
            this.btn_gueltigkeit_2.UseVisualStyleBackColor = true;
            this.btn_gueltigkeit_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_gueltigkeit_1
            // 
            this.lbl_gueltigkeit_1.AutoSize = true;
            this.lbl_gueltigkeit_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gueltigkeit_1.Location = new System.Drawing.Point(448, 128);
            this.lbl_gueltigkeit_1.Name = "lbl_gueltigkeit_1";
            this.lbl_gueltigkeit_1.Size = new System.Drawing.Size(321, 26);
            this.lbl_gueltigkeit_1.TabIndex = 2;
            this.lbl_gueltigkeit_1.Text = "Hier steht gleich etwas anderes!";
            // 
            // lbl_gueltigkeit_2
            // 
            this.lbl_gueltigkeit_2.AutoSize = true;
            this.lbl_gueltigkeit_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gueltigkeit_2.Location = new System.Drawing.Point(448, 216);
            this.lbl_gueltigkeit_2.Name = "lbl_gueltigkeit_2";
            this.lbl_gueltigkeit_2.Size = new System.Drawing.Size(321, 26);
            this.lbl_gueltigkeit_2.TabIndex = 3;
            this.lbl_gueltigkeit_2.Text = "Hier steht gleich etwas anderes!";
            // 
            // frm_gueltigkeit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_gueltigkeit_2);
            this.Controls.Add(this.lbl_gueltigkeit_1);
            this.Controls.Add(this.btn_gueltigkeit_2);
            this.Controls.Add(this.btn_gueltigkeit_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_gueltigkeit";
            this.Text = "Gueltigkeitsbereich von Variablen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gueltigkeit_1;
        private System.Windows.Forms.Button btn_gueltigkeit_2;
        private System.Windows.Forms.Label lbl_gueltigkeit_1;
        private System.Windows.Forms.Label lbl_gueltigkeit_2;
    }
}

