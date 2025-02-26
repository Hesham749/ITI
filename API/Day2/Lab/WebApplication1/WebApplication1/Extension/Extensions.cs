using AutoMapper;

namespace WebApplication1.Extension
{
    public static class Extensions
    {
        public static IEnumerable<O> Pagination<T, O>(this IEnumerable<T> source, IMapper _map, int page = 1, int pageSize = 10)
            where T : class where O : class
        {
            if (source == null)
                return [];
            var size = source.Count();
            pageSize = (pageSize < 1) ? 10 : pageSize;
            int maxPages = (int)Math.Ceiling((double)size / pageSize);
            page = Math.Max(1, page);
            page = Math.Min(page, maxPages);
            var students = source.Chunk(pageSize).ToList()[page - 1];
            var studentsDTO = _map.Map<List<O>>(students);
            return studentsDTO;
        }

    }
}
