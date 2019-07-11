// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/location_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/location_placeholder_field.proto</summary>
  public static partial class LocationPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/location_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9sb2NhdGlvbl9wbGFj",
            "ZWhvbGRlcl9maWVsZC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIu",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i4QEKHExvY2F0",
            "aW9uUGxhY2Vob2xkZXJGaWVsZEVudW0iwAEKGExvY2F0aW9uUGxhY2Vob2xk",
            "ZXJGaWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIRCg1CVVNJ",
            "TkVTU19OQU1FEAISEgoOQUREUkVTU19MSU5FXzEQAxISCg5BRERSRVNTX0xJ",
            "TkVfMhAEEggKBENJVFkQBRIMCghQUk9WSU5DRRAGEg8KC1BPU1RBTF9DT0RF",
            "EAcSEAoMQ09VTlRSWV9DT0RFEAgSEAoMUEhPTkVfTlVNQkVSEAlC8gEKIWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtc0IdTG9jYXRpb25QbGFj",
            "ZWhvbGRlckZpZWxkUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2VudW1zO2VudW1zogID",
            "R0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51bXPKAh1Hb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.LocationPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V2.Enums.LocationPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.LocationPlaceholderFieldEnum.Types.LocationPlaceholderField) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Location placeholder fields.
  /// </summary>
  public sealed partial class LocationPlaceholderFieldEnum : pb::IMessage<LocationPlaceholderFieldEnum> {
    private static readonly pb::MessageParser<LocationPlaceholderFieldEnum> _parser = new pb::MessageParser<LocationPlaceholderFieldEnum>(() => new LocationPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LocationPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.LocationPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocationPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocationPlaceholderFieldEnum(LocationPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocationPlaceholderFieldEnum Clone() {
      return new LocationPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LocationPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LocationPlaceholderFieldEnum other) {
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
    public void MergeFrom(LocationPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the LocationPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Location placeholder fields.
      /// </summary>
      public enum LocationPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The name of the business.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME")] BusinessName = 2,
        /// <summary>
        /// Data Type: STRING. Line 1 of the business address.
        /// </summary>
        [pbr::OriginalName("ADDRESS_LINE_1")] AddressLine1 = 3,
        /// <summary>
        /// Data Type: STRING. Line 2 of the business address.
        /// </summary>
        [pbr::OriginalName("ADDRESS_LINE_2")] AddressLine2 = 4,
        /// <summary>
        /// Data Type: STRING. City of the business address.
        /// </summary>
        [pbr::OriginalName("CITY")] City = 5,
        /// <summary>
        /// Data Type: STRING. Province of the business address.
        /// </summary>
        [pbr::OriginalName("PROVINCE")] Province = 6,
        /// <summary>
        /// Data Type: STRING. Postal code of the business address.
        /// </summary>
        [pbr::OriginalName("POSTAL_CODE")] PostalCode = 7,
        /// <summary>
        /// Data Type: STRING. Country code of the business address.
        /// </summary>
        [pbr::OriginalName("COUNTRY_CODE")] CountryCode = 8,
        /// <summary>
        /// Data Type: STRING. Phone number of the business.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER")] PhoneNumber = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
