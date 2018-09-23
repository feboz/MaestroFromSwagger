/*
 * MaestroHostService
 *
 * This is the Host API for Maestro System
 *
 * OpenAPI spec version: 1.0.0
 * Contact: febo74@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ScenesResponseData : IEquatable<ScenesResponseData>
    { 
        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="projectID")]
        public int? ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [DataMember(Name="projectName")]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets Scenes
        /// </summary>
        [DataMember(Name="scenes")]
        public List<Scene> Scenes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScenesResponseData {\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("  Scenes: ").Append(Scenes).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ScenesResponseData)obj);
        }

        /// <summary>
        /// Returns true if ScenesResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of ScenesResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScenesResponseData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProjectID == other.ProjectID ||
                    ProjectID != null &&
                    ProjectID.Equals(other.ProjectID)
                ) && 
                (
                    ProjectName == other.ProjectName ||
                    ProjectName != null &&
                    ProjectName.Equals(other.ProjectName)
                ) && 
                (
                    Scenes == other.Scenes ||
                    Scenes != null &&
                    Scenes.SequenceEqual(other.Scenes)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ProjectID != null)
                    hashCode = hashCode * 59 + ProjectID.GetHashCode();
                    if (ProjectName != null)
                    hashCode = hashCode * 59 + ProjectName.GetHashCode();
                    if (Scenes != null)
                    hashCode = hashCode * 59 + Scenes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ScenesResponseData left, ScenesResponseData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ScenesResponseData left, ScenesResponseData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
