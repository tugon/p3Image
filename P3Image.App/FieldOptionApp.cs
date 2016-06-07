using P3Image.App.Interfaces;
using P3Image.Domain.Entities;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.App
{
    public class FieldOptionApp : BaseApp<FieldOption>, IFieldOptionApp
    {
        private IFieldOptionService _service;

        public FieldOptionApp(IFieldOptionService service)
            : base(service)
        {
            _service = service;
        }
    }
}