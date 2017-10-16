using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinderTest
{
    public partial class Form1 : Form
    {
        BindingList<Fruit> lstFruits;
        public Form1()
        {
            InitializeComponent();
            lstFruits = new BindingList<Fruit>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lstFruits;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstFruits.Add(new Fruit { FruitName = txtFruitName.Text, FruitColor = txtFruitColor.Text });
        }
    }
}
