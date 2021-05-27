namespace List
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
            this.LabelListOut = new System.Windows.Forms.Label();
            this.CreateList = new System.Windows.Forms.Button();
            this.LabelSort = new System.Windows.Forms.Label();
            this.LabelRemove = new System.Windows.Forms.Label();
            this.BtnCreateInt = new System.Windows.Forms.Button();
            this.BtnCreateStr = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.BtnPrepend = new System.Windows.Forms.Button();
            this.BtnDelByIndex = new System.Windows.Forms.Button();
            this.labelDelByIndex = new System.Windows.Forms.Label();
            this.labelPrepend = new System.Windows.Forms.Label();
            this.labelAppend = new System.Windows.Forms.Label();
            this.TbAppend = new System.Windows.Forms.TextBox();
            this.TbPrepend = new System.Windows.Forms.TextBox();
            this.TbId = new System.Windows.Forms.TextBox();
            this.TbDel = new System.Windows.Forms.TextBox();
            this.labelMainElement = new System.Windows.Forms.Label();
            this.labelLeftElement = new System.Windows.Forms.Label();
            this.labelRightElement = new System.Windows.Forms.Label();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelListOut
            // 
            this.LabelListOut.AutoSize = true;
            this.LabelListOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.LabelListOut.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelListOut.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelListOut.Location = new System.Drawing.Point(12, 9);
            this.LabelListOut.Name = "LabelListOut";
            this.LabelListOut.Size = new System.Drawing.Size(0, 45);
            this.LabelListOut.TabIndex = 0;
            // 
            // CreateList
            // 
            this.CreateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateList.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateList.Location = new System.Drawing.Point(113, 74);
            this.CreateList.Name = "CreateList";
            this.CreateList.Size = new System.Drawing.Size(165, 57);
            this.CreateList.TabIndex = 1;
            this.CreateList.Text = "Create";
            this.CreateList.UseVisualStyleBackColor = true;
            this.CreateList.Click += new System.EventHandler(this.CreateList_Click);
            // 
            // LabelSort
            // 
            this.LabelSort.AutoSize = true;
            this.LabelSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.LabelSort.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSort.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelSort.Location = new System.Drawing.Point(12, 232);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(0, 45);
            this.LabelSort.TabIndex = 2;
            // 
            // LabelRemove
            // 
            this.LabelRemove.AutoSize = true;
            this.LabelRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.LabelRemove.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelRemove.Location = new System.Drawing.Point(12, 305);
            this.LabelRemove.Name = "LabelRemove";
            this.LabelRemove.Size = new System.Drawing.Size(0, 45);
            this.LabelRemove.TabIndex = 3;
            // 
            // BtnCreateInt
            // 
            this.BtnCreateInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateInt.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateInt.Location = new System.Drawing.Point(284, 91);
            this.BtnCreateInt.Name = "BtnCreateInt";
            this.BtnCreateInt.Size = new System.Drawing.Size(77, 40);
            this.BtnCreateInt.TabIndex = 6;
            this.BtnCreateInt.Text = "int";
            this.BtnCreateInt.UseVisualStyleBackColor = true;
            this.BtnCreateInt.Click += new System.EventHandler(this.BtnCreateInt_Click);
            // 
            // BtnCreateStr
            // 
            this.BtnCreateStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateStr.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateStr.Location = new System.Drawing.Point(367, 91);
            this.BtnCreateStr.Name = "BtnCreateStr";
            this.BtnCreateStr.Size = new System.Drawing.Size(77, 40);
            this.BtnCreateStr.TabIndex = 7;
            this.BtnCreateStr.Text = "string";
            this.BtnCreateStr.UseVisualStyleBackColor = true;
            this.BtnCreateStr.Click += new System.EventHandler(this.BtnCreateStr_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnSort
            // 
            this.BtnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSort.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSort.Location = new System.Drawing.Point(295, 239);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(119, 40);
            this.BtnSort.TabIndex = 8;
            this.BtnSort.Text = "sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.Location = new System.Drawing.Point(295, 312);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(119, 40);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "Delete";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppend.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppend.Location = new System.Drawing.Point(295, 512);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(119, 40);
            this.btnAppend.TabIndex = 13;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // BtnPrepend
            // 
            this.BtnPrepend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrepend.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrepend.Location = new System.Drawing.Point(295, 446);
            this.BtnPrepend.Name = "BtnPrepend";
            this.BtnPrepend.Size = new System.Drawing.Size(119, 40);
            this.BtnPrepend.TabIndex = 14;
            this.BtnPrepend.Text = "Prepend";
            this.BtnPrepend.UseVisualStyleBackColor = true;
            this.BtnPrepend.Click += new System.EventHandler(this.BtnPrepend_Click);
            // 
            // BtnDelByIndex
            // 
            this.BtnDelByIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelByIndex.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelByIndex.Location = new System.Drawing.Point(295, 378);
            this.BtnDelByIndex.Name = "BtnDelByIndex";
            this.BtnDelByIndex.Size = new System.Drawing.Size(119, 40);
            this.BtnDelByIndex.TabIndex = 15;
            this.BtnDelByIndex.Text = "Delete by index";
            this.BtnDelByIndex.UseVisualStyleBackColor = true;
            this.BtnDelByIndex.Click += new System.EventHandler(this.BtnDelByIndex_Click);
            // 
            // labelDelByIndex
            // 
            this.labelDelByIndex.AutoSize = true;
            this.labelDelByIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.labelDelByIndex.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDelByIndex.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDelByIndex.Location = new System.Drawing.Point(12, 368);
            this.labelDelByIndex.Name = "labelDelByIndex";
            this.labelDelByIndex.Size = new System.Drawing.Size(0, 45);
            this.labelDelByIndex.TabIndex = 16;
            // 
            // labelPrepend
            // 
            this.labelPrepend.AutoSize = true;
            this.labelPrepend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.labelPrepend.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrepend.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrepend.Location = new System.Drawing.Point(12, 439);
            this.labelPrepend.Name = "labelPrepend";
            this.labelPrepend.Size = new System.Drawing.Size(0, 45);
            this.labelPrepend.TabIndex = 17;
            // 
            // labelAppend
            // 
            this.labelAppend.AutoSize = true;
            this.labelAppend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.labelAppend.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAppend.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAppend.Location = new System.Drawing.Point(12, 505);
            this.labelAppend.Name = "labelAppend";
            this.labelAppend.Size = new System.Drawing.Size(0, 45);
            this.labelAppend.TabIndex = 18;
            // 
            // TbAppend
            // 
            this.TbAppend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAppend.ForeColor = System.Drawing.SystemColors.Info;
            this.TbAppend.Location = new System.Drawing.Point(420, 512);
            this.TbAppend.Multiline = true;
            this.TbAppend.Name = "TbAppend";
            this.TbAppend.Size = new System.Drawing.Size(24, 20);
            this.TbAppend.TabIndex = 19;
            // 
            // TbPrepend
            // 
            this.TbPrepend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrepend.ForeColor = System.Drawing.SystemColors.Info;
            this.TbPrepend.Location = new System.Drawing.Point(420, 446);
            this.TbPrepend.Multiline = true;
            this.TbPrepend.Name = "TbPrepend";
            this.TbPrepend.Size = new System.Drawing.Size(24, 20);
            this.TbPrepend.TabIndex = 20;
            // 
            // TbId
            // 
            this.TbId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbId.ForeColor = System.Drawing.SystemColors.Info;
            this.TbId.Location = new System.Drawing.Point(420, 378);
            this.TbId.Multiline = true;
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(24, 20);
            this.TbId.TabIndex = 12;
            // 
            // TbDel
            // 
            this.TbDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDel.ForeColor = System.Drawing.SystemColors.Info;
            this.TbDel.Location = new System.Drawing.Point(420, 312);
            this.TbDel.Multiline = true;
            this.TbDel.Name = "TbDel";
            this.TbDel.Size = new System.Drawing.Size(24, 20);
            this.TbDel.TabIndex = 21;
            // 
            // labelMainElement
            // 
            this.labelMainElement.AutoSize = true;
            this.labelMainElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.labelMainElement.Font = new System.Drawing.Font("Bookman Old Style", 250F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMainElement.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMainElement.Location = new System.Drawing.Point(675, 139);
            this.labelMainElement.Name = "labelMainElement";
            this.labelMainElement.Size = new System.Drawing.Size(365, 376);
            this.labelMainElement.TabIndex = 22;
            this.labelMainElement.Text = "0";
            // 
            // labelLeftElement
            // 
            this.labelLeftElement.AutoSize = true;
            this.labelLeftElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.labelLeftElement.Font = new System.Drawing.Font("Bookman Old Style", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeftElement.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLeftElement.Location = new System.Drawing.Point(448, 286);
            this.labelLeftElement.Name = "labelLeftElement";
            this.labelLeftElement.Size = new System.Drawing.Size(221, 229);
            this.labelLeftElement.TabIndex = 23;
            this.labelLeftElement.Text = "0";
            // 
            // labelRightElement
            // 
            this.labelRightElement.AutoSize = true;
            this.labelRightElement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.labelRightElement.Font = new System.Drawing.Font("Bookman Old Style", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRightElement.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRightElement.Location = new System.Drawing.Point(1046, 286);
            this.labelRightElement.Name = "labelRightElement";
            this.labelRightElement.Size = new System.Drawing.Size(221, 229);
            this.labelRightElement.TabIndex = 24;
            this.labelRightElement.Text = "0";
            // 
            // BtnLeft
            // 
            this.BtnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeft.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(590, 537);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(165, 57);
            this.BtnLeft.TabIndex = 25;
            this.BtnLeft.Text = "Left";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRight.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(965, 537);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(165, 57);
            this.BtnRight.TabIndex = 26;
            this.BtnRight.Text = "Right";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.labelRightElement);
            this.Controls.Add(this.labelLeftElement);
            this.Controls.Add(this.labelMainElement);
            this.Controls.Add(this.TbDel);
            this.Controls.Add(this.TbPrepend);
            this.Controls.Add(this.TbAppend);
            this.Controls.Add(this.BtnDelByIndex);
            this.Controls.Add(this.BtnPrepend);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.CreateList);
            this.Controls.Add(this.LabelListOut);
            this.Controls.Add(this.BtnCreateInt);
            this.Controls.Add(this.BtnCreateStr);
            this.Controls.Add(this.labelAppend);
            this.Controls.Add(this.labelPrepend);
            this.Controls.Add(this.labelDelByIndex);
            this.Controls.Add(this.LabelRemove);
            this.Controls.Add(this.LabelSort);
            this.Name = "Form1";
            this.Text = "List";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelListOut;
        private System.Windows.Forms.Button CreateList;
        private System.Windows.Forms.Label LabelSort;
        private System.Windows.Forms.Label LabelRemove;
        private System.Windows.Forms.Button BtnCreateInt;
        private System.Windows.Forms.Button BtnCreateStr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button BtnPrepend;
        private System.Windows.Forms.Button BtnDelByIndex;
        private System.Windows.Forms.Label labelDelByIndex;
        private System.Windows.Forms.Label labelPrepend;
        private System.Windows.Forms.Label labelAppend;
        private System.Windows.Forms.TextBox TbAppend;
        private System.Windows.Forms.TextBox TbPrepend;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.TextBox TbDel;
        private System.Windows.Forms.Label labelMainElement;
        private System.Windows.Forms.Label labelLeftElement;
        private System.Windows.Forms.Label labelRightElement;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
    }
}

