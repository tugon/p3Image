using P3Image.App.Interfaces;
using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.App
{
    public class FieldApp : BaseApp<Field>, IFieldApp
    {
        private IFieldService _service;

        public FieldApp(IFieldService service)
            : base(service)
        {
            _service = service;
        }
    }
}