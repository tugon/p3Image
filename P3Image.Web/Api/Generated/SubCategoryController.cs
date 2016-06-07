using System.Web.Http;
//using P3Image.Domain.Interfaces.Services;
using P3Image.App.Interfaces;

namespace P3Image.Web.Api
{
    [RoutePrefix("api/SubCategory")]
    public partial class SubCategoryController : ApiController
    {
        
		private readonly ISubCategoryApp _app;

        public SubCategoryController(ISubCategoryApp app)
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
            return Ok(Mapper.Map<List<SubCategory>, List<SubCategoryViewModel>>(model));
        }
		

        [Route("save")]
        [HttpPost]
        public IHttpActionResult Save(SubCategoryViewModel viewModel)
        {
            
			
            try
            { 
				var model = Mapper.Map<SubCategoryViewModel, SubCategory>(viewModel);
                var result = viewModel.Id <= 0 ? _app.Add(model) : _app.Update(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Error while saving Sub Category");
            }
        }

		[Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(SubCategoryViewModel viewModel)
        {
            try
            {
				var model = Mapper.Map<SubCategoryViewModel, SubCategory>(viewModel);
                _app.Remove(model);
                return Ok();
            }
            catch
            {
                return BadRequest("Error while deleting Sub Category");
            }
        }
		*/

    }
}

