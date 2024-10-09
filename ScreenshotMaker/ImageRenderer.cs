using HtmlAgilityPack;
using PuppeteerSharp;

namespace ScreenshotMaker
{
    public class ImageRenderer : IDisposable
    {
        private BrowserFetcher _browserFetcher;
        private static readonly string[] options = new[] { "--window-size=3840,2160" };

        public ImageRenderer()
        {
            _browserFetcher = new BrowserFetcher();
        }

        public async Task<byte[]> GetDataFromURL(string htmlUrl)
        {
            try
            {
                var client = new HttpClient();
                var linkList = new List<string>();
                var html = await client.GetStringAsync(htmlUrl);

                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(html);

                var anchorTags = htmlDoc.DocumentNode.SelectNodes("//a[@href]");
                if (anchorTags != null)
                {
                    foreach (var tag in anchorTags)
                    {
                        var link = tag.GetAttributeValue("href", string.Empty);

                        if (!string.IsNullOrEmpty(link))
                        {
                            linkList.Add(link);
                        }
                    }
                }

                foreach (var link in linkList)
                {
                    Console.WriteLine(link);
                }
                Console.WriteLine("=======================================================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public void Dispose()
        {
            _browserFetcher = null;
        }

        public async Task CreateScreen(string url)
        {
            await new BrowserFetcher().DownloadAsync();

            using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true,
                DefaultViewport = new ViewPortOptions()
                {
                    Width = 2160,
                    Height = 3840,
                    IsLandscape = false,
                },
                Timeout = 3000,
                Args = options,
                AcceptInsecureCerts = true,
                EnqueueAsyncMessages = true
            });

            using var page = await browser.NewPageAsync();

            var response = await page.GoToAsync(url);

            await page.SetViewportAsync(new ViewPortOptions
            {
                Width = 2160,
                Height = 3840
            });

            await page.ScreenshotAsync(Path.Combine(Directory.GetCurrentDirectory(), "test_image_from_url_2.png"));

            await browser.CloseAsync();

            Console.WriteLine("Screenshot saved!");
        }
    }
}