using MediatR;

namespace Application.Brand.Commands
{
    public class UpdateBrandCommand : IRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
