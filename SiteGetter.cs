using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace GameScanner
{
    /// <summary>
    /// Gets the sites html and checks if the game title appears anywhere on the site
    /// </summary>
    public static class SiteGetter
    {
        private static HttpClient httpClient = new HttpClient()
        {
            Timeout = TimeSpan.FromSeconds(5)
        };
        public static async Task<bool> CheckIfSiteHasTitle(string game_title, string url)
        {
            try
            {
                // Download the HTML content
                var html = await httpClient.GetStringAsync(url);

                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);

                // Remove script, style, input, and textarea nodes
                var nodesToRemove = htmlDoc.DocumentNode
                    .SelectNodes("//script|//style|//input|//textarea");

                if (nodesToRemove != null)
                {
                    foreach (var node in nodesToRemove)
                        node.Remove();
                }

                // Get all remaining visible text
                var bodyText = htmlDoc.DocumentNode
                    .SelectSingleNode("//body")?
                    .InnerText ?? "";

                // Normalize text for comparison
                string normalizedBodyText = bodyText.ToLowerInvariant();
                string normalizedGameTitle = game_title.ToLowerInvariant();

                return normalizedBodyText.Contains(normalizedGameTitle);
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
