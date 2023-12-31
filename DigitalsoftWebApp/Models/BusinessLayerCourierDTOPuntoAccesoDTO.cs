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
    /// BusinessLayerCourierDTOPuntoAccesoDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierDTOPuntoAccesoDTO :  IEquatable<BusinessLayerCourierDTOPuntoAccesoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierDTOPuntoAccesoDTO" /> class.
        /// </summary>
        /// <param name="intIdpuntoAcceso">intIdpuntoAcceso.</param>
        /// <param name="strIdsucursal">strIdsucursal.</param>
        /// <param name="strDescripcionPunto">strDescripcionPunto.</param>
        /// <param name="strObservaciones">strObservaciones.</param>
        /// <param name="blnActivo">blnActivo.</param>
        /// <param name="strImpresoraTicketsEnvios">strImpresoraTicketsEnvios.</param>
        /// <param name="strImpresoraFacurasEnvios">strImpresoraFacurasEnvios.</param>
        /// <param name="strImpresoraTicketsGiros">strImpresoraTicketsGiros.</param>
        /// <param name="strNumeroSerieFacEnvios">strNumeroSerieFacEnvios.</param>
        /// <param name="strIdsucursalNavigation">strIdsucursalNavigation.</param>
        public BusinessLayerCourierDTOPuntoAccesoDTO(int? intIdpuntoAcceso = default(int?), string strIdsucursal = default(string), string strDescripcionPunto = default(string), string strObservaciones = default(string), bool? blnActivo = default(bool?), string strImpresoraTicketsEnvios = default(string), string strImpresoraFacurasEnvios = default(string), string strImpresoraTicketsGiros = default(string), string strNumeroSerieFacEnvios = default(string), BusinessLayerCourierDTOAgenciaDTO strIdsucursalNavigation = default(BusinessLayerCourierDTOAgenciaDTO))
        {
            this.int_idpunto_acceso = intIdpuntoAcceso;
            this.str_idsucursal = strIdsucursal;
            this.str_descripcion_punto = strDescripcionPunto;
            this.str_observaciones = strObservaciones;
            this.bln_activo = blnActivo;
            this.str_impresora_tickets_envios = strImpresoraTicketsEnvios;
            this.str_impresora_facuras_envios = strImpresoraFacurasEnvios;
            this.str_impresora_tickets_giros = strImpresoraTicketsGiros;
            this.str_numero_serie_fac_envios = strNumeroSerieFacEnvios;
            this.str_idsucursal_navigation = strIdsucursalNavigation;
        }
        
        /// <summary>
        /// Gets or Sets int_idpunto_acceso
        /// </summary>
        [DataMember(Name="intIdpuntoAcceso", EmitDefaultValue=false)]
        public int? int_idpunto_acceso { get; set; }

        /// <summary>
        /// Gets or Sets str_idsucursal
        /// </summary>
        [DataMember(Name="strIdsucursal", EmitDefaultValue=false)]
        public string str_idsucursal { get; set; }

        /// <summary>
        /// Gets or Sets str_descripcion_punto
        /// </summary>
        [DataMember(Name="strDescripcionPunto", EmitDefaultValue=false)]
        public string str_descripcion_punto { get; set; }

        /// <summary>
        /// Gets or Sets str_observaciones
        /// </summary>
        [DataMember(Name="strObservaciones", EmitDefaultValue=false)]
        public string str_observaciones { get; set; }

        /// <summary>
        /// Gets or Sets bln_activo
        /// </summary>
        [DataMember(Name="blnActivo", EmitDefaultValue=false)]
        public bool? bln_activo { get; set; }

        /// <summary>
        /// Gets or Sets str_impresora_tickets_envios
        /// </summary>
        [DataMember(Name="strImpresoraTicketsEnvios", EmitDefaultValue=false)]
        public string str_impresora_tickets_envios { get; set; }

        /// <summary>
        /// Gets or Sets str_impresora_facuras_envios
        /// </summary>
        [DataMember(Name="strImpresoraFacurasEnvios", EmitDefaultValue=false)]
        public string str_impresora_facuras_envios { get; set; }

        /// <summary>
        /// Gets or Sets str_impresora_tickets_giros
        /// </summary>
        [DataMember(Name="strImpresoraTicketsGiros", EmitDefaultValue=false)]
        public string str_impresora_tickets_giros { get; set; }

        /// <summary>
        /// Gets or Sets str_numero_serie_fac_envios
        /// </summary>
        [DataMember(Name="strNumeroSerieFacEnvios", EmitDefaultValue=false)]
        public string str_numero_serie_fac_envios { get; set; }

        /// <summary>
        /// Gets or Sets str_idsucursal_navigation
        /// </summary>
        [DataMember(Name="strIdsucursalNavigation", EmitDefaultValue=false)]
        public BusinessLayerCourierDTOAgenciaDTO str_idsucursal_navigation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierDTOPuntoAccesoDTO {\n");
            sb.Append("  int_idpunto_acceso: ").Append(int_idpunto_acceso).Append("\n");
            sb.Append("  str_idsucursal: ").Append(str_idsucursal).Append("\n");
            sb.Append("  str_descripcion_punto: ").Append(str_descripcion_punto).Append("\n");
            sb.Append("  str_observaciones: ").Append(str_observaciones).Append("\n");
            sb.Append("  bln_activo: ").Append(bln_activo).Append("\n");
            sb.Append("  str_impresora_tickets_envios: ").Append(str_impresora_tickets_envios).Append("\n");
            sb.Append("  str_impresora_facuras_envios: ").Append(str_impresora_facuras_envios).Append("\n");
            sb.Append("  str_impresora_tickets_giros: ").Append(str_impresora_tickets_giros).Append("\n");
            sb.Append("  str_numero_serie_fac_envios: ").Append(str_numero_serie_fac_envios).Append("\n");
            sb.Append("  str_idsucursal_navigation: ").Append(str_idsucursal_navigation).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierDTOPuntoAccesoDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierDTOPuntoAccesoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierDTOPuntoAccesoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierDTOPuntoAccesoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.int_idpunto_acceso == input.int_idpunto_acceso ||
                    (this.int_idpunto_acceso != null &&
                    this.int_idpunto_acceso.Equals(input.int_idpunto_acceso))
                ) && 
                (
                    this.str_idsucursal == input.str_idsucursal ||
                    (this.str_idsucursal != null &&
                    this.str_idsucursal.Equals(input.str_idsucursal))
                ) && 
                (
                    this.str_descripcion_punto == input.str_descripcion_punto ||
                    (this.str_descripcion_punto != null &&
                    this.str_descripcion_punto.Equals(input.str_descripcion_punto))
                ) && 
                (
                    this.str_observaciones == input.str_observaciones ||
                    (this.str_observaciones != null &&
                    this.str_observaciones.Equals(input.str_observaciones))
                ) && 
                (
                    this.bln_activo == input.bln_activo ||
                    (this.bln_activo != null &&
                    this.bln_activo.Equals(input.bln_activo))
                ) && 
                (
                    this.str_impresora_tickets_envios == input.str_impresora_tickets_envios ||
                    (this.str_impresora_tickets_envios != null &&
                    this.str_impresora_tickets_envios.Equals(input.str_impresora_tickets_envios))
                ) && 
                (
                    this.str_impresora_facuras_envios == input.str_impresora_facuras_envios ||
                    (this.str_impresora_facuras_envios != null &&
                    this.str_impresora_facuras_envios.Equals(input.str_impresora_facuras_envios))
                ) && 
                (
                    this.str_impresora_tickets_giros == input.str_impresora_tickets_giros ||
                    (this.str_impresora_tickets_giros != null &&
                    this.str_impresora_tickets_giros.Equals(input.str_impresora_tickets_giros))
                ) && 
                (
                    this.str_numero_serie_fac_envios == input.str_numero_serie_fac_envios ||
                    (this.str_numero_serie_fac_envios != null &&
                    this.str_numero_serie_fac_envios.Equals(input.str_numero_serie_fac_envios))
                ) && 
                (
                    this.str_idsucursal_navigation == input.str_idsucursal_navigation ||
                    (this.str_idsucursal_navigation != null &&
                    this.str_idsucursal_navigation.Equals(input.str_idsucursal_navigation))
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
                if (this.int_idpunto_acceso != null)
                    hashCode = hashCode * 59 + this.int_idpunto_acceso.GetHashCode();
                if (this.str_idsucursal != null)
                    hashCode = hashCode * 59 + this.str_idsucursal.GetHashCode();
                if (this.str_descripcion_punto != null)
                    hashCode = hashCode * 59 + this.str_descripcion_punto.GetHashCode();
                if (this.str_observaciones != null)
                    hashCode = hashCode * 59 + this.str_observaciones.GetHashCode();
                if (this.bln_activo != null)
                    hashCode = hashCode * 59 + this.bln_activo.GetHashCode();
                if (this.str_impresora_tickets_envios != null)
                    hashCode = hashCode * 59 + this.str_impresora_tickets_envios.GetHashCode();
                if (this.str_impresora_facuras_envios != null)
                    hashCode = hashCode * 59 + this.str_impresora_facuras_envios.GetHashCode();
                if (this.str_impresora_tickets_giros != null)
                    hashCode = hashCode * 59 + this.str_impresora_tickets_giros.GetHashCode();
                if (this.str_numero_serie_fac_envios != null)
                    hashCode = hashCode * 59 + this.str_numero_serie_fac_envios.GetHashCode();
                if (this.str_idsucursal_navigation != null)
                    hashCode = hashCode * 59 + this.str_idsucursal_navigation.GetHashCode();
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
