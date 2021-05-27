using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashTable.HashTabel;

namespace HashTable
{
    public partial class Form1 : Form
    {
        Hash<string> hash;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(3, 7, 12);
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Location = new Point(this.Width / 2 - btnAdd.Size.Width / 2, this.Height / 2 - btnAdd.Size.Height / 2);
            btnFind.Location = new Point(tbValue.Location.X, tbValue.Location.Y + tbValue.Size.Height + 50);
            btnGetHash.Location = new Point(tbGetHash.Location.X, tbGetHash.Location.Y + tbGetHash.Size.Height + 50);
            btnFind.Size = new Size(100, 50);
            btnGetHash.Size = new Size(100, 50);

            lbKey.Location = new Point(250, lbKey.Location.Y);
            lbValue.Location = new Point(this.Width / 2 - lbValue.Size.Width / 2, lbValue.Location.Y);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamReader path = new StreamReader(@"Files\DataBase.txt");
            int count = 0;

            while (!path.EndOfStream)
            {
                count++;
                //cbNumEl.Text += count.ToString() + "\n";
                path.ReadLine();
            }

            hash = new Hash<string>(count / 2);
            path.Close();

            path = new StreamReader(@"Files\DataBase.txt");

            while (!path.EndOfStream)
            {
                hash.Add(path.ReadLine());
                
            }

            lbCount.Text = hash.items.Length.ToString();

            btnFind.Visible = true;
            btnGetHash.Visible = true;
            btnAdd.Visible = false;

            //for (int i = 0; i < hash.items.Length; i++)
            //{
            //    if (hash.items[i] != null)
            //        lbHashFunc.Text += i.ToString() + ": " + hash.items[i].Count + "\n";

            //    else
            //        lbHashFunc.Text += i.ToString() + ": null\n";
            //}
        }

        private void ViewData()
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lbValue.Text = "";

            List<string> list = new List<string>();

            if (tbValue.TextLength != 0)
                list = hash.GetList(int.Parse(tbValue.Text));

            if(list != null)
            {
                foreach (var el in list)
                {
                    lbValue.Text += el + "\n";
                }
            }

            else
            {
                lbValue.Text += "null";
            }
        }

        private void btnGetHash_Click(object sender, EventArgs e)
        {
            lbKey.Text = "";

            if (tbGetHash.TextLength != 0)
                lbKey.Text = hash.GetHash(tbGetHash.Text).ToString();
        }
    }
}
