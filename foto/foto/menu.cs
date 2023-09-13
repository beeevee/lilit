using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foto
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создайте новую форму, которую вы хотите открыть
            Li form2 = new Li();
            // Откройте новую форму
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создайте новую форму, которую вы хотите открыть
            mond form2 = new mond();
            // Откройте новую форму
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Создайте новую форму, которую вы хотите открыть
            font form2 = new font();
            // Откройте новую форму
            form2.Show();
        }
    }
}
