// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/errors/feed_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/errors/feed_error.proto</summary>
  public static partial class FeedErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/errors/feed_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnMvZmVlZF9lcnJvci5w",
            "cm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZXJyb3JzGhxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvIvkFCg1GZWVkRXJyb3JFbnVtIucFCglG",
            "ZWVkRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESHgoaQVRU",
            "UklCVVRFX05BTUVTX05PVF9VTklRVUUQAhIvCitBVFRSSUJVVEVTX0RPX05P",
            "VF9NQVRDSF9FWElTVElOR19BVFRSSUJVVEVTEAMSLgoqQ0FOTk9UX1NQRUNJ",
            "RllfVVNFUl9PUklHSU5fRk9SX1NZU1RFTV9GRUVEEAQSNAowQ0FOTk9UX1NQ",
            "RUNJRllfR09PR0xFX09SSUdJTl9GT1JfTk9OX1NZU1RFTV9GRUVEEAUSMgou",
            "Q0FOTk9UX1NQRUNJRllfRkVFRF9BVFRSSUJVVEVTX0ZPUl9TWVNURU1fRkVF",
            "RBAGEjQKMENBTk5PVF9VUERBVEVfRkVFRF9BVFRSSUJVVEVTX1dJVEhfT1JJ",
            "R0lOX0dPT0dMRRAHEhAKDEZFRURfUkVNT1ZFRBAIEhgKFElOVkFMSURfT1JJ",
            "R0lOX1ZBTFVFEAkSGwoXRkVFRF9PUklHSU5fSVNfTk9UX1VTRVIQChIgChxJ",
            "TlZBTElEX0FVVEhfVE9LRU5fRk9SX0VNQUlMEAsSEQoNSU5WQUxJRF9FTUFJ",
            "TBAMEhcKE0RVUExJQ0FURV9GRUVEX05BTUUQDRIVChFJTlZBTElEX0ZFRURf",
            "TkFNRRAOEhYKEk1JU1NJTkdfT0FVVEhfSU5GTxAPEi4KKk5FV19BVFRSSUJV",
            "VEVfQ0FOTk9UX0JFX1BBUlRfT0ZfVU5JUVVFX0tFWRAQEhcKE1RPT19NQU5Z",
            "X0FUVFJJQlVURVMQERIcChhJTlZBTElEX0JVU0lORVNTX0FDQ09VTlQQEhIz",
            "Ci9CVVNJTkVTU19BQ0NPVU5UX0NBTk5PVF9BQ0NFU1NfTE9DQVRJT05fQUND",
            "T1VOVBATEh4KGklOVkFMSURfQUZGSUxJQVRFX0NIQUlOX0lEEBQSGQoVRFVQ",
            "TElDQVRFX1NZU1RFTV9GRUVEEBVC6QEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Mi5lcnJvcnNCDkZlZWRFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9l",
            "cnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIu",
            "RXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcRXJyb3Jz6gIiR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Errors.FeedErrorEnum), global::Google.Ads.GoogleAds.V2.Errors.FeedErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Errors.FeedErrorEnum.Types.FeedError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed errors.
  /// </summary>
  public sealed partial class FeedErrorEnum : pb::IMessage<FeedErrorEnum> {
    private static readonly pb::MessageParser<FeedErrorEnum> _parser = new pb::MessageParser<FeedErrorEnum>(() => new FeedErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Errors.FeedErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedErrorEnum(FeedErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedErrorEnum Clone() {
      return new FeedErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedErrorEnum other) {
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
    public void MergeFrom(FeedErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed errors.
      /// </summary>
      public enum FeedError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The names of the FeedAttributes must be unique.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTE_NAMES_NOT_UNIQUE")] AttributeNamesNotUnique = 2,
        /// <summary>
        /// The attribute list must be an exact copy of the existing list if the
        /// attribute ID's are present.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTES_DO_NOT_MATCH_EXISTING_ATTRIBUTES")] AttributesDoNotMatchExistingAttributes = 3,
        /// <summary>
        /// Cannot specify USER origin for a system generated feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_SPECIFY_USER_ORIGIN_FOR_SYSTEM_FEED")] CannotSpecifyUserOriginForSystemFeed = 4,
        /// <summary>
        /// Cannot specify GOOGLE origin for a non-system generated feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_SPECIFY_GOOGLE_ORIGIN_FOR_NON_SYSTEM_FEED")] CannotSpecifyGoogleOriginForNonSystemFeed = 5,
        /// <summary>
        /// Cannot specify feed attributes for system feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_SPECIFY_FEED_ATTRIBUTES_FOR_SYSTEM_FEED")] CannotSpecifyFeedAttributesForSystemFeed = 6,
        /// <summary>
        /// Cannot update FeedAttributes on feed with origin GOOGLE.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_FEED_ATTRIBUTES_WITH_ORIGIN_GOOGLE")] CannotUpdateFeedAttributesWithOriginGoogle = 7,
        /// <summary>
        /// The given ID refers to a removed Feed. Removed Feeds are immutable.
        /// </summary>
        [pbr::OriginalName("FEED_REMOVED")] FeedRemoved = 8,
        /// <summary>
        /// The origin of the feed is not valid for the client.
        /// </summary>
        [pbr::OriginalName("INVALID_ORIGIN_VALUE")] InvalidOriginValue = 9,
        /// <summary>
        /// A user can only create and modify feeds with USER origin.
        /// </summary>
        [pbr::OriginalName("FEED_ORIGIN_IS_NOT_USER")] FeedOriginIsNotUser = 10,
        /// <summary>
        /// Invalid auth token for the given email.
        /// </summary>
        [pbr::OriginalName("INVALID_AUTH_TOKEN_FOR_EMAIL")] InvalidAuthTokenForEmail = 11,
        /// <summary>
        /// Invalid email specified.
        /// </summary>
        [pbr::OriginalName("INVALID_EMAIL")] InvalidEmail = 12,
        /// <summary>
        /// Feed name matches that of another active Feed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_FEED_NAME")] DuplicateFeedName = 13,
        /// <summary>
        /// Name of feed is not allowed.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_NAME")] InvalidFeedName = 14,
        /// <summary>
        /// Missing OAuthInfo.
        /// </summary>
        [pbr::OriginalName("MISSING_OAUTH_INFO")] MissingOauthInfo = 15,
        /// <summary>
        /// New FeedAttributes must not affect the unique key.
        /// </summary>
        [pbr::OriginalName("NEW_ATTRIBUTE_CANNOT_BE_PART_OF_UNIQUE_KEY")] NewAttributeCannotBePartOfUniqueKey = 16,
        /// <summary>
        /// Too many FeedAttributes for a Feed.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_ATTRIBUTES")] TooManyAttributes = 17,
        /// <summary>
        /// The business account is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_BUSINESS_ACCOUNT")] InvalidBusinessAccount = 18,
        /// <summary>
        /// Business account cannot access Google My Business account.
        /// </summary>
        [pbr::OriginalName("BUSINESS_ACCOUNT_CANNOT_ACCESS_LOCATION_ACCOUNT")] BusinessAccountCannotAccessLocationAccount = 19,
        /// <summary>
        /// Invalid chain ID provided for affiliate location feed.
        /// </summary>
        [pbr::OriginalName("INVALID_AFFILIATE_CHAIN_ID")] InvalidAffiliateChainId = 20,
        /// <summary>
        /// There is already a feed with the given system feed generation data.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_SYSTEM_FEED")] DuplicateSystemFeed = 21,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
