namespace mssql_connect
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "DBHost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "DBName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "DBId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "DBPass";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(64, 6);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(211, 21);
            this.txt_host.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(64, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(211, 21);
            this.txt_name.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(64, 60);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(211, 21);
            this.txt_id.TabIndex = 6;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(64, 87);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(211, 21);
            this.txt_pass.TabIndex = 7;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(10, 114);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(265, 23);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(127, 150);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(29, 12);
            this.result.TabIndex = 9;
            this.result.Text = "결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ms-sql";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label result;
    }
}

