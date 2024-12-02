using Microsoft.EntityFrameworkCore;

namespace Core.Persistance.Paging;

public static class IQueryablePaginateExtensions
{
    public static async Task<Paginate<T>> ToPaginateAsync<T>(
        this IQueryable<T> source,
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        int count = await source.CountAsync(cancellationToken).ConfigureAwait(false);

        List<T> items = await source.Skip(pageNumber*pageSize).Take(pageSize).ToListAsync(cancellationToken).ConfigureAwait(false);
        Paginate<T> list = new()
        {
            Index = pageNumber,
            Count = count,
            Items = items,
            Size = pageSize,
            Pages = (int)Math.Ceiling(count / (double)pageSize)
        };
        return list;
    }
    
    public static Paginate<T> ToPaginate<T>(this IQueryable<T> source, int index, int size)
    {
        int count = source.Count();
        var items = source.Skip(index * size).Take(size).ToList();

        Paginate<T> list =
            new()
            {
                Index = index,
                Size = size,
                Count = count,
                Items = items,
                Pages = (int)Math.Ceiling(count / (double)size)
            };
        return list;
    }
}