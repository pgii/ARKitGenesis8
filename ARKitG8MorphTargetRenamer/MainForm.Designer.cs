namespace ARKitG8MorphTargetRenamer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDragFile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDragFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDragFile
            // 
            this.pnlDragFile.AllowDrop = true;
            this.pnlDragFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlDragFile.Controls.Add(this.label1);
            this.pnlDragFile.Location = new System.Drawing.Point(13, 13);
            this.pnlDragFile.Name = "pnlDragFile";
            this.pnlDragFile.Size = new System.Drawing.Size(237, 196);
            this.pnlDragFile.TabIndex = 0;
            this.pnlDragFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDragFile_DragDrop);
            this.pnlDragFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDragFile_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag ASCII FBX the file here.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 222);
            this.Controls.Add(this.pnlDragFile);
            this.Name = "MainForm";
            this.Text = "ARKitG8MorphTargetRenamer";
            this.TopMost = true;
            this.pnlDragFile.ResumeLayout(false);
            this.pnlDragFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDragFile;
        private System.Windows.Forms.Label label1;
    }
}

