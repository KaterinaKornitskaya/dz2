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
            this.comboBoxForList.Location = new System.Drawing.Point(12, 40);
            this.comboBoxForList.Name = "comboBoxForList";
            this.comboBoxForList.Size = new System.Drawing.Size(274, 21);
            this.comboBoxForList.TabIndex = 0;
            this.comboBoxForList.SelectedIndexChanged += new System.EventHandler(this.comboBoxForList_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(318, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(221, 121);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxForEnter
            // 
            this.textBoxForEnter.Location = new System.Drawing.Point(12, 258);
            this.textBoxForEnter.Name = "textBoxForEnter";
            this.textBoxForEnter.Size = new System.Drawing.Size(124, 20);
            this.textBoxForEnter.TabIndex = 2;
            // 
            // labelForText
            // 
            this.labelForText.AutoSize = true;
            this.labelForText.Location = new System.Drawing.Point(12, 242);
            this.labelForText.Name = "labelForText";
            this.labelForText.Size = new System.Drawing.Size(0, 13);
            this.labelForText.TabIndex = 3;
            // 
            // buttonForText
            // 
            this.buttonForText.Location = new System.Drawing.Point(149, 256);
            this.buttonForText.Name = "buttonForText";
            this.buttonForText.Size = new System.Drawing.Size(124, 23);
            this.buttonForText.TabIndex = 4;
            this.buttonForText.Text = "Показать";
            this.buttonForText.UseVisualStyleBackColor = true;
            this.buttonForText.Click += new System.EventHandler(this.buttonForText_Click);
            // 
            // textBoxForShow
            // 
            this.textBoxForShow.Location = new System.Drawing.Point(318, 207);
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
            this.comboBoxForText.Location = new System.Drawing.Point(12, 207);
            this.comboBoxForText.Name = "comboBoxForText";
            this.comboBoxForText.Size = new System.Drawing.Size(274, 21);
            this.comboBoxForText.TabIndex = 6;
            this.comboBoxForText.SelectedIndexChanged += new System.EventHandler(this.comboBoxForText_SelectedIndexChanged);
            // 
            // textBoxForEnterForList
            // 
            this.textBoxForEnterForList.Location = new System.Drawing.Point(12, 93);
            this.textBoxForEnterForList.Name = "textBoxForEnterForList";
            this.textBoxForEnterForList.Size = new System.Drawing.Size(124, 20);
            this.textBoxForEnterForList.TabIndex = 7;
            // 
            // buttonForList
            // 
            this.buttonForList.Location = new System.Drawing.Point(149, 91);
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
            this.labelForList.Location = new System.Drawing.Point(12, 76);
            this.labelForList.Name = "labelForList";
            this.labelForList.Size = new System.Drawing.Size(0, 13);
            this.labelForList.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 166);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для показа списка ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 130);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Для скалярных значений";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 319);
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
    }
}

