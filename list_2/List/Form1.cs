using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    
    public partial class Form1 : Form
    {
        Thread t;

        Listt<int> workList;
        Listt<int> list;
        ListNode<int> goElelemnt;

        Rectangle menu;

        bool Start = false;

        int changeX = 5;
        int changeXTwo = 5;

        public Form1()
        {
            InitializeComponent();

            

            BackColor = Color.FromArgb(27, 29, 30);
            CreateList.BackColor = Color.FromArgb(157, 148, 136);

            TbId.BackColor = Color.FromArgb(27, 29, 30);
            TbAppend.BackColor = Color.FromArgb(27, 29, 30);
            TbDel.BackColor = Color.FromArgb(27, 29, 30);
            TbPrepend.BackColor = Color.FromArgb(27, 29, 30);

            BtnCreateInt.BackColor = Color.FromArgb(157, 148, 136);
            BtnCreateInt.Visible = false;

            BtnCreateStr.BackColor = Color.FromArgb(157, 148, 136);
            BtnCreateStr.Visible = false;

            BtnSort.BackColor = Color.FromArgb(157, 148, 136);
            BtnSort.Visible = false;

            BtnRemove.BackColor = Color.FromArgb(157, 148, 136);
            BtnRemove.Visible = false;

            btnAppend.BackColor = Color.FromArgb(157, 148, 136);
            btnAppend.Visible = false;

            BtnPrepend.BackColor = Color.FromArgb(157, 148, 136);
            BtnPrepend.Visible = false;

            BtnDelByIndex.BackColor = Color.FromArgb(157, 148, 136);
            BtnDelByIndex.Visible = false;

            BtnRight.BackColor = Color.FromArgb(157, 148, 136);
            
            BtnLeft.BackColor = Color.FromArgb(157, 148, 136);

            //LabelListOut.Text = "123455654645645";
            LabelRemove.Visible = false;
            LabelSort.Visible = false;
            TbId.Visible = false;
            TbAppend.Visible = false;
            TbPrepend.Visible = false;
            TbDel.Visible = false;

            this.WindowState = FormWindowState.Maximized;

            menu = new Rectangle(0, 0, BtnCreateStr.Location.X + BtnCreateStr.Size.Width + 300, 1500);

            labelLeftElement.Location = new Point(menu.Width + 200, labelLeftElement.Location.Y + 100);

            labelMainElement.Location = new Point(labelLeftElement.Location.X + labelLeftElement.Size.Width + 10, labelMainElement.Location.Y + 100);
            labelRightElement.Location = new Point(labelMainElement.Location.X + labelMainElement.Size.Width + 10, labelRightElement.Location.Y + 100);

            BtnLeft.Location = new Point(labelLeftElement.Location.X + labelLeftElement.Size.Width - BtnLeft.Size.Width, labelLeftElement.Location.Y + labelLeftElement.Size.Height);
            BtnRight.Location = new Point(labelRightElement.Location.X, labelRightElement.Location.Y + labelRightElement.Size.Height);
        }

        private void CreateIntRandList()
        {
            Random rand = new Random();

            list = new Listt<int>();
            workList = new Listt<int>();
            

            for(int i = 0; i < 10; i++)
            {
                list.Append(rand.Next(0, 10));
                workList.Append(list[i]);
                LabelListOut.Text += list[i].ToString();
            }
        }



        #region Animation And Draw
        private void MoveBtn()
        {
            Point finishLoc = new Point(CreateList.Location.X + CreateList.Size.Width + 10, CreateList.Location.Y + CreateList.Size.Height + 10);


            if (BtnCreateInt.Location.X > finishLoc.X - 30) { changeX = 2; }

            else if (BtnCreateInt.Location.X > finishLoc.X - 40) { changeX = 3; }

            else if (BtnCreateInt.Location.X > finishLoc.X - 60) { changeX = 4; }

            if (BtnCreateInt.Location.X > finishLoc.X) { Start = true; BtnCreateStr.Location = BtnCreateInt.Location; BtnCreateStr.Visible = true; }

            else
                BtnCreateInt.Location = new Point(BtnCreateInt.Location.X + changeX, BtnCreateInt.Location.Y);

        }

        private void MoveBtnTwo()
        {
            Point finishLoc = new Point(BtnCreateInt.Location.X + BtnCreateInt.Size.Width + 10, BtnCreateInt.Location.Y + BtnCreateInt.Size.Height + 10);

            int changeFinishLoc = 40;

            if (BtnCreateStr.Location.X > finishLoc.X - 30) { changeXTwo = 2; changeFinishLoc = 10; }

            else if (BtnCreateStr.Location.X > finishLoc.X - 40) { changeXTwo = 3; changeFinishLoc = 20; }

            else if (BtnCreateStr.Location.X > finishLoc.X - 60) { changeXTwo = 4; changeFinishLoc = 30; }

            if (BtnCreateStr.Location.X > finishLoc.X)
            {
                timer1.Enabled = false;
                Start = false;
            }
            else
            {
                BtnCreateStr.Location = new Point(BtnCreateStr.Location.X + changeXTwo, BtnCreateStr.Location.Y);
            }
        }

        private void DrawMenu(Graphics g, Rectangle rec)
        {
            g.DrawRectangle(new Pen(Color.FromArgb(157, 148, 136)), rec);
            g.FillRectangle(new SolidBrush(Color.FromArgb(18, 32, 56)), rec);
        }

        #endregion

        #region SystemMethod

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawMenu(e.Graphics, menu);

            
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (goElelemnt != null)
            {
                if (goElelemnt != null && goElelemnt.next.next != null)
                    goElelemnt = goElelemnt.next;

                if (goElelemnt.prev != null)
                    labelLeftElement.Text = goElelemnt.prev.data.ToString();

                labelMainElement.Text = goElelemnt.data.ToString();
                labelRightElement.Text = goElelemnt.next.data.ToString();
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if(goElelemnt != null)
            {
                if (goElelemnt.prev.prev != null)
                    goElelemnt = goElelemnt.prev;

                if (goElelemnt.prev != null)
                    labelLeftElement.Text = goElelemnt.prev.data.ToString();

                labelMainElement.Text = goElelemnt.data.ToString();
                labelRightElement.Text = goElelemnt.next.data.ToString();
            }
            
        }

        private void CreateList_Click(object sender, EventArgs e)
        {
            //CreateRandList();

            BtnCreateInt.Location = new Point(CreateList.Location.X + CreateList.Size.Width - BtnCreateInt.Size.Width, CreateList.Location.Y + CreateList.Size.Height - BtnCreateInt.Size.Height);
            BtnCreateInt.Visible = true;

            BtnCreateStr.Visible = false;

            changeX = 5;
            changeXTwo = 5;


            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Start) MoveBtn();

            else if (Start) MoveBtnTwo();
        }

        private void BtnCreateStr_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateInt_Click(object sender, EventArgs e)
        {
            LabelListOut.Text = "";
            labelRightElement.Text = "";
            labelLeftElement.Text = "";

            CreateIntRandList();

            goElelemnt = null;

            goElelemnt = list.First;

            labelMainElement.Text = workList.First.data.ToString();
            labelRightElement.Text = workList.First.next.data.ToString();

            BtnSort.Visible = true;
            BtnRemove.Visible = true;
            btnAppend.Visible = true;
            BtnPrepend.Visible = true;
            BtnDelByIndex.Visible = true;

            TbId.Visible = true;
            TbAppend.Visible = true;
            TbPrepend.Visible = true;
            TbDel.Visible = true;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            LabelSort.Text = "";
            LabelSort.Visible = true;

            if(workList.Count > 0)
            {
                workList.Sort();
            }

            foreach (var el in workList)
            {
                LabelSort.Text += el.ToString() + " ";
            }

            BtnSort.Location = new Point(LabelSort.Location.X + LabelSort.Size.Width + 10, BtnSort.Location.Y);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            LabelRemove.Visible = true;
            DoCommand(LabelRemove, TbDel, BtnRemove, "Del");
            BtnRemove.Location = new Point(LabelRemove.Location.X + LabelRemove.Size.Width + 10, BtnRemove.Location.Y);
            TbDel.Location = new Point(BtnRemove.Location.X + BtnRemove.Size.Width + 10, TbDel.Location.Y);
        }

        private void BtnDelByIndex_Click(object sender, EventArgs e)
        {
            DoCommand(labelDelByIndex, TbId, BtnDelByIndex, "DelByIndex");
            BtnDelByIndex.Location = new Point(labelDelByIndex.Location.X + labelDelByIndex.Size.Width + 10, BtnDelByIndex.Location.Y);
            TbId.Location = new Point(BtnDelByIndex.Location.X + BtnDelByIndex.Size.Width + 10, TbId.Location.Y);
        }

        private void BtnPrepend_Click(object sender, EventArgs e)
        {
            DoCommand(labelPrepend, TbPrepend, BtnPrepend, "Prepend");

            BtnPrepend.Location = new Point(labelPrepend.Location.X + labelPrepend.Size.Width + 10, BtnPrepend.Location.Y);
            TbPrepend.Location = new Point(TbPrepend.Location.X + TbPrepend.Size.Width + 10, TbPrepend.Location.Y);
        }

        private void DoCommand(Label label, TextBox tb, Button btn, string command)
        {
            label.Text = "";

            if (tb.Text.Length > 0)
            {
                switch (command)
                {
                    case "Append":
                        workList.Append(int.Parse(tb.Text));
                        break;
                    case "Sort":
                        workList.Sort();
                        break;
                    case "Prepend":
                        workList.Prepend(int.Parse(tb.Text));
                        break;
                    case "DelByIndex":
                        workList.DeleteByIndex(int.Parse(tb.Text));
                        break;
                    case "Del":
                        workList.Delete(int.Parse(tb.Text));
                        break;
                }

                foreach (var el in workList) 
                    label.Text += el;

                //btn.Location = new Point(label.Location.X + label.Size.Width + 10, btn.Location.Y);
                //tb.Location = new Point(label.Location.X + label.Size.Width + btn.Size.Width + 10, btn.Location.Y);
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            DoCommand(labelAppend, TbAppend, btnAppend, "Append");

            btnAppend.Location = new Point(labelAppend.Location.X + labelAppend.Size.Width + 10, btnAppend.Location.Y);
            TbAppend.Location = new Point(btnAppend.Location.X + btnAppend.Size.Width + 10, TbAppend.Location.Y);
        }

        #endregion
    }
}
