using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinarTree.Tree;

namespace BinarTree
{
    public partial class Form1 : Form
    {
        int tick;

        PictureBox startAnim;

        BinaryTree<int> tree;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Black;

            lbOutrandom.Text = "";
            lbCLR.Text = "";
            lbLCR.Text = "";
            lbRCL.Text = "";

            btCLR.Visible = false;
            btLCR.Visible = false;
            btRCL.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            var videoFile = new OpenFileDialog();

            #region startAnim
            startAnim = new PictureBox();
            startAnim.BackColor = Color.White;
            startAnim.Visible = true;
            startAnim.Image = new Bitmap(@"Files\startVideoGIF.gif");
            startAnim.Size = new Size(startAnim.Image.Width, startAnim.Image.Height);
            startAnim.Location = new Point(this.Width / 2 - startAnim.Width / 2, this.Height / 2 - startAnim.Height / 2);

            this.Controls.Add(startAnim);

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

            #endregion


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            lbOutrandom.Text = "";
            tree = new BinaryTree<int>();

            Random rand = new Random();

            int r = 0;

            for (int i = 0; i < 5; i++)
            {
                r = rand.Next(0, 100);
                tree.Add(r);
                lbOutrandom.Text += r + " ";
            }
            lbCount.Text = tree.Count.ToString();
            LoadMenu();
        }

        private void LoadMenu()
        {
            if (timer1.Enabled)
            {
                this.Controls.Remove(startAnim);
                //startAnim.Image.Dispose();

                btCLR.Visible = true;
                btLCR.Visible = true;
                btRCL.Visible = true;
                btnAdd.Visible = true;
                btnDel.Visible = true;
                btnFind.Visible = true;

                tbAdd.Visible = true;
                tbDel.Visible = true;
                tbFind.Visible = true;

            }

            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++tick == 9)
            {
                LoadMenu();
            }
        }

        enum Command
        {
            clr,
            lcr,
            rcl
        }

        private void Traversal(Label lb, Command comm)
        {
            lb.Text = "";
            List<int> trav = new List<int>();

            switch (comm)
            {
                case Command.clr:
                    trav = tree.CLR();
                    break;

                case Command.lcr:
                    trav = tree.LCR();
                    break;

                case Command.rcl:
                    trav = tree.RCL();
                    break;
            }
            

            foreach (var el in trav) lb.Text += el + " ";
        }

        private void btCLR_Click(object sender, EventArgs e) => Traversal(lbCLR, Command.clr);

        private void btLCR_Click(object sender, EventArgs e) => Traversal(lbLCR, Command.lcr);

        private void btRCL_Click(object sender, EventArgs e) => Traversal(lbRCL, Command.rcl);

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbAdd.TextLength != 0)
                tree.Add(int.Parse(tbAdd.Text));

            Update();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bool find = tbFind.TextLength != 0 ? tree.Find(int.Parse(tbFind.Text)) : false;
            lbFind.Text = find.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(tbDel.TextLength != 0)
            {
                tree.Delete(int.Parse(tbDel.Text));

                Update();
            }
        }

        private void Update()
        {
            Traversal(lbCLR, Command.clr);
            Traversal(lbLCR, Command.lcr);
            Traversal(lbRCL, Command.rcl);

            lbCount.Text = tree.Count.ToString();
        }
    }
}
