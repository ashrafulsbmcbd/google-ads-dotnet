// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/custom_interest_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/services/custom_interest_service.proto</summary>
  public static partial class CustomInterestServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/services/custom_interest_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomInterestServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9zZXJ2aWNlcy9jdXN0b21faW50",
            "ZXJlc3Rfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIu",
            "c2VydmljZXMaN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YyL3Jlc291cmNlcy9j",
            "dXN0b21faW50ZXJlc3QucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUvYXBpL2Zp",
            "ZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3Rv",
            "GiBnb29nbGUvcHJvdG9idWYvZmllbGRfbWFzay5wcm90byJiChhHZXRDdXN0",
            "b21JbnRlcmVzdFJlcXVlc3QSRgoNcmVzb3VyY2VfbmFtZRgBIAEoCUIv4EEC",
            "+kEpCidnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tSW50ZXJlc3Qi",
            "owEKHE11dGF0ZUN1c3RvbUludGVyZXN0c1JlcXVlc3QSGAoLY3VzdG9tZXJf",
            "aWQYASABKAlCA+BBAhJSCgpvcGVyYXRpb25zGAIgAygLMjkuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjIuc2VydmljZXMuQ3VzdG9tSW50ZXJlc3RPcGVyYXRp",
            "b25CA+BBAhIVCg12YWxpZGF0ZV9vbmx5GAQgASgIIuEBChdDdXN0b21JbnRl",
            "cmVzdE9wZXJhdGlvbhIvCgt1cGRhdGVfbWFzaxgEIAEoCzIaLmdvb2dsZS5w",
            "cm90b2J1Zi5GaWVsZE1hc2sSQwoGY3JlYXRlGAEgASgLMjEuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjIucmVzb3VyY2VzLkN1c3RvbUludGVyZXN0SAASQwoG",
            "dXBkYXRlGAIgASgLMjEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3Vy",
            "Y2VzLkN1c3RvbUludGVyZXN0SABCCwoJb3BlcmF0aW9uIm4KHU11dGF0ZUN1",
            "c3RvbUludGVyZXN0c1Jlc3BvbnNlEk0KB3Jlc3VsdHMYAiADKAsyPC5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52Mi5zZXJ2aWNlcy5NdXRhdGVDdXN0b21JbnRl",
            "cmVzdFJlc3VsdCIzChpNdXRhdGVDdXN0b21JbnRlcmVzdFJlc3VsdBIVCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJMvkDChVDdXN0b21JbnRlcmVzdFNlcnZpY2US",
            "zQEKEUdldEN1c3RvbUludGVyZXN0EjouZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djIuc2VydmljZXMuR2V0Q3VzdG9tSW50ZXJlc3RSZXF1ZXN0GjEuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjIucmVzb3VyY2VzLkN1c3RvbUludGVyZXN0IkmC",
            "0+STAjMSMS92Mi97cmVzb3VyY2VfbmFtZT1jdXN0b21lcnMvKi9jdXN0b21J",
            "bnRlcmVzdHMvKn3aQQ1yZXNvdXJjZV9uYW1lEvIBChVNdXRhdGVDdXN0b21J",
            "bnRlcmVzdHMSPi5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5zZXJ2aWNlcy5N",
            "dXRhdGVDdXN0b21JbnRlcmVzdHNSZXF1ZXN0Gj8uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjIuc2VydmljZXMuTXV0YXRlQ3VzdG9tSW50ZXJlc3RzUmVzcG9u",
            "c2UiWILT5JMCOSI0L3YyL2N1c3RvbWVycy97Y3VzdG9tZXJfaWQ9Kn0vY3Vz",
            "dG9tSW50ZXJlc3RzOm11dGF0ZToBKtpBFmN1c3RvbWVyX2lkLG9wZXJhdGlv",
            "bnMaG8pBGGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbUKBAgokY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYyLnNlcnZpY2VzQhpDdXN0b21JbnRlcmVzdFNl",
            "cnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIvc2VydmljZXM7c2VydmljZXOiAgNH",
            "QUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5TZXJ2aWNlc8oCIEdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYyXFNlcnZpY2Vz6gIkR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjI6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Resources.CustomInterestReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.GetCustomInterestRequest), global::Google.Ads.GoogleAds.V2.Services.GetCustomInterestRequest.Parser, new[]{ "ResourceName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestsRequest), global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestsRequest.Parser, new[]{ "CustomerId", "Operations", "ValidateOnly" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.CustomInterestOperation), global::Google.Ads.GoogleAds.V2.Services.CustomInterestOperation.Parser, new[]{ "UpdateMask", "Create", "Update" }, new[]{ "Operation" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestsResponse), global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestsResponse.Parser, new[]{ "Results" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestResult), global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestResult.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [CustomInterestService.GetCustomInterest][google.ads.googleads.v2.services.CustomInterestService.GetCustomInterest].
  /// </summary>
  public sealed partial class GetCustomInterestRequest : pb::IMessage<GetCustomInterestRequest> {
    private static readonly pb::MessageParser<GetCustomInterestRequest> _parser = new pb::MessageParser<GetCustomInterestRequest>(() => new GetCustomInterestRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCustomInterestRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.CustomInterestServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomInterestRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomInterestRequest(GetCustomInterestRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomInterestRequest Clone() {
      return new GetCustomInterestRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the custom interest to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCustomInterestRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCustomInterestRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCustomInterestRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Request message for [CustomInterestService.MutateCustomInterests][google.ads.googleads.v2.services.CustomInterestService.MutateCustomInterests].
  /// </summary>
  public sealed partial class MutateCustomInterestsRequest : pb::IMessage<MutateCustomInterestsRequest> {
    private static readonly pb::MessageParser<MutateCustomInterestsRequest> _parser = new pb::MessageParser<MutateCustomInterestsRequest>(() => new MutateCustomInterestsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCustomInterestsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.CustomInterestServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestsRequest(MutateCustomInterestsRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      validateOnly_ = other.validateOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestsRequest Clone() {
      return new MutateCustomInterestsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer whose custom interests are being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V2.Services.CustomInterestOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V2.Services.CustomInterestOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.CustomInterestOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.CustomInterestOperation>();
    /// <summary>
    /// Required. The list of operations to perform on individual custom interests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.CustomInterestOperation> Operations {
      get { return operations_; }
    }

    /// <summary>Field number for the "validate_only" field.</summary>
    public const int ValidateOnlyFieldNumber = 4;
    private bool validateOnly_;
    /// <summary>
    /// If true, the request is validated but not executed. Only errors are
    /// returned, not results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ValidateOnly {
      get { return validateOnly_; }
      set {
        validateOnly_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateCustomInterestsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCustomInterestsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      if (ValidateOnly != other.ValidateOnly) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
      if (ValidateOnly != false) hash ^= ValidateOnly.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (ValidateOnly != false) {
        output.WriteRawTag(32);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (ValidateOnly != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateCustomInterestsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
      if (other.ValidateOnly != false) {
        ValidateOnly = other.ValidateOnly;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
          case 32: {
            ValidateOnly = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A single operation (create, update) on a custom interest.
  /// </summary>
  public sealed partial class CustomInterestOperation : pb::IMessage<CustomInterestOperation> {
    private static readonly pb::MessageParser<CustomInterestOperation> _parser = new pb::MessageParser<CustomInterestOperation>(() => new CustomInterestOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomInterestOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.CustomInterestServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestOperation(CustomInterestOperation other) : this() {
      updateMask_ = other.updateMask_ != null ? other.updateMask_.Clone() : null;
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Update:
          Update = other.Update.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestOperation Clone() {
      return new CustomInterestOperation(this);
    }

    /// <summary>Field number for the "update_mask" field.</summary>
    public const int UpdateMaskFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
    /// <summary>
    /// FieldMask that determines which resource fields are modified in an update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.FieldMask UpdateMask {
      get { return updateMask_; }
      set {
        updateMask_ = value;
      }
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new custom
    /// interest.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Resources.CustomInterest Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V2.Resources.CustomInterest) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "update" field.</summary>
    public const int UpdateFieldNumber = 2;
    /// <summary>
    /// Update operation: The custom interest is expected to have a valid
    /// resource name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Resources.CustomInterest Update {
      get { return operationCase_ == OperationOneofCase.Update ? (global::Google.Ads.GoogleAds.V2.Resources.CustomInterest) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Update;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Update = 2,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomInterestOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomInterestOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UpdateMask, other.UpdateMask)) return false;
      if (!object.Equals(Create, other.Create)) return false;
      if (!object.Equals(Update, other.Update)) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Update) hash ^= Update.GetHashCode();
      hash ^= (int) operationCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        output.WriteRawTag(18);
        output.WriteMessage(Update);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (updateMask_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateMask);
      }
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Update);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomInterestOperation other) {
      if (other == null) {
        return;
      }
      if (other.updateMask_ != null) {
        if (updateMask_ == null) {
          UpdateMask = new global::Google.Protobuf.WellKnownTypes.FieldMask();
        }
        UpdateMask.MergeFrom(other.UpdateMask);
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V2.Resources.CustomInterest();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Update:
          if (Update == null) {
            Update = new global::Google.Ads.GoogleAds.V2.Resources.CustomInterest();
          }
          Update.MergeFrom(other.Update);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::Google.Ads.GoogleAds.V2.Resources.CustomInterest subBuilder = new global::Google.Ads.GoogleAds.V2.Resources.CustomInterest();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V2.Resources.CustomInterest subBuilder = new global::Google.Ads.GoogleAds.V2.Resources.CustomInterest();
            if (operationCase_ == OperationOneofCase.Update) {
              subBuilder.MergeFrom(Update);
            }
            input.ReadMessage(subBuilder);
            Update = subBuilder;
            break;
          }
          case 34: {
            if (updateMask_ == null) {
              UpdateMask = new global::Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for custom interest mutate.
  /// </summary>
  public sealed partial class MutateCustomInterestsResponse : pb::IMessage<MutateCustomInterestsResponse> {
    private static readonly pb::MessageParser<MutateCustomInterestsResponse> _parser = new pb::MessageParser<MutateCustomInterestsResponse>(() => new MutateCustomInterestsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCustomInterestsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.CustomInterestServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestsResponse(MutateCustomInterestsResponse other) : this() {
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestsResponse Clone() {
      return new MutateCustomInterestsResponse(this);
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MutateCustomInterestResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateCustomInterestsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCustomInterestsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!results_.Equals(other.results_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= results_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      results_.WriteTo(output, _repeated_results_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += results_.CalculateSize(_repeated_results_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateCustomInterestsResponse other) {
      if (other == null) {
        return;
      }
      results_.Add(other.results_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The result for the custom interest mutate.
  /// </summary>
  public sealed partial class MutateCustomInterestResult : pb::IMessage<MutateCustomInterestResult> {
    private static readonly pb::MessageParser<MutateCustomInterestResult> _parser = new pb::MessageParser<MutateCustomInterestResult>(() => new MutateCustomInterestResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCustomInterestResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.CustomInterestServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestResult(MutateCustomInterestResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCustomInterestResult Clone() {
      return new MutateCustomInterestResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Returned for successful operations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateCustomInterestResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCustomInterestResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateCustomInterestResult other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code