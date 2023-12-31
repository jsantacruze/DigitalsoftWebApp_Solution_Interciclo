/* 
 * API Servicios Integrados InventPro ERP - DigitalsoftEC
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = api.digitalsoftec.net.Client.SwaggerDateConverter;
namespace api.digitalsoftec.net.Model
{
    /// <summary>
    /// BusinessLayerAdminEmpresasDTOEmpresaDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerAdminEmpresasDTOEmpresaDTO :  IEquatable<BusinessLayerAdminEmpresasDTOEmpresaDTO>, IValidatableObject
    {
        public BusinessLayerAdminEmpresasDTOEmpresaDTO()
        { 
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerAdminEmpresasDTOEmpresaDTO" /> class.
        /// </summary>
        /// <param name="empresaId">empresaId.</param>
        /// <param name="empresaCodigoInterno">empresaCodigoInterno.</param>
        /// <param name="empresaRazonSocial">empresaRazonSocial.</param>
        /// <param name="empresaNombreComercial">empresaNombreComercial.</param>
        /// <param name="empresaActiva">empresaActiva.</param>
        /// <param name="empresaNroIdentificacion">empresaNroIdentificacion.</param>
        /// <param name="tipoIdentificacionId">tipoIdentificacionId.</param>
        /// <param name="tipoIdentificacion">tipoIdentificacion.</param>
        /// <param name="empresaTelefono">empresaTelefono.</param>
        /// <param name="empresaMovil">empresaMovil.</param>
        /// <param name="empresaDireccionPrincipal">empresaDireccionPrincipal.</param>
        /// <param name="empresaDireccionRef">empresaDireccionRef.</param>
        /// <param name="empresaEmail">empresaEmail.</param>
        /// <param name="empresaSiteUrl">empresaSiteUrl.</param>
        /// <param name="empresaSlogan">empresaSlogan.</param>
        /// <param name="empresaContribuyenteEspecial">empresaContribuyenteEspecial.</param>
        /// <param name="empresaObligadoContabilidad">empresaObligadoContabilidad.</param>
        /// <param name="empresaRealizaAts">empresaRealizaAts.</param>
        /// <param name="empresaAgenteRetencion">empresaAgenteRetencion.</param>
        /// <param name="empresaLogo">empresaLogo.</param>
        /// <param name="empresaRepLegalId">empresaRepLegalId.</param>
        /// <param name="empresaRepLegal">empresaRepLegal.</param>
        /// <param name="empresaConatdorId">empresaConatdorId.</param>
        /// <param name="empresaContadorName">empresaContadorName.</param>
        /// <param name="empresaRegimenTributarioId">empresaRegimenTributarioId.</param>
        /// <param name="regimenTributario">regimenTributario.</param>
        /// <param name="empresaParroquiaId">empresaParroquiaId.</param>
        /// <param name="parroquia">parroquia.</param>
        /// <param name="empresaTipoAgenteRetencionId">empresaTipoAgenteRetencionId.</param>
        /// <param name="tipoAgenteRetencion">tipoAgenteRetencion.</param>
        /// <param name="sucursales">sucursales.</param>
        /// <param name="tarifasVentaDetalle">tarifasVentaDetalle.</param>
        public BusinessLayerAdminEmpresasDTOEmpresaDTO(int? empresaId = default(int?), string empresaCodigoInterno = default(string), string empresaRazonSocial = default(string), string empresaNombreComercial = default(string), bool? empresaActiva = default(bool?), string empresaNroIdentificacion = default(string), int? tipoIdentificacionId = default(int?), BusinessLayerCommonDTOTipoIdentificacionDTO tipoIdentificacion = default(BusinessLayerCommonDTOTipoIdentificacionDTO), string empresaTelefono = default(string), string empresaMovil = default(string), string empresaDireccionPrincipal = default(string), string empresaDireccionRef = default(string), string empresaEmail = default(string), string empresaSiteUrl = default(string), string empresaSlogan = default(string), bool? empresaContribuyenteEspecial = default(bool?), bool? empresaObligadoContabilidad = default(bool?), bool? empresaRealizaAts = default(bool?), bool? empresaAgenteRetencion = default(bool?), byte[] empresaLogo = default(byte[]), string empresaRepLegalId = default(string), string empresaRepLegal = default(string), string empresaConatdorId = default(string), string empresaContadorName = default(string), int? empresaRegimenTributarioId = default(int?), BusinessLayerCommonDTORegimenTributarioDTO regimenTributario = default(BusinessLayerCommonDTORegimenTributarioDTO), string empresaParroquiaId = default(string), BusinessLayerAdminUbicacionesDTOParroquiaDTO parroquia = default(BusinessLayerAdminUbicacionesDTOParroquiaDTO), int? empresaTipoAgenteRetencionId = default(int?), BusinessLayerCommonDTOTipoAgenteRetencionDTO tipoAgenteRetencion = default(BusinessLayerCommonDTOTipoAgenteRetencionDTO), List<BusinessLayerAdminEmpresasDTOSucursalDTO> sucursales = default(List<BusinessLayerAdminEmpresasDTOSucursalDTO>), List<BusinessLayerVentasTransaccionesDTOTarifaVentaDetalleEmpresaDTO> tarifasVentaDetalle = default(List<BusinessLayerVentasTransaccionesDTOTarifaVentaDetalleEmpresaDTO>))
        {
            this.empresa_id = empresaId;
            this.empresa_codigo_interno = empresaCodigoInterno;
            this.empresa_razon_social = empresaRazonSocial;
            this.empresa_nombre_comercial = empresaNombreComercial;
            this.empresa_activa = empresaActiva;
            this.empresa_nro_identificacion = empresaNroIdentificacion;
            this.tipo_identificacion_id = tipoIdentificacionId;
            this.tipo_identificacion = tipoIdentificacion;
            this.empresa_telefono = empresaTelefono;
            this.empresa_movil = empresaMovil;
            this.empresa_direccion_principal = empresaDireccionPrincipal;
            this.empresa_direccion_ref = empresaDireccionRef;
            this.empresa_email = empresaEmail;
            this.empresa_site_url = empresaSiteUrl;
            this.empresa_slogan = empresaSlogan;
            this.empresa_contribuyente_especial = empresaContribuyenteEspecial;
            this.empresa_obligado_contabilidad = empresaObligadoContabilidad;
            this.empresa_realiza_ats = empresaRealizaAts;
            this.empresa_agente_retencion = empresaAgenteRetencion;
            this.empresa_logo = empresaLogo;
            this.empresa_rep_legal_id = empresaRepLegalId;
            this.empresa_rep_legal = empresaRepLegal;
            this.empresa_conatdor_id = empresaConatdorId;
            this.empresa_contador_name = empresaContadorName;
            this.empresa_regimen_tributario_id = empresaRegimenTributarioId;
            this.regimen_tributario = regimenTributario;
            this.empresa_parroquia_id = empresaParroquiaId;
            this.parroquia = parroquia;
            this.empresa_tipo_agente_retencion_id = empresaTipoAgenteRetencionId;
            this.tipo_agente_retencion = tipoAgenteRetencion;
            this.sucursales = sucursales;
            this.tarifas_venta_detalle = tarifasVentaDetalle;
        }
        
        /// <summary>
        /// Gets or Sets empresa_id
        /// </summary>
        [DataMember(Name="empresa_id", EmitDefaultValue=false)]
        public int? empresa_id { get; set; }

        /// <summary>
        /// Gets or Sets empresa_codigo_interno
        /// </summary>
        [DataMember(Name="empresa_codigo_interno", EmitDefaultValue=false)]
        public string empresa_codigo_interno { get; set; }

        /// <summary>
        /// Gets or Sets empresa_razon_social
        /// </summary>
        [DataMember(Name="empresa_razon_social", EmitDefaultValue=false)]
        public string empresa_razon_social { get; set; }

        /// <summary>
        /// Gets or Sets empresa_nombre_comercial
        /// </summary>
        [DataMember(Name="empresa_nombre_comercial", EmitDefaultValue=false)]
        public string empresa_nombre_comercial { get; set; }

        /// <summary>
        /// Gets or Sets empresa_activa
        /// </summary>
        [DataMember(Name="empresa_activa", EmitDefaultValue=false)]
        public bool? empresa_activa { get; set; }

        /// <summary>
        /// Gets or Sets empresa_nro_identificacion
        /// </summary>
        [DataMember(Name="empresa_nro_identificacion", EmitDefaultValue=false)]
        public string empresa_nro_identificacion { get; set; }

        /// <summary>
        /// Gets or Sets tipo_identificacion_id
        /// </summary>
        [DataMember(Name="tipo_identificacion_id", EmitDefaultValue=false)]
        public int? tipo_identificacion_id { get; set; }

        /// <summary>
        /// Gets or Sets tipo_identificacion
        /// </summary>
        [DataMember(Name="tipoIdentificacion", EmitDefaultValue=false)]
        public BusinessLayerCommonDTOTipoIdentificacionDTO tipo_identificacion { get; set; }

        /// <summary>
        /// Gets or Sets empresa_telefono
        /// </summary>
        [DataMember(Name="empresa_telefono", EmitDefaultValue=false)]
        public string empresa_telefono { get; set; }

        /// <summary>
        /// Gets or Sets empresa_movil
        /// </summary>
        [DataMember(Name="empresa_movil", EmitDefaultValue=false)]
        public string empresa_movil { get; set; }

        /// <summary>
        /// Gets or Sets empresa_direccion_principal
        /// </summary>
        [DataMember(Name="empresa_direccion_principal", EmitDefaultValue=false)]
        public string empresa_direccion_principal { get; set; }

        /// <summary>
        /// Gets or Sets empresa_direccion_ref
        /// </summary>
        [DataMember(Name="empresa_direccion_ref", EmitDefaultValue=false)]
        public string empresa_direccion_ref { get; set; }

        /// <summary>
        /// Gets or Sets empresa_email
        /// </summary>
        [DataMember(Name="empresa_email", EmitDefaultValue=false)]
        public string empresa_email { get; set; }

        /// <summary>
        /// Gets or Sets empresa_site_url
        /// </summary>
        [DataMember(Name="empresa_site_url", EmitDefaultValue=false)]
        public string empresa_site_url { get; set; }

        /// <summary>
        /// Gets or Sets empresa_slogan
        /// </summary>
        [DataMember(Name="empresa_slogan", EmitDefaultValue=false)]
        public string empresa_slogan { get; set; }

        /// <summary>
        /// Gets or Sets empresa_contribuyente_especial
        /// </summary>
        [DataMember(Name="empresa_contribuyente_especial", EmitDefaultValue=false)]
        public bool? empresa_contribuyente_especial { get; set; }

        /// <summary>
        /// Gets or Sets empresa_obligado_contabilidad
        /// </summary>
        [DataMember(Name="empresa_obligado_contabilidad", EmitDefaultValue=false)]
        public bool? empresa_obligado_contabilidad { get; set; }

        /// <summary>
        /// Gets or Sets empresa_realiza_ats
        /// </summary>
        [DataMember(Name="empresa_realiza_ats", EmitDefaultValue=false)]
        public bool? empresa_realiza_ats { get; set; }

        /// <summary>
        /// Gets or Sets empresa_agente_retencion
        /// </summary>
        [DataMember(Name="empresa_agente_retencion", EmitDefaultValue=false)]
        public bool? empresa_agente_retencion { get; set; }

        /// <summary>
        /// Gets or Sets empresa_logo
        /// </summary>
        [DataMember(Name="empresa_logo", EmitDefaultValue=false)]
        public byte[] empresa_logo { get; set; }

        /// <summary>
        /// Gets or Sets empresa_rep_legal_id
        /// </summary>
        [DataMember(Name="empresa_rep_legal_id", EmitDefaultValue=false)]
        public string empresa_rep_legal_id { get; set; }

        /// <summary>
        /// Gets or Sets empresa_rep_legal
        /// </summary>
        [DataMember(Name="empresa_rep_legal", EmitDefaultValue=false)]
        public string empresa_rep_legal { get; set; }

        /// <summary>
        /// Gets or Sets empresa_conatdor_id
        /// </summary>
        [DataMember(Name="empresa_conatdor_id", EmitDefaultValue=false)]
        public string empresa_conatdor_id { get; set; }

        /// <summary>
        /// Gets or Sets empresa_contador_name
        /// </summary>
        [DataMember(Name="empresa_contador_name", EmitDefaultValue=false)]
        public string empresa_contador_name { get; set; }

        /// <summary>
        /// Gets or Sets empresa_regimen_tributario_id
        /// </summary>
        [DataMember(Name="empresa_regimen_tributario_id", EmitDefaultValue=false)]
        public int? empresa_regimen_tributario_id { get; set; }

        /// <summary>
        /// Gets or Sets regimen_tributario
        /// </summary>
        [DataMember(Name="regimenTributario", EmitDefaultValue=false)]
        public BusinessLayerCommonDTORegimenTributarioDTO regimen_tributario { get; set; }

        /// <summary>
        /// Gets or Sets empresa_parroquia_id
        /// </summary>
        [DataMember(Name="empresa_parroquia_id", EmitDefaultValue=false)]
        public string empresa_parroquia_id { get; set; }

        /// <summary>
        /// Gets or Sets parroquia
        /// </summary>
        [DataMember(Name="parroquia", EmitDefaultValue=false)]
        public BusinessLayerAdminUbicacionesDTOParroquiaDTO parroquia { get; set; }

        /// <summary>
        /// Gets or Sets empresa_tipo_agente_retencion_id
        /// </summary>
        [DataMember(Name="empresa_tipo_agente_retencion_id", EmitDefaultValue=false)]
        public int? empresa_tipo_agente_retencion_id { get; set; }

        /// <summary>
        /// Gets or Sets tipo_agente_retencion
        /// </summary>
        [DataMember(Name="tipoAgenteRetencion", EmitDefaultValue=false)]
        public BusinessLayerCommonDTOTipoAgenteRetencionDTO tipo_agente_retencion { get; set; }

        /// <summary>
        /// Gets or Sets sucursales
        /// </summary>
        [DataMember(Name="sucursales", EmitDefaultValue=false)]
        public List<BusinessLayerAdminEmpresasDTOSucursalDTO> sucursales { get; set; }

        /// <summary>
        /// Gets or Sets tarifas_venta_detalle
        /// </summary>
        [DataMember(Name="tarifas_venta_detalle", EmitDefaultValue=false)]
        public List<BusinessLayerVentasTransaccionesDTOTarifaVentaDetalleEmpresaDTO> tarifas_venta_detalle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerAdminEmpresasDTOEmpresaDTO {\n");
            sb.Append("  empresa_id: ").Append(empresa_id).Append("\n");
            sb.Append("  empresa_codigo_interno: ").Append(empresa_codigo_interno).Append("\n");
            sb.Append("  empresa_razon_social: ").Append(empresa_razon_social).Append("\n");
            sb.Append("  empresa_nombre_comercial: ").Append(empresa_nombre_comercial).Append("\n");
            sb.Append("  empresa_activa: ").Append(empresa_activa).Append("\n");
            sb.Append("  empresa_nro_identificacion: ").Append(empresa_nro_identificacion).Append("\n");
            sb.Append("  tipo_identificacion_id: ").Append(tipo_identificacion_id).Append("\n");
            sb.Append("  tipo_identificacion: ").Append(tipo_identificacion).Append("\n");
            sb.Append("  empresa_telefono: ").Append(empresa_telefono).Append("\n");
            sb.Append("  empresa_movil: ").Append(empresa_movil).Append("\n");
            sb.Append("  empresa_direccion_principal: ").Append(empresa_direccion_principal).Append("\n");
            sb.Append("  empresa_direccion_ref: ").Append(empresa_direccion_ref).Append("\n");
            sb.Append("  empresa_email: ").Append(empresa_email).Append("\n");
            sb.Append("  empresa_site_url: ").Append(empresa_site_url).Append("\n");
            sb.Append("  empresa_slogan: ").Append(empresa_slogan).Append("\n");
            sb.Append("  empresa_contribuyente_especial: ").Append(empresa_contribuyente_especial).Append("\n");
            sb.Append("  empresa_obligado_contabilidad: ").Append(empresa_obligado_contabilidad).Append("\n");
            sb.Append("  empresa_realiza_ats: ").Append(empresa_realiza_ats).Append("\n");
            sb.Append("  empresa_agente_retencion: ").Append(empresa_agente_retencion).Append("\n");
            sb.Append("  empresa_logo: ").Append(empresa_logo).Append("\n");
            sb.Append("  empresa_rep_legal_id: ").Append(empresa_rep_legal_id).Append("\n");
            sb.Append("  empresa_rep_legal: ").Append(empresa_rep_legal).Append("\n");
            sb.Append("  empresa_conatdor_id: ").Append(empresa_conatdor_id).Append("\n");
            sb.Append("  empresa_contador_name: ").Append(empresa_contador_name).Append("\n");
            sb.Append("  empresa_regimen_tributario_id: ").Append(empresa_regimen_tributario_id).Append("\n");
            sb.Append("  regimen_tributario: ").Append(regimen_tributario).Append("\n");
            sb.Append("  empresa_parroquia_id: ").Append(empresa_parroquia_id).Append("\n");
            sb.Append("  parroquia: ").Append(parroquia).Append("\n");
            sb.Append("  empresa_tipo_agente_retencion_id: ").Append(empresa_tipo_agente_retencion_id).Append("\n");
            sb.Append("  tipo_agente_retencion: ").Append(tipo_agente_retencion).Append("\n");
            sb.Append("  sucursales: ").Append(sucursales).Append("\n");
            sb.Append("  tarifas_venta_detalle: ").Append(tarifas_venta_detalle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessLayerAdminEmpresasDTOEmpresaDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerAdminEmpresasDTOEmpresaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerAdminEmpresasDTOEmpresaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerAdminEmpresasDTOEmpresaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.empresa_id == input.empresa_id ||
                    (this.empresa_id != null &&
                    this.empresa_id.Equals(input.empresa_id))
                ) && 
                (
                    this.empresa_codigo_interno == input.empresa_codigo_interno ||
                    (this.empresa_codigo_interno != null &&
                    this.empresa_codigo_interno.Equals(input.empresa_codigo_interno))
                ) && 
                (
                    this.empresa_razon_social == input.empresa_razon_social ||
                    (this.empresa_razon_social != null &&
                    this.empresa_razon_social.Equals(input.empresa_razon_social))
                ) && 
                (
                    this.empresa_nombre_comercial == input.empresa_nombre_comercial ||
                    (this.empresa_nombre_comercial != null &&
                    this.empresa_nombre_comercial.Equals(input.empresa_nombre_comercial))
                ) && 
                (
                    this.empresa_activa == input.empresa_activa ||
                    (this.empresa_activa != null &&
                    this.empresa_activa.Equals(input.empresa_activa))
                ) && 
                (
                    this.empresa_nro_identificacion == input.empresa_nro_identificacion ||
                    (this.empresa_nro_identificacion != null &&
                    this.empresa_nro_identificacion.Equals(input.empresa_nro_identificacion))
                ) && 
                (
                    this.tipo_identificacion_id == input.tipo_identificacion_id ||
                    (this.tipo_identificacion_id != null &&
                    this.tipo_identificacion_id.Equals(input.tipo_identificacion_id))
                ) && 
                (
                    this.tipo_identificacion == input.tipo_identificacion ||
                    (this.tipo_identificacion != null &&
                    this.tipo_identificacion.Equals(input.tipo_identificacion))
                ) && 
                (
                    this.empresa_telefono == input.empresa_telefono ||
                    (this.empresa_telefono != null &&
                    this.empresa_telefono.Equals(input.empresa_telefono))
                ) && 
                (
                    this.empresa_movil == input.empresa_movil ||
                    (this.empresa_movil != null &&
                    this.empresa_movil.Equals(input.empresa_movil))
                ) && 
                (
                    this.empresa_direccion_principal == input.empresa_direccion_principal ||
                    (this.empresa_direccion_principal != null &&
                    this.empresa_direccion_principal.Equals(input.empresa_direccion_principal))
                ) && 
                (
                    this.empresa_direccion_ref == input.empresa_direccion_ref ||
                    (this.empresa_direccion_ref != null &&
                    this.empresa_direccion_ref.Equals(input.empresa_direccion_ref))
                ) && 
                (
                    this.empresa_email == input.empresa_email ||
                    (this.empresa_email != null &&
                    this.empresa_email.Equals(input.empresa_email))
                ) && 
                (
                    this.empresa_site_url == input.empresa_site_url ||
                    (this.empresa_site_url != null &&
                    this.empresa_site_url.Equals(input.empresa_site_url))
                ) && 
                (
                    this.empresa_slogan == input.empresa_slogan ||
                    (this.empresa_slogan != null &&
                    this.empresa_slogan.Equals(input.empresa_slogan))
                ) && 
                (
                    this.empresa_contribuyente_especial == input.empresa_contribuyente_especial ||
                    (this.empresa_contribuyente_especial != null &&
                    this.empresa_contribuyente_especial.Equals(input.empresa_contribuyente_especial))
                ) && 
                (
                    this.empresa_obligado_contabilidad == input.empresa_obligado_contabilidad ||
                    (this.empresa_obligado_contabilidad != null &&
                    this.empresa_obligado_contabilidad.Equals(input.empresa_obligado_contabilidad))
                ) && 
                (
                    this.empresa_realiza_ats == input.empresa_realiza_ats ||
                    (this.empresa_realiza_ats != null &&
                    this.empresa_realiza_ats.Equals(input.empresa_realiza_ats))
                ) && 
                (
                    this.empresa_agente_retencion == input.empresa_agente_retencion ||
                    (this.empresa_agente_retencion != null &&
                    this.empresa_agente_retencion.Equals(input.empresa_agente_retencion))
                ) && 
                (
                    this.empresa_logo == input.empresa_logo ||
                    (this.empresa_logo != null &&
                    this.empresa_logo.Equals(input.empresa_logo))
                ) && 
                (
                    this.empresa_rep_legal_id == input.empresa_rep_legal_id ||
                    (this.empresa_rep_legal_id != null &&
                    this.empresa_rep_legal_id.Equals(input.empresa_rep_legal_id))
                ) && 
                (
                    this.empresa_rep_legal == input.empresa_rep_legal ||
                    (this.empresa_rep_legal != null &&
                    this.empresa_rep_legal.Equals(input.empresa_rep_legal))
                ) && 
                (
                    this.empresa_conatdor_id == input.empresa_conatdor_id ||
                    (this.empresa_conatdor_id != null &&
                    this.empresa_conatdor_id.Equals(input.empresa_conatdor_id))
                ) && 
                (
                    this.empresa_contador_name == input.empresa_contador_name ||
                    (this.empresa_contador_name != null &&
                    this.empresa_contador_name.Equals(input.empresa_contador_name))
                ) && 
                (
                    this.empresa_regimen_tributario_id == input.empresa_regimen_tributario_id ||
                    (this.empresa_regimen_tributario_id != null &&
                    this.empresa_regimen_tributario_id.Equals(input.empresa_regimen_tributario_id))
                ) && 
                (
                    this.regimen_tributario == input.regimen_tributario ||
                    (this.regimen_tributario != null &&
                    this.regimen_tributario.Equals(input.regimen_tributario))
                ) && 
                (
                    this.empresa_parroquia_id == input.empresa_parroquia_id ||
                    (this.empresa_parroquia_id != null &&
                    this.empresa_parroquia_id.Equals(input.empresa_parroquia_id))
                ) && 
                (
                    this.parroquia == input.parroquia ||
                    (this.parroquia != null &&
                    this.parroquia.Equals(input.parroquia))
                ) && 
                (
                    this.empresa_tipo_agente_retencion_id == input.empresa_tipo_agente_retencion_id ||
                    (this.empresa_tipo_agente_retencion_id != null &&
                    this.empresa_tipo_agente_retencion_id.Equals(input.empresa_tipo_agente_retencion_id))
                ) && 
                (
                    this.tipo_agente_retencion == input.tipo_agente_retencion ||
                    (this.tipo_agente_retencion != null &&
                    this.tipo_agente_retencion.Equals(input.tipo_agente_retencion))
                ) && 
                (
                    this.sucursales == input.sucursales ||
                    this.sucursales != null &&
                    input.sucursales != null &&
                    this.sucursales.SequenceEqual(input.sucursales)
                ) && 
                (
                    this.tarifas_venta_detalle == input.tarifas_venta_detalle ||
                    this.tarifas_venta_detalle != null &&
                    input.tarifas_venta_detalle != null &&
                    this.tarifas_venta_detalle.SequenceEqual(input.tarifas_venta_detalle)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.empresa_id != null)
                    hashCode = hashCode * 59 + this.empresa_id.GetHashCode();
                if (this.empresa_codigo_interno != null)
                    hashCode = hashCode * 59 + this.empresa_codigo_interno.GetHashCode();
                if (this.empresa_razon_social != null)
                    hashCode = hashCode * 59 + this.empresa_razon_social.GetHashCode();
                if (this.empresa_nombre_comercial != null)
                    hashCode = hashCode * 59 + this.empresa_nombre_comercial.GetHashCode();
                if (this.empresa_activa != null)
                    hashCode = hashCode * 59 + this.empresa_activa.GetHashCode();
                if (this.empresa_nro_identificacion != null)
                    hashCode = hashCode * 59 + this.empresa_nro_identificacion.GetHashCode();
                if (this.tipo_identificacion_id != null)
                    hashCode = hashCode * 59 + this.tipo_identificacion_id.GetHashCode();
                if (this.tipo_identificacion != null)
                    hashCode = hashCode * 59 + this.tipo_identificacion.GetHashCode();
                if (this.empresa_telefono != null)
                    hashCode = hashCode * 59 + this.empresa_telefono.GetHashCode();
                if (this.empresa_movil != null)
                    hashCode = hashCode * 59 + this.empresa_movil.GetHashCode();
                if (this.empresa_direccion_principal != null)
                    hashCode = hashCode * 59 + this.empresa_direccion_principal.GetHashCode();
                if (this.empresa_direccion_ref != null)
                    hashCode = hashCode * 59 + this.empresa_direccion_ref.GetHashCode();
                if (this.empresa_email != null)
                    hashCode = hashCode * 59 + this.empresa_email.GetHashCode();
                if (this.empresa_site_url != null)
                    hashCode = hashCode * 59 + this.empresa_site_url.GetHashCode();
                if (this.empresa_slogan != null)
                    hashCode = hashCode * 59 + this.empresa_slogan.GetHashCode();
                if (this.empresa_contribuyente_especial != null)
                    hashCode = hashCode * 59 + this.empresa_contribuyente_especial.GetHashCode();
                if (this.empresa_obligado_contabilidad != null)
                    hashCode = hashCode * 59 + this.empresa_obligado_contabilidad.GetHashCode();
                if (this.empresa_realiza_ats != null)
                    hashCode = hashCode * 59 + this.empresa_realiza_ats.GetHashCode();
                if (this.empresa_agente_retencion != null)
                    hashCode = hashCode * 59 + this.empresa_agente_retencion.GetHashCode();
                if (this.empresa_logo != null)
                    hashCode = hashCode * 59 + this.empresa_logo.GetHashCode();
                if (this.empresa_rep_legal_id != null)
                    hashCode = hashCode * 59 + this.empresa_rep_legal_id.GetHashCode();
                if (this.empresa_rep_legal != null)
                    hashCode = hashCode * 59 + this.empresa_rep_legal.GetHashCode();
                if (this.empresa_conatdor_id != null)
                    hashCode = hashCode * 59 + this.empresa_conatdor_id.GetHashCode();
                if (this.empresa_contador_name != null)
                    hashCode = hashCode * 59 + this.empresa_contador_name.GetHashCode();
                if (this.empresa_regimen_tributario_id != null)
                    hashCode = hashCode * 59 + this.empresa_regimen_tributario_id.GetHashCode();
                if (this.regimen_tributario != null)
                    hashCode = hashCode * 59 + this.regimen_tributario.GetHashCode();
                if (this.empresa_parroquia_id != null)
                    hashCode = hashCode * 59 + this.empresa_parroquia_id.GetHashCode();
                if (this.parroquia != null)
                    hashCode = hashCode * 59 + this.parroquia.GetHashCode();
                if (this.empresa_tipo_agente_retencion_id != null)
                    hashCode = hashCode * 59 + this.empresa_tipo_agente_retencion_id.GetHashCode();
                if (this.tipo_agente_retencion != null)
                    hashCode = hashCode * 59 + this.tipo_agente_retencion.GetHashCode();
                if (this.sucursales != null)
                    hashCode = hashCode * 59 + this.sucursales.GetHashCode();
                if (this.tarifas_venta_detalle != null)
                    hashCode = hashCode * 59 + this.tarifas_venta_detalle.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
