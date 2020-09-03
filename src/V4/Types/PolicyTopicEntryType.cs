// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/policy_topic_entry_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/policy_topic_entry_type.proto</summary>
  public static partial class PolicyTopicEntryTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/policy_topic_entry_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyTopicEntryTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9wb2xpY3lfdG9waWNf",
            "ZW50cnlfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ivQEKGFBvbGljeVRv",
            "cGljRW50cnlUeXBlRW51bSKgAQoUUG9saWN5VG9waWNFbnRyeVR5cGUSDwoL",
            "VU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDgoKUFJPSElCSVRFRBACEgsK",
            "B0xJTUlURUQQBBIRCg1GVUxMWV9MSU1JVEVEEAgSDwoLREVTQ1JJUFRJVkUQ",
            "BRIOCgpCUk9BREVOSU5HEAYSGQoVQVJFQV9PRl9JTlRFUkVTVF9PTkxZEAdC",
            "7gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lbnVtc0IZUG9saWN5",
            "VG9waWNFbnRyeVR5cGVQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQvZW51bXM7ZW51bXOi",
            "AgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5FbnVtc8oCHUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFY0XEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6VjQ6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.PolicyTopicEntryTypeEnum), global::Google.Ads.GoogleAds.V4.Enums.PolicyTopicEntryTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.PolicyTopicEntryTypeEnum.Types.PolicyTopicEntryType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy topic entry types.
  /// </summary>
  public sealed partial class PolicyTopicEntryTypeEnum : pb::IMessage<PolicyTopicEntryTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyTopicEntryTypeEnum> _parser = new pb::MessageParser<PolicyTopicEntryTypeEnum>(() => new PolicyTopicEntryTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyTopicEntryTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.PolicyTopicEntryTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEntryTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEntryTypeEnum(PolicyTopicEntryTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEntryTypeEnum Clone() {
      return new PolicyTopicEntryTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyTopicEntryTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyTopicEntryTypeEnum other) {
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
    public void MergeFrom(PolicyTopicEntryTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PolicyTopicEntryTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible policy topic entry types.
      /// </summary>
      public enum PolicyTopicEntryType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The resource will not be served.
        /// </summary>
        [pbr::OriginalName("PROHIBITED")] Prohibited = 2,
        /// <summary>
        /// The resource will not be served under some circumstances.
        /// </summary>
        [pbr::OriginalName("LIMITED")] Limited = 4,
        /// <summary>
        /// The resource cannot serve at all because of the current targeting
        /// criteria.
        /// </summary>
        [pbr::OriginalName("FULLY_LIMITED")] FullyLimited = 8,
        /// <summary>
        /// May be of interest, but does not limit how the resource is served.
        /// </summary>
        [pbr::OriginalName("DESCRIPTIVE")] Descriptive = 5,
        /// <summary>
        /// Could increase coverage beyond normal.
        /// </summary>
        [pbr::OriginalName("BROADENING")] Broadening = 6,
        /// <summary>
        /// Constrained for all targeted countries, but may serve in other countries
        /// through area of interest.
        /// </summary>
        [pbr::OriginalName("AREA_OF_INTEREST_ONLY")] AreaOfInterestOnly = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
