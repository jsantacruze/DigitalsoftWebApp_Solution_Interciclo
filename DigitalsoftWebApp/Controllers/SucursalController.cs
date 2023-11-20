using api.digitalsoftec.net.Api;
using api.digitalsoftec.net.Client;
using api.digitalsoftec.net.Model;
using Microsoft.AspNetCore.Mvc;

namespace DigitalsoftWebApp.Controllers
{
    public class SucursalController : BaseController
    {
        public SucursalController(IHttpContextAccessor httpContextAccessor, IConfiguration configuration) 
            : base(httpContextAccessor, configuration)
        {
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ConfigureUserData();
            Configuration apiConfiguration = new Configuration();
            apiConfiguration.BasePath = _base_url;
            apiConfiguration.AddDefaultHeader("Authorization", "Bearer " + _token);
            SucursalApi sucursalApi = new SucursalApi(apiConfiguration);
            var sucursal = await sucursalApi.ApiSucursalGetSucursalByIdPostAsync(new BusinessLayerAdminEmpresasHelpersFindSucursalRequest()
            {
                sucursal_id = id
            });
            return View(sucursal);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BusinessLayerAdminEmpresasDTOSucursalDTO sucursal)
        {
            ConfigureUserData();

            Configuration apiConfiguration = new Configuration();
            apiConfiguration.BasePath = _base_url;
            apiConfiguration.AddDefaultHeader("Authorization", "Bearer " + _token);
            SucursalApi sucursalApi = new SucursalApi(apiConfiguration);
            BusinessLayerAdminEmpresasHelpersEditSucursalRequest request = new BusinessLayerAdminEmpresasHelpersEditSucursalRequest();
            
            //CustomMapper.CopyProperties(sucursal, request);

            request.sucursal_id = sucursal.sucursal_id;
            request.sucursal_nombre = sucursal.sucursal_nombre;
            request.sucursal_nombre_comercial = sucursal.sucursal_nombre_comercial;
            request.sucursal_direccion = sucursal.sucursal_direccion;
            request.sucursal_direccion_ref = sucursal.sucursal_direccion_ref;
            request.sucursal_empresa_id = sucursal.sucursal_empresa_id;
            request.sucursal_email = "";
            request.sucursal_activa = true;
            request.sucursal_matriz = false;
            request.sucursal_movil = "";
            request.sucursal_observaciones = "";
            request.sucursal_parroquia_id = sucursal.sucursal_parroquia_id;
            request.sucursal_telefono = "";


            var edited = await sucursalApi.ApiSucursalEditSucursalPutAsync(request);
            TempData["SuccessMessage"] = "Sucursal guardada exitosamente!";
            TempData["SelectedTab"] = "sucursales";
            //TempData["SelectedTab"] = "sucursales";
            return RedirectToAction("Edit", "Empresa", new { id = sucursal.sucursal_empresa_id });
        }


    }
}
