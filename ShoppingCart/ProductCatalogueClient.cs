using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ProductCatalogueClient : IProductCatalogueClient
    {
        private static string productCatalogBaseUrl =
        @"http://private-05cc8-chapter2productcatalogmicroservice.apiary-mock.com";
        private static string getProductPathTemplate = "/products?productIds=[{0}]";

        private static async Task<HttpResponseMessage> RequestProductFromProductCatalogue(int[] productCatalogueIds)
        {
            var productResource = string.Format(
                getProductPathTemplate, string.Join(",", productCatalogueIds));
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(productCatalogBaseUrl);
                return await httpClient.GetAsync(productResource).ConfigureAwait(false);
            }
        }
    }
}