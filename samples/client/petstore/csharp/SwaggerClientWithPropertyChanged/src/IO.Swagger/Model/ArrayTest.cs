/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ArrayTest
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class ArrayTest :  IEquatable<ArrayTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayTest" /> class.
        /// </summary>
        /// <param name="arrayOfString">arrayOfString.</param>
        /// <param name="arrayArrayOfInteger">arrayArrayOfInteger.</param>
        /// <param name="arrayArrayOfModel">arrayArrayOfModel.</param>
        public ArrayTest(List<string> arrayOfString = default(List<string>), List<List<long?>> arrayArrayOfInteger = default(List<List<long?>>), List<List<ReadOnlyFirst>> arrayArrayOfModel = default(List<List<ReadOnlyFirst>>))
        {
            this.ArrayOfString = arrayOfString;
            this.ArrayArrayOfInteger = arrayArrayOfInteger;
            this.ArrayArrayOfModel = arrayArrayOfModel;
        }
        
        /// <summary>
        /// Gets or Sets ArrayOfString
        /// </summary>
        [DataMember(Name="array_of_string", EmitDefaultValue=false)]
        public List<string> ArrayOfString { get; set; }

        /// <summary>
        /// Gets or Sets ArrayArrayOfInteger
        /// </summary>
        [DataMember(Name="array_array_of_integer", EmitDefaultValue=false)]
        public List<List<long?>> ArrayArrayOfInteger { get; set; }

        /// <summary>
        /// Gets or Sets ArrayArrayOfModel
        /// </summary>
        [DataMember(Name="array_array_of_model", EmitDefaultValue=false)]
        public List<List<ReadOnlyFirst>> ArrayArrayOfModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArrayTest {\n");
            sb.Append("  ArrayOfString: ").Append(ArrayOfString).Append("\n");
            sb.Append("  ArrayArrayOfInteger: ").Append(ArrayArrayOfInteger).Append("\n");
            sb.Append("  ArrayArrayOfModel: ").Append(ArrayArrayOfModel).Append("\n");
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
            return this.Equals(input as ArrayTest);
        }

        /// <summary>
        /// Returns true if ArrayTest instances are equal
        /// </summary>
        /// <param name="input">Instance of ArrayTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArrayTest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ArrayOfString == input.ArrayOfString ||
                    this.ArrayOfString != null &&
                    this.ArrayOfString.SequenceEqual(input.ArrayOfString)
                ) && 
                (
                    this.ArrayArrayOfInteger == input.ArrayArrayOfInteger ||
                    this.ArrayArrayOfInteger != null &&
                    this.ArrayArrayOfInteger.SequenceEqual(input.ArrayArrayOfInteger)
                ) && 
                (
                    this.ArrayArrayOfModel == input.ArrayArrayOfModel ||
                    this.ArrayArrayOfModel != null &&
                    this.ArrayArrayOfModel.SequenceEqual(input.ArrayArrayOfModel)
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
                if (this.ArrayOfString != null)
                    hashCode = hashCode * 59 + this.ArrayOfString.GetHashCode();
                if (this.ArrayArrayOfInteger != null)
                    hashCode = hashCode * 59 + this.ArrayArrayOfInteger.GetHashCode();
                if (this.ArrayArrayOfModel != null)
                    hashCode = hashCode * 59 + this.ArrayArrayOfModel.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
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
