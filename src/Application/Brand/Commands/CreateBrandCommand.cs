using MediatR;

namespace Application.Brand.Commands
{
    public class CreateBrandCommand : IRequest<long>
    {
        public string Name { get; set; }
    }
}
