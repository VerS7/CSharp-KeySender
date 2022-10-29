namespace KeySender
{
    partial class AppForm
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
            this.keylistbox = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.wndslistbox = new System.Windows.Forms.CheckedListBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            this.statLbl = new System.Windows.Forms.Label();
            this.currentStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keylistbox
            // 
            this.keylistbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keylistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.keylistbox.FormattingEnabled = true;
            this.keylistbox.IntegralHeight = false;
            this.keylistbox.ItemHeight = 25;
            this.keylistbox.Location = new System.Drawing.Point(5, 8);
            this.keylistbox.MaxDropDownItems = 5;
            this.keylistbox.Name = "keylistbox";
            this.keylistbox.Size = new System.Drawing.Size(106, 33);
            this.keylistbox.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.startBtn.Location = new System.Drawing.Point(5, 183);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(106, 28);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // wndslistbox
            // 
            this.wndslistbox.CheckOnClick = true;
            this.wndslistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wndslistbox.FormattingEnabled = true;
            this.wndslistbox.Location = new System.Drawing.Point(117, 8);
            this.wndslistbox.Name = "wndslistbox";
            this.wndslistbox.Size = new System.Drawing.Size(230, 235);
            this.wndslistbox.TabIndex = 4;
            this.wndslistbox.SelectedIndexChanged += new System.EventHandler(this.wndslistbox_SelectedIndexChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.stopBtn.Location = new System.Drawing.Point(5, 215);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(106, 28);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // refBtn
            // 
            this.refBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refBtn.Location = new System.Drawing.Point(313, 208);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(32, 32);
            this.refBtn.TabIndex = 6;
            this.refBtn.Text = "↻";
            this.refBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // statLbl
            // 
            this.statLbl.AutoSize = true;
            this.statLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statLbl.Location = new System.Drawing.Point(2, 48);
            this.statLbl.Name = "statLbl";
            this.statLbl.Size = new System.Drawing.Size(60, 20);
            this.statLbl.TabIndex = 7;
            this.statLbl.Text = "Status:";
            // 
            // currentStatus
            // 
            this.currentStatus.AutoSize = true;
            this.currentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentStatus.Location = new System.Drawing.Point(3, 65);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(67, 20);
            this.currentStatus.TabIndex = 8;
            this.currentStatus.Text = "stopped";
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 246);
            this.Controls.Add(this.currentStatus);
            this.Controls.Add(this.statLbl);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.wndslistbox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.keylistbox);
            this.Name = "AppForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox keylistbox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.CheckedListBox wndslistbox;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button refBtn;
        private System.Windows.Forms.Label statLbl;
        private System.Windows.Forms.Label currentStatus;
    }
}

