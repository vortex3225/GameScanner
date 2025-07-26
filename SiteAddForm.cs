using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameScanner
{
    public partial class SiteAddForm : Form
    {
        public SiteAddForm()
        {
            InitializeComponent();
        }

        private bool isValidURL(string url_to_check)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(url_to_check, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string site_name = name_box.Text;
            string url = url_box.Text;
            string search_query_string = query_box.Text;

            bool isValid = (site_name == string.Empty || url == string.Empty || search_query_string == string.Empty) ? false : true;
            if (!isValidURL(url))
            {
                isValid = false;
                MessageBox.Show($"Invalid URL: {url}", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DatabaseHandler.CheckIfNameAlreadyExists(site_name) != null)
            {
                isValid = false;
                MessageBox.Show($"There is already a site saved under the name: {site_name}!", "Duplicate names", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isValid)
            {
                DatabaseHandler.SaveSite(site_name, url, search_query_string);
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be completed!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            name_box.Text = string.Empty;
            url_box.Text = string.Empty;
            query_box.Text = string.Empty;
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void sqstring_info_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("""
                The 'Search Query String' is the part of the URL which sites use to search for specific content. For example, on Youtube, if you search for 'e', the URL will look like this:
                https://www.youtube.com/results?search_query=e
                The part which you need to insert for this example would be: results?search_query
                This is very important as you will not be getting the correct results if you do not include the correct search query string. Currently there is no way of seeing the search queries of the sites
                you save without an external tool such as DB Browser for SQLite (TBA) so be very careful while inputting the string.
                """,
                "Search Query String Information",
                MessageBoxButtons.OK
                );
        }
    }
}


