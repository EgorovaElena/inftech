namespace Egorova_6
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
            this.forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.keft = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.GPS = new System.Windows.Forms.CheckBox();
            this.power = new System.Windows.Forms.CheckBox();
            this.Koords = new System.Windows.Forms.Label();
            this.call_operator = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dron_on = new System.Windows.Forms.Button();
            this.Controller_on = new System.Windows.Forms.Button();
            this.dron_off = new System.Windows.Forms.Button();
            this.controller_off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(74, 86);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(75, 23);
            this.forward.TabIndex = 0;
            this.forward.Text = "вперёд";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(155, 86);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // keft
            // 
            this.keft.Location = new System.Drawing.Point(236, 86);
            this.keft.Name = "keft";
            this.keft.Size = new System.Drawing.Size(75, 23);
            this.keft.TabIndex = 2;
            this.keft.Text = "влево";
            this.keft.UseVisualStyleBackColor = true;
            this.keft.Click += new System.EventHandler(this.keft_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(317, 86);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 3;
            this.right.Text = "врпаво";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(399, 85);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 4;
            this.up.Text = "вверх";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(481, 85);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 5;
            this.down.Text = "вниз";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // GPS
            // 
            this.GPS.AutoSize = true;
            this.GPS.Location = new System.Drawing.Point(74, 171);
            this.GPS.Name = "GPS";
            this.GPS.Size = new System.Drawing.Size(59, 21);
            this.GPS.TabIndex = 6;
            this.GPS.Text = "GPS";
            this.GPS.UseVisualStyleBackColor = true;
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Location = new System.Drawing.Point(74, 132);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(87, 21);
            this.power.TabIndex = 7;
            this.power.Text = "Питание";
            this.power.UseVisualStyleBackColor = true;
            // 
            // Koords
            // 
            this.Koords.AutoSize = true;
            this.Koords.Location = new System.Drawing.Point(384, 37);
            this.Koords.Name = "Koords";
            this.Koords.Size = new System.Drawing.Size(90, 17);
            this.Koords.TabIndex = 8;
            this.Koords.Text = "Координаты";
            // 
            // call_operator
            // 
            this.call_operator.Location = new System.Drawing.Point(399, 169);
            this.call_operator.Name = "call_operator";
            this.call_operator.Size = new System.Drawing.Size(157, 23);
            this.call_operator.TabIndex = 9;
            this.call_operator.Text = "вызвать механика";
            this.call_operator.UseVisualStyleBackColor = true;
            this.call_operator.Click += new System.EventHandler(this.call_operator_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(74, 210);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Пульт управления";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сообщение";
            // 
            // dron_on
            // 
            this.dron_on.Location = new System.Drawing.Point(399, 132);
            this.dron_on.Name = "dron_on";
            this.dron_on.Size = new System.Drawing.Size(157, 23);
            this.dron_on.TabIndex = 12;
            this.dron_on.Text = "Включить дрон";
            this.dron_on.UseVisualStyleBackColor = true;
            this.dron_on.Click += new System.EventHandler(this.dron_on_Click);
            // 
            // Controller_on
            // 
            this.Controller_on.Location = new System.Drawing.Point(399, 210);
            this.Controller_on.Name = "Controller_on";
            this.Controller_on.Size = new System.Drawing.Size(157, 23);
            this.Controller_on.TabIndex = 13;
            this.Controller_on.Text = "Включить пульт";
            this.Controller_on.UseVisualStyleBackColor = true;
            this.Controller_on.Click += new System.EventHandler(this.Controller_on_Click);
            // 
            // dron_off
            // 
            this.dron_off.Location = new System.Drawing.Point(562, 132);
            this.dron_off.Name = "dron_off";
            this.dron_off.Size = new System.Drawing.Size(157, 23);
            this.dron_off.TabIndex = 14;
            this.dron_off.Text = "Выключить дрон";
            this.dron_off.UseVisualStyleBackColor = true;
            this.dron_off.Click += new System.EventHandler(this.dron_off_Click);
            // 
            // controller_off
            // 
            this.controller_off.Location = new System.Drawing.Point(563, 209);
            this.controller_off.Name = "controller_off";
            this.controller_off.Size = new System.Drawing.Size(156, 23);
            this.controller_off.TabIndex = 15;
            this.controller_off.Text = "Выключить пульт";
            this.controller_off.UseVisualStyleBackColor = true;
            this.controller_off.Click += new System.EventHandler(this.controller_off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controller_off);
            this.Controls.Add(this.dron_off);
            this.Controls.Add(this.Controller_on);
            this.Controls.Add(this.dron_on);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.call_operator);
            this.Controls.Add(this.Koords);
            this.Controls.Add(this.power);
            this.Controls.Add(this.GPS);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.right);
            this.Controls.Add(this.keft);
            this.Controls.Add(this.back);
            this.Controls.Add(this.forward);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button keft;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.CheckBox GPS;
        private System.Windows.Forms.CheckBox power;
        private System.Windows.Forms.Label Koords;
        private System.Windows.Forms.Button call_operator;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dron_on;
        private System.Windows.Forms.Button Controller_on;
        private System.Windows.Forms.Button dron_off;
        private System.Windows.Forms.Button controller_off;
    }
}

