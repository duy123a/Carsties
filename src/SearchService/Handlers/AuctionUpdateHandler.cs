using Contracts;
using Mapster;
using Meilisearch;
using SearchService.Models;

namespace SearchService.Handlers
{
    public class AuctionUpdateHandler
    {
        public async Task Handle(
            AuctionUpdated message,
            MeilisearchClient client)
        {
            var item = message.Adapt<Item>();

            await client.Index("items").UpdateDocumentsAsync([item]);
        }
    }
}
