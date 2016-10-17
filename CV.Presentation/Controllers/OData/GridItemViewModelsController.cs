using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using CV.Presentation.Models.Pruebas;
using Microsoft.Data.OData;
using CV.Domain.Service.Contract;
using CV.Domain.DTO;

namespace CV.Presentation.Controllers.OData
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using CV.Presentation.Models.Pruebas;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<GridItemViewModel>("GridItemViewModels");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class GridItemViewModelsController : ODataController
    {

        private IUsuarioService _usuarios;

        public GridItemViewModelsController(IUsuarioService usuarios)
        {
            _usuarios = usuarios;
        }

        private static List<GridItemViewModel> _items;
        private static List<GridItemViewModel> items {
            get
            {
                if(_items == null)
                {
                    _items = new List<GridItemViewModel>();
                    var rand = new Random();
                    for (var i = 0; i < 100; i++)
                    {
                        _items.Add(new GridItemViewModel()
                        {
                            ID = i,
                            Nombre = "Nombre " + i,
                            Valor = rand.NextDouble() * 1000,
                            Fecha = DateTime.Now
                        });
                    }
                }
                return _items;
            }
        }
            

        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/GridItemViewModels
        public IHttpActionResult GetGridItemViewModels2(ODataQueryOptions<GridItemViewModel> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<GridItemViewModel>>(gridItemViewModels);
            //return StatusCode(HttpStatusCode.NotImplemented);

            var result = queryOptions.ApplyTo(items.AsQueryable()) as IQueryable<GridItemViewModel>;

            return Ok<IEnumerable<GridItemViewModel>>(result);
        }


        // GET: odata/GridItemViewModels
        public IHttpActionResult GetGridItemViewModels(ODataQueryOptions<UsuarioDTO> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<GridItemViewModel>>(gridItemViewModels);
            //return StatusCode(HttpStatusCode.NotImplemented);
            
            var result = _usuarios.Query(queryOptions) as IQueryable<UsuarioDTO>;

            return Ok<IEnumerable<UsuarioDTO>>(result);
        }

        /*
        [EnableQuery]
        public IQueryable<GridItemViewModel> Get()
        {
            return items.AsQueryable();
        }
        [EnableQuery]
        public SingleResult<GridItemViewModel> Get([FromODataUri] int key)
        {
            IQueryable<GridItemViewModel> result = items.AsQueryable().Where(p => p.ID == key);
            return SingleResult.Create(result);
        }
        */

        // GET: odata/GridItemViewModels(5)
        public IHttpActionResult GetGridItemViewModel([FromODataUri] int key, ODataQueryOptions<GridItemViewModel> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<GridItemViewModel>(gridItemViewModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/GridItemViewModels(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<GridItemViewModel> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(gridItemViewModel);

            // TODO: Save the patched entity.

            // return Updated(gridItemViewModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/GridItemViewModels
        public IHttpActionResult Post(GridItemViewModel gridItemViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(gridItemViewModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/GridItemViewModels(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<GridItemViewModel> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(gridItemViewModel);

            // TODO: Save the patched entity.

            // return Updated(gridItemViewModel);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/GridItemViewModels(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
