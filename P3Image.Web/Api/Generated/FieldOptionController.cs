using System.Web.Http;
//using P3Image.Domain.Interfaces.Services;
using P3Image.App.Interfaces;

namespace P3Image.Web.Api
{
    [RoutePrefix("api/FieldOption")]
    public partial class FieldOptionController : ApiController
    {
        
		private readonly IFieldOptionApp _app;

        public FieldOptionController(IFieldOptionApp app)
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
            return Ok(Mapper.Map<List<FieldOption>, List<FieldOptionViewModel>>(model));
        }
		

        [Route("save")]
        [HttpPost]
        public IHttpActionResult Save(FieldOptionViewModel viewModel)
        {
            
			
            try
            { 
				var model = Mapper.Map<FieldOptionViewModel, FieldOption>(viewModel);
                var result = viewModel.Id <= 0 ? _app.Add(model) : _app.Update(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Error while saving Field Option");
            }
        }

		[Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(FieldOptionViewModel viewModel)
        {
            try
            {
				var model = Mapper.Map<FieldOptionViewModel, FieldOption>(viewModel);
                _app.Remove(model);
                return Ok();
            }
            catch
            {
                return BadRequest("Error while deleting Field Option");
            }
        }
		*/

    }
}

