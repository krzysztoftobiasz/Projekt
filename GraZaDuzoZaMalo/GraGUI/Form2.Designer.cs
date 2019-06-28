namespace GraGUI
{
    partial class Form2
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
            this.listViewHistoria = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewHistoria
            // 
            this.listViewHistoria.GridLines = true;
            this.listViewHistoria.HideSelection = false;
            this.listViewHistoria.LabelEdit = true;
            this.listViewHistoria.Location = new System.Drawing.Point(0, 3);
            this.listViewHistoria.Name = "listViewHistoria";
            this.listViewHistoria.Size = new System.Drawing.Size(372, 295);
            this.listViewHistoria.TabIndex = 0;
            this.listViewHistoria.UseCompatibleStateImageBehavior = false;
            this.listViewHistoria.View = System.Windows.Forms.View.Details;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 297);
            this.Controls.Add(this.listViewHistoria);
            this.Name = "Form2";
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewHistoria;
    }
}