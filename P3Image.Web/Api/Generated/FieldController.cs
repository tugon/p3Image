using System.Web.Http;
//using P3Image.Domain.Interfaces.Services;
using P3Image.App.Interfaces;

namespace P3Image.Web.Api
{
    [RoutePrefix("api/Field")]
    public partial class FieldController : ApiController
    {
        
		private readonly IFieldApp _app;

        public FieldController(IFieldApp app)
        {
            _app = app;
        }
		/*

		[Route("getById")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var model = _app.GetById(id);
            return Ok(model);
        }

        [Route("getAll")]
        [HttpGet]
        public IHttpActionResult GetByAll()
        {
            var model = _app.GetAll().ToList();
            return Ok(Mapper.Map<List<Field>, List<FieldViewModel>>(model));
        }
		

        [Route("save")]
        [HttpPost]
        public IHttpActionResult Save(FieldViewModel viewModel)
        {
            
			
            try
            { 
				var model = Mapper.Map<FieldViewModel, Field>(viewModel);
                var result = viewModel.Id <= 0 ? _app.Add(model) : _app.Update(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Error while saving Field");
            }
        }

		[Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(FieldViewModel viewModel)
        {
            try
            {
				var model = Mapper.Map<FieldViewModel, Field>(viewModel);
                _app.Remove(model);
                return Ok();
            }
            catch
            {
                return BadRequest("Error while deleting Field");
            }
        }
		*/

    }
}

