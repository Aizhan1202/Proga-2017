namespace Collision
{
    partial class Frame
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
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PaintPanel
            // 
            this.PaintPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PaintPanel.Location = new System.Drawing.Point(0, 0);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(286, 263);
            this.PaintPanel.TabIndex = 0;
            this.PaintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PaintPanel);
            this.Name = "Frame";
            this.Text = "Collision";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaintPanel;
    }
}

