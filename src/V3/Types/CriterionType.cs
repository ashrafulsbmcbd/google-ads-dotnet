// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/criterion_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/criterion_type.proto</summary>
  public static partial class CriterionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/criterion_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriterionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9jcml0ZXJpb25fdHlw",
            "ZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i1AQKEUNyaXRlcmlvblR5cGVFbnVt",
            "Ir4ECg1Dcml0ZXJpb25UeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEgsKB0tFWVdPUkQQAhINCglQTEFDRU1FTlQQAxIXChNNT0JJTEVfQVBQ",
            "X0NBVEVHT1JZEAQSFgoSTU9CSUxFX0FQUExJQ0FUSU9OEAUSCgoGREVWSUNF",
            "EAYSDAoITE9DQVRJT04QBxIRCg1MSVNUSU5HX0dST1VQEAgSDwoLQURfU0NI",
            "RURVTEUQCRINCglBR0VfUkFOR0UQChIKCgZHRU5ERVIQCxIQCgxJTkNPTUVf",
            "UkFOR0UQDBITCg9QQVJFTlRBTF9TVEFUVVMQDRIRCg1ZT1VUVUJFX1ZJREVP",
            "EA4SEwoPWU9VVFVCRV9DSEFOTkVMEA8SDQoJVVNFUl9MSVNUEBASDQoJUFJP",
            "WElNSVRZEBESCQoFVE9QSUMQEhIRCg1MSVNUSU5HX1NDT1BFEBMSDAoITEFO",
            "R1VBR0UQFBIMCghJUF9CTE9DSxAVEhEKDUNPTlRFTlRfTEFCRUwQFhILCgdD",
            "QVJSSUVSEBcSEQoNVVNFUl9JTlRFUkVTVBAYEgsKB1dFQlBBR0UQGRIcChhP",
            "UEVSQVRJTkdfU1lTVEVNX1ZFUlNJT04QGhIVChFBUFBfUEFZTUVOVF9NT0RF",
            "TBAbEhEKDU1PQklMRV9ERVZJQ0UQHBITCg9DVVNUT01fQUZGSU5JVFkQHRIR",
            "Cg1DVVNUT01fSU5URU5UEB4SEgoOTE9DQVRJT05fR1JPVVAQH0LnAQohY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVudW1zQhJDcml0ZXJpb25UeXBl",
            "UHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xl",
            "LkFkcy5Hb29nbGVBZHMuVjMuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWM1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpFbnVt",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeEnum.Types.CriterionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The possible types of a criterion.
  /// </summary>
  public sealed partial class CriterionTypeEnum : pb::IMessage<CriterionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CriterionTypeEnum> _parser = new pb::MessageParser<CriterionTypeEnum>(() => new CriterionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CriterionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionTypeEnum(CriterionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionTypeEnum Clone() {
      return new CriterionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CriterionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CriterionTypeEnum other) {
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
    public void MergeFrom(CriterionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the CriterionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible criterion types.
      /// </summary>
      public enum CriterionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Keyword. e.g. 'mars cruise'.
        /// </summary>
        [pbr::OriginalName("KEYWORD")] Keyword = 2,
        /// <summary>
        /// Placement, aka Website. e.g. 'www.flowers4sale.com'
        /// </summary>
        [pbr::OriginalName("PLACEMENT")] Placement = 3,
        /// <summary>
        /// Mobile application categories to target.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_CATEGORY")] MobileAppCategory = 4,
        /// <summary>
        /// Mobile applications to target.
        /// </summary>
        [pbr::OriginalName("MOBILE_APPLICATION")] MobileApplication = 5,
        /// <summary>
        /// Devices to target.
        /// </summary>
        [pbr::OriginalName("DEVICE")] Device = 6,
        /// <summary>
        /// Locations to target.
        /// </summary>
        [pbr::OriginalName("LOCATION")] Location = 7,
        /// <summary>
        /// Listing groups to target.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP")] ListingGroup = 8,
        /// <summary>
        /// Ad Schedule.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE")] AdSchedule = 9,
        /// <summary>
        /// Age range.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE")] AgeRange = 10,
        /// <summary>
        /// Gender.
        /// </summary>
        [pbr::OriginalName("GENDER")] Gender = 11,
        /// <summary>
        /// Income Range.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE")] IncomeRange = 12,
        /// <summary>
        /// Parental status.
        /// </summary>
        [pbr::OriginalName("PARENTAL_STATUS")] ParentalStatus = 13,
        /// <summary>
        /// YouTube Video.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO")] YoutubeVideo = 14,
        /// <summary>
        /// YouTube Channel.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_CHANNEL")] YoutubeChannel = 15,
        /// <summary>
        /// User list.
        /// </summary>
        [pbr::OriginalName("USER_LIST")] UserList = 16,
        /// <summary>
        /// Proximity.
        /// </summary>
        [pbr::OriginalName("PROXIMITY")] Proximity = 17,
        /// <summary>
        /// A topic target on the display network (e.g. "Pets &amp; Animals").
        /// </summary>
        [pbr::OriginalName("TOPIC")] Topic = 18,
        /// <summary>
        /// Listing scope to target.
        /// </summary>
        [pbr::OriginalName("LISTING_SCOPE")] ListingScope = 19,
        /// <summary>
        /// Language.
        /// </summary>
        [pbr::OriginalName("LANGUAGE")] Language = 20,
        /// <summary>
        /// IpBlock.
        /// </summary>
        [pbr::OriginalName("IP_BLOCK")] IpBlock = 21,
        /// <summary>
        /// Content Label for category exclusion.
        /// </summary>
        [pbr::OriginalName("CONTENT_LABEL")] ContentLabel = 22,
        /// <summary>
        /// Carrier.
        /// </summary>
        [pbr::OriginalName("CARRIER")] Carrier = 23,
        /// <summary>
        /// A category the user is interested in.
        /// </summary>
        [pbr::OriginalName("USER_INTEREST")] UserInterest = 24,
        /// <summary>
        /// Webpage criterion for dynamic search ads.
        /// </summary>
        [pbr::OriginalName("WEBPAGE")] Webpage = 25,
        /// <summary>
        /// Operating system version.
        /// </summary>
        [pbr::OriginalName("OPERATING_SYSTEM_VERSION")] OperatingSystemVersion = 26,
        /// <summary>
        /// App payment model.
        /// </summary>
        [pbr::OriginalName("APP_PAYMENT_MODEL")] AppPaymentModel = 27,
        /// <summary>
        /// Mobile device.
        /// </summary>
        [pbr::OriginalName("MOBILE_DEVICE")] MobileDevice = 28,
        /// <summary>
        /// Custom affinity.
        /// </summary>
        [pbr::OriginalName("CUSTOM_AFFINITY")] CustomAffinity = 29,
        /// <summary>
        /// Custom intent.
        /// </summary>
        [pbr::OriginalName("CUSTOM_INTENT")] CustomIntent = 30,
        /// <summary>
        /// Location group.
        /// </summary>
        [pbr::OriginalName("LOCATION_GROUP")] LocationGroup = 31,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
