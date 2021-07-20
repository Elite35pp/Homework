
namespace homework
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.usename = new System.Windows.Forms.Label();
            this.use = new System.Windows.Forms.Label();
            this.CC = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.kuruma = new System.Windows.Forms.ComboBox();
            this.enjin = new System.Windows.Forms.ComboBox();
            this.kakutei = new System.Windows.Forms.Button();
            this.riseto = new System.Windows.Forms.Button();
            this.keeka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usename
            // 
            this.usename.AutoSize = true;
            this.usename.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usename.Location = new System.Drawing.Point(48, 98);
            this.usename.Name = "usename";
            this.usename.Size = new System.Drawing.Size(106, 24);
            this.usename.TabIndex = 0;
            this.usename.Text = "使用期間";
            // 
            // use
            // 
            this.use.AutoSize = true;
            this.use.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.use.Location = new System.Drawing.Point(43, 180);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(58, 24);
            this.use.TabIndex = 1;
            this.use.Text = "用途";
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CC.Location = new System.Drawing.Point(48, 250);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(232, 24);
            this.CC.TabIndex = 2;
            this.CC.Text = "汽缸CC數／馬達馬力";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label4.Location = new System.Drawing.Point(43, 332);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(106, 24);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "試算結果";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(250, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全年度";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(340, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "依期間";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 106);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "至";
            this.label1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(776, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Visible = false;
            // 
            // kuruma
            // 
            this.kuruma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kuruma.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kuruma.FormattingEnabled = true;
            this.kuruma.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.kuruma.Location = new System.Drawing.Point(324, 177);
            this.kuruma.Name = "kuruma";
            this.kuruma.Size = new System.Drawing.Size(185, 31);
            this.kuruma.TabIndex = 9;
            this.kuruma.SelectedIndexChanged += new System.EventHandler(this.kuruma_SelectedIndexChanged);
            // 
            // enjin
            // 
            this.enjin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enjin.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enjin.FormattingEnabled = true;
            this.enjin.Items.AddRange(new object[] {
            "150以下/12HP以下(12.2PS以下)",
            "151-250/12.1-20HP(12.3-20.3PS)",
            "251-500/20.1HP以上(20.4PS以上)",
            "501-600",
            "601-1200",
            "1201-1800",
            "1801或以上"});
            this.enjin.Location = new System.Drawing.Point(324, 247);
            this.enjin.Name = "enjin";
            this.enjin.Size = new System.Drawing.Size(495, 31);
            this.enjin.TabIndex = 10;
            // 
            // kakutei
            // 
            this.kakutei.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kakutei.Location = new System.Drawing.Point(231, 516);
            this.kakutei.Name = "kakutei";
            this.kakutei.Size = new System.Drawing.Size(139, 51);
            this.kakutei.TabIndex = 11;
            this.kakutei.Text = "確定送出";
            this.kakutei.UseVisualStyleBackColor = true;
            this.kakutei.Click += new System.EventHandler(this.kakutei_Click);
            // 
            // riseto
            // 
            this.riseto.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.riseto.Location = new System.Drawing.Point(589, 518);
            this.riseto.Name = "riseto";
            this.riseto.Size = new System.Drawing.Size(143, 49);
            this.riseto.TabIndex = 12;
            this.riseto.Text = "取消重填";
            this.riseto.UseVisualStyleBackColor = true;
            this.riseto.Click += new System.EventHandler(this.riseto_Click);
            // 
            // keeka
            // 
            this.keeka.AutoSize = true;
            this.keeka.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.keeka.Location = new System.Drawing.Point(320, 332);
            this.keeka.Name = "keeka";
            this.keeka.Size = new System.Drawing.Size(18, 24);
            this.keeka.TabIndex = 13;
            this.keeka.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "從";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keeka);
            this.Controls.Add(this.riseto);
            this.Controls.Add(this.kakutei);
            this.Controls.Add(this.enjin);
            this.Controls.Add(this.kuruma);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.use);
            this.Controls.Add(this.usename);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usename;
        private System.Windows.Forms.Label use;
        private System.Windows.Forms.Label CC;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox kuruma;
        private System.Windows.Forms.ComboBox enjin;
        private System.Windows.Forms.Button kakutei;
        private System.Windows.Forms.Button riseto;
        private System.Windows.Forms.Label keeka;
        private System.Windows.Forms.Label label2;
    }
}

