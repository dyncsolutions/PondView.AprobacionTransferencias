namespace PondView.AprobacionTransferencias
{
    partial class PVSVC00100
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProcess.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnProcess, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnProcess.FlatAppearance.BorderSize = 0;
            this.btnProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Image = global::PondView.AprobacionTransferencias.Properties.Resources.Toolbar_Post;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(12, 0);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(92, 24);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // PVSVC00100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 268);
            this.Controls.Add(this.btnProcess);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PVSVC00100";
            this.Text = "Autorizar Transferencias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
    }
}

