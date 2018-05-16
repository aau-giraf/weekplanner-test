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
    /// ActivityDTO
    /// </summary>
    [DataContract]
    public partial class ActivityDTO :  IEquatable<ActivityDTO>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Normal for value: Normal
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal = 1,
            
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 2,
            
            /// <summary>
            /// Enum Canceled for value: Canceled
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled = 3,
            
            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 4
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDTO" /> class.
        /// </summary>
        /// <param name="Pictogram">Pictogram.</param>
        /// <param name="Order">Order.</param>
        /// <param name="State">State.</param>
        /// <param name="IsChoiceBoard">This is used in the WeekPlanner app by the frontend groups and should never be set from our side.</param>
        public ActivityDTO(WeekPictogramDTO Pictogram = default(WeekPictogramDTO), int? Order = default(int?), StateEnum? State = default(StateEnum?), bool? IsChoiceBoard = default(bool?), long? Id = default(long?))
        {
            this.Pictogram = Pictogram;
            this.Order = Order;
            this.State = State;
            this.IsChoiceBoard = IsChoiceBoard;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Pictogram
        /// </summary>
        [DataMember(Name="pictogram", EmitDefaultValue=false)]
        public WeekPictogramDTO Pictogram { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// This is used in the WeekPlanner app by the frontend groups and should never be set from our side
        /// </summary>
        /// <value>This is used in the WeekPlanner app by the frontend groups and should never be set from our side</value>
        [DataMember(Name="isChoiceBoard", EmitDefaultValue=false)]
        public bool? IsChoiceBoard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityDTO {\n");
            sb.Append("  Pictogram: ").Append(Pictogram).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsChoiceBoard: ").Append(IsChoiceBoard).Append("\n");
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
            return this.Equals(input as ActivityDTO);
        }

        /// <summary>
        /// Returns true if ActivityDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pictogram == input.Pictogram ||
                    (this.Pictogram != null &&
                    this.Pictogram.Equals(input.Pictogram))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsChoiceBoard == input.IsChoiceBoard ||
                    (this.IsChoiceBoard != null &&
                    this.IsChoiceBoard.Equals(input.IsChoiceBoard))
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
                if (this.Pictogram != null)
                    hashCode = hashCode * 59 + this.Pictogram.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsChoiceBoard != null)
                    hashCode = hashCode * 59 + this.IsChoiceBoard.GetHashCode();
                return hashCode;
            }
        }

        public long? ChoiceBoardID { get; set; }

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
