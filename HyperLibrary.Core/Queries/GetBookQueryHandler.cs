using HyperLibrary.Core.LibraryModel;
using HyperLibrary.Core.Resources;

namespace HyperLibrary.Core.Queries
{
    public class GetBookQueryHandler
    {
        private readonly IInMemoryBookRepository _bookRepository;
        private readonly BookResourceMapper _bookResourceMapper;

        public GetBookQueryHandler(IInMemoryBookRepository bookRepository, BookResourceMapper bookResourceMapper)
        {
            _bookRepository = bookRepository;
            _bookResourceMapper = bookResourceMapper;
        }

        public BookResource Query(int bookId)
        {
            var book = _bookRepository.Get(bookId);
            var resource = _bookResourceMapper.MapToResouce(book);
            return resource;
        }
    }
}