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
    /// WeekTemplateDTO
    /// </summary>
    [DataContract]
    public partial class WeekTemplateDTO :  IEquatable<WeekTemplateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeekTemplateDTO" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Thumbnail">The weeks thumbnail..</param>
        /// <param name="Name">A Name describing the week..</param>
        /// <param name="Days">A list of the days in the week schedule..</param>
        public WeekTemplateDTO(long? Id = default(long?), WeekPictogramDTO Thumbnail = default(WeekPictogramDTO), string Name = default(string), List<WeekdayDTO> Days = default(List<WeekdayDTO>))
        {
            this.Id = Id;
            this.Thumbnail = Thumbnail;
            this.Name = Name;
            this.Days = Days;
        }
        
        /// <summary>
        /// Gets or Sets DepartmentKey
        /// </summary>
        [DataMember(Name="departmentKey", EmitDefaultValue=false)]
        public long? DepartmentKey { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The weeks thumbnail.
        /// </summary>
        /// <value>The weeks thumbnail.</value>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public WeekPictogramDTO Thumbnail { get; set; }

        /// <summary>
        /// A Name describing the week.
        /// </summary>
        /// <value>A Name describing the week.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A list of the days in the week schedule.
        /// </summary>
        /// <value>A list of the days in the week schedule.</value>
        [DataMember(Name="days", EmitDefaultValue=false)]
        public List<WeekdayDTO> Days { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeekTemplateDTO {\n");
            sb.Append("  DepartmentKey: ").Append(DepartmentKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
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
            return this.Equals(input as WeekTemplateDTO);
        }

        /// <summary>
        /// Returns true if WeekTemplateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of WeekTemplateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeekTemplateDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DepartmentKey == input.DepartmentKey ||
                    (this.DepartmentKey != null &&
                    this.DepartmentKey.Equals(input.DepartmentKey))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Days == input.Days ||
                    this.Days != null &&
                    this.Days.SequenceEqual(input.Days)
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
                if (this.DepartmentKey != null)
                    hashCode = hashCode * 59 + this.DepartmentKey.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Days != null)
                    hashCode = hashCode * 59 + this.Days.GetHashCode();
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
