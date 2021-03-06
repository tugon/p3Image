﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using P3Image.Domain.Entities;
using P3Image.Web.ViewModels;

namespace P3Image.Web.Api
{
    public partial class FieldController
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
    }
}