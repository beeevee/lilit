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
    public partial class font : Form
    {
        public font()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создайте новую форму, которую вы хотите открыть
            menu form2 = new menu();
            // Откройте новую форму
            form2.Show();
            // Закройте текущую форму (если это необходимо)
            this.Close();
        }
    }
}
