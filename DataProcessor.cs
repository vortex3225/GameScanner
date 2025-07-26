using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScanner
{
    public static class DataProcessor
    {
        public static List<ListViewItem> SearchList(string name_to_search, ListView.ListViewItemCollection list)
        {
            List<ListViewItem> fetched_results = new List<ListViewItem>();

            foreach (ListViewItem item in list)
            {
                if (item.Name.Contains(name_to_search))
                {
                    fetched_results.Add(item);
                }
            }

            return fetched_results;
        }

        public static List<string> ConvertCheckedCollectionToListString(ListView.CheckedListViewItemCollection collection)
        {
            List<string> converted_List = new List<string>();

            foreach (ListViewItem item in collection)
            {
                converted_List.Add(item.Name);
            }
            return converted_List;
        }

        public static SiteObject GetSiteObjectFromName(List<SiteObject> list, string name)
        {
            foreach (SiteObject obj in list)
            {
                if (obj.name == name)
                {
                    return obj;
                }
            }
            return null;
        }
    }
}