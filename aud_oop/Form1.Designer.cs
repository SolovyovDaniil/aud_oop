namespace aud_oop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            task = new TabPage();
            add_el = new TabPage();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            del_task = new TabPage();
            button2 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            task.SuspendLayout();
            add_el.SuspendLayout();
            del_task.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1121, 618);
            dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(task);
            tabControl1.Controls.Add(add_el);
            tabControl1.Controls.Add(del_task);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1182, 703);
            tabControl1.TabIndex = 3;
            // 
            // task
            // 
            task.Controls.Add(dataGridView1);
            task.Location = new Point(4, 34);
            task.Name = "task";
            task.Padding = new Padding(3);
            task.Size = new Size(1174, 665);
            task.TabIndex = 0;
            task.Text = "Задачи";
            task.UseVisualStyleBackColor = true;
            // 
            // add_el
            // 
            add_el.Controls.Add(button1);
            add_el.Controls.Add(comboBox1);
            add_el.Controls.Add(label3);
            add_el.Controls.Add(dateTimePicker1);
            add_el.Controls.Add(label2);
            add_el.Controls.Add(textBox1);
            add_el.Controls.Add(label1);
            add_el.Location = new Point(4, 34);
            add_el.Name = "add_el";
            add_el.Padding = new Padding(3);
            add_el.Size = new Size(1174, 665);
            add_el.TabIndex = 1;
            add_el.Text = "Добавление";
            add_el.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(502, 563);
            button1.Name = "button1";
            button1.Size = new Size(175, 67);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Завершено", "Не завершено" });
            comboBox1.Location = new Point(44, 486);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 33);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 439);
            label3.Name = "label3";
            label3.Size = new Size(305, 32);
            label3.TabIndex = 4;
            label3.Text = "Выберите завершенность:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(44, 383);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 31);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 334);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 2;
            label2.Text = "Выберите дату: ";
            label2.UseMnemonic = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1075, 212);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 36);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Напишите задачу:";
            label1.UseMnemonic = false;
            // 
            // del_task
            // 
            del_task.Controls.Add(button2);
            del_task.Controls.Add(textBox2);
            del_task.Controls.Add(label4);
            del_task.Location = new Point(4, 34);
            del_task.Name = "del_task";
            del_task.Size = new Size(1174, 665);
            del_task.TabIndex = 2;
            del_task.Text = "Удаление";
            del_task.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(429, 307);
            button2.Name = "button2";
            button2.Size = new Size(237, 67);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(429, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 31);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(422, 194);
            label4.Name = "label4";
            label4.Size = new Size(158, 32);
            label4.TabIndex = 0;
            label4.Text = "Выберите ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 727);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            task.ResumeLayout(false);
            add_el.ResumeLayout(false);
            add_el.PerformLayout();
            del_task.ResumeLayout(false);
            del_task.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage task;
        private TabPage add_el;
        private TabPage del_task;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label4;
        private Button button2;
        private TextBox textBox2;
    }
}
