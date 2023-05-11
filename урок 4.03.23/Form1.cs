using System.Text;

namespace урок_4._03._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.выввестиToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            this.отсортироватьToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1; //Указываем количество строк

            dataGridView1.ColumnCount = 15; //Указываем количество столбцов

            int[,] a = new int[1, 15]; //Инициализируем массив

            int i, j;

            //Заполняем матрицу случайными числами

            Random rand = new Random();

            for (i = 0; i < 1; i++)

                for (j = 0; j < 15; j++)

                    a[i, j] = rand.Next(-10, 10);

            //Выводим матрицу в dataGridView1

            for (i = 0; i < 1; i++)

                for (j = 0; j < 15; j++)

                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                list.Add(int.Parse(dataGridView1[j, 0].Value.ToString()));
            }
            list.Sort((a, b) => b.CompareTo(a));
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                dataGridView1[j, 0].Value = list[j];
            }

            

        }

        private void выввестиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отсортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                string text = dataGridView1.Text;
                SaveFileDialog open = new SaveFileDialog();

                open.ShowDialog();

                string path = open.FileName;

                try
                {

                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(text);
                        fs.Write(info, 0, info.Length);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}