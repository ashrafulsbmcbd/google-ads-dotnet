// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/enums/policy_review_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/enums/policy_review_status.proto</summary>
  public static partial class PolicyReviewStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/enums/policy_review_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyReviewStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9wb2xpY3lfcmV2aWV3",
            "X3N0YXR1cy5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8inQEKFlBvbGljeVJldmll",
            "d1N0YXR1c0VudW0iggEKElBvbGljeVJldmlld1N0YXR1cxIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIWChJSRVZJRVdfSU5fUFJPR1JFU1MQAhIM",
            "CghSRVZJRVdFRBADEhAKDFVOREVSX0FQUEVBTBAEEhYKEkVMSUdJQkxFX01B",
            "WV9TRVJWRRAFQuwBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUuZW51",
            "bXNCF1BvbGljeVJldmlld1N0YXR1c1Byb3RvUAFaQmdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NS9lbnVt",
            "cztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY1LkVudW1z",
            "ygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjVcRW51bXPqAiFHb29nbGU6OkFk",
            "czo6R29vZ2xlQWRzOjpWNTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Enums.PolicyReviewStatusEnum), global::Google.Ads.GoogleAds.V5.Enums.PolicyReviewStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V5.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy review statuses.
  /// </summary>
  public sealed partial class PolicyReviewStatusEnum : pb::IMessage<PolicyReviewStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyReviewStatusEnum> _parser = new pb::MessageParser<PolicyReviewStatusEnum>(() => new PolicyReviewStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyReviewStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Enums.PolicyReviewStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyReviewStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyReviewStatusEnum(PolicyReviewStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyReviewStatusEnum Clone() {
      return new PolicyReviewStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyReviewStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyReviewStatusEnum other) {
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
    public void MergeFrom(PolicyReviewStatusEnum other) {
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
    /// <summary>Container for nested types declared in the PolicyReviewStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible policy review statuses.
      /// </summary>
      public enum PolicyReviewStatus {
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
        /// Currently under review.
        /// </summary>
        [pbr::OriginalName("REVIEW_IN_PROGRESS")] ReviewInProgress = 2,
        /// <summary>
        /// Primary review complete. Other reviews may be continuing.
        /// </summary>
        [pbr::OriginalName("REVIEWED")] Reviewed = 3,
        /// <summary>
        /// The resource has been resubmitted for approval or its policy decision has
        /// been appealed.
        /// </summary>
        [pbr::OriginalName("UNDER_APPEAL")] UnderAppeal = 4,
        /// <summary>
        /// The resource is eligible and may be serving but could still undergo
        /// further review.
        /// </summary>
        [pbr::OriginalName("ELIGIBLE_MAY_SERVE")] EligibleMayServe = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
