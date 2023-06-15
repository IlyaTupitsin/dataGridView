namespace урок_4._03._23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            отсортироватьToolStripMenuItem1 = new ToolStripMenuItem();
            массивToolStripMenuItem = new ToolStripMenuItem();
            выввестиToolStripMenuItem = new ToolStripMenuItem();
            отсортироватьToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, массивToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(740, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(164, 26);
            сохранитьToolStripMenuItem.Text = "сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отсортироватьToolStripMenuItem1 });
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(164, 26);
            открытьToolStripMenuItem.Text = "открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // отсортироватьToolStripMenuItem1
            // 
            отсортироватьToolStripMenuItem1.Name = "отсортироватьToolStripMenuItem1";
            отсортироватьToolStripMenuItem1.Size = new Size(199, 26);
            отсортироватьToolStripMenuItem1.Text = "отсортировать ";
            отсортироватьToolStripMenuItem1.Click += отсортироватьToolStripMenuItem1_Click;
            // 
            // массивToolStripMenuItem
            // 
            массивToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выввестиToolStripMenuItem, отсортироватьToolStripMenuItem });
            массивToolStripMenuItem.Name = "массивToolStripMenuItem";
            массивToolStripMenuItem.Size = new Size(73, 24);
            массивToolStripMenuItem.Text = "массив";
            // 
            // выввестиToolStripMenuItem
            // 
            выввестиToolStripMenuItem.Name = "выввестиToolStripMenuItem";
            выввестиToolStripMenuItem.Size = new Size(224, 26);
            выввестиToolStripMenuItem.Text = "выввести";
            выввестиToolStripMenuItem.Click += выввестиToolStripMenuItem_Click;
            // 
            // отсортироватьToolStripMenuItem
            // 
            отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
            отсортироватьToolStripMenuItem.Size = new Size(224, 26);
            отсортироватьToolStripMenuItem.Text = "отсортировать";
            отсортироватьToolStripMenuItem.Click += отсортироватьToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 59;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(205, 477);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // button1
            // 
            button1.Location = new Point(277, 57);
            button1.Name = "button1";
            button1.Size = new Size(126, 60);
            button1.TabIndex = 2;
            button1.Text = "вывести массив";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(277, 174);
            button2.Name = "button2";
            button2.Size = new Size(126, 60);
            button2.TabIndex = 3;
            button2.Text = "отсортировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(277, 297);
            button3.Name = "button3";
            button3.Size = new Size(126, 60);
            button3.TabIndex = 4;
            button3.Text = "график";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 568);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem массивToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem выввестиToolStripMenuItem;
        private ToolStripMenuItem отсортироватьToolStripMenuItem;
        private ToolStripMenuItem отсортироватьToolStripMenuItem1;
        private Button button3;
    }
}