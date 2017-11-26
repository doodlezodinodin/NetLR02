namespace LabaRab2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCount = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(526, 27);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(159, 26);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Количество чисел в тексте";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Enabled = false;
            this.richTextBox.Location = new System.Drawing.Point(12, 26);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(508, 212);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(12, 253);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(131, 33);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(526, 212);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 26);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редактировать файл";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 300);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ПNet LR02";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

