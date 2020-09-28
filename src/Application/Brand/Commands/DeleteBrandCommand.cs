using MediatR;

namespace Application.Brand.Commands
{
    public class DeleteBrandCommand : IRequest
    {
        public long Id { get; }

        public DeleteBrandCommand(long id)
        {
            Id = id;
        }
    }
}
