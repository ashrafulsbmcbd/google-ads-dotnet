// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/price_extension_price_unit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/price_extension_price_unit.proto</summary>
  public static partial class PriceExtensionPriceUnitReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/price_extension_price_unit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PriceExtensionPriceUnitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9wcmljZV9leHRlbnNp",
            "b25fcHJpY2VfdW5pdC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIu",
            "ZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8irAEKG1ByaWNl",
            "RXh0ZW5zaW9uUHJpY2VVbml0RW51bSKMAQoXUHJpY2VFeHRlbnNpb25Qcmlj",
            "ZVVuaXQSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoIUEVSX0hP",
            "VVIQAhILCgdQRVJfREFZEAMSDAoIUEVSX1dFRUsQBBINCglQRVJfTU9OVEgQ",
            "BRIMCghQRVJfWUVBUhAGEg0KCVBFUl9OSUdIVBAHQvEBCiFjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjIuZW51bXNCHFByaWNlRXh0ZW5zaW9uUHJpY2VV",
            "bml0UHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2VudW1zO2VudW1zogIDR0FBqgIdR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYyOjpF",
            "bnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.PriceExtensionPriceUnitEnum), global::Google.Ads.GoogleAds.V2.Enums.PriceExtensionPriceUnitEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.PriceExtensionPriceUnitEnum.Types.PriceExtensionPriceUnit) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing price extension price unit.
  /// </summary>
  public sealed partial class PriceExtensionPriceUnitEnum : pb::IMessage<PriceExtensionPriceUnitEnum> {
    private static readonly pb::MessageParser<PriceExtensionPriceUnitEnum> _parser = new pb::MessageParser<PriceExtensionPriceUnitEnum>(() => new PriceExtensionPriceUnitEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PriceExtensionPriceUnitEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.PriceExtensionPriceUnitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionPriceUnitEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionPriceUnitEnum(PriceExtensionPriceUnitEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PriceExtensionPriceUnitEnum Clone() {
      return new PriceExtensionPriceUnitEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PriceExtensionPriceUnitEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PriceExtensionPriceUnitEnum other) {
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
    public void MergeFrom(PriceExtensionPriceUnitEnum other) {
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
    /// <summary>Container for nested types declared in the PriceExtensionPriceUnitEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Price extension price unit.
      /// </summary>
      public enum PriceExtensionPriceUnit {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Per hour.
        /// </summary>
        [pbr::OriginalName("PER_HOUR")] PerHour = 2,
        /// <summary>
        /// Per day.
        /// </summary>
        [pbr::OriginalName("PER_DAY")] PerDay = 3,
        /// <summary>
        /// Per week.
        /// </summary>
        [pbr::OriginalName("PER_WEEK")] PerWeek = 4,
        /// <summary>
        /// Per month.
        /// </summary>
        [pbr::OriginalName("PER_MONTH")] PerMonth = 5,
        /// <summary>
        /// Per year.
        /// </summary>
        [pbr::OriginalName("PER_YEAR")] PerYear = 6,
        /// <summary>
        /// Per night.
        /// </summary>
        [pbr::OriginalName("PER_NIGHT")] PerNight = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
