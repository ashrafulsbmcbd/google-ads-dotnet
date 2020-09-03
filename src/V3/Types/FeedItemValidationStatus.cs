// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/feed_item_validation_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/feed_item_validation_status.proto</summary>
  public static partial class FeedItemValidationStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/feed_item_validation_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemValidationStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9mZWVkX2l0ZW1fdmFs",
            "aWRhdGlvbl9zdGF0dXMucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIn0KHEZlZWRJ",
            "dGVtVmFsaWRhdGlvblN0YXR1c0VudW0iXQoYRmVlZEl0ZW1WYWxpZGF0aW9u",
            "U3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsKB1BFTkRJ",
            "TkcQAhILCgdJTlZBTElEEAMSCQoFVkFMSUQQBELyAQohY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYzLmVudW1zQh1GZWVkSXRlbVZhbGlkYXRpb25TdGF0",
            "dXNQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjMvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMy5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYzXEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjM6OkVu",
            "dW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.FeedItemValidationStatusEnum), global::Google.Ads.GoogleAds.V3.Enums.FeedItemValidationStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.FeedItemValidationStatusEnum.Types.FeedItemValidationStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible validation statuses of a feed item.
  /// </summary>
  public sealed partial class FeedItemValidationStatusEnum : pb::IMessage<FeedItemValidationStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemValidationStatusEnum> _parser = new pb::MessageParser<FeedItemValidationStatusEnum>(() => new FeedItemValidationStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedItemValidationStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.FeedItemValidationStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemValidationStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemValidationStatusEnum(FeedItemValidationStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemValidationStatusEnum Clone() {
      return new FeedItemValidationStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedItemValidationStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedItemValidationStatusEnum other) {
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
    public void MergeFrom(FeedItemValidationStatusEnum other) {
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
    /// <summary>Container for nested types declared in the FeedItemValidationStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible validation statuses of a feed item.
      /// </summary>
      public enum FeedItemValidationStatus {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Validation pending.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 2,
        /// <summary>
        /// An error was found.
        /// </summary>
        [pbr::OriginalName("INVALID")] Invalid = 3,
        /// <summary>
        /// Feed item is semantically well-formed.
        /// </summary>
        [pbr::OriginalName("VALID")] Valid = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
