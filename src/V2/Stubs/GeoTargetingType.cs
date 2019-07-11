// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/geo_targeting_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/geo_targeting_type.proto</summary>
  public static partial class GeoTargetingTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/geo_targeting_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeoTargetingTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9nZW9fdGFyZ2V0aW5n",
            "X3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIngKFEdlb1RhcmdldGluZ1R5",
            "cGVFbnVtImAKEEdlb1RhcmdldGluZ1R5cGUSDwoLVU5TUEVDSUZJRUQQABIL",
            "CgdVTktOT1dOEAESFAoQQVJFQV9PRl9JTlRFUkVTVBACEhgKFExPQ0FUSU9O",
            "X09GX1BSRVNFTkNFEANC6gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "Mi5lbnVtc0IVR2VvVGFyZ2V0aW5nVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9l",
            "bnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYyLkVu",
            "dW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcRW51bXPqAiFHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWMjo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.GeoTargetingTypeEnum), global::Google.Ads.GoogleAds.V2.Enums.GeoTargetingTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.GeoTargetingTypeEnum.Types.GeoTargetingType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible geo targeting types.
  /// </summary>
  public sealed partial class GeoTargetingTypeEnum : pb::IMessage<GeoTargetingTypeEnum> {
    private static readonly pb::MessageParser<GeoTargetingTypeEnum> _parser = new pb::MessageParser<GeoTargetingTypeEnum>(() => new GeoTargetingTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GeoTargetingTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.GeoTargetingTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetingTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetingTypeEnum(GeoTargetingTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetingTypeEnum Clone() {
      return new GeoTargetingTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GeoTargetingTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GeoTargetingTypeEnum other) {
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GeoTargetingTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GeoTargetingTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible geo targeting types.
      /// </summary>
      public enum GeoTargetingType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Location the user is interested in while making the query.
        /// </summary>
        [pbr::OriginalName("AREA_OF_INTEREST")] AreaOfInterest = 2,
        /// <summary>
        /// Location of the user issuing the query.
        /// </summary>
        [pbr::OriginalName("LOCATION_OF_PRESENCE")] LocationOfPresence = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
