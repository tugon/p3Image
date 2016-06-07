using System.Web.Http;
using P3Image.Domain.Interfaces.Services;

namespace P3Image.Web.Api
{
    [RoutePrefix("api/Category")]
    public partial class CategoryController : ApiController
    {
        
		private readonly ICategoryService _app;

        public CategoryController(ICategoryService app)
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
            return Ok(Mapper.Map<List<Category>, List<CategoryViewModel>>(model));
        }
		

        [Route("save")]
        [HttpPost]
        public IHttpActionResult Save(CategoryViewModel viewModel)
        {
            
			
            try
            { 
				var model = Mapper.Map<CategoryViewModel, Category>(viewModel);
                var result = viewModel.Id <= 0 ? _app.Add(model) : _app.Update(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Error while saving Category");
            }
        }

		[Route("remove")]
        [HttpPost]
        public IHttpActionResult Remove(CategoryViewModel viewModel)
        {
            try
            {
				var model = Mapper.Map<CategoryViewModel, Category>(viewModel);
                _app.Remove(model);
                return Ok();
            }
            catch
            {
                return BadRequest("Error while deleting Category");
            }
        }
		*/

    }
}

