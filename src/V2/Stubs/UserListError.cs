// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/errors/user_list_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/errors/user_list_error.proto</summary>
  public static partial class UserListErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/errors/user_list_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnMvdXNlcl9saXN0X2Vy",
            "cm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lcnJvcnMaHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i7AcKEVVzZXJMaXN0RXJyb3JF",
            "bnVtItYHCg1Vc2VyTGlzdEVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5L",
            "Tk9XThABEjcKM0VYVEVSTkFMX1JFTUFSS0VUSU5HX1VTRVJfTElTVF9NVVRB",
            "VEVfTk9UX1NVUFBPUlRFRBACEhoKFkNPTkNSRVRFX1RZUEVfUkVRVUlSRUQQ",
            "AxIfChtDT05WRVJTSU9OX1RZUEVfSURfUkVRVUlSRUQQBBIeChpEVVBMSUNB",
            "VEVfQ09OVkVSU0lPTl9UWVBFUxAFEhsKF0lOVkFMSURfQ09OVkVSU0lPTl9U",
            "WVBFEAYSFwoTSU5WQUxJRF9ERVNDUklQVElPThAHEhAKDElOVkFMSURfTkFN",
            "RRAIEhAKDElOVkFMSURfVFlQRRAJEjQKMENBTl9OT1RfQUREX0xPR0lDQUxf",
            "TElTVF9BU19MT0dJQ0FMX0xJU1RfT1BFUkFORBAKEioKJklOVkFMSURfVVNF",
            "Ul9MSVNUX0xPR0lDQUxfUlVMRV9PUEVSQU5EEAsSFQoRTkFNRV9BTFJFQURZ",
            "X1VTRUQQDBIlCiFORVdfQ09OVkVSU0lPTl9UWVBFX05BTUVfUkVRVUlSRUQQ",
            "DRIlCiFDT05WRVJTSU9OX1RZUEVfTkFNRV9BTFJFQURZX1VTRUQQDhIeChpP",
            "V05FUlNISVBfUkVRVUlSRURfRk9SX1NFVBAPEiIKHlVTRVJfTElTVF9NVVRB",
            "VEVfTk9UX1NVUFBPUlRFRBAQEhAKDElOVkFMSURfUlVMRRAREhYKEklOVkFM",
            "SURfREFURV9SQU5HRRAbEiUKIUNBTl9OT1RfTVVUQVRFX1NFTlNJVElWRV9V",
            "U0VSTElTVBAcEh8KG01BWF9OVU1fUlVMRUJBU0VEX1VTRVJMSVNUUxAdEicK",
            "I0NBTk5PVF9NT0RJRllfQklMTEFCTEVfUkVDT1JEX0NPVU5UEB4SEgoOQVBQ",
            "X0lEX05PVF9TRVQQHxItCilVU0VSTElTVF9OQU1FX0lTX1JFU0VSVkVEX0ZP",
            "Ul9TWVNURU1fTElTVBAgEjYKMkFEVkVSVElTRVJfTk9UX1dISVRFTElTVEVE",
            "X0ZPUl9VU0lOR19VUExPQURFRF9EQVRBECESHgoaUlVMRV9UWVBFX0lTX05P",
            "VF9TVVBQT1JURUQQIhI6CjZDQU5fTk9UX0FERF9BX1NJTUlMQVJfVVNFUkxJ",
            "U1RfQVNfTE9HSUNBTF9MSVNUX09QRVJBTkQQIxI6CjZDQU5fTk9UX01JWF9D",
            "Uk1fQkFTRURfSU5fTE9HSUNBTF9MSVNUX1dJVEhfT1RIRVJfTElTVFMQJELt",
            "AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVycm9yc0ISVXNlckxp",
            "c3RFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9lcnJvcnM7ZXJyb3JzogIDR0FB",
            "qgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRXJyb3JzygIeR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjJcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjI6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Errors.UserListErrorEnum), global::Google.Ads.GoogleAds.V2.Errors.UserListErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Errors.UserListErrorEnum.Types.UserListError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible user list errors.
  /// </summary>
  public sealed partial class UserListErrorEnum : pb::IMessage<UserListErrorEnum> {
    private static readonly pb::MessageParser<UserListErrorEnum> _parser = new pb::MessageParser<UserListErrorEnum>(() => new UserListErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Errors.UserListErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListErrorEnum(UserListErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListErrorEnum Clone() {
      return new UserListErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListErrorEnum other) {
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
    public void MergeFrom(UserListErrorEnum other) {
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
    /// <summary>Container for nested types declared in the UserListErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list errors.
      /// </summary>
      public enum UserListError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Creating and updating external remarketing user lists is not supported.
        /// </summary>
        [pbr::OriginalName("EXTERNAL_REMARKETING_USER_LIST_MUTATE_NOT_SUPPORTED")] ExternalRemarketingUserListMutateNotSupported = 2,
        /// <summary>
        /// Concrete type of user list is required.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 3,
        /// <summary>
        /// Creating/updating user list conversion types requires specifying the
        /// conversion type Id.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_ID_REQUIRED")] ConversionTypeIdRequired = 4,
        /// <summary>
        /// Remarketing user list cannot have duplicate conversion types.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CONVERSION_TYPES")] DuplicateConversionTypes = 5,
        /// <summary>
        /// Conversion type is invalid/unknown.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_TYPE")] InvalidConversionType = 6,
        /// <summary>
        /// User list description is empty or invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_DESCRIPTION")] InvalidDescription = 7,
        /// <summary>
        /// User list name is empty or invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_NAME")] InvalidName = 8,
        /// <summary>
        /// Type of the UserList does not match.
        /// </summary>
        [pbr::OriginalName("INVALID_TYPE")] InvalidType = 9,
        /// <summary>
        /// Embedded logical user lists are not allowed.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_ADD_LOGICAL_LIST_AS_LOGICAL_LIST_OPERAND")] CanNotAddLogicalListAsLogicalListOperand = 10,
        /// <summary>
        /// User list rule operand is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST_LOGICAL_RULE_OPERAND")] InvalidUserListLogicalRuleOperand = 11,
        /// <summary>
        /// Name is already being used for another user list for the account.
        /// </summary>
        [pbr::OriginalName("NAME_ALREADY_USED")] NameAlreadyUsed = 12,
        /// <summary>
        /// Name is required when creating a new conversion type.
        /// </summary>
        [pbr::OriginalName("NEW_CONVERSION_TYPE_NAME_REQUIRED")] NewConversionTypeNameRequired = 13,
        /// <summary>
        /// The given conversion type name has been used.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TYPE_NAME_ALREADY_USED")] ConversionTypeNameAlreadyUsed = 14,
        /// <summary>
        /// Only an owner account may edit a user list.
        /// </summary>
        [pbr::OriginalName("OWNERSHIP_REQUIRED_FOR_SET")] OwnershipRequiredForSet = 15,
        /// <summary>
        /// Creating user list without setting type in oneof user_list field, or
        /// creating/updating read-only user list types is not allowed.
        /// </summary>
        [pbr::OriginalName("USER_LIST_MUTATE_NOT_SUPPORTED")] UserListMutateNotSupported = 16,
        /// <summary>
        /// Rule is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_RULE")] InvalidRule = 17,
        /// <summary>
        /// The specified date range is empty.
        /// </summary>
        [pbr::OriginalName("INVALID_DATE_RANGE")] InvalidDateRange = 27,
        /// <summary>
        /// A UserList which is privacy sensitive or legal rejected cannot be mutated
        /// by external users.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_MUTATE_SENSITIVE_USERLIST")] CanNotMutateSensitiveUserlist = 28,
        /// <summary>
        /// Maximum number of rulebased user lists a customer can have.
        /// </summary>
        [pbr::OriginalName("MAX_NUM_RULEBASED_USERLISTS")] MaxNumRulebasedUserlists = 29,
        /// <summary>
        /// BasicUserList's billable record field cannot be modified once it is set.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_BILLABLE_RECORD_COUNT")] CannotModifyBillableRecordCount = 30,
        /// <summary>
        /// crm_based_user_list.app_id field must be set when upload_key_type is
        /// MOBILE_ADVERTISING_ID.
        /// </summary>
        [pbr::OriginalName("APP_ID_NOT_SET")] AppIdNotSet = 31,
        /// <summary>
        /// Name of the user list is reserved for system generated lists and cannot
        /// be used.
        /// </summary>
        [pbr::OriginalName("USERLIST_NAME_IS_RESERVED_FOR_SYSTEM_LIST")] UserlistNameIsReservedForSystemList = 32,
        /// <summary>
        /// Advertiser needs to be whitelisted to use remarketing lists created from
        /// advertiser uploaded data (e.g., Customer Match lists).
        /// </summary>
        [pbr::OriginalName("ADVERTISER_NOT_WHITELISTED_FOR_USING_UPLOADED_DATA")] AdvertiserNotWhitelistedForUsingUploadedData = 33,
        /// <summary>
        /// The provided rule_type is not supported for the user list.
        /// </summary>
        [pbr::OriginalName("RULE_TYPE_IS_NOT_SUPPORTED")] RuleTypeIsNotSupported = 34,
        /// <summary>
        /// Similar user list cannot be used as a logical user list operand.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_ADD_A_SIMILAR_USERLIST_AS_LOGICAL_LIST_OPERAND")] CanNotAddASimilarUserlistAsLogicalListOperand = 35,
        /// <summary>
        /// Logical user list should not have a mix of CRM based user list and other
        /// types of lists in its rules.
        /// </summary>
        [pbr::OriginalName("CAN_NOT_MIX_CRM_BASED_IN_LOGICAL_LIST_WITH_OTHER_LISTS")] CanNotMixCrmBasedInLogicalListWithOtherLists = 36,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
