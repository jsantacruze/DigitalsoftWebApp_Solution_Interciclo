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
    /// BusinessLayerSecurityUsersCreateUserRequest
    /// </summary>
    [DataContract]
        public partial class BusinessLayerSecurityUsersCreateUserRequest :  IEquatable<BusinessLayerSecurityUsersCreateUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerSecurityUsersCreateUserRequest" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="username">username.</param>
        /// <param name="empleadoId">empleadoId.</param>
        /// <param name="profilePicture">profilePicture.</param>
        public BusinessLayerSecurityUsersCreateUserRequest(string email = default(string), string password = default(string), string username = default(string), long? empleadoId = default(long?), byte[] profilePicture = default(byte[]))
        {
            this.email = email;
            this.password = password;
            this.username = username;
            this.empleado_id = empleadoId;
            this.profile_picture = profilePicture;
        }
        
        /// <summary>
        /// Gets or Sets email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string email { get; set; }

        /// <summary>
        /// Gets or Sets password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string password { get; set; }

        /// <summary>
        /// Gets or Sets username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string username { get; set; }

        /// <summary>
        /// Gets or Sets empleado_id
        /// </summary>
        [DataMember(Name="empleadoID", EmitDefaultValue=false)]
        public long? empleado_id { get; set; }

        /// <summary>
        /// Gets or Sets profile_picture
        /// </summary>
        [DataMember(Name="profilePicture", EmitDefaultValue=false)]
        public byte[] profile_picture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerSecurityUsersCreateUserRequest {\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  password: ").Append(password).Append("\n");
            sb.Append("  username: ").Append(username).Append("\n");
            sb.Append("  empleado_id: ").Append(empleado_id).Append("\n");
            sb.Append("  profile_picture: ").Append(profile_picture).Append("\n");
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
            return this.Equals(input as BusinessLayerSecurityUsersCreateUserRequest);
        }

        /// <summary>
        /// Returns true if BusinessLayerSecurityUsersCreateUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerSecurityUsersCreateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerSecurityUsersCreateUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
                ) && 
                (
                    this.password == input.password ||
                    (this.password != null &&
                    this.password.Equals(input.password))
                ) && 
                (
                    this.username == input.username ||
                    (this.username != null &&
                    this.username.Equals(input.username))
                ) && 
                (
                    this.empleado_id == input.empleado_id ||
                    (this.empleado_id != null &&
                    this.empleado_id.Equals(input.empleado_id))
                ) && 
                (
                    this.profile_picture == input.profile_picture ||
                    (this.profile_picture != null &&
                    this.profile_picture.Equals(input.profile_picture))
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
                if (this.email != null)
                    hashCode = hashCode * 59 + this.email.GetHashCode();
                if (this.password != null)
                    hashCode = hashCode * 59 + this.password.GetHashCode();
                if (this.username != null)
                    hashCode = hashCode * 59 + this.username.GetHashCode();
                if (this.empleado_id != null)
                    hashCode = hashCode * 59 + this.empleado_id.GetHashCode();
                if (this.profile_picture != null)
                    hashCode = hashCode * 59 + this.profile_picture.GetHashCode();
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
