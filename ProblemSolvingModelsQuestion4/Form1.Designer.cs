namespace ProblemSolvingModelsQuestion4
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
            this.backgroungButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroungButton
            // 
            this.backgroungButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backgroungButton.Location = new System.Drawing.Point(2, -2);
            this.backgroungButton.Name = "backgroungButton";
            this.backgroungButton.Size = new System.Drawing.Size(798, 451);
            this.backgroungButton.TabIndex = 0;
            this.backgroungButton.Text = "Click on window to start";
            this.backgroungButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backgroungButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backgroungButton;
    }
}

