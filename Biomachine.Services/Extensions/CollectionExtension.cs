using Biomachine.Services.Configurations;
using Newtonsoft.Json;

namespace Biomachine.Services.Extensions;

public static class CollectionExtension
{
    public static IEnumerable<T> ToPaginateAsEnumerableAsnyc<T>(this IQueryable<T> source, PaginationParams @params)
    {
        int totalCount = source.Count();

        var json = JsonConvert.SerializeObject(new PaginationMetaData(totalCount, @params));


    }
}
