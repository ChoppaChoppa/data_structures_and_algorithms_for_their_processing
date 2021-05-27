
namespace OPZ_stack_forms
{
    partial class FormMora
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
            this.Create = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.outOpz = new System.Windows.Forms.TextBox();
            this.OutAns = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(326, 90);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(129, 43);
            this.Create.TabIndex = 0;
            this.Create.Text = "create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(12, 28);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(776, 56);
            this.Input.TabIndex = 1;
            // 
            // outOpz
            // 
            this.outOpz.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outOpz.Location = new System.Drawing.Point(12, 139);
            this.outOpz.Multiline = true;
            this.outOpz.Name = "outOpz";
            this.outOpz.Size = new System.Drawing.Size(776, 56);
            this.outOpz.TabIndex = 2;
            // 
            // OutAns
            // 
            this.OutAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutAns.Location = new System.Drawing.Point(12, 222);
            this.OutAns.Multiline = true;
            this.OutAns.Name = "OutAns";
            this.OutAns.Size = new System.Drawing.Size(776, 56);
            this.OutAns.TabIndex = 3;
            // 
            // FormMora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutAns);
            this.Controls.Add(this.outOpz);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Create);
            this.Name = "FormMora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox outOpz;
        private System.Windows.Forms.TextBox OutAns;
    }
}

