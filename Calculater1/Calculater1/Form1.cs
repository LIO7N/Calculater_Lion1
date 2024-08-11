using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + (".");
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("3");
        }
        float num;
        int count;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                txtresualt.Text = textstore.Text + "-";
                textstore.Clear();
                count = 1;
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            num = float.Parse(textstore.Text);
            txtresualt.Text = textstore.Text + "+";
            textstore.Clear();
            count = 2;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            num = float.Parse(textstore.Text);
            txtresualt.Text = textstore.Text + "x";
            textstore.Clear();
            count = 3;
        }

        private void guna2Button15_Click_1(object sender, EventArgs e)
        {
            num = float.Parse(textstore.Text);
            txtresualt.Text = textstore.Text + "%";
            textstore.Clear();
            count = 5;
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("4");
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("9");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("6");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("0");
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("1");
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("2");
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("5");
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("7");
        }

        private void btneghit_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ("8");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresualt.Clear();
            textstore.Clear();
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(textstore.Text);
                    txtresualt.Text = txtresualt.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(textstore.Text);
                    txtresualt.Text = txtresualt.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textstore.Text);
                    txtresualt.Text = txtresualt.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textstore.Text);
                    txtresualt.Text = txtresualt.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(textstore.Text);
                    txtresualt.Text = txtresualt.Text + textstore.Text + "=" + ans;
                    textstore.Text = ans.ToString();
                    break;
            }
        }

        private void btndevide_Click(object sender, EventArgs e)
        {
            num = float.Parse(textstore.Text);
            txtresualt.Text = textstore.Text + "/";
            textstore.Clear();
            count = 4;
        }
    }
}
