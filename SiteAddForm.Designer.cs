namespace GameScanner
{
    partial class SiteAddForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name_box = new TextBox();
            url_box = new TextBox();
            query_box = new TextBox();
            sqstring_info_btn = new Button();
            add_btn = new Button();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 68);
            label2.Name = "label2";
            label2.Size = new Size(43, 18);
            label2.TabIndex = 1;
            label2.Text = "URL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 101);
            label3.Name = "label3";
            label3.Size = new Size(152, 18);
            label3.TabIndex = 2;
            label3.Text = "Search Query String:";
            // 
            // name_box
            // 
            name_box.Location = new Point(82, 37);
            name_box.MaxLength = 500;
            name_box.Name = "name_box";
            name_box.Size = new Size(691, 21);
            name_box.TabIndex = 3;
            // 
            // url_box
            // 
            url_box.Location = new Point(82, 68);
            url_box.MaxLength = 1000;
            url_box.Name = "url_box";
            url_box.Size = new Size(691, 21);
            url_box.TabIndex = 4;
            // 
            // query_box
            // 
            query_box.Location = new Point(180, 101);
            query_box.MaxLength = 325;
            query_box.Name = "query_box";
            query_box.Size = new Size(563, 21);
            query_box.TabIndex = 5;
            // 
            // sqstring_info_btn
            // 
            sqstring_info_btn.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sqstring_info_btn.Location = new Point(749, 101);
            sqstring_info_btn.Name = "sqstring_info_btn";
            sqstring_info_btn.Size = new Size(24, 23);
            sqstring_info_btn.TabIndex = 6;
            sqstring_info_btn.Text = "?";
            sqstring_info_btn.UseVisualStyleBackColor = true;
            sqstring_info_btn.Click += sqstring_info_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.Lime;
            add_btn.DialogResult = DialogResult.OK;
            add_btn.FlatStyle = FlatStyle.Popup;
            add_btn.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            add_btn.Location = new Point(224, 153);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(276, 33);
            add_btn.TabIndex = 7;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Red;
            cancel_btn.DialogResult = DialogResult.OK;
            cancel_btn.FlatStyle = FlatStyle.Popup;
            cancel_btn.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            cancel_btn.Location = new Point(506, 153);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(190, 33);
            cancel_btn.TabIndex = 8;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // SiteAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 198);
            ControlBox = false;
            Controls.Add(cancel_btn);
            Controls.Add(add_btn);
            Controls.Add(sqstring_info_btn);
            Controls.Add(query_box);
            Controls.Add(url_box);
            Controls.Add(name_box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SiteAddForm";
            ShowInTaskbar = false;
            Text = "Add a new site (GameScanner)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name_box;
        private TextBox url_box;
        private TextBox query_box;
        private Button sqstring_info_btn;
        private Button add_btn;
        private Button cancel_btn;
    }
}