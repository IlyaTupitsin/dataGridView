using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;


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
            dataGridView1.RowCount = 30; //Указываем количество строк
            dataGridView1.ColumnCount = 1; //Указываем количество столбцов
            int[,] a = new int[30, 1]; //Инициализируем массив
            int i, j;
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 30; i++)
                for (j = 0; j < 1; j++)
                    a[i, j] = rand.Next(-10, 10);
            //Выводим матрицу в dataGridView1
            for (i = 0; i < 30; i++)
                for (j = 0; j < 1; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
            for (int x = 0; x < 30; x++)
            {
                dataGridView1.Rows[x].HeaderCell.Value = x + 1 + "  ";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                list.Add(int.Parse(dataGridView1[0, j].Value.ToString()));
            }
            list.Sort((a, b) => b.CompareTo(a));
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                dataGridView1[0, j].Value = list[j];
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


        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            string[] lines = File.ReadAllLines(@"C:\Users\Пользователь\Desktop\Текстовый документ.txt", Encoding.Default);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lines[i];
            }
            for (int i = 0; i < lines.Length; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = i + 1 + "";
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void отсортироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            List<int> list = new List<int>();
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                list.Add(int.Parse(dataGridView1[0, j].Value.ToString()));
            }
            list.Sort((a, b) => b.CompareTo(a));
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                dataGridView1[0, j].Value = list[j];
            }
        }

        private void эксельСОхранениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}