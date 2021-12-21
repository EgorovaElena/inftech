namespace Egorova_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.amount_lists_text_box = new System.Windows.Forms.RichTextBox();
            this.SizeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IsPresentCheckBox = new System.Windows.Forms.CheckBox();
            this.priceText = new System.Windows.Forms.Label();
            this.amount_Lists_text = new System.Windows.Forms.Label();
            this.lists_size_text = new System.Windows.Forms.Label();
            this.isPresent_text = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.painted_checker = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "количество листов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "размер листов";
            // 
            // PriceRichTextBox
            // 
            this.PriceRichTextBox.Location = new System.Drawing.Point(242, 138);
            this.PriceRichTextBox.Name = "PriceRichTextBox";
            this.PriceRichTextBox.Size = new System.Drawing.Size(100, 28);
            this.PriceRichTextBox.TabIndex = 4;
            this.PriceRichTextBox.Text = "0";
            // 
            // amount_lists_text_box
            // 
            this.amount_lists_text_box.Location = new System.Drawing.Point(242, 191);
            this.amount_lists_text_box.Name = "amount_lists_text_box";
            this.amount_lists_text_box.Size = new System.Drawing.Size(100, 27);
            this.amount_lists_text_box.TabIndex = 5;
            this.amount_lists_text_box.Text = "";
            // 
            // SizeRichTextBox
            // 
            this.SizeRichTextBox.Location = new System.Drawing.Point(242, 240);
            this.SizeRichTextBox.Name = "SizeRichTextBox";
            this.SizeRichTextBox.Size = new System.Drawing.Size(100, 24);
            this.SizeRichTextBox.TabIndex = 6;
            this.SizeRichTextBox.Text = "";
            // 
            // IsPresentCheckBox
            // 
            this.IsPresentCheckBox.AutoSize = true;
            this.IsPresentCheckBox.Location = new System.Drawing.Point(106, 289);
            this.IsPresentCheckBox.Name = "IsPresentCheckBox";
            this.IsPresentCheckBox.Size = new System.Drawing.Size(114, 21);
            this.IsPresentCheckBox.TabIndex = 7;
            this.IsPresentCheckBox.Text = "Подарочный";
            this.IsPresentCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Location = new System.Drawing.Point(461, 149);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(51, 17);
            this.priceText.TabIndex = 8;
            this.priceText.Text = "Цена: ";
            // 
            // amount_Lists_text
            // 
            this.amount_Lists_text.AutoSize = true;
            this.amount_Lists_text.Location = new System.Drawing.Point(461, 201);
            this.amount_Lists_text.Name = "amount_Lists_text";
            this.amount_Lists_text.Size = new System.Drawing.Size(143, 17);
            this.amount_Lists_text.TabIndex = 9;
            this.amount_Lists_text.Text = "Количество листов: ";
            // 
            // lists_size_text
            // 
            this.lists_size_text.AutoSize = true;
            this.lists_size_text.Location = new System.Drawing.Point(461, 246);
            this.lists_size_text.Name = "lists_size_text";
            this.lists_size_text.Size = new System.Drawing.Size(114, 17);
            this.lists_size_text.TabIndex = 10;
            this.lists_size_text.Text = "Размер листов: ";
            // 
            // isPresent_text
            // 
            this.isPresent_text.AutoSize = true;
            this.isPresent_text.Location = new System.Drawing.Point(464, 289);
            this.isPresent_text.Name = "isPresent_text";
            this.isPresent_text.Size = new System.Drawing.Size(114, 21);
            this.isPresent_text.TabIndex = 11;
            this.isPresent_text.Text = "Подарочный";
            this.isPresent_text.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(464, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Раскрашен";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // painted_checker
            // 
            this.painted_checker.AutoSize = true;
            this.painted_checker.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.painted_checker.Location = new System.Drawing.Point(106, 336);
            this.painted_checker.Name = "painted_checker";
            this.painted_checker.Size = new System.Drawing.Size(104, 21);
            this.painted_checker.TabIndex = 13;
            this.painted_checker.Text = "Раскрашен";
            this.painted_checker.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Раскрасить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Стереть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.painted_checker);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.isPresent_text);
            this.Controls.Add(this.lists_size_text);
            this.Controls.Add(this.amount_Lists_text);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.IsPresentCheckBox);
            this.Controls.Add(this.SizeRichTextBox);
            this.Controls.Add(this.amount_lists_text_box);
            this.Controls.Add(this.PriceRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox PriceRichTextBox;
        private System.Windows.Forms.RichTextBox amount_lists_text_box;
        private System.Windows.Forms.RichTextBox SizeRichTextBox;
        private System.Windows.Forms.CheckBox IsPresentCheckBox;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Label amount_Lists_text;
        private System.Windows.Forms.Label lists_size_text;
        private System.Windows.Forms.CheckBox isPresent_text;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox painted_checker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

