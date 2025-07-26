using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GameScanner
{
    public partial class MainForm : Form
    {
        List<SiteObject> fetched_sites = DatabaseHandler.GetSites();
        List<string> checked_items = new List<string>();
        Form siteAddForm = new SiteAddForm();
        private void InitSiteList()
        {
            foreach (SiteObject site in fetched_sites)
            {
                ListViewItem item = new ListViewItem();
                item.Name = site.name;
                item.Text = site.name;
                item.SubItems.Add(site.url);
                item.Checked = (checked_items.Contains(item.Name)) ? true : false;
                sites_list.Items.Add(item);
            }
            sites_selected_display.Text = $"Will search: 0/{sites_list.Items.Count} sites";
        }

        public MainForm()
        {
            InitializeComponent();
            sites_list.View = View.Details;
            sites_list.Columns.Add("Name", 180);
            sites_list.Columns.Add("URL", 286, HorizontalAlignment.Center);
            InitSiteList();
            result_list.View = View.List;
            version_display.Text = $"Version: {Program.APP_VERSION}";
        }


        public void AddSite(string name, string url)
        {
            ListViewItem item = new ListViewItem();
            item.Name = name;
            item.Text = name;
            item.SubItems.Add(url);
            item.SubItems.Add(name);
            item.Checked = false;
            sites_list.Items.Add(item);
            sites_selected_display.Text = $"Will search: 0/{sites_list.Items.Count} sites";
            fetched_sites = DatabaseHandler.GetSites();
        }


        // MENU STRIP BUTTONS
        private void siteadd_menu_btn_Click(object sender, EventArgs e)
        {
            siteAddForm = new SiteAddForm();
            siteAddForm.Show();
            siteAddForm.FormClosing += OnFormClosing;
        }

        private void settings_menu_btn_Click(object sender, EventArgs e)
        {
            //TODO: implement this.
        }
        private void info_menu_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"""
                GameScanner
                VERSION: {Program.APP_VERSION}

                GameScanner is an app which can check most sites for a specific game title saving time from having to search each site individually.

                To get started, add a new site using the Add button.
                You will need to fill out all of the respective fields. URLs must include https:// OR http:// and must be valid URL domains, ex: https://www.google.com would be a valid domain while
                www.google.com will not be considered a valid domain. (Subject to change)

                To delete a site after it has been created, select the site from the list by clicking on it and press backspace or delete. You will be prompted with a confirmation pop up first to
                reduce the chances of accidental deletion of sites.
                
                Check every site you want the program to search the specified game title in and wait until it displays the results.
                To go directly to the sites where the game title was found, select the link in the list and press the 'Go to selected site' button. You will be prompted with a confirmation pop up and after that,
                the site will open the link in the default browser (MS Edge).

                Check the Github page for updates and new features: https://github.com/vortex3225/GameScanner
                """,
                "GameScanner Information",
                MessageBoxButtons.OK
                );
        }

        // // //  // //////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                string x = siteAddForm.Controls["name_box"].Text;
                string y = siteAddForm.Controls["url_box"].Text;
                if (x != string.Empty && y != string.Empty)
                {
                    AddSite(x, y);
                }
            }
        }

        private void search_name_btn_Click(object sender, EventArgs e)
        {
            List<ListViewItem> search_results = DataProcessor.SearchList(site_name_searchbox.Text, sites_list.Items);

            sites_list.Items.Clear();
            if (site_name_searchbox.Text.Length > 0)
            {
                if (search_results.Count > 0)
                {
                    foreach (ListViewItem fetched_result in search_results)
                    {
                        sites_list.Items.Add(fetched_result);
                    }
                }
            }
            else
            {
                InitSiteList();
                foreach (ListViewItem existing_item in sites_list.Items)
                {
                    if (checked_items.Contains(existing_item.Name))
                    {
                        existing_item.Checked = true;
                    }
                }
            }
        }

        private void OnSiteChecked(object sender, ItemCheckedEventArgs e)
        {

            if (sites_list.Items.Count > 0)
            {
                ListViewItem item = e.Item;
                if (item.Checked)
                {
                    checked_items.Add(e.Item.Name);
                }
                else if (!item.Checked && checked_items.Contains(item.Name))
                {
                    checked_items.Remove(item.Name);
                }
                sites_selected_display.Text = $"Will search: {checked_items.Count}/{sites_list.Items.Count} sites";
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                ListViewItem selected = sites_list.SelectedItems[0];
                if (selected != null)
                {
                    if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to remove the following site: {selected.Name}?", $"Deleting {selected.Name}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SiteObject? fetched_obj = DataProcessor.GetSiteObjectFromName(fetched_sites, selected.Name);
                        sites_list.Items.RemoveByKey(selected.Name);
                        if (fetched_obj != null)
                        {
                            DatabaseHandler.DeleteSite(fetched_obj.name);
                            sites_selected_display.Text = $"Will search: 0/{sites_list.Items.Count} sites";
                        }
                        else
                        {
                            MessageBox.Show($"Could not find : {selected.Name} Item wasn't deleted!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled!");
                    }
                }
            }
        }

        private void select_all_btn_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show($"Are you sure you wish to select all sites? ({sites_list.Items.Count})", $"Selecting {sites_list.Items.Count} sites...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                foreach (ListViewItem item in sites_list.Items)
                {
                    item.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Cancelled!");
            }

        }

        private void deselect_all_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show($"Are you sure you wish to deselect all sites? ({checked_items.Count})", $"Deselecting {checked_items.Count} sites...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                foreach (ListViewItem item in sites_list.Items)
                {
                    item.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Cancelled!");
            }
        }

        private int found_results = 0;
        private void AddToFoundSites(string url, string real_url)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AddToFoundSites(url, real_url)));
                return;
            }

            ListViewItem item = new ListViewItem
            {
                Text = url,
                Name = real_url
            };
            result_list.Items.Add(item);

            found_results++;
        }


        private async void search_btn_Click(object sender, EventArgs e)
        {
            if (game_name_box.Text != string.Empty)
            {
                result_list.Items.Clear();
                found_results = 0;
                {
                    search_btn.Enabled = false;
                    search_btn.Text = $"Searching for {game_name_box.Text}...";
                    try
                    {
                        var tasks = new List<Task>();

                        foreach (ListViewItem checked_item in sites_list.CheckedItems)
                        {
                            var item = checked_item;
                            tasks.Add(Task.Run(async () =>
                            {
                                SiteObject obj = DataProcessor.GetSiteObjectFromName(fetched_sites, item.SubItems[0].Text);
                                if (obj != null)
                                {
                                    string formatted_url = $"{item.SubItems[1].Text}{obj.search_query_string}={game_name_box.Text}";
                                    bool has_title = await SiteGetter.CheckIfSiteHasTitle(game_name_box.Text, formatted_url);
                                    if (has_title)
                                    {
                                        Invoke(() => AddToFoundSites(obj.url, formatted_url));
                                    }
                                }
                            }));
                        }

                        await Task.WhenAll(tasks);
                        MessageBox.Show($"Found: {found_results} results!", $"{found_results} found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    search_btn.Enabled = true;
                    search_btn.Text = "Search";
                }
            }
            else
            {
                MessageBox.Show($"Please input a game title!", $"No game title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            found_display.Text = $"Found {found_results} results";
        }

        private void go_to_selected_btn_Click(object sender, EventArgs e)
        {
            ListViewItem? selected_item = (result_list.SelectedItems != null) ? result_list.SelectedItems[0] : null;
            if (DialogResult.Yes != MessageBox.Show($"Are you sure you wish to go to: {selected_item.Text}?", $"Redirecting to {selected_item.Text}", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) { return; }

            if (selected_item != null)
            {
                try
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo
                    {
                        UseShellExecute = true,
                        FileName = selected_item.Name,
                    };
                    Process.Start(processStartInfo);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an URL from the list first!");
            }
        }
    }
}

