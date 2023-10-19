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
    /// BusinessLayerCourierDTOClienteDTO
    /// </summary>
    [DataContract]
        public partial class BusinessLayerCourierDTOClienteDTO :  IEquatable<BusinessLayerCourierDTOClienteDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessLayerCourierDTOClienteDTO" /> class.
        /// </summary>
        /// <param name="idcliente">idcliente.</param>
        /// <param name="cedulaRucpassport">cedulaRucpassport.</param>
        /// <param name="nombresCliente">nombresCliente.</param>
        /// <param name="apellidosCliente">apellidosCliente.</param>
        /// <param name="dtFechaNacimientoCliente">dtFechaNacimientoCliente.</param>
        /// <param name="emailCliente">emailCliente.</param>
        /// <param name="telefonoCliente">telefonoCliente.</param>
        /// <param name="movilCliente">movilCliente.</param>
        /// <param name="fechaRegistro">fechaRegistro.</param>
        /// <param name="fechaUltimaModificacion">fechaUltimaModificacion.</param>
        /// <param name="clienteRiesgoso">clienteRiesgoso.</param>
        /// <param name="idtipoIdentificacion">idtipoIdentificacion.</param>
        /// <param name="idsexo">idsexo.</param>
        /// <param name="idestadoCivil">idestadoCivil.</param>
        /// <param name="idusuarioCrea">idusuarioCrea.</param>
        /// <param name="idusuarioMarcaRiesgoso">idusuarioMarcaRiesgoso.</param>
        /// <param name="idagenciaCrea">idagenciaCrea.</param>
        /// <param name="imagenCliente">imagenCliente.</param>
        /// <param name="observacionesCliente">observacionesCliente.</param>
        /// <param name="resideExterior">resideExterior.</param>
        /// <param name="profesion">profesion.</param>
        /// <param name="passwordEbilling">passwordEbilling.</param>
        /// <param name="cuentaActiva">cuentaActiva.</param>
        /// <param name="paisEmisionDoc">paisEmisionDoc.</param>
        /// <param name="estadoEmisionDoc">estadoEmisionDoc.</param>
        /// <param name="fechaExpiracionDoc">fechaExpiracionDoc.</param>
        /// <param name="tipoDocumentoPresenta">tipoDocumentoPresenta.</param>
        /// <param name="numeroDocumentoPresenta">numeroDocumentoPresenta.</param>
        /// <param name="clienteActivo">clienteActivo.</param>
        /// <param name="idagenciaCreaNavigation">idagenciaCreaNavigation.</param>
        public BusinessLayerCourierDTOClienteDTO(long? idcliente = default(long?), string cedulaRucpassport = default(string), string nombresCliente = default(string), string apellidosCliente = default(string), DateTime? dtFechaNacimientoCliente = default(DateTime?), string emailCliente = default(string), string telefonoCliente = default(string), string movilCliente = default(string), DateTime? fechaRegistro = default(DateTime?), DateTime? fechaUltimaModificacion = default(DateTime?), bool? clienteRiesgoso = default(bool?), int? idtipoIdentificacion = default(int?), string idsexo = default(string), string idestadoCivil = default(string), string idusuarioCrea = default(string), string idusuarioMarcaRiesgoso = default(string), string idagenciaCrea = default(string), byte[] imagenCliente = default(byte[]), string observacionesCliente = default(string), bool? resideExterior = default(bool?), string profesion = default(string), string passwordEbilling = default(string), bool? cuentaActiva = default(bool?), string paisEmisionDoc = default(string), string estadoEmisionDoc = default(string), DateTime? fechaExpiracionDoc = default(DateTime?), string tipoDocumentoPresenta = default(string), string numeroDocumentoPresenta = default(string), bool? clienteActivo = default(bool?), BusinessLayerCourierDTOAgenciaDTO idagenciaCreaNavigation = default(BusinessLayerCourierDTOAgenciaDTO))
        {
            this.idcliente = idcliente;
            this.cedula_rucpassport = cedulaRucpassport;
            this.nombres_cliente = nombresCliente;
            this.apellidos_cliente = apellidosCliente;
            this.dt_fecha_nacimiento_cliente = dtFechaNacimientoCliente;
            this.email_cliente = emailCliente;
            this.telefono_cliente = telefonoCliente;
            this.movil_cliente = movilCliente;
            this.fecha_registro = fechaRegistro;
            this.fecha_ultima_modificacion = fechaUltimaModificacion;
            this.cliente_riesgoso = clienteRiesgoso;
            this.idtipo_identificacion = idtipoIdentificacion;
            this.idsexo = idsexo;
            this.idestado_civil = idestadoCivil;
            this.idusuario_crea = idusuarioCrea;
            this.idusuario_marca_riesgoso = idusuarioMarcaRiesgoso;
            this.idagencia_crea = idagenciaCrea;
            this.imagen_cliente = imagenCliente;
            this.observaciones_cliente = observacionesCliente;
            this.reside_exterior = resideExterior;
            this.profesion = profesion;
            this.password_ebilling = passwordEbilling;
            this.cuenta_activa = cuentaActiva;
            this.pais_emision_doc = paisEmisionDoc;
            this.estado_emision_doc = estadoEmisionDoc;
            this.fecha_expiracion_doc = fechaExpiracionDoc;
            this.tipo_documento_presenta = tipoDocumentoPresenta;
            this.numero_documento_presenta = numeroDocumentoPresenta;
            this.cliente_activo = clienteActivo;
            this.idagencia_crea_navigation = idagenciaCreaNavigation;
        }
        
        /// <summary>
        /// Gets or Sets idcliente
        /// </summary>
        [DataMember(Name="idcliente", EmitDefaultValue=false)]
        public long? idcliente { get; set; }

        /// <summary>
        /// Gets or Sets cedula_rucpassport
        /// </summary>
        [DataMember(Name="cedulaRucpassport", EmitDefaultValue=false)]
        public string cedula_rucpassport { get; set; }

        /// <summary>
        /// Gets or Sets nombres_cliente
        /// </summary>
        [DataMember(Name="nombresCliente", EmitDefaultValue=false)]
        public string nombres_cliente { get; set; }

        /// <summary>
        /// Gets or Sets apellidos_cliente
        /// </summary>
        [DataMember(Name="apellidosCliente", EmitDefaultValue=false)]
        public string apellidos_cliente { get; set; }

        /// <summary>
        /// Gets or Sets dt_fecha_nacimiento_cliente
        /// </summary>
        [DataMember(Name="dtFechaNacimientoCliente", EmitDefaultValue=false)]
        public DateTime? dt_fecha_nacimiento_cliente { get; set; }

        /// <summary>
        /// Gets or Sets email_cliente
        /// </summary>
        [DataMember(Name="emailCliente", EmitDefaultValue=false)]
        public string email_cliente { get; set; }

        /// <summary>
        /// Gets or Sets telefono_cliente
        /// </summary>
        [DataMember(Name="telefonoCliente", EmitDefaultValue=false)]
        public string telefono_cliente { get; set; }

        /// <summary>
        /// Gets or Sets movil_cliente
        /// </summary>
        [DataMember(Name="movilCliente", EmitDefaultValue=false)]
        public string movil_cliente { get; set; }

        /// <summary>
        /// Gets or Sets fecha_registro
        /// </summary>
        [DataMember(Name="fechaRegistro", EmitDefaultValue=false)]
        public DateTime? fecha_registro { get; set; }

        /// <summary>
        /// Gets or Sets fecha_ultima_modificacion
        /// </summary>
        [DataMember(Name="fechaUltimaModificacion", EmitDefaultValue=false)]
        public DateTime? fecha_ultima_modificacion { get; set; }

        /// <summary>
        /// Gets or Sets cliente_riesgoso
        /// </summary>
        [DataMember(Name="clienteRiesgoso", EmitDefaultValue=false)]
        public bool? cliente_riesgoso { get; set; }

        /// <summary>
        /// Gets or Sets idtipo_identificacion
        /// </summary>
        [DataMember(Name="idtipoIdentificacion", EmitDefaultValue=false)]
        public int? idtipo_identificacion { get; set; }

        /// <summary>
        /// Gets or Sets idsexo
        /// </summary>
        [DataMember(Name="idsexo", EmitDefaultValue=false)]
        public string idsexo { get; set; }

        /// <summary>
        /// Gets or Sets idestado_civil
        /// </summary>
        [DataMember(Name="idestadoCivil", EmitDefaultValue=false)]
        public string idestado_civil { get; set; }

        /// <summary>
        /// Gets or Sets idusuario_crea
        /// </summary>
        [DataMember(Name="idusuarioCrea", EmitDefaultValue=false)]
        public string idusuario_crea { get; set; }

        /// <summary>
        /// Gets or Sets idusuario_marca_riesgoso
        /// </summary>
        [DataMember(Name="idusuarioMarcaRiesgoso", EmitDefaultValue=false)]
        public string idusuario_marca_riesgoso { get; set; }

        /// <summary>
        /// Gets or Sets idagencia_crea
        /// </summary>
        [DataMember(Name="idagenciaCrea", EmitDefaultValue=false)]
        public string idagencia_crea { get; set; }

        /// <summary>
        /// Gets or Sets imagen_cliente
        /// </summary>
        [DataMember(Name="imagenCliente", EmitDefaultValue=false)]
        public byte[] imagen_cliente { get; set; }

        /// <summary>
        /// Gets or Sets observaciones_cliente
        /// </summary>
        [DataMember(Name="observacionesCliente", EmitDefaultValue=false)]
        public string observaciones_cliente { get; set; }

        /// <summary>
        /// Gets or Sets reside_exterior
        /// </summary>
        [DataMember(Name="resideExterior", EmitDefaultValue=false)]
        public bool? reside_exterior { get; set; }

        /// <summary>
        /// Gets or Sets profesion
        /// </summary>
        [DataMember(Name="profesion", EmitDefaultValue=false)]
        public string profesion { get; set; }

        /// <summary>
        /// Gets or Sets password_ebilling
        /// </summary>
        [DataMember(Name="passwordEbilling", EmitDefaultValue=false)]
        public string password_ebilling { get; set; }

        /// <summary>
        /// Gets or Sets cuenta_activa
        /// </summary>
        [DataMember(Name="cuentaActiva", EmitDefaultValue=false)]
        public bool? cuenta_activa { get; set; }

        /// <summary>
        /// Gets or Sets pais_emision_doc
        /// </summary>
        [DataMember(Name="paisEmisionDoc", EmitDefaultValue=false)]
        public string pais_emision_doc { get; set; }

        /// <summary>
        /// Gets or Sets estado_emision_doc
        /// </summary>
        [DataMember(Name="estadoEmisionDoc", EmitDefaultValue=false)]
        public string estado_emision_doc { get; set; }

        /// <summary>
        /// Gets or Sets fecha_expiracion_doc
        /// </summary>
        [DataMember(Name="fechaExpiracionDoc", EmitDefaultValue=false)]
        public DateTime? fecha_expiracion_doc { get; set; }

        /// <summary>
        /// Gets or Sets tipo_documento_presenta
        /// </summary>
        [DataMember(Name="tipoDocumentoPresenta", EmitDefaultValue=false)]
        public string tipo_documento_presenta { get; set; }

        /// <summary>
        /// Gets or Sets numero_documento_presenta
        /// </summary>
        [DataMember(Name="numeroDocumentoPresenta", EmitDefaultValue=false)]
        public string numero_documento_presenta { get; set; }

        /// <summary>
        /// Gets or Sets cliente_activo
        /// </summary>
        [DataMember(Name="clienteActivo", EmitDefaultValue=false)]
        public bool? cliente_activo { get; set; }

        /// <summary>
        /// Gets or Sets idagencia_crea_navigation
        /// </summary>
        [DataMember(Name="idagenciaCreaNavigation", EmitDefaultValue=false)]
        public BusinessLayerCourierDTOAgenciaDTO idagencia_crea_navigation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLayerCourierDTOClienteDTO {\n");
            sb.Append("  idcliente: ").Append(idcliente).Append("\n");
            sb.Append("  cedula_rucpassport: ").Append(cedula_rucpassport).Append("\n");
            sb.Append("  nombres_cliente: ").Append(nombres_cliente).Append("\n");
            sb.Append("  apellidos_cliente: ").Append(apellidos_cliente).Append("\n");
            sb.Append("  dt_fecha_nacimiento_cliente: ").Append(dt_fecha_nacimiento_cliente).Append("\n");
            sb.Append("  email_cliente: ").Append(email_cliente).Append("\n");
            sb.Append("  telefono_cliente: ").Append(telefono_cliente).Append("\n");
            sb.Append("  movil_cliente: ").Append(movil_cliente).Append("\n");
            sb.Append("  fecha_registro: ").Append(fecha_registro).Append("\n");
            sb.Append("  fecha_ultima_modificacion: ").Append(fecha_ultima_modificacion).Append("\n");
            sb.Append("  cliente_riesgoso: ").Append(cliente_riesgoso).Append("\n");
            sb.Append("  idtipo_identificacion: ").Append(idtipo_identificacion).Append("\n");
            sb.Append("  idsexo: ").Append(idsexo).Append("\n");
            sb.Append("  idestado_civil: ").Append(idestado_civil).Append("\n");
            sb.Append("  idusuario_crea: ").Append(idusuario_crea).Append("\n");
            sb.Append("  idusuario_marca_riesgoso: ").Append(idusuario_marca_riesgoso).Append("\n");
            sb.Append("  idagencia_crea: ").Append(idagencia_crea).Append("\n");
            sb.Append("  imagen_cliente: ").Append(imagen_cliente).Append("\n");
            sb.Append("  observaciones_cliente: ").Append(observaciones_cliente).Append("\n");
            sb.Append("  reside_exterior: ").Append(reside_exterior).Append("\n");
            sb.Append("  profesion: ").Append(profesion).Append("\n");
            sb.Append("  password_ebilling: ").Append(password_ebilling).Append("\n");
            sb.Append("  cuenta_activa: ").Append(cuenta_activa).Append("\n");
            sb.Append("  pais_emision_doc: ").Append(pais_emision_doc).Append("\n");
            sb.Append("  estado_emision_doc: ").Append(estado_emision_doc).Append("\n");
            sb.Append("  fecha_expiracion_doc: ").Append(fecha_expiracion_doc).Append("\n");
            sb.Append("  tipo_documento_presenta: ").Append(tipo_documento_presenta).Append("\n");
            sb.Append("  numero_documento_presenta: ").Append(numero_documento_presenta).Append("\n");
            sb.Append("  cliente_activo: ").Append(cliente_activo).Append("\n");
            sb.Append("  idagencia_crea_navigation: ").Append(idagencia_crea_navigation).Append("\n");
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
            return this.Equals(input as BusinessLayerCourierDTOClienteDTO);
        }

        /// <summary>
        /// Returns true if BusinessLayerCourierDTOClienteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessLayerCourierDTOClienteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLayerCourierDTOClienteDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.idcliente == input.idcliente ||
                    (this.idcliente != null &&
                    this.idcliente.Equals(input.idcliente))
                ) && 
                (
                    this.cedula_rucpassport == input.cedula_rucpassport ||
                    (this.cedula_rucpassport != null &&
                    this.cedula_rucpassport.Equals(input.cedula_rucpassport))
                ) && 
                (
                    this.nombres_cliente == input.nombres_cliente ||
                    (this.nombres_cliente != null &&
                    this.nombres_cliente.Equals(input.nombres_cliente))
                ) && 
                (
                    this.apellidos_cliente == input.apellidos_cliente ||
                    (this.apellidos_cliente != null &&
                    this.apellidos_cliente.Equals(input.apellidos_cliente))
                ) && 
                (
                    this.dt_fecha_nacimiento_cliente == input.dt_fecha_nacimiento_cliente ||
                    (this.dt_fecha_nacimiento_cliente != null &&
                    this.dt_fecha_nacimiento_cliente.Equals(input.dt_fecha_nacimiento_cliente))
                ) && 
                (
                    this.email_cliente == input.email_cliente ||
                    (this.email_cliente != null &&
                    this.email_cliente.Equals(input.email_cliente))
                ) && 
                (
                    this.telefono_cliente == input.telefono_cliente ||
                    (this.telefono_cliente != null &&
                    this.telefono_cliente.Equals(input.telefono_cliente))
                ) && 
                (
                    this.movil_cliente == input.movil_cliente ||
                    (this.movil_cliente != null &&
                    this.movil_cliente.Equals(input.movil_cliente))
                ) && 
                (
                    this.fecha_registro == input.fecha_registro ||
                    (this.fecha_registro != null &&
                    this.fecha_registro.Equals(input.fecha_registro))
                ) && 
                (
                    this.fecha_ultima_modificacion == input.fecha_ultima_modificacion ||
                    (this.fecha_ultima_modificacion != null &&
                    this.fecha_ultima_modificacion.Equals(input.fecha_ultima_modificacion))
                ) && 
                (
                    this.cliente_riesgoso == input.cliente_riesgoso ||
                    (this.cliente_riesgoso != null &&
                    this.cliente_riesgoso.Equals(input.cliente_riesgoso))
                ) && 
                (
                    this.idtipo_identificacion == input.idtipo_identificacion ||
                    (this.idtipo_identificacion != null &&
                    this.idtipo_identificacion.Equals(input.idtipo_identificacion))
                ) && 
                (
                    this.idsexo == input.idsexo ||
                    (this.idsexo != null &&
                    this.idsexo.Equals(input.idsexo))
                ) && 
                (
                    this.idestado_civil == input.idestado_civil ||
                    (this.idestado_civil != null &&
                    this.idestado_civil.Equals(input.idestado_civil))
                ) && 
                (
                    this.idusuario_crea == input.idusuario_crea ||
                    (this.idusuario_crea != null &&
                    this.idusuario_crea.Equals(input.idusuario_crea))
                ) && 
                (
                    this.idusuario_marca_riesgoso == input.idusuario_marca_riesgoso ||
                    (this.idusuario_marca_riesgoso != null &&
                    this.idusuario_marca_riesgoso.Equals(input.idusuario_marca_riesgoso))
                ) && 
                (
                    this.idagencia_crea == input.idagencia_crea ||
                    (this.idagencia_crea != null &&
                    this.idagencia_crea.Equals(input.idagencia_crea))
                ) && 
                (
                    this.imagen_cliente == input.imagen_cliente ||
                    (this.imagen_cliente != null &&
                    this.imagen_cliente.Equals(input.imagen_cliente))
                ) && 
                (
                    this.observaciones_cliente == input.observaciones_cliente ||
                    (this.observaciones_cliente != null &&
                    this.observaciones_cliente.Equals(input.observaciones_cliente))
                ) && 
                (
                    this.reside_exterior == input.reside_exterior ||
                    (this.reside_exterior != null &&
                    this.reside_exterior.Equals(input.reside_exterior))
                ) && 
                (
                    this.profesion == input.profesion ||
                    (this.profesion != null &&
                    this.profesion.Equals(input.profesion))
                ) && 
                (
                    this.password_ebilling == input.password_ebilling ||
                    (this.password_ebilling != null &&
                    this.password_ebilling.Equals(input.password_ebilling))
                ) && 
                (
                    this.cuenta_activa == input.cuenta_activa ||
                    (this.cuenta_activa != null &&
                    this.cuenta_activa.Equals(input.cuenta_activa))
                ) && 
                (
                    this.pais_emision_doc == input.pais_emision_doc ||
                    (this.pais_emision_doc != null &&
                    this.pais_emision_doc.Equals(input.pais_emision_doc))
                ) && 
                (
                    this.estado_emision_doc == input.estado_emision_doc ||
                    (this.estado_emision_doc != null &&
                    this.estado_emision_doc.Equals(input.estado_emision_doc))
                ) && 
                (
                    this.fecha_expiracion_doc == input.fecha_expiracion_doc ||
                    (this.fecha_expiracion_doc != null &&
                    this.fecha_expiracion_doc.Equals(input.fecha_expiracion_doc))
                ) && 
                (
                    this.tipo_documento_presenta == input.tipo_documento_presenta ||
                    (this.tipo_documento_presenta != null &&
                    this.tipo_documento_presenta.Equals(input.tipo_documento_presenta))
                ) && 
                (
                    this.numero_documento_presenta == input.numero_documento_presenta ||
                    (this.numero_documento_presenta != null &&
                    this.numero_documento_presenta.Equals(input.numero_documento_presenta))
                ) && 
                (
                    this.cliente_activo == input.cliente_activo ||
                    (this.cliente_activo != null &&
                    this.cliente_activo.Equals(input.cliente_activo))
                ) && 
                (
                    this.idagencia_crea_navigation == input.idagencia_crea_navigation ||
                    (this.idagencia_crea_navigation != null &&
                    this.idagencia_crea_navigation.Equals(input.idagencia_crea_navigation))
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
                if (this.idcliente != null)
                    hashCode = hashCode * 59 + this.idcliente.GetHashCode();
                if (this.cedula_rucpassport != null)
                    hashCode = hashCode * 59 + this.cedula_rucpassport.GetHashCode();
                if (this.nombres_cliente != null)
                    hashCode = hashCode * 59 + this.nombres_cliente.GetHashCode();
                if (this.apellidos_cliente != null)
                    hashCode = hashCode * 59 + this.apellidos_cliente.GetHashCode();
                if (this.dt_fecha_nacimiento_cliente != null)
                    hashCode = hashCode * 59 + this.dt_fecha_nacimiento_cliente.GetHashCode();
                if (this.email_cliente != null)
                    hashCode = hashCode * 59 + this.email_cliente.GetHashCode();
                if (this.telefono_cliente != null)
                    hashCode = hashCode * 59 + this.telefono_cliente.GetHashCode();
                if (this.movil_cliente != null)
                    hashCode = hashCode * 59 + this.movil_cliente.GetHashCode();
                if (this.fecha_registro != null)
                    hashCode = hashCode * 59 + this.fecha_registro.GetHashCode();
                if (this.fecha_ultima_modificacion != null)
                    hashCode = hashCode * 59 + this.fecha_ultima_modificacion.GetHashCode();
                if (this.cliente_riesgoso != null)
                    hashCode = hashCode * 59 + this.cliente_riesgoso.GetHashCode();
                if (this.idtipo_identificacion != null)
                    hashCode = hashCode * 59 + this.idtipo_identificacion.GetHashCode();
                if (this.idsexo != null)
                    hashCode = hashCode * 59 + this.idsexo.GetHashCode();
                if (this.idestado_civil != null)
                    hashCode = hashCode * 59 + this.idestado_civil.GetHashCode();
                if (this.idusuario_crea != null)
                    hashCode = hashCode * 59 + this.idusuario_crea.GetHashCode();
                if (this.idusuario_marca_riesgoso != null)
                    hashCode = hashCode * 59 + this.idusuario_marca_riesgoso.GetHashCode();
                if (this.idagencia_crea != null)
                    hashCode = hashCode * 59 + this.idagencia_crea.GetHashCode();
                if (this.imagen_cliente != null)
                    hashCode = hashCode * 59 + this.imagen_cliente.GetHashCode();
                if (this.observaciones_cliente != null)
                    hashCode = hashCode * 59 + this.observaciones_cliente.GetHashCode();
                if (this.reside_exterior != null)
                    hashCode = hashCode * 59 + this.reside_exterior.GetHashCode();
                if (this.profesion != null)
                    hashCode = hashCode * 59 + this.profesion.GetHashCode();
                if (this.password_ebilling != null)
                    hashCode = hashCode * 59 + this.password_ebilling.GetHashCode();
                if (this.cuenta_activa != null)
                    hashCode = hashCode * 59 + this.cuenta_activa.GetHashCode();
                if (this.pais_emision_doc != null)
                    hashCode = hashCode * 59 + this.pais_emision_doc.GetHashCode();
                if (this.estado_emision_doc != null)
                    hashCode = hashCode * 59 + this.estado_emision_doc.GetHashCode();
                if (this.fecha_expiracion_doc != null)
                    hashCode = hashCode * 59 + this.fecha_expiracion_doc.GetHashCode();
                if (this.tipo_documento_presenta != null)
                    hashCode = hashCode * 59 + this.tipo_documento_presenta.GetHashCode();
                if (this.numero_documento_presenta != null)
                    hashCode = hashCode * 59 + this.numero_documento_presenta.GetHashCode();
                if (this.cliente_activo != null)
                    hashCode = hashCode * 59 + this.cliente_activo.GetHashCode();
                if (this.idagencia_crea_navigation != null)
                    hashCode = hashCode * 59 + this.idagencia_crea_navigation.GetHashCode();
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