namespace ATM_simulator
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
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.service_title = new System.Windows.Forms.Label();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.top_up_btn = new System.Windows.Forms.Button();
            this.check_balance_btn = new System.Windows.Forms.Button();
            this.check_history_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.money_label = new System.Windows.Forms.Label();
            this.history_textbox = new System.Windows.Forms.TextBox();
            this.NTD_btn = new System.Windows.Forms.Button();
            this.USD_btn = new System.Windows.Forms.Button();
            this.money_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(451, 318);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.PasswordChar = '*';
            this.login_textbox.Size = new System.Drawing.Size(100, 22);
            this.login_textbox.TabIndex = 0;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(573, 318);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 1;
            this.login_btn.Text = "登入";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.login_label.Location = new System.Drawing.Point(291, 316);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(154, 24);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "請輸入6~12為晶片卡密碼:\r\nEnter PIN (6~12 Digits)";
            // 
            // service_title
            // 
            this.service_title.AutoSize = true;
            this.service_title.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.service_title.Location = new System.Drawing.Point(415, 271);
            this.service_title.Name = "service_title";
            this.service_title.Size = new System.Drawing.Size(142, 19);
            this.service_title.TabIndex = 3;
            this.service_title.Text = "請選擇服務項目";
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.Location = new System.Drawing.Point(419, 309);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(138, 27);
            this.withdraw_btn.TabIndex = 4;
            this.withdraw_btn.Text = "存簿提款";
            this.withdraw_btn.UseVisualStyleBackColor = true;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // top_up_btn
            // 
            this.top_up_btn.Location = new System.Drawing.Point(419, 343);
            this.top_up_btn.Name = "top_up_btn";
            this.top_up_btn.Size = new System.Drawing.Size(138, 27);
            this.top_up_btn.TabIndex = 5;
            this.top_up_btn.Text = "存簿存款";
            this.top_up_btn.UseVisualStyleBackColor = true;
            this.top_up_btn.Click += new System.EventHandler(this.top_up_btn_Click);
            // 
            // check_balance_btn
            // 
            this.check_balance_btn.Location = new System.Drawing.Point(419, 377);
            this.check_balance_btn.Name = "check_balance_btn";
            this.check_balance_btn.Size = new System.Drawing.Size(138, 27);
            this.check_balance_btn.TabIndex = 6;
            this.check_balance_btn.Text = "查詢餘額";
            this.check_balance_btn.UseVisualStyleBackColor = true;
            this.check_balance_btn.Click += new System.EventHandler(this.check_balance_btn_Click);
            // 
            // check_history_btn
            // 
            this.check_history_btn.Location = new System.Drawing.Point(419, 410);
            this.check_history_btn.Name = "check_history_btn";
            this.check_history_btn.Size = new System.Drawing.Size(138, 27);
            this.check_history_btn.TabIndex = 7;
            this.check_history_btn.Text = "查詢歷史紀錄";
            this.check_history_btn.UseVisualStyleBackColor = true;
            this.check_history_btn.Click += new System.EventHandler(this.check_history_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(419, 443);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(138, 27);
            this.logout_btn.TabIndex = 8;
            this.logout_btn.Text = "登出";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // money_label
            // 
            this.money_label.AutoSize = true;
            this.money_label.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.money_label.Location = new System.Drawing.Point(291, 373);
            this.money_label.Name = "money_label";
            this.money_label.Size = new System.Drawing.Size(95, 12);
            this.money_label.TabIndex = 9;
            this.money_label.Text = "請輸入提款金額: ";
            // 
            // history_textbox
            // 
            this.history_textbox.Enabled = false;
            this.history_textbox.Location = new System.Drawing.Point(302, 255);
            this.history_textbox.Multiline = true;
            this.history_textbox.Name = "history_textbox";
            this.history_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.history_textbox.Size = new System.Drawing.Size(401, 182);
            this.history_textbox.TabIndex = 10;
            // 
            // NTD_btn
            // 
            this.NTD_btn.Location = new System.Drawing.Point(573, 347);
            this.NTD_btn.Name = "NTD_btn";
            this.NTD_btn.Size = new System.Drawing.Size(75, 23);
            this.NTD_btn.TabIndex = 11;
            this.NTD_btn.Text = "NTD";
            this.NTD_btn.UseVisualStyleBackColor = true;
            // 
            // USD_btn
            // 
            this.USD_btn.Location = new System.Drawing.Point(573, 381);
            this.USD_btn.Name = "USD_btn";
            this.USD_btn.Size = new System.Drawing.Size(75, 23);
            this.USD_btn.TabIndex = 12;
            this.USD_btn.Text = "USD";
            this.USD_btn.UseVisualStyleBackColor = true;
            // 
            // money_textbox
            // 
            this.money_textbox.Location = new System.Drawing.Point(451, 363);
            this.money_textbox.Name = "money_textbox";
            this.money_textbox.Size = new System.Drawing.Size(100, 22);
            this.money_textbox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 648);
            this.Controls.Add(this.money_textbox);
            this.Controls.Add(this.USD_btn);
            this.Controls.Add(this.NTD_btn);
            this.Controls.Add(this.history_textbox);
            this.Controls.Add(this.money_label);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.check_history_btn);
            this.Controls.Add(this.check_balance_btn);
            this.Controls.Add(this.top_up_btn);
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.service_title);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label service_title;
        private System.Windows.Forms.Button withdraw_btn;
        private System.Windows.Forms.Button top_up_btn;
        private System.Windows.Forms.Button check_balance_btn;
        private System.Windows.Forms.Button check_history_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.TextBox history_textbox;
        private System.Windows.Forms.Button NTD_btn;
        private System.Windows.Forms.Button USD_btn;
        private System.Windows.Forms.TextBox money_textbox;
    }
}

