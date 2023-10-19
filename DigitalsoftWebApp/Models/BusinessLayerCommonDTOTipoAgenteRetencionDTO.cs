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
    /// BusinessLayerCommonDTOTipoAgenteRetencionDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCommonDTOTipoAgenteRetencionDTO :  IEquatable<BusinessLayerCommonDTOTipoAgenteRetencionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCommonDTOTipoAgenteRetencionDTO" /> class.
        /// </summary>
        /// <param name="tipoId">tipoId.</param>
        /// <param name="tipoResolucion">tipoResolucion.</param>
        /// <param name="tipoActivo">tipoActivo.</param>
        public BusinessLayerCommonDTOTipoAgenteRetencionDTO(int? tipoId = default(int?), string tipoResolucion = default(string), bool? tipoActivo = default(bool?))
        {
            this.tipo_id = tipoId;
            this.tipo_resolucion = tipoResolucion;
            this.tipo_activo = tipoActivo;
        }
        
        /// <summary>
        /// Gets or Sets tipo_id
        /// </summary>
        [DataMember(Name="tipo_id", EmitDefaultValue=false)]
        public int? tipo_id { get; set; }

        /// <summary>
        /// Gets or Sets tipo_resolucion
        /// </summary>
        [DataMember(Name="tipo_resolucion", EmitDefaultValue=false)]
        public string tipo_resolucion { get; set; }

        /// <summary>
        /// Gets or Sets tipo_activo
        /// </summary>
        [DataMember(Name="tipo_activo", EmitDefaultValue=false)]
        public bool? tipo_activo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCommonDTOTipoAgenteRetencionDTO {\n");
            sb.Append("  tipo_id: ").Append(tipo_id).Append("\n");
            sb.Append("  tipo_resolucion: ").Append(tipo_resolucion).Append("\n");
            sb.Append("  tipo_activo: ").Append(tipo_activo).Append("\n");
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
            return this.Equals(input as BusinessLayerCommonDTOTipoAgenteRetencionDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCommonDTOTipoAgenteRetencionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCommonDTOTipoAgenteRetencionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCommonDTOTipoAgenteRetencionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.tipo_id == input.tipo_id ||
                    (this.tipo_id != null &&
                    this.tipo_id.Equals(input.tipo_id))
                ) && 
                (
                    this.tipo_resolucion == input.tipo_resolucion ||
                    (this.tipo_resolucion != null &&
                    this.tipo_resolucion.Equals(input.tipo_resolucion))
                ) && 
                (
                    this.tipo_activo == input.tipo_activo ||
                    (this.tipo_activo != null &&
                    this.tipo_activo.Equals(input.tipo_activo))
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
                if (this.tipo_id != null)
                    hashCode = hashCode * 59 + this.tipo_id.GetHashCode();
                if (this.tipo_resolucion != null)
                    hashCode = hashCode * 59 + this.tipo_resolucion.GetHashCode();
                if (this.tipo_activo != null)
                    hashCode = hashCode * 59 + this.tipo_activo.GetHashCode();
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