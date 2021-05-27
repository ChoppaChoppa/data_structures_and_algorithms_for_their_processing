
namespace HashTable
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbValue = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbGetHash = new System.Windows.Forms.TextBox();
            this.btnGetHash = new System.Windows.Forms.Button();
            this.lbCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(195, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(259, 101);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "GO";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbValue.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbValue.Location = new System.Drawing.Point(684, 22);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(0, 25);
            this.lbValue.TabIndex = 2;
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKey.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbKey.Location = new System.Drawing.Point(329, 22);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(0, 25);
            this.lbKey.TabIndex = 3;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(12, 27);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 4;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(300, 349);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(259, 101);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Visible = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbGetHash
            // 
            this.tbGetHash.Location = new System.Drawing.Point(138, 27);
            this.tbGetHash.Name = "tbGetHash";
            this.tbGetHash.Size = new System.Drawing.Size(100, 20);
            this.tbGetHash.TabIndex = 6;
            // 
            // btnGetHash
            // 
            this.btnGetHash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetHash.Location = new System.Drawing.Point(289, 259);
            this.btnGetHash.Name = "btnGetHash";
            this.btnGetHash.Size = new System.Drawing.Size(259, 101);
            this.btnGetHash.TabIndex = 7;
            this.btnGetHash.Text = "GET";
            this.btnGetHash.UseVisualStyleBackColor = false;
            this.btnGetHash.Visible = false;
            this.btnGetHash.Click += new System.EventHandler(this.btnGetHash_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbCount.Location = new System.Drawing.Point(506, 22);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 25);
            this.lbCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 619);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.btnGetHash);
            this.Controls.Add(this.tbGetHash);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbGetHash;
        private System.Windows.Forms.Button btnGetHash;
        private System.Windows.Forms.Label lbCount;
    }
}

