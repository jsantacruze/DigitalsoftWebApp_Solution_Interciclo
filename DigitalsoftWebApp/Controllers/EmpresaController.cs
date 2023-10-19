using api.digitalsoftec.net.Api;
using api.digitalsoftec.net.Client;
using api.digitalsoftec.net.Model;
using DigitalsoftWebApp.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigitalsoftWebApp.Controllers
{
    public class EmpresaController : BaseController
    {
        public EmpresaController(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
            : base(httpContextAccessor, configuration)
        {
        }

        public async Task<IActionResult> List()
        {
            ConfigureUserData();

            Configuration apiConfiguration = new Configuration();
            apiConfiguration.BasePath = _base_url;
            apiConfiguration.AddDefaultHeader("Authorization", "Bearer " + _token);

            EmpresaApi empresaApi = new EmpresaApi(apiConfiguration);
            var list = await empresaApi.ApiEmpresaListPostAsync(new api.digitalsoftec.net.Model.BusinessLayerAdminEmpresasHelpersListEmpresasRequest()
            {
                filtro = "",
                activa = true
            });
            return View(list);
        }

        private async Task<List<BusinessLayerCommonDTOTipoIdentificacionDTO>> getTipoIdentificacionList()
        {
            TipoIdentificacionApi api = new TipoIdentificacionApi(_apiConfiguration);
            return await api.ApiTipoIdentificacionListGetAsync();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);
            var empresa = await empresaApi.ApiEmpresaGetByIdPostAsync(new BusinessLayerAdminEmpresasHelpersFindEmpresaRequest()
            {
                empresa_id = id
            });

            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", empresa.tipo_identificacion_id);

            return View(empresa);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(BusinessLayerAdminEmpresasDTOEmpresaDTO empresa)
        {
            ConfigureUserData();
            EmpresaApi empresaApi = new EmpresaApi(_apiConfiguration);
            BusinessLayerAdminEmpresasHelpersEditEmpresaRequest request = new BusinessLayerAdminEmpresasHelpersEditEmpresaRequest();
            CustomMapper.CopyProperties(empresa, request);
            var edited = await empresaApi.ApiEmpresaEditPutAsync(request);
            TempData["SuccessMessage"] = "Datos guardados exitosamente!";
            List<BusinessLayerCommonDTOTipoIdentificacionDTO> tiposIdentificacion = await getTipoIdentificacionList();
            ViewBag.TiposIdentificacion = new SelectList(tiposIdentificacion, "tipo_identificacion_id", "tipo_identificacion_nombre", empresa.tipo_identificacion_id);
            return View(edited);
        }
    }
}
