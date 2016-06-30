namespace WinFormApp
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResultFactorial = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDPlayer = new System.Windows.Forms.TextBox();
            this.textBoxfName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonClass = new System.Windows.Forms.RadioButton();
            this.radioButtonString = new System.Windows.Forms.RadioButton();
            this.radioButtonNumeric = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResponseResult = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(164, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Send to server";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResultFactorial
            // 
            this.lblResultFactorial.AutoSize = true;
            this.lblResultFactorial.Location = new System.Drawing.Point(287, 67);
            this.lblResultFactorial.Name = "lblResultFactorial";
            this.lblResultFactorial.Size = new System.Drawing.Size(0, 13);
            this.lblResultFactorial.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Request";
            // 
            // textBoxIDPlayer
            // 
            this.textBoxIDPlayer.Location = new System.Drawing.Point(384, 129);
            this.textBoxIDPlayer.Name = "textBoxIDPlayer";
            this.textBoxIDPlayer.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDPlayer.TabIndex = 10;
            this.textBoxIDPlayer.Text = "2";
            // 
            // textBoxfName
            // 
            this.textBoxfName.Location = new System.Drawing.Point(564, 128);
            this.textBoxfName.Name = "textBoxfName";
            this.textBoxfName.Size = new System.Drawing.Size(100, 20);
            this.textBoxfName.TabIndex = 11;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(564, 158);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Player";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonClass);
            this.groupBox1.Controls.Add(this.radioButtonString);
            this.groupBox1.Controls.Add(this.radioButtonNumeric);
            this.groupBox1.Location = new System.Drawing.Point(14, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 102);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data types";
            // 
            // radioButtonClass
            // 
            this.radioButtonClass.AutoSize = true;
            this.radioButtonClass.Location = new System.Drawing.Point(18, 73);
            this.radioButtonClass.Name = "radioButtonClass";
            this.radioButtonClass.Size = new System.Drawing.Size(50, 17);
            this.radioButtonClass.TabIndex = 17;
            this.radioButtonClass.Text = "Class";
            this.radioButtonClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonString
            // 
            this.radioButtonString.AutoSize = true;
            this.radioButtonString.Location = new System.Drawing.Point(18, 50);
            this.radioButtonString.Name = "radioButtonString";
            this.radioButtonString.Size = new System.Drawing.Size(52, 17);
            this.radioButtonString.TabIndex = 16;
            this.radioButtonString.Text = "String";
            this.radioButtonString.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumeric
            // 
            this.radioButtonNumeric.AutoSize = true;
            this.radioButtonNumeric.Checked = true;
            this.radioButtonNumeric.Location = new System.Drawing.Point(18, 27);
            this.radioButtonNumeric.Name = "radioButtonNumeric";
            this.radioButtonNumeric.Size = new System.Drawing.Size(64, 17);
            this.radioButtonNumeric.TabIndex = 15;
            this.radioButtonNumeric.TabStop = true;
            this.radioButtonNumeric.Text = "Numeric";
            this.radioButtonNumeric.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Response";
            // 
            // lblResponseResult
            // 
            this.lblResponseResult.AutoSize = true;
            this.lblResponseResult.Location = new System.Drawing.Point(273, 157);
            this.lblResponseResult.Name = "lblResponseResult";
            this.lblResponseResult.Size = new System.Drawing.Size(0, 13);
            this.lblResponseResult.TabIndex = 19;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(564, 191);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxLevel.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "LastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "FirstName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Level";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(164, 41);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 26;
            this.textBoxPassword.Text = "123";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(164, 15);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 25;
            this.textBoxUserName.Text = "TestUser";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "User name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Password";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(3, 41);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 29;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 304);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.lblResponseResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxfName);
            this.Controls.Add(this.textBoxIDPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResultFactorial);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResultFactorial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDPlayer;
        private System.Windows.Forms.TextBox textBoxfName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonString;
        private System.Windows.Forms.RadioButton radioButtonNumeric;
        private System.Windows.Forms.RadioButton radioButtonClass;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResponseResult;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

