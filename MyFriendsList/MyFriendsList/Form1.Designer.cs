namespace MyFriendsList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_newFriend = new System.Windows.Forms.TextBox();
            this.btn_addFriend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addFive = new System.Windows.Forms.Button();
            this.btn_sortA = new System.Windows.Forms.Button();
            this.btn_sortD = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 220);
            this.listBox1.TabIndex = 0;
            // 
            // txt_newFriend
            // 
            this.txt_newFriend.Location = new System.Drawing.Point(155, 12);
            this.txt_newFriend.Name = "txt_newFriend";
            this.txt_newFriend.Size = new System.Drawing.Size(169, 21);
            this.txt_newFriend.TabIndex = 1;
            // 
            // btn_addFriend
            // 
            this.btn_addFriend.Location = new System.Drawing.Point(154, 39);
            this.btn_addFriend.Name = "btn_addFriend";
            this.btn_addFriend.Size = new System.Drawing.Size(170, 30);
            this.btn_addFriend.TabIndex = 2;
            this.btn_addFriend.Text = "Add Friends";
            this.btn_addFriend.UseVisualStyleBackColor = true;
            this.btn_addFriend.Click += new System.EventHandler(this.btn_addFriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "people";
            // 
            // btn_addFive
            // 
            this.btn_addFive.Location = new System.Drawing.Point(153, 75);
            this.btn_addFive.Name = "btn_addFive";
            this.btn_addFive.Size = new System.Drawing.Size(171, 30);
            this.btn_addFive.TabIndex = 4;
            this.btn_addFive.Text = "Add 5 Friends";
            this.btn_addFive.UseVisualStyleBackColor = true;
            this.btn_addFive.Click += new System.EventHandler(this.btn_addFive_Click);
            // 
            // btn_sortA
            // 
            this.btn_sortA.Location = new System.Drawing.Point(153, 111);
            this.btn_sortA.Name = "btn_sortA";
            this.btn_sortA.Size = new System.Drawing.Size(171, 30);
            this.btn_sortA.TabIndex = 5;
            this.btn_sortA.Text = "A -> Z";
            this.btn_sortA.UseVisualStyleBackColor = true;
            this.btn_sortA.Click += new System.EventHandler(this.btn_sortA_Click);
            // 
            // btn_sortD
            // 
            this.btn_sortD.Location = new System.Drawing.Point(153, 147);
            this.btn_sortD.Name = "btn_sortD";
            this.btn_sortD.Size = new System.Drawing.Size(171, 30);
            this.btn_sortD.TabIndex = 6;
            this.btn_sortD.Text = "Z -> A";
            this.btn_sortD.UseVisualStyleBackColor = true;
            this.btn_sortD.Click += new System.EventHandler(this.btn_sortD_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(153, 183);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(171, 30);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 248);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sortD);
            this.Controls.Add(this.btn_sortA);
            this.Controls.Add(this.btn_addFive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addFriend);
            this.Controls.Add(this.txt_newFriend);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "My Friends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_newFriend;
        private System.Windows.Forms.Button btn_addFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addFive;
        private System.Windows.Forms.Button btn_sortA;
        private System.Windows.Forms.Button btn_sortD;
        private System.Windows.Forms.Button btn_clear;
    }
}

