// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/enums/price_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/enums/price_placeholder_field.proto</summary>
  public static partial class PricePlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/enums/price_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PricePlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9lbnVtcy9wcmljZV9wbGFjZWhv",
            "bGRlcl9maWVsZC5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i7wkKGVByaWNlUGxh",
            "Y2Vob2xkZXJGaWVsZEVudW0i0QkKFVByaWNlUGxhY2Vob2xkZXJGaWVsZBIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIICgRUWVBFEAISEwoPUFJJ",
            "Q0VfUVVBTElGSUVSEAMSFQoRVFJBQ0tJTkdfVEVNUExBVEUQBBIMCghMQU5H",
            "VUFHRRAFEhQKEEZJTkFMX1VSTF9TVUZGSVgQBhIRCg1JVEVNXzFfSEVBREVS",
            "EGQSFgoSSVRFTV8xX0RFU0NSSVBUSU9OEGUSEAoMSVRFTV8xX1BSSUNFEGYS",
            "DwoLSVRFTV8xX1VOSVQQZxIVChFJVEVNXzFfRklOQUxfVVJMUxBoEhwKGElU",
            "RU1fMV9GSU5BTF9NT0JJTEVfVVJMUxBpEhIKDUlURU1fMl9IRUFERVIQyAES",
            "FwoSSVRFTV8yX0RFU0NSSVBUSU9OEMkBEhEKDElURU1fMl9QUklDRRDKARIQ",
            "CgtJVEVNXzJfVU5JVBDLARIWChFJVEVNXzJfRklOQUxfVVJMUxDMARIdChhJ",
            "VEVNXzJfRklOQUxfTU9CSUxFX1VSTFMQzQESEgoNSVRFTV8zX0hFQURFUhCs",
            "AhIXChJJVEVNXzNfREVTQ1JJUFRJT04QrQISEQoMSVRFTV8zX1BSSUNFEK4C",
            "EhAKC0lURU1fM19VTklUEK8CEhYKEUlURU1fM19GSU5BTF9VUkxTELACEh0K",
            "GElURU1fM19GSU5BTF9NT0JJTEVfVVJMUxCxAhISCg1JVEVNXzRfSEVBREVS",
            "EJADEhcKEklURU1fNF9ERVNDUklQVElPThCRAxIRCgxJVEVNXzRfUFJJQ0UQ",
            "kgMSEAoLSVRFTV80X1VOSVQQkwMSFgoRSVRFTV80X0ZJTkFMX1VSTFMQlAMS",
            "HQoYSVRFTV80X0ZJTkFMX01PQklMRV9VUkxTEJUDEhIKDUlURU1fNV9IRUFE",
            "RVIQ9AMSFwoSSVRFTV81X0RFU0NSSVBUSU9OEPUDEhEKDElURU1fNV9QUklD",
            "RRD2AxIQCgtJVEVNXzVfVU5JVBD3AxIWChFJVEVNXzVfRklOQUxfVVJMUxD4",
            "AxIdChhJVEVNXzVfRklOQUxfTU9CSUxFX1VSTFMQ+QMSEgoNSVRFTV82X0hF",
            "QURFUhDYBBIXChJJVEVNXzZfREVTQ1JJUFRJT04Q2QQSEQoMSVRFTV82X1BS",
            "SUNFENoEEhAKC0lURU1fNl9VTklUENsEEhYKEUlURU1fNl9GSU5BTF9VUkxT",
            "ENwEEh0KGElURU1fNl9GSU5BTF9NT0JJTEVfVVJMUxDdBBISCg1JVEVNXzdf",
            "SEVBREVSELwFEhcKEklURU1fN19ERVNDUklQVElPThC9BRIRCgxJVEVNXzdf",
            "UFJJQ0UQvgUSEAoLSVRFTV83X1VOSVQQvwUSFgoRSVRFTV83X0ZJTkFMX1VS",
            "TFMQwAUSHQoYSVRFTV83X0ZJTkFMX01PQklMRV9VUkxTEMEFEhIKDUlURU1f",
            "OF9IRUFERVIQoAYSFwoSSVRFTV84X0RFU0NSSVBUSU9OEKEGEhEKDElURU1f",
            "OF9QUklDRRCiBhIQCgtJVEVNXzhfVU5JVBCjBhIWChFJVEVNXzhfRklOQUxf",
            "VVJMUxCkBhIdChhJVEVNXzhfRklOQUxfTU9CSUxFX1VSTFMQpQZC7wEKIWNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NS5lbnVtc0IaUHJpY2VQbGFjZWhv",
            "bGRlckZpZWxkUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y1L2VudW1zO2VudW1zogIDR0FB",
            "qgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjUuRW51bXPKAh1Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWNVxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlY1OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Enums.PricePlaceholderFieldEnum), global::Google.Ads.GoogleAds.V5.Enums.PricePlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V5.Enums.PricePlaceholderFieldEnum.Types.PricePlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Price placeholder fields.
  /// </summary>
  public sealed partial class PricePlaceholderFieldEnum : pb::IMessage<PricePlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PricePlaceholderFieldEnum> _parser = new pb::MessageParser<PricePlaceholderFieldEnum>(() => new PricePlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PricePlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Enums.PricePlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricePlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricePlaceholderFieldEnum(PricePlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PricePlaceholderFieldEnum Clone() {
      return new PricePlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PricePlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PricePlaceholderFieldEnum other) {
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
    public void MergeFrom(PricePlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the PricePlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Price placeholder fields.
      /// </summary>
      public enum PricePlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The type of your price feed. Must match one of the
        /// predefined price feed type exactly.
        /// </summary>
        [pbr::OriginalName("TYPE")] Type = 2,
        /// <summary>
        /// Data Type: STRING. The qualifier of each price. Must match one of the
        /// predefined price qualifiers exactly.
        /// </summary>
        [pbr::OriginalName("PRICE_QUALIFIER")] PriceQualifier = 3,
        /// <summary>
        /// Data Type: URL. Tracking template for the price feed when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_TEMPLATE")] TrackingTemplate = 4,
        /// <summary>
        /// Data Type: STRING. Language of the price feed. Must match one of the
        /// available available locale codes exactly.
        /// </summary>
        [pbr::OriginalName("LANGUAGE")] Language = 5,
        /// <summary>
        /// Data Type: STRING. Final URL suffix for the price feed when using
        /// parallel tracking.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SUFFIX")] FinalUrlSuffix = 6,
        /// <summary>
        /// Data Type: STRING. The header of item 1 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_1_HEADER")] Item1Header = 100,
        /// <summary>
        /// Data Type: STRING. The description of item 1 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_1_DESCRIPTION")] Item1Description = 101,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 1 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_1_PRICE")] Item1Price = 102,
        /// <summary>
        /// Data Type: STRING. The price unit of item 1 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_1_UNIT")] Item1Unit = 103,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 1 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_1_FINAL_URLS")] Item1FinalUrls = 104,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 1 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_1_FINAL_MOBILE_URLS")] Item1FinalMobileUrls = 105,
        /// <summary>
        /// Data Type: STRING. The header of item 2 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_2_HEADER")] Item2Header = 200,
        /// <summary>
        /// Data Type: STRING. The description of item 2 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_2_DESCRIPTION")] Item2Description = 201,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 2 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_2_PRICE")] Item2Price = 202,
        /// <summary>
        /// Data Type: STRING. The price unit of item 2 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_2_UNIT")] Item2Unit = 203,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 2 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_2_FINAL_URLS")] Item2FinalUrls = 204,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 2 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_2_FINAL_MOBILE_URLS")] Item2FinalMobileUrls = 205,
        /// <summary>
        /// Data Type: STRING. The header of item 3 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_3_HEADER")] Item3Header = 300,
        /// <summary>
        /// Data Type: STRING. The description of item 3 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_3_DESCRIPTION")] Item3Description = 301,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 3 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_3_PRICE")] Item3Price = 302,
        /// <summary>
        /// Data Type: STRING. The price unit of item 3 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_3_UNIT")] Item3Unit = 303,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 3 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_3_FINAL_URLS")] Item3FinalUrls = 304,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 3 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_3_FINAL_MOBILE_URLS")] Item3FinalMobileUrls = 305,
        /// <summary>
        /// Data Type: STRING. The header of item 4 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_4_HEADER")] Item4Header = 400,
        /// <summary>
        /// Data Type: STRING. The description of item 4 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_4_DESCRIPTION")] Item4Description = 401,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 4 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_4_PRICE")] Item4Price = 402,
        /// <summary>
        /// Data Type: STRING. The price unit of item 4 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_4_UNIT")] Item4Unit = 403,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 4 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_4_FINAL_URLS")] Item4FinalUrls = 404,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 4 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_4_FINAL_MOBILE_URLS")] Item4FinalMobileUrls = 405,
        /// <summary>
        /// Data Type: STRING. The header of item 5 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_5_HEADER")] Item5Header = 500,
        /// <summary>
        /// Data Type: STRING. The description of item 5 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_5_DESCRIPTION")] Item5Description = 501,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 5 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_5_PRICE")] Item5Price = 502,
        /// <summary>
        /// Data Type: STRING. The price unit of item 5 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_5_UNIT")] Item5Unit = 503,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 5 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_5_FINAL_URLS")] Item5FinalUrls = 504,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 5 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_5_FINAL_MOBILE_URLS")] Item5FinalMobileUrls = 505,
        /// <summary>
        /// Data Type: STRING. The header of item 6 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_6_HEADER")] Item6Header = 600,
        /// <summary>
        /// Data Type: STRING. The description of item 6 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_6_DESCRIPTION")] Item6Description = 601,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 6 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_6_PRICE")] Item6Price = 602,
        /// <summary>
        /// Data Type: STRING. The price unit of item 6 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_6_UNIT")] Item6Unit = 603,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 6 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_6_FINAL_URLS")] Item6FinalUrls = 604,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 6 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_6_FINAL_MOBILE_URLS")] Item6FinalMobileUrls = 605,
        /// <summary>
        /// Data Type: STRING. The header of item 7 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_7_HEADER")] Item7Header = 700,
        /// <summary>
        /// Data Type: STRING. The description of item 7 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_7_DESCRIPTION")] Item7Description = 701,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 7 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_7_PRICE")] Item7Price = 702,
        /// <summary>
        /// Data Type: STRING. The price unit of item 7 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_7_UNIT")] Item7Unit = 703,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 7 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_7_FINAL_URLS")] Item7FinalUrls = 704,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 7 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_7_FINAL_MOBILE_URLS")] Item7FinalMobileUrls = 705,
        /// <summary>
        /// Data Type: STRING. The header of item 8 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_8_HEADER")] Item8Header = 800,
        /// <summary>
        /// Data Type: STRING. The description of item 8 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_8_DESCRIPTION")] Item8Description = 801,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 8 of the table,
        /// e.g., 30 USD. The currency must match one of the available currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_8_PRICE")] Item8Price = 802,
        /// <summary>
        /// Data Type: STRING. The price unit of item 8 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_8_UNIT")] Item8Unit = 803,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 8 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_8_FINAL_URLS")] Item8FinalUrls = 804,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 8 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_8_FINAL_MOBILE_URLS")] Item8FinalMobileUrls = 805,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
