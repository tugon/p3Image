using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using P3Image.Domain.Entities;
using P3Image.Web.ViewModels;

namespace P3Image.Web.Api
{
    public partial class SubCategoryController
    {
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

        [Route("AddField")]
        [HttpPost]
        public IHttpActionResult AddField(FieldViewModel fieldViewModel)
        {
            try
            {
                var model = Mapper.Map<FieldViewModel, Field>(fieldViewModel);
                var result = _app.AddField(model);
                return Ok(Mapper.Map<FieldViewModel>(result));
            }
            catch
            {
                return BadRequest("Error while adding Field");
            }
        }

        [Route("editField")]
        [HttpPost]
        public IHttpActionResult EditField(FieldViewModel fieldViewModel)
        {
            try
            {
                var model = Mapper.Map<FieldViewModel, Field>(fieldViewModel);
                var result = _app.EditField(model);
                return Ok(Mapper.Map<FieldViewModel>(result));
            }
            catch
            {
                return BadRequest("Error while adding Field");
            }
        }

        [Route("removeField")]
        [HttpPost]
        public IHttpActionResult RemoveField(FieldViewModel fieldViewModel)
        {
            try
            {
                var model = Mapper.Map<FieldViewModel, Field>(fieldViewModel);
                _app.RemoveField(model);
                return Ok();
            }
            catch
            {
                return BadRequest("Error while removing Field");
            }
        }

        [Route("getFields")]
        [HttpPost]
        public IHttpActionResult GetFields(SubCategoryViewModel subCategory)
        {
            try
            {
                var model = Mapper.Map<SubCategory>(subCategory);
                var fields = _app.GetFields(model);
                return Ok(Mapper.Map<List<FieldViewModel>>(fields));
            }
            catch
            {
                return BadRequest("Error while removing Field");
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

        [Route("getBySlug")]
        [HttpGet]
        public IHttpActionResult GetBySlug(string slugCategory,string slugSubCategory)
        {
            var model = _app.GetBySlug(slugCategory,slugSubCategory);
            return Ok(model);
        }
    }
}