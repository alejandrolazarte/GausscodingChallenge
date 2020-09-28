using MediatR;

namespace Application.Product.Commands
{
    public class DeleteProductCommand : IRequest
    {
        public long Id { get; }

        public DeleteProductCommand(long id)
        {
            Id = id;
        }
    }
}
