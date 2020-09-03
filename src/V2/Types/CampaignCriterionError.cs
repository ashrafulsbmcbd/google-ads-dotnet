// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/errors/campaign_criterion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/errors/campaign_criterion_error.proto</summary>
  public static partial class CampaignCriterionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/errors/campaign_criterion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnMvY2FtcGFpZ25fY3Jp",
            "dGVyaW9uX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5l",
            "cnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i9QMKGkNhbXBh",
            "aWduQ3JpdGVyaW9uRXJyb3JFbnVtItYDChZDYW1wYWlnbkNyaXRlcmlvbkVy",
            "cm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhoKFkNPTkNSRVRF",
            "X1RZUEVfUkVRVUlSRUQQAhIZChVJTlZBTElEX1BMQUNFTUVOVF9VUkwQAxIg",
            "ChxDQU5OT1RfRVhDTFVERV9DUklURVJJQV9UWVBFEAQSJwojQ0FOTk9UX1NF",
            "VF9TVEFUVVNfRk9SX0NSSVRFUklBX1RZUEUQBRIrCidDQU5OT1RfU0VUX1NU",
            "QVRVU19GT1JfRVhDTFVERURfQ1JJVEVSSUEQBhIdChlDQU5OT1RfVEFSR0VU",
            "X0FORF9FWENMVURFEAcSFwoTVE9PX01BTllfT1BFUkFUSU9OUxAIEi0KKU9Q",
            "RVJBVE9SX05PVF9TVVBQT1JURURfRk9SX0NSSVRFUklPTl9UWVBFEAkSQwo/",
            "U0hPUFBJTkdfQ0FNUEFJR05fU0FMRVNfQ09VTlRSWV9OT1RfU1VQUE9SVEVE",
            "X0ZPUl9TQUxFU19DSEFOTkVMEAoSHQoZQ0FOTk9UX0FERF9FWElTVElOR19G",
            "SUVMRBALEiQKIENBTk5PVF9VUERBVEVfTkVHQVRJVkVfQ1JJVEVSSU9OEAxC",
            "9gEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lcnJvcnNCG0NhbXBh",
            "aWduQ3JpdGVyaW9uRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIvZXJyb3JzO2Vy",
            "cm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYyLkVycm9yc8oC",
            "Hkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVycm9yc+oCIkdvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYyOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Errors.CampaignCriterionErrorEnum), global::Google.Ads.GoogleAds.V2.Errors.CampaignCriterionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Errors.CampaignCriterionErrorEnum.Types.CampaignCriterionError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign criterion errors.
  /// </summary>
  public sealed partial class CampaignCriterionErrorEnum : pb::IMessage<CampaignCriterionErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignCriterionErrorEnum> _parser = new pb::MessageParser<CampaignCriterionErrorEnum>(() => new CampaignCriterionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignCriterionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Errors.CampaignCriterionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionErrorEnum(CampaignCriterionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionErrorEnum Clone() {
      return new CampaignCriterionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignCriterionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignCriterionErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignCriterionErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CampaignCriterionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign criterion errors.
      /// </summary>
      public enum CampaignCriterionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Concrete type of criterion (keyword v.s. placement) is required for
        /// CREATE and UPDATE operations.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 2,
        /// <summary>
        /// Invalid placement URL.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEMENT_URL")] InvalidPlacementUrl = 3,
        /// <summary>
        /// Criteria type can not be excluded for the campaign by the customer. like
        /// AOL account type cannot target site type criteria
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_CRITERIA_TYPE")] CannotExcludeCriteriaType = 4,
        /// <summary>
        /// Cannot set the campaign criterion status for this criteria type.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_FOR_CRITERIA_TYPE")] CannotSetStatusForCriteriaType = 5,
        /// <summary>
        /// Cannot set the campaign criterion status for an excluded criteria.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_STATUS_FOR_EXCLUDED_CRITERIA")] CannotSetStatusForExcludedCriteria = 6,
        /// <summary>
        /// Cannot target and exclude the same criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_AND_EXCLUDE")] CannotTargetAndExclude = 7,
        /// <summary>
        /// The mutate contained too many operations.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 8,
        /// <summary>
        /// This operator cannot be applied to a criterion of this type.
        /// </summary>
        [pbr::OriginalName("OPERATOR_NOT_SUPPORTED_FOR_CRITERION_TYPE")] OperatorNotSupportedForCriterionType = 9,
        /// <summary>
        /// The Shopping campaign sales country is not supported for
        /// ProductSalesChannel targeting.
        /// </summary>
        [pbr::OriginalName("SHOPPING_CAMPAIGN_SALES_COUNTRY_NOT_SUPPORTED_FOR_SALES_CHANNEL")] ShoppingCampaignSalesCountryNotSupportedForSalesChannel = 10,
        /// <summary>
        /// The existing field can't be updated with CREATE operation. It can be
        /// updated with UPDATE operation only.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_EXISTING_FIELD")] CannotAddExistingField = 11,
        /// <summary>
        /// Negative criteria are immutable, so updates are not allowed.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_NEGATIVE_CRITERION")] CannotUpdateNegativeCriterion = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
