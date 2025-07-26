namespace GameScanner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            app_title_label = new Label();
            main_menu_strip = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            siteadd_menu_btn = new ToolStripMenuItem();
            info_menu_btn = new ToolStripMenuItem();
            settings_menu_btn = new ToolStripMenuItem();
            label1 = new Label();
            game_name_box = new TextBox();
            label2 = new Label();
            label3 = new Label();
            select_all_btn = new Button();
            deselect_all_btn = new Button();
            save_pref_btn = new Button();
            label4 = new Label();
            site_name_searchbox = new TextBox();
            label5 = new Label();
            search_btn = new Button();
            sites_selected_display = new Label();
            search_name_btn = new Button();
            go_to_selected_btn = new Button();
            found_display = new Label();
            sites_list = new ListView();
            result_list = new ListView();
            version_display = new Label();
            main_menu_strip.SuspendLayout();
            SuspendLayout();
            // 
            // app_title_label
            // 
            app_title_label.AutoSize = true;
            app_title_label.Font = new Font("Wide Latin", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            app_title_label.Location = new Point(24, 36);
            app_title_label.Name = "app_title_label";
            app_title_label.Size = new Size(478, 46);
            app_title_label.TabIndex = 0;
            app_title_label.Text = "GameScanner";
            // 
            // main_menu_strip
            // 
            main_menu_strip.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, info_menu_btn, settings_menu_btn });
            main_menu_strip.Location = new Point(0, 0);
            main_menu_strip.Name = "main_menu_strip";
            main_menu_strip.Size = new Size(573, 24);
            main_menu_strip.TabIndex = 1;
            main_menu_strip.Text = "Main Menu";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siteadd_menu_btn });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(41, 20);
            addToolStripMenuItem.Text = "Add";
            // 
            // siteadd_menu_btn
            // 
            siteadd_menu_btn.Name = "siteadd_menu_btn";
            siteadd_menu_btn.Size = new Size(118, 22);
            siteadd_menu_btn.Text = "Add Site";
            siteadd_menu_btn.Click += siteadd_menu_btn_Click;
            // 
            // info_menu_btn
            // 
            info_menu_btn.Name = "info_menu_btn";
            info_menu_btn.Size = new Size(40, 20);
            info_menu_btn.Text = "Info";
            info_menu_btn.Click += info_menu_btn_Click;
            // 
            // settings_menu_btn
            // 
            settings_menu_btn.Enabled = false;
            settings_menu_btn.Name = "settings_menu_btn";
            settings_menu_btn.Size = new Size(61, 20);
            settings_menu_btn.Text = "Settings";
            settings_menu_btn.Visible = false;
            settings_menu_btn.Click += settings_menu_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 154);
            label1.Name = "label1";
            label1.Size = new Size(122, 22);
            label1.TabIndex = 2;
            label1.Text = "Game Name:";
            // 
            // game_name_box
            // 
            game_name_box.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            game_name_box.Location = new Point(152, 151);
            game_name_box.MaxLength = 650;
            game_name_box.Name = "game_name_box";
            game_name_box.Size = new Size(370, 29);
            game_name_box.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 197);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 4;
            label2.Text = "Sites to search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Wide Latin", 6F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(256, 72);
            label3.Name = "label3";
            label3.Size = new Size(246, 10);
            label3.TabIndex = 5;
            label3.Text = "vortex3225                                    2025";
            // 
            // select_all_btn
            // 
            select_all_btn.Font = new Font("Arial", 9F);
            select_all_btn.Location = new Point(171, 197);
            select_all_btn.Name = "select_all_btn";
            select_all_btn.Size = new Size(75, 23);
            select_all_btn.TabIndex = 7;
            select_all_btn.Text = "Select All";
            select_all_btn.UseVisualStyleBackColor = true;
            select_all_btn.Click += select_all_btn_Click;
            // 
            // deselect_all_btn
            // 
            deselect_all_btn.Font = new Font("Arial", 9F);
            deselect_all_btn.Location = new Point(256, 196);
            deselect_all_btn.Name = "deselect_all_btn";
            deselect_all_btn.Size = new Size(93, 23);
            deselect_all_btn.TabIndex = 8;
            deselect_all_btn.Text = "Deselect All";
            deselect_all_btn.UseVisualStyleBackColor = true;
            deselect_all_btn.Click += deselect_all_btn_Click;
            // 
            // save_pref_btn
            // 
            save_pref_btn.Enabled = false;
            save_pref_btn.Font = new Font("Arial", 9F);
            save_pref_btn.Location = new Point(364, 196);
            save_pref_btn.Name = "save_pref_btn";
            save_pref_btn.Size = new Size(157, 23);
            save_pref_btn.TabIndex = 9;
            save_pref_btn.Text = "Save Preferences";
            save_pref_btn.UseVisualStyleBackColor = true;
            save_pref_btn.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 228);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Search Site:";
            // 
            // site_name_searchbox
            // 
            site_name_searchbox.Font = new Font("Arial", 8F);
            site_name_searchbox.Location = new Point(128, 227);
            site_name_searchbox.Name = "site_name_searchbox";
            site_name_searchbox.Size = new Size(363, 20);
            site_name_searchbox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 538);
            label5.Name = "label5";
            label5.Size = new Size(79, 22);
            label5.TabIndex = 12;
            label5.Text = "Results:";
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.Lime;
            search_btn.FlatStyle = FlatStyle.Flat;
            search_btn.Font = new Font("Arial", 16F);
            search_btn.Location = new Point(49, 448);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(472, 48);
            search_btn.TabIndex = 14;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += search_btn_Click;
            // 
            // sites_selected_display
            // 
            sites_selected_display.AutoSize = true;
            sites_selected_display.Location = new Point(50, 420);
            sites_selected_display.Name = "sites_selected_display";
            sites_selected_display.Size = new Size(121, 15);
            sites_selected_display.TabIndex = 15;
            sites_selected_display.Text = "Will search: 0/0 sites";
            // 
            // search_name_btn
            // 
            search_name_btn.Font = new Font("Arial Black", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_name_btn.Location = new Point(497, 225);
            search_name_btn.Name = "search_name_btn";
            search_name_btn.Size = new Size(25, 22);
            search_name_btn.TabIndex = 16;
            search_name_btn.Text = "🔍";
            search_name_btn.UseVisualStyleBackColor = true;
            search_name_btn.Click += search_name_btn_Click;
            // 
            // go_to_selected_btn
            // 
            go_to_selected_btn.Location = new Point(364, 544);
            go_to_selected_btn.Name = "go_to_selected_btn";
            go_to_selected_btn.Size = new Size(157, 23);
            go_to_selected_btn.TabIndex = 17;
            go_to_selected_btn.Text = "Go to selected site";
            go_to_selected_btn.UseVisualStyleBackColor = true;
            go_to_selected_btn.Click += go_to_selected_btn_Click;
            // 
            // found_display
            // 
            found_display.AutoSize = true;
            found_display.Location = new Point(44, 726);
            found_display.Name = "found_display";
            found_display.Size = new Size(93, 15);
            found_display.TabIndex = 18;
            found_display.Text = "Found 0 results";
            // 
            // sites_list
            // 
            sites_list.CheckBoxes = true;
            sites_list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            sites_list.Location = new Point(50, 253);
            sites_list.MultiSelect = false;
            sites_list.Name = "sites_list";
            sites_list.Size = new Size(471, 164);
            sites_list.TabIndex = 19;
            sites_list.UseCompatibleStateImageBehavior = false;
            sites_list.ItemChecked += OnSiteChecked;
            sites_list.KeyUp += OnKeyUp;
            // 
            // result_list
            // 
            result_list.Location = new Point(49, 583);
            result_list.MultiSelect = false;
            result_list.Name = "result_list";
            result_list.Size = new Size(473, 140);
            result_list.TabIndex = 20;
            result_list.UseCompatibleStateImageBehavior = false;
            // 
            // version_display
            // 
            version_display.AutoSize = true;
            version_display.Font = new Font("Wide Latin", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            version_display.Location = new Point(0, 108);
            version_display.Name = "version_display";
            version_display.Size = new Size(100, 10);
            version_display.TabIndex = 21;
            version_display.Text = "Version: 0.0.1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 745);
            Controls.Add(version_display);
            Controls.Add(result_list);
            Controls.Add(sites_list);
            Controls.Add(found_display);
            Controls.Add(go_to_selected_btn);
            Controls.Add(search_name_btn);
            Controls.Add(sites_selected_display);
            Controls.Add(search_btn);
            Controls.Add(label5);
            Controls.Add(site_name_searchbox);
            Controls.Add(label4);
            Controls.Add(save_pref_btn);
            Controls.Add(deselect_all_btn);
            Controls.Add(select_all_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(game_name_box);
            Controls.Add(label1);
            Controls.Add(app_title_label);
            Controls.Add(main_menu_strip);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = main_menu_strip;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "GameScanner";
            main_menu_strip.ResumeLayout(false);
            main_menu_strip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label app_title_label;
        private MenuStrip main_menu_strip;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem siteadd_menu_btn;
        private ToolStripMenuItem settings_menu_btn;
        private ToolStripMenuItem info_menu_btn;
        private Label label1;
        private TextBox game_name_box;
        private Label label2;
        private Label label3;
        private Button select_all_btn;
        private Button deselect_all_btn;
        private Button save_pref_btn;
        private Label label4;
        private TextBox site_name_searchbox;
        private Label label5;
        private Button search_btn;
        private Label sites_selected_display;
        private Button search_name_btn;
        private Button go_to_selected_btn;
        private Label found_display;
        private ListView sites_list;
        private ListView result_list;
        private Label version_display;
    }
}
