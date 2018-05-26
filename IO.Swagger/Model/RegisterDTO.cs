/* 
 * The Giraf REST API
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// This class is used when a new user is to be created. It simply defines the structure of the expected  json string.
    /// </summary>
    [DataContract]
    public partial class RegisterDTO :  IEquatable<RegisterDTO>, IValidatableObject
    {
        /// <summary>
        /// Defines Role
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            
            /// <summary>
            /// Enum Citizen for value: Citizen
            /// </summary>
            [EnumMember(Value = "Citizen")]
            Citizen = 1,
            
            /// <summary>
            /// Enum Department for value: Department
            /// </summary>
            [EnumMember(Value = "Department")]
            Department = 2,
            
            /// <summary>
            /// Enum Guardian for value: Guardian
            /// </summary>
            [EnumMember(Value = "Guardian")]
            Guardian = 3,
            
            /// <summary>
            /// Enum SuperUser for value: SuperUser
            /// </summary>
            [EnumMember(Value = "SuperUser")]
            SuperUser = 4
        }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDTO" /> class.
        /// </summary>
        /// <param name="Username">The users username. (required).</param>
        /// <param name="Password">The users password. (required).</param>
        /// <param name="DisplayName">The users DisplayName.</param>
        /// <param name="DepartmentId">The users departmentid. (required).</param>
        /// <param name="Role">Role (required).</param>
        public RegisterDTO(string Username = default(string), string Password = default(string), string DisplayName = default(string), long? DepartmentId = default(long?), RoleEnum Role = default(RoleEnum))
        {
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for RegisterDTO and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for RegisterDTO and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "DepartmentId" is required (not null)
            if (DepartmentId == null)
            {
                throw new InvalidDataException("DepartmentId is a required property for RegisterDTO and cannot be null");
            }
            else
            {
                this.DepartmentId = DepartmentId;
            }
            // to ensure "Role" is required (not null)
            if (Role == null)
            {
                throw new InvalidDataException("Role is a required property for RegisterDTO and cannot be null");
            }
            else
            {
                this.Role = Role;
            }
            this.DisplayName = DisplayName;
        }
        
        /// <summary>
        /// The users username.
        /// </summary>
        /// <value>The users username.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The users password.
        /// </summary>
        /// <value>The users password.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The users DisplayName
        /// </summary>
        /// <value>The users DisplayName</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The users departmentid.
        /// </summary>
        /// <value>The users departmentid.</value>
        [DataMember(Name="departmentId", EmitDefaultValue=false)]
        public long? DepartmentId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterDTO {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as RegisterDTO);
        }

        /// <summary>
        /// Returns true if RegisterDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DepartmentId != null)
                    hashCode = hashCode * 59 + this.DepartmentId.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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