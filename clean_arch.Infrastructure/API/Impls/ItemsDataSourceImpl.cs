using clean_arch.Data.DTOs;
using clean_arch.Data.Repository;
using clean_arch.Infrastructure.API.Models;
using clean_arch.Infrastructure.API.Mappers;
using System.Net.Http.Json;

namespace clean_arch.Infrastructure.API.Impls
{
    public class ItemsDataSourceImpl(IHttpClientFactory httpClientFactory) : ItemsDataSource
    {
        IHttpClientFactory httpClientFactory = httpClientFactory;

        public Task<bool> AddItem(ItemDTO itemDTO)
        {
            return Task.FromResult(true);
        }

        public async Task<List<ItemDTO>> GetItems()
        {
            using HttpClient client = httpClientFactory.CreateClient();

            List<ItemApi> items = await client.GetFromJsonAsync<List<ItemApi>>("http://localhost:8000/api/getitems");
            List<ItemDTO> result = new();
            foreach (ItemApi item in items)
            {
                result.Add(ItemApiToItemDTOMapper.Map(item));
            }
            return result;
        }
    }
}
