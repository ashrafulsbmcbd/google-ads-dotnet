// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/advertising_channel_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/advertising_channel_type.proto</summary>
  public static partial class AdvertisingChannelTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/advertising_channel_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdvertisingChannelTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9hZHZlcnRpc2luZ19j",
            "aGFubmVsX3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVu",
            "dW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqUBChpBZHZlcnRp",
            "c2luZ0NoYW5uZWxUeXBlRW51bSKGAQoWQWR2ZXJ0aXNpbmdDaGFubmVsVHlw",
            "ZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIKCgZTRUFSQ0gQAhIL",
            "CgdESVNQTEFZEAMSDAoIU0hPUFBJTkcQBBIJCgVIT1RFTBAFEgkKBVZJREVP",
            "EAYSEQoNTVVMVElfQ0hBTk5FTBAHQvABCiFjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjIuZW51bXNCG0FkdmVydGlzaW5nQ2hhbm5lbFR5cGVQcm90b1AB",
            "WkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjIvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMi5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVu",
            "dW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.AdvertisingChannelTypeEnum), global::Google.Ads.GoogleAds.V2.Enums.AdvertisingChannelTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The channel type a campaign may target to serve on.
  /// </summary>
  public sealed partial class AdvertisingChannelTypeEnum : pb::IMessage<AdvertisingChannelTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdvertisingChannelTypeEnum> _parser = new pb::MessageParser<AdvertisingChannelTypeEnum>(() => new AdvertisingChannelTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdvertisingChannelTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.AdvertisingChannelTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelTypeEnum(AdvertisingChannelTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelTypeEnum Clone() {
      return new AdvertisingChannelTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdvertisingChannelTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdvertisingChannelTypeEnum other) {
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
    public void MergeFrom(AdvertisingChannelTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdvertisingChannelTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the various advertising channel types.
      /// </summary>
      public enum AdvertisingChannelType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Search Network. Includes display bundled, and Search+ campaigns.
        /// </summary>
        [pbr::OriginalName("SEARCH")] Search = 2,
        /// <summary>
        /// Google Display Network only.
        /// </summary>
        [pbr::OriginalName("DISPLAY")] Display = 3,
        /// <summary>
        /// Shopping campaigns serve on the shopping property
        /// and on google.com search results.
        /// </summary>
        [pbr::OriginalName("SHOPPING")] Shopping = 4,
        /// <summary>
        /// Hotel Ads campaigns.
        /// </summary>
        [pbr::OriginalName("HOTEL")] Hotel = 5,
        /// <summary>
        /// Video campaigns.
        /// </summary>
        [pbr::OriginalName("VIDEO")] Video = 6,
        /// <summary>
        /// App Campaigns, and App Campaigns for Engagement, that run
        /// across multiple channels.
        /// </summary>
        [pbr::OriginalName("MULTI_CHANNEL")] MultiChannel = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
