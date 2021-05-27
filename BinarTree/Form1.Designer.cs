
namespace BinarTree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbOutrandom = new System.Windows.Forms.Label();
            this.lbCLR = new System.Windows.Forms.Label();
            this.btCLR = new System.Windows.Forms.Button();
            this.btLCR = new System.Windows.Forms.Button();
            this.btRCL = new System.Windows.Forms.Button();
            this.lbLCR = new System.Windows.Forms.Label();
            this.lbRCL = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lbFind = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbOutrandom
            // 
            this.lbOutrandom.AutoSize = true;
            this.lbOutrandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOutrandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbOutrandom.Location = new System.Drawing.Point(12, 9);
            this.lbOutrandom.Name = "lbOutrandom";
            this.lbOutrandom.Size = new System.Drawing.Size(86, 31);
            this.lbOutrandom.TabIndex = 1;
            this.lbOutrandom.Text = "label2";
            // 
            // lbCLR
            // 
            this.lbCLR.AutoSize = true;
            this.lbCLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCLR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbCLR.Location = new System.Drawing.Point(194, 163);
            this.lbCLR.Name = "lbCLR";
            this.lbCLR.Size = new System.Drawing.Size(86, 31);
            this.lbCLR.TabIndex = 2;
            this.lbCLR.Text = "label2";
            // 
            // btCLR
            // 
            this.btCLR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.btCLR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCLR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(234)))));
            this.btCLR.Location = new System.Drawing.Point(18, 157);
            this.btCLR.Name = "btCLR";
            this.btCLR.Size = new System.Drawing.Size(146, 49);
            this.btCLR.TabIndex = 3;
            this.btCLR.Text = "CLR";
            this.btCLR.UseVisualStyleBackColor = false;
            this.btCLR.Click += new System.EventHandler(this.btCLR_Click);
            // 
            // btLCR
            // 
            this.btLCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.btLCR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(234)))));
            this.btLCR.Location = new System.Drawing.Point(18, 236);
            this.btLCR.Name = "btLCR";
            this.btLCR.Size = new System.Drawing.Size(146, 49);
            this.btLCR.TabIndex = 4;
            this.btLCR.Text = "LCR";
            this.btLCR.UseVisualStyleBackColor = false;
            this.btLCR.Click += new System.EventHandler(this.btLCR_Click);
            // 
            // btRCL
            // 
            this.btRCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.btRCL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRCL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(234)))));
            this.btRCL.Location = new System.Drawing.Point(18, 313);
            this.btRCL.Name = "btRCL";
            this.btRCL.Size = new System.Drawing.Size(146, 49);
            this.btRCL.TabIndex = 5;
            this.btRCL.Text = "RCL";
            this.btRCL.UseVisualStyleBackColor = false;
            this.btRCL.Click += new System.EventHandler(this.btRCL_Click);
            // 
            // lbLCR
            // 
            this.lbLCR.AutoSize = true;
            this.lbLCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbLCR.Location = new System.Drawing.Point(194, 242);
            this.lbLCR.Name = "lbLCR";
            this.lbLCR.Size = new System.Drawing.Size(86, 31);
            this.lbLCR.TabIndex = 6;
            this.lbLCR.Text = "label2";
            // 
            // lbRCL
            // 
            this.lbRCL.AutoSize = true;
            this.lbRCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRCL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbRCL.Location = new System.Drawing.Point(194, 319);
            this.lbRCL.Name = "lbRCL";
            this.lbRCL.Size = new System.Drawing.Size(86, 31);
            this.lbRCL.TabIndex = 7;
            this.lbRCL.Text = "label2";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(234)))));
            this.btnAdd.Location = new System.Drawing.Point(18, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(234)))));
            this.btnFind.Location = new System.Drawing.Point(18, 504);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(146, 49);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbFind.Location = new System.Drawing.Point(207, 521);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(0, 31);
            this.lbFind.TabIndex = 11;
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(170, 449);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(31, 20);
            this.tbAdd.TabIndex = 12;
            this.tbAdd.Visible = false;
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(170, 504);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(31, 20);
            this.tbFind.TabIndex = 13;
            this.tbFind.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(215)))), ((int)(((byte)(234)))));
            this.btnDel.Location = new System.Drawing.Point(18, 559);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(146, 49);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbDel
            // 
            this.tbDel.Location = new System.Drawing.Point(170, 559);
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(31, 20);
            this.tbDel.TabIndex = 15;
            this.tbDel.Visible = false;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(102)))), ((int)(((byte)(200)))));
            this.lbCount.Location = new System.Drawing.Point(207, 393);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 31);
            this.lbCount.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(996, 697);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.tbDel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.lbFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbRCL);
            this.Controls.Add(this.lbLCR);
            this.Controls.Add(this.btRCL);
            this.Controls.Add(this.btLCR);
            this.Controls.Add(this.btCLR);
            this.Controls.Add(this.lbCLR);
            this.Controls.Add(this.lbOutrandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbOutrandom;
        private System.Windows.Forms.Label lbCLR;
        private System.Windows.Forms.Button btCLR;
        private System.Windows.Forms.Button btLCR;
        private System.Windows.Forms.Button btRCL;
        private System.Windows.Forms.Label lbLCR;
        private System.Windows.Forms.Label lbRCL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbDel;
        private System.Windows.Forms.Label lbCount;
    }
}

