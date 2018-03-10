/* 
 * My API
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
    /// The LauncherOptions, which is the various settings the users can add to customize the Launcher App.
    /// </summary>
    [DataContract]
    public partial class LauncherOptions :  IEquatable<LauncherOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LauncherOptions" /> class.
        /// </summary>
        /// <param name="UseGrayscale">A flag indicating whether to run applications in grayscale or not..</param>
        /// <param name="DisplayLauncherAnimations">A flag indicating whether to display animations in the launcher or not..</param>
        /// <param name="AppsUserCanAccess">A collection of all the user&#39;s applications..</param>
        /// <param name="AppGridSizeRows">A field for storing how many rows to display in the GirafLauncher application..</param>
        /// <param name="AppGridSizeColumns">A field for storing how many columns to display in the GirafLauncher application..</param>
        public LauncherOptions(bool? UseGrayscale = default(bool?), bool? DisplayLauncherAnimations = default(bool?), List<ApplicationOption> AppsUserCanAccess = default(List<ApplicationOption>), int? AppGridSizeRows = default(int?), int? AppGridSizeColumns = default(int?))
        {
            this.UseGrayscale = UseGrayscale;
            this.DisplayLauncherAnimations = DisplayLauncherAnimations;
            this.AppsUserCanAccess = AppsUserCanAccess;
            this.AppGridSizeRows = AppGridSizeRows;
            this.AppGridSizeColumns = AppGridSizeColumns;
        }
        
        /// <summary>
        /// Key for LauncherOptions
        /// </summary>
        /// <value>Key for LauncherOptions</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public long? Key { get; private set; }

        /// <summary>
        /// A flag indicating whether to run applications in grayscale or not.
        /// </summary>
        /// <value>A flag indicating whether to run applications in grayscale or not.</value>
        [DataMember(Name="useGrayscale", EmitDefaultValue=false)]
        public bool? UseGrayscale { get; set; }

        /// <summary>
        /// A flag indicating whether to display animations in the launcher or not.
        /// </summary>
        /// <value>A flag indicating whether to display animations in the launcher or not.</value>
        [DataMember(Name="displayLauncherAnimations", EmitDefaultValue=false)]
        public bool? DisplayLauncherAnimations { get; set; }

        /// <summary>
        /// A collection of all the user&#39;s applications.
        /// </summary>
        /// <value>A collection of all the user&#39;s applications.</value>
        [DataMember(Name="appsUserCanAccess", EmitDefaultValue=false)]
        public List<ApplicationOption> AppsUserCanAccess { get; set; }

        /// <summary>
        /// A field for storing how many rows to display in the GirafLauncher application.
        /// </summary>
        /// <value>A field for storing how many rows to display in the GirafLauncher application.</value>
        [DataMember(Name="appGridSizeRows", EmitDefaultValue=false)]
        public int? AppGridSizeRows { get; set; }

        /// <summary>
        /// A field for storing how many columns to display in the GirafLauncher application.
        /// </summary>
        /// <value>A field for storing how many columns to display in the GirafLauncher application.</value>
        [DataMember(Name="appGridSizeColumns", EmitDefaultValue=false)]
        public int? AppGridSizeColumns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LauncherOptions {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  UseGrayscale: ").Append(UseGrayscale).Append("\n");
            sb.Append("  DisplayLauncherAnimations: ").Append(DisplayLauncherAnimations).Append("\n");
            sb.Append("  AppsUserCanAccess: ").Append(AppsUserCanAccess).Append("\n");
            sb.Append("  AppGridSizeRows: ").Append(AppGridSizeRows).Append("\n");
            sb.Append("  AppGridSizeColumns: ").Append(AppGridSizeColumns).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as LauncherOptions);
        }

        /// <summary>
        /// Returns true if LauncherOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of LauncherOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LauncherOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.UseGrayscale == other.UseGrayscale ||
                    this.UseGrayscale != null &&
                    this.UseGrayscale.Equals(other.UseGrayscale)
                ) && 
                (
                    this.DisplayLauncherAnimations == other.DisplayLauncherAnimations ||
                    this.DisplayLauncherAnimations != null &&
                    this.DisplayLauncherAnimations.Equals(other.DisplayLauncherAnimations)
                ) && 
                (
                    this.AppsUserCanAccess == other.AppsUserCanAccess ||
                    this.AppsUserCanAccess != null &&
                    this.AppsUserCanAccess.SequenceEqual(other.AppsUserCanAccess)
                ) && 
                (
                    this.AppGridSizeRows == other.AppGridSizeRows ||
                    this.AppGridSizeRows != null &&
                    this.AppGridSizeRows.Equals(other.AppGridSizeRows)
                ) && 
                (
                    this.AppGridSizeColumns == other.AppGridSizeColumns ||
                    this.AppGridSizeColumns != null &&
                    this.AppGridSizeColumns.Equals(other.AppGridSizeColumns)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.UseGrayscale != null)
                    hash = hash * 59 + this.UseGrayscale.GetHashCode();
                if (this.DisplayLauncherAnimations != null)
                    hash = hash * 59 + this.DisplayLauncherAnimations.GetHashCode();
                if (this.AppsUserCanAccess != null)
                    hash = hash * 59 + this.AppsUserCanAccess.GetHashCode();
                if (this.AppGridSizeRows != null)
                    hash = hash * 59 + this.AppGridSizeRows.GetHashCode();
                if (this.AppGridSizeColumns != null)
                    hash = hash * 59 + this.AppGridSizeColumns.GetHashCode();
                return hash;
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