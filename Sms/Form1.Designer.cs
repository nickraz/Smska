namespace Sms
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelCountSymnols = new System.Windows.Forms.Label();
            this.labelSender = new System.Windows.Forms.Label();
            this.labelSymbols = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.radioButtonAlya = new System.Windows.Forms.RadioButton();
            this.radioButtonNick = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBoxMessage);
            this.panel1.Controls.Add(this.radioButtonAlya);
            this.panel1.Controls.Add(this.radioButtonNick);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 294);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.buttonSend);
            this.groupBoxMessage.Controls.Add(this.labelCountSymnols);
            this.groupBoxMessage.Controls.Add(this.labelSender);
            this.groupBoxMessage.Controls.Add(this.labelSymbols);
            this.groupBoxMessage.Controls.Add(this.textBoxSender);
            this.groupBoxMessage.Controls.Add(this.textBoxMessage);
            this.groupBoxMessage.Location = new System.Drawing.Point(3, 32);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(340, 246);
            this.groupBoxMessage.TabIndex = 1;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Сообщение";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(155, 199);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(179, 41);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelCountSymnols
            // 
            this.labelCountSymnols.AutoSize = true;
            this.labelCountSymnols.Location = new System.Drawing.Point(152, 171);
            this.labelCountSymnols.Name = "labelCountSymnols";
            this.labelCountSymnols.Size = new System.Drawing.Size(45, 16);
            this.labelCountSymnols.TabIndex = 6;
            this.labelCountSymnols.Text = "label1";
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(6, 199);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(72, 16);
            this.labelSender.TabIndex = 5;
            this.labelSender.Text = "Ваше имя:";
            // 
            // labelSymbols
            // 
            this.labelSymbols.AutoSize = true;
            this.labelSymbols.Location = new System.Drawing.Point(6, 171);
            this.labelSymbols.Name = "labelSymbols";
            this.labelSymbols.Size = new System.Drawing.Size(140, 16);
            this.labelSymbols.TabIndex = 4;
            this.labelSymbols.Text = "Осталось символов:";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(9, 218);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(100, 22);
            this.textBoxSender.TabIndex = 3;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(6, 21);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(328, 147);
            this.textBoxMessage.TabIndex = 2;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // radioButtonAlya
            // 
            this.radioButtonAlya.AutoSize = true;
            this.radioButtonAlya.Location = new System.Drawing.Point(67, 6);
            this.radioButtonAlya.Name = "radioButtonAlya";
            this.radioButtonAlya.Size = new System.Drawing.Size(51, 20);
            this.radioButtonAlya.TabIndex = 1;
            this.radioButtonAlya.TabStop = true;
            this.radioButtonAlya.Text = "Але";
            this.radioButtonAlya.UseVisualStyleBackColor = true;
            // 
            // radioButtonNick
            // 
            this.radioButtonNick.AutoSize = true;
            this.radioButtonNick.Location = new System.Drawing.Point(3, 6);
            this.radioButtonNick.Name = "radioButtonNick";
            this.radioButtonNick.Size = new System.Drawing.Size(58, 20);
            this.radioButtonNick.TabIndex = 0;
            this.radioButtonNick.TabStop = true;
            this.radioButtonNick.Text = "Коле";
            this.radioButtonNick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 318);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 357);
            this.MinimumSize = new System.Drawing.Size(389, 357);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправить SMS-сообщение ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.RadioButton radioButtonAlya;
        private System.Windows.Forms.RadioButton radioButtonNick;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelCountSymnols;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.Label labelSymbols;
        private System.Windows.Forms.TextBox textBoxSender;

    }
}

