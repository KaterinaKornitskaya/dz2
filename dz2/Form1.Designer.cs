namespace dz2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxForList = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxForEnter = new System.Windows.Forms.TextBox();
            this.labelForText = new System.Windows.Forms.Label();
            this.buttonForText = new System.Windows.Forms.Button();
            this.textBoxForShow = new System.Windows.Forms.TextBox();
            this.comboBoxForText = new System.Windows.Forms.ComboBox();
            this.textBoxForEnterForList = new System.Windows.Forms.TextBox();
            this.buttonForList = new System.Windows.Forms.Button();
            this.labelForList = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameForUpdate = new System.Windows.Forms.TextBox();
            this.textBoxColorForUpdate = new System.Windows.Forms.TextBox();
            this.textBoxCalForUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonForUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonForDelete = new System.Windows.Forms.Button();
            this.textBoxNameForDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxForList
            // 
            this.comboBoxForList.FormattingEnabled = true;
            this.comboBoxForList.Items.AddRange(new object[] {
            "Вся информация из таблицы",
            "Все названия овощей и фруктов",
            "Все цвета",
            "Показать кол-во овощей и фруктов каждого цвета",
            "Овощи и фрукты с калорийностью ниже указанной",
            "Овощи и фрукты с калорийностью выше указанной"});
            this.comboBoxForList.Location = new System.Drawing.Point(21, 186);
            this.comboBoxForList.Name = "comboBoxForList";
            this.comboBoxForList.Size = new System.Drawing.Size(274, 21);
            this.comboBoxForList.TabIndex = 0;
            this.comboBoxForList.SelectedIndexChanged += new System.EventHandler(this.comboBoxForList_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(327, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(221, 121);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxForEnter
            // 
            this.textBoxForEnter.Location = new System.Drawing.Point(21, 392);
            this.textBoxForEnter.Name = "textBoxForEnter";
            this.textBoxForEnter.Size = new System.Drawing.Size(124, 20);
            this.textBoxForEnter.TabIndex = 2;
            // 
            // labelForText
            // 
            this.labelForText.AutoSize = true;
            this.labelForText.Location = new System.Drawing.Point(29, 268);
            this.labelForText.Name = "labelForText";
            this.labelForText.Size = new System.Drawing.Size(0, 13);
            this.labelForText.TabIndex = 3;
            // 
            // buttonForText
            // 
            this.buttonForText.Location = new System.Drawing.Point(158, 390);
            this.buttonForText.Name = "buttonForText";
            this.buttonForText.Size = new System.Drawing.Size(124, 23);
            this.buttonForText.TabIndex = 4;
            this.buttonForText.Text = "Показать";
            this.buttonForText.UseVisualStyleBackColor = true;
            this.buttonForText.Click += new System.EventHandler(this.buttonForText_Click);
            // 
            // textBoxForShow
            // 
            this.textBoxForShow.Location = new System.Drawing.Point(327, 341);
            this.textBoxForShow.Name = "textBoxForShow";
            this.textBoxForShow.Size = new System.Drawing.Size(221, 20);
            this.textBoxForShow.TabIndex = 5;
            // 
            // comboBoxForText
            // 
            this.comboBoxForText.FormattingEnabled = true;
            this.comboBoxForText.Items.AddRange(new object[] {
            "Максимальная калорийность",
            "Минимальная калорийность",
            "Средняя калорийность",
            "Колличество овощей",
            "Колличество фруктов",
            "Количество овощей и фруктов заданного цвета"});
            this.comboBoxForText.Location = new System.Drawing.Point(21, 341);
            this.comboBoxForText.Name = "comboBoxForText";
            this.comboBoxForText.Size = new System.Drawing.Size(274, 21);
            this.comboBoxForText.TabIndex = 6;
            this.comboBoxForText.SelectedIndexChanged += new System.EventHandler(this.comboBoxForText_SelectedIndexChanged);
            // 
            // textBoxForEnterForList
            // 
            this.textBoxForEnterForList.Location = new System.Drawing.Point(21, 239);
            this.textBoxForEnterForList.Name = "textBoxForEnterForList";
            this.textBoxForEnterForList.Size = new System.Drawing.Size(124, 20);
            this.textBoxForEnterForList.TabIndex = 7;
            // 
            // buttonForList
            // 
            this.buttonForList.Location = new System.Drawing.Point(158, 237);
            this.buttonForList.Name = "buttonForList";
            this.buttonForList.Size = new System.Drawing.Size(124, 22);
            this.buttonForList.TabIndex = 8;
            this.buttonForList.Text = "Показать";
            this.buttonForList.UseVisualStyleBackColor = true;
            this.buttonForList.Click += new System.EventHandler(this.buttonForList_Click);
            // 
            // labelForList
            // 
            this.labelForList.AutoSize = true;
            this.labelForList.Location = new System.Drawing.Point(12, 68);
            this.labelForList.Name = "labelForList";
            this.labelForList.Size = new System.Drawing.Size(0, 13);
            this.labelForList.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для показа списка ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 102);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Для скалярных значений";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonForUpdate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxCalForUpdate);
            this.groupBox3.Controls.Add(this.textBoxColorForUpdate);
            this.groupBox3.Controls.Add(this.textBoxNameForUpdate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 66);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обновление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя продукта для обновления";
            // 
            // textBoxNameForUpdate
            // 
            this.textBoxNameForUpdate.Location = new System.Drawing.Point(12, 37);
            this.textBoxNameForUpdate.Name = "textBoxNameForUpdate";
            this.textBoxNameForUpdate.Size = new System.Drawing.Size(159, 20);
            this.textBoxNameForUpdate.TabIndex = 1;
            // 
            // textBoxColorForUpdate
            // 
            this.textBoxColorForUpdate.Location = new System.Drawing.Point(186, 37);
            this.textBoxColorForUpdate.Name = "textBoxColorForUpdate";
            this.textBoxColorForUpdate.Size = new System.Drawing.Size(110, 20);
            this.textBoxColorForUpdate.TabIndex = 2;
            // 
            // textBoxCalForUpdate
            // 
            this.textBoxCalForUpdate.Location = new System.Drawing.Point(302, 37);
            this.textBoxCalForUpdate.Name = "textBoxCalForUpdate";
            this.textBoxCalForUpdate.Size = new System.Drawing.Size(110, 20);
            this.textBoxCalForUpdate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Новый цвет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Новая калорийность";
            // 
            // buttonForUpdate
            // 
            this.buttonForUpdate.Location = new System.Drawing.Point(433, 34);
            this.buttonForUpdate.Name = "buttonForUpdate";
            this.buttonForUpdate.Size = new System.Drawing.Size(94, 23);
            this.buttonForUpdate.TabIndex = 7;
            this.buttonForUpdate.Text = "Обновить";
            this.buttonForUpdate.UseVisualStyleBackColor = true;
            this.buttonForUpdate.Click += new System.EventHandler(this.buttonForUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonForDelete);
            this.groupBox4.Controls.Add(this.textBoxNameForDelete);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 69);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удаление";
            // 
            // buttonForDelete
            // 
            this.buttonForDelete.Location = new System.Drawing.Point(189, 34);
            this.buttonForDelete.Name = "buttonForDelete";
            this.buttonForDelete.Size = new System.Drawing.Size(94, 23);
            this.buttonForDelete.TabIndex = 7;
            this.buttonForDelete.Text = "Удалить";
            this.buttonForDelete.UseVisualStyleBackColor = true;
            this.buttonForDelete.Click += new System.EventHandler(this.buttonForDelete_Click);
            // 
            // textBoxNameForDelete
            // 
            this.textBoxNameForDelete.Location = new System.Drawing.Point(12, 37);
            this.textBoxNameForDelete.Name = "textBoxNameForDelete";
            this.textBoxNameForDelete.Size = new System.Drawing.Size(159, 20);
            this.textBoxNameForDelete.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Имя продукта для удаления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelForList);
            this.Controls.Add(this.buttonForList);
            this.Controls.Add(this.textBoxForEnterForList);
            this.Controls.Add(this.comboBoxForText);
            this.Controls.Add(this.textBoxForShow);
            this.Controls.Add(this.buttonForText);
            this.Controls.Add(this.labelForText);
            this.Controls.Add(this.textBoxForEnter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxForList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxForList;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxForEnter;
        private System.Windows.Forms.Label labelForText;
        private System.Windows.Forms.Button buttonForText;
        private System.Windows.Forms.TextBox textBoxForShow;
        private System.Windows.Forms.ComboBox comboBoxForText;
        private System.Windows.Forms.TextBox textBoxForEnterForList;
        private System.Windows.Forms.Button buttonForList;
        private System.Windows.Forms.Label labelForList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxNameForUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCalForUpdate;
        private System.Windows.Forms.TextBox textBoxColorForUpdate;
        private System.Windows.Forms.Button buttonForUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonForDelete;
        private System.Windows.Forms.TextBox textBoxNameForDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

