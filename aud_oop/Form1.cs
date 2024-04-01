using System.Data;
using System.Text;
using System.Windows.Forms;

namespace aud_oop
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Задача";
            dataGridView1.Columns[2].Name = "Дата";
            dataGridView1.Columns[3].Name = "Завершено";
            import_file("file.txt");
            count = dataGridView1.Rows.Count;
        }
        public void add_task()
        {
            if ((textBox1.Text != String.Empty) && (comboBox1.Text != String.Empty))
                dataGridView1.Rows.Add(count++, textBox1.Text, dateTimePicker1.Value.ToShortDateString(), comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_task();
            fill_bad_task();
        }
        private void del_el(string id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null && row.Cells["ID"].Value.ToString() == id)
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            del_el(textBox2.Text);
            fill_bad_task();
        }

        private void fill_bad_task()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                DateTime date;
                DateTime.TryParse(row.Cells["Дата"].Value.ToString(), out date);
                if (date < DateTime.Today)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                    }
                }
            }
        }
        private void go_to_file(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value + "\t");
                }
                sb.AppendLine();
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            go_to_file("file.txt");
        }
        private void import_file(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                dataGridView1.Rows.Clear();
                foreach (string line in lines)
                {
                    string[] values = line.Split('\t');
                    dataGridView1.Rows.Add(values);
                }
                fill_bad_task();
            }
        }
    }
}
