﻿//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


#nullable enable


namespace WaterHeating
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// ProblemDetails provides detailed information about an errors that occurred during an api call execution.
    /// <br/>This problem object is conform the standard specifications, see https://tools.ietf.org/html/rfc7807.
    /// </summary>
    
    public partial record Error
    {
        /// <summary>
        /// A short, human-readable summary of the problem type.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Title { get; set; } = default!;

        /// <summary>
        /// A human-readable explanation for what exactly happened (in English).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("detail")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public string? Detail { get; set; } = default!;


        [System.Text.Json.Serialization.JsonPropertyName("validationProblemDetails")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public ValidationProblemDetails? ValidationProblemDetails { get; set; } = default!;



        private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// ValidationProblemDetails provides detailed information about a validation errors that occurred during an api call execution.
    /// </summary>
    
    public partial record ValidationProblemDetails
    {
        /// <summary>
        /// Validation errors.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("errors")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.ICollection<string>>? Errors { get; set; } = default!;



        private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;

        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    
    public partial record UpsertMeteringPointCustomerVersionCommandExecutedEventPayload
    {
        /// <summary>
        /// Number of DataHub BRS process
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("brsNumber")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        public string? BrsNumber { get; set; } = default!;

        /// <summary>
        /// Number of DataHub RSM process
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("rsmNumber")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        public string? RsmNumber { get; set; } = default!;

        /// <summary>
        /// Id of metering point customer version
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("meteringPointCustomerVersionId")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string? MeteringPointCustomerVersionId { get; set; } = default!;

        /// <summary>
        /// Id of metering point
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("meteringPointId")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string? MeteringPointId { get; set; } = default!;


        [System.Text.Json.Serialization.JsonPropertyName("result")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public UpsertMeteringPointCustomerVersionCommandExecutedEventPayloadResult? Result { get; set; } = default!;


        [System.Text.Json.Serialization.JsonPropertyName("error")]

        [System.Text.Json.Serialization.JsonIgnore(Condition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault)]   
        public Error? Error { get; set; } = default!;


    }

    
    public enum UpsertMeteringPointCustomerVersionCommandExecutedEventPayloadResult
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Success")]
        Success = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"Failure")]
        Failure = 1,


    }
}