// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/errors/ad_group_feed_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/errors/ad_group_feed_error.proto</summary>
  public static partial class AdGroupFeedErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/errors/ad_group_feed_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupFeedErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnMvYWRfZ3JvdXBfZmVl",
            "ZF9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZXJyb3Jz",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItwCChRBZEdyb3VwRmVl",
            "ZEVycm9yRW51bSLDAgoQQWRHcm91cEZlZWRFcnJvchIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIsCihGRUVEX0FMUkVBRFlfRVhJU1RTX0ZPUl9Q",
            "TEFDRUhPTERFUl9UWVBFEAISIgoeQ0FOTk9UX0NSRUFURV9GT1JfUkVNT1ZF",
            "RF9GRUVEEAMSHwobQURHUk9VUF9GRUVEX0FMUkVBRFlfRVhJU1RTEAQSKgom",
            "Q0FOTk9UX09QRVJBVEVfT05fUkVNT1ZFRF9BREdST1VQX0ZFRUQQBRIcChhJ",
            "TlZBTElEX1BMQUNFSE9MREVSX1RZUEUQBhIsCihNSVNTSU5HX0ZFRURNQVBQ",
            "SU5HX0ZPUl9QTEFDRUhPTERFUl9UWVBFEAcSJgoiTk9fRVhJU1RJTkdfTE9D",
            "QVRJT05fQ1VTVE9NRVJfRkVFRBAIQvABCiJjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjIuZXJyb3JzQhVBZEdyb3VwRmVlZEVycm9yUHJvdG9QAVpEZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YyL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMi5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMlxFcnJv",
            "cnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6RXJyb3JzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Errors.AdGroupFeedErrorEnum), global::Google.Ads.GoogleAds.V2.Errors.AdGroupFeedErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Errors.AdGroupFeedErrorEnum.Types.AdGroupFeedError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group feed errors.
  /// </summary>
  public sealed partial class AdGroupFeedErrorEnum : pb::IMessage<AdGroupFeedErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupFeedErrorEnum> _parser = new pb::MessageParser<AdGroupFeedErrorEnum>(() => new AdGroupFeedErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupFeedErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Errors.AdGroupFeedErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupFeedErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupFeedErrorEnum(AdGroupFeedErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupFeedErrorEnum Clone() {
      return new AdGroupFeedErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupFeedErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupFeedErrorEnum other) {
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
    public void MergeFrom(AdGroupFeedErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupFeedErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group feed errors.
      /// </summary>
      public enum AdGroupFeedError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An active feed already exists for this ad group and place holder type.
        /// </summary>
        [pbr::OriginalName("FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] FeedAlreadyExistsForPlaceholderType = 2,
        /// <summary>
        /// The specified feed is removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_FOR_REMOVED_FEED")] CannotCreateForRemovedFeed = 3,
        /// <summary>
        /// The AdGroupFeed already exists. UPDATE operation should be used to modify
        /// the existing AdGroupFeed.
        /// </summary>
        [pbr::OriginalName("ADGROUP_FEED_ALREADY_EXISTS")] AdgroupFeedAlreadyExists = 4,
        /// <summary>
        /// Cannot operate on removed AdGroupFeed.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_ADGROUP_FEED")] CannotOperateOnRemovedAdgroupFeed = 5,
        /// <summary>
        /// Invalid placeholder type.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_TYPE")] InvalidPlaceholderType = 6,
        /// <summary>
        /// Feed mapping for this placeholder type does not exist.
        /// </summary>
        [pbr::OriginalName("MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE")] MissingFeedmappingForPlaceholderType = 7,
        /// <summary>
        /// Location AdGroupFeeds cannot be created unless there is a location
        /// CustomerFeed for the specified feed.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_LOCATION_CUSTOMER_FEED")] NoExistingLocationCustomerFeed = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
