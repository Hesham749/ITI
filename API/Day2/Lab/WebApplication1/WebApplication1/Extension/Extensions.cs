using AutoMapper;

namespace WebApplication1.Extension
{
    public static class Extensions
    {
        public static IEnumerable<O> Pagination<T, O>(this IEnumerable<T> source, IMapper _map, int page = 1, int pageSize = 10)
            where T : class where O : class
        {
            if (source == null || pageSize < 1 || page < 1) return [];
            int maxPages = (int)Math.Ceiling((double)source.Count() / pageSize);
            if (page > maxPages) return [];
            var studentsDTO = source.Skip((page - 1) * pageSize).Take(pageSize)
                .Select(s => _map.Map<O>(s));
            return studentsDTO;
        }

    }
}
