// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/customer_client.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/customer_client.proto</summary>
  public static partial class CustomerClientReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/customer_client.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerClientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "Y2xpZW50LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52My5yZXNvdXJj",
            "ZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5w",
            "cm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKgBQoOQ3VzdG9t",
            "ZXJDbGllbnQSRgoNcmVzb3VyY2VfbmFtZRgBIAEoCUIv4EED+kEpCidnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJDbGllbnQSOgoPY2xpZW50",
            "X2N1c3RvbWVyGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVl",
            "QgPgQQMSLwoGaGlkZGVuGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLkJvb2xW",
            "YWx1ZUID4EEDEi8KBWxldmVsGAUgASgLMhsuZ29vZ2xlLnByb3RvYnVmLklu",
            "dDY0VmFsdWVCA+BBAxI0Cgl0aW1lX3pvbmUYBiABKAsyHC5nb29nbGUucHJv",
            "dG9idWYuU3RyaW5nVmFsdWVCA+BBAxI1Cgx0ZXN0X2FjY291bnQYByABKAsy",
            "Gi5nb29nbGUucHJvdG9idWYuQm9vbFZhbHVlQgPgQQMSMAoHbWFuYWdlchgI",
            "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5Cb29sVmFsdWVCA+BBAxI7ChBkZXNj",
            "cmlwdGl2ZV9uYW1lGAkgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlQgPgQQMSOAoNY3VycmVuY3lfY29kZRgKIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEiwKAmlkGAsgASgLMhsuZ29vZ2xlLnBy",
            "b3RvYnVmLkludDY0VmFsdWVCA+BBAzpk6kFhCidnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQ3VzdG9tZXJDbGllbnQSNmN1c3RvbWVycy97Y3VzdG9tZXJ9",
            "L2N1c3RvbWVyQ2xpZW50cy97Y3VzdG9tZXJfY2xpZW50fUKAAgolY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNlc0ITQ3VzdG9tZXJDbGll",
            "bnRQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjMvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dB",
            "QaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLlJlc291cmNlc8oCIUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYzXFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYzOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.CustomerClient), global::Google.Ads.GoogleAds.V3.Resources.CustomerClient.Parser, new[]{ "ResourceName", "ClientCustomer", "Hidden", "Level", "TimeZone", "TestAccount", "Manager", "DescriptiveName", "CurrencyCode", "Id" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between the given customer and a client customer. CustomerClients only
  /// exist for manager customers. All direct and indirect client customers are
  /// included, as well as the manager itself.
  /// </summary>
  public sealed partial class CustomerClient : pb::IMessage<CustomerClient>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerClient> _parser = new pb::MessageParser<CustomerClient>(() => new CustomerClient());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.CustomerClientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClient(CustomerClient other) : this() {
      resourceName_ = other.resourceName_;
      ClientCustomer = other.ClientCustomer;
      Hidden = other.Hidden;
      Level = other.Level;
      TimeZone = other.TimeZone;
      TestAccount = other.TestAccount;
      Manager = other.Manager;
      DescriptiveName = other.DescriptiveName;
      CurrencyCode = other.CurrencyCode;
      Id = other.Id;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClient Clone() {
      return new CustomerClient(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the customer client.
    /// CustomerClient resource names have the form:
    /// `customers/{customer_id}/customerClients/{client_customer_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_customer" field.</summary>
    public const int ClientCustomerFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_clientCustomer_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string clientCustomer_;
    /// <summary>
    /// Output only. The resource name of the client-customer which is linked to
    /// the given customer. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientCustomer {
      get { return clientCustomer_; }
      set {
        clientCustomer_ = value;
      }
    }


    /// <summary>Field number for the "hidden" field.</summary>
    public const int HiddenFieldNumber = 4;
    private static readonly pb::FieldCodec<bool?> _single_hidden_codec = pb::FieldCodec.ForStructWrapper<bool>(34);
    private bool? hidden_;
    /// <summary>
    /// Output only. Specifies whether this is a
    /// [hidden account](https://support.google.com/google-ads/answer/7519830).
    /// Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Hidden {
      get { return hidden_; }
      set {
        hidden_ = value;
      }
    }


    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 5;
    private static readonly pb::FieldCodec<long?> _single_level_codec = pb::FieldCodec.ForStructWrapper<long>(42);
    private long? level_;
    /// <summary>
    /// Output only. Distance between given customer and client. For self link, the level value
    /// will be 0. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }


    /// <summary>Field number for the "time_zone" field.</summary>
    public const int TimeZoneFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_timeZone_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string timeZone_;
    /// <summary>
    /// Output only. Common Locale Data Repository (CLDR) string representation of the
    /// time zone of the client, e.g. America/Los_Angeles. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TimeZone {
      get { return timeZone_; }
      set {
        timeZone_ = value;
      }
    }


    /// <summary>Field number for the "test_account" field.</summary>
    public const int TestAccountFieldNumber = 7;
    private static readonly pb::FieldCodec<bool?> _single_testAccount_codec = pb::FieldCodec.ForStructWrapper<bool>(58);
    private bool? testAccount_;
    /// <summary>
    /// Output only. Identifies if the client is a test account. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? TestAccount {
      get { return testAccount_; }
      set {
        testAccount_ = value;
      }
    }


    /// <summary>Field number for the "manager" field.</summary>
    public const int ManagerFieldNumber = 8;
    private static readonly pb::FieldCodec<bool?> _single_manager_codec = pb::FieldCodec.ForStructWrapper<bool>(66);
    private bool? manager_;
    /// <summary>
    /// Output only. Identifies if the client is a manager. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? Manager {
      get { return manager_; }
      set {
        manager_ = value;
      }
    }


    /// <summary>Field number for the "descriptive_name" field.</summary>
    public const int DescriptiveNameFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _single_descriptiveName_codec = pb::FieldCodec.ForClassWrapper<string>(74);
    private string descriptiveName_;
    /// <summary>
    /// Output only. Descriptive name for the client. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DescriptiveName {
      get { return descriptiveName_; }
      set {
        descriptiveName_ = value;
      }
    }


    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _single_currencyCode_codec = pb::FieldCodec.ForClassWrapper<string>(82);
    private string currencyCode_;
    /// <summary>
    /// Output only. Currency code (e.g. 'USD', 'EUR') for the client. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = value;
      }
    }


    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 11;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(90);
    private long? id_;
    /// <summary>
    /// Output only. The ID of the client customer. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerClient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ClientCustomer != other.ClientCustomer) return false;
      if (Hidden != other.Hidden) return false;
      if (Level != other.Level) return false;
      if (TimeZone != other.TimeZone) return false;
      if (TestAccount != other.TestAccount) return false;
      if (Manager != other.Manager) return false;
      if (DescriptiveName != other.DescriptiveName) return false;
      if (CurrencyCode != other.CurrencyCode) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (clientCustomer_ != null) hash ^= ClientCustomer.GetHashCode();
      if (hidden_ != null) hash ^= Hidden.GetHashCode();
      if (level_ != null) hash ^= Level.GetHashCode();
      if (timeZone_ != null) hash ^= TimeZone.GetHashCode();
      if (testAccount_ != null) hash ^= TestAccount.GetHashCode();
      if (manager_ != null) hash ^= Manager.GetHashCode();
      if (descriptiveName_ != null) hash ^= DescriptiveName.GetHashCode();
      if (currencyCode_ != null) hash ^= CurrencyCode.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (clientCustomer_ != null) {
        _single_clientCustomer_codec.WriteTagAndValue(output, ClientCustomer);
      }
      if (hidden_ != null) {
        _single_hidden_codec.WriteTagAndValue(output, Hidden);
      }
      if (level_ != null) {
        _single_level_codec.WriteTagAndValue(output, Level);
      }
      if (timeZone_ != null) {
        _single_timeZone_codec.WriteTagAndValue(output, TimeZone);
      }
      if (testAccount_ != null) {
        _single_testAccount_codec.WriteTagAndValue(output, TestAccount);
      }
      if (manager_ != null) {
        _single_manager_codec.WriteTagAndValue(output, Manager);
      }
      if (descriptiveName_ != null) {
        _single_descriptiveName_codec.WriteTagAndValue(output, DescriptiveName);
      }
      if (currencyCode_ != null) {
        _single_currencyCode_codec.WriteTagAndValue(output, CurrencyCode);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (clientCustomer_ != null) {
        _single_clientCustomer_codec.WriteTagAndValue(ref output, ClientCustomer);
      }
      if (hidden_ != null) {
        _single_hidden_codec.WriteTagAndValue(ref output, Hidden);
      }
      if (level_ != null) {
        _single_level_codec.WriteTagAndValue(ref output, Level);
      }
      if (timeZone_ != null) {
        _single_timeZone_codec.WriteTagAndValue(ref output, TimeZone);
      }
      if (testAccount_ != null) {
        _single_testAccount_codec.WriteTagAndValue(ref output, TestAccount);
      }
      if (manager_ != null) {
        _single_manager_codec.WriteTagAndValue(ref output, Manager);
      }
      if (descriptiveName_ != null) {
        _single_descriptiveName_codec.WriteTagAndValue(ref output, DescriptiveName);
      }
      if (currencyCode_ != null) {
        _single_currencyCode_codec.WriteTagAndValue(ref output, CurrencyCode);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(ref output, Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (clientCustomer_ != null) {
        size += _single_clientCustomer_codec.CalculateSizeWithTag(ClientCustomer);
      }
      if (hidden_ != null) {
        size += _single_hidden_codec.CalculateSizeWithTag(Hidden);
      }
      if (level_ != null) {
        size += _single_level_codec.CalculateSizeWithTag(Level);
      }
      if (timeZone_ != null) {
        size += _single_timeZone_codec.CalculateSizeWithTag(TimeZone);
      }
      if (testAccount_ != null) {
        size += _single_testAccount_codec.CalculateSizeWithTag(TestAccount);
      }
      if (manager_ != null) {
        size += _single_manager_codec.CalculateSizeWithTag(Manager);
      }
      if (descriptiveName_ != null) {
        size += _single_descriptiveName_codec.CalculateSizeWithTag(DescriptiveName);
      }
      if (currencyCode_ != null) {
        size += _single_currencyCode_codec.CalculateSizeWithTag(CurrencyCode);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerClient other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.clientCustomer_ != null) {
        if (clientCustomer_ == null || other.ClientCustomer != "") {
          ClientCustomer = other.ClientCustomer;
        }
      }
      if (other.hidden_ != null) {
        if (hidden_ == null || other.Hidden != false) {
          Hidden = other.Hidden;
        }
      }
      if (other.level_ != null) {
        if (level_ == null || other.Level != 0L) {
          Level = other.Level;
        }
      }
      if (other.timeZone_ != null) {
        if (timeZone_ == null || other.TimeZone != "") {
          TimeZone = other.TimeZone;
        }
      }
      if (other.testAccount_ != null) {
        if (testAccount_ == null || other.TestAccount != false) {
          TestAccount = other.TestAccount;
        }
      }
      if (other.manager_ != null) {
        if (manager_ == null || other.Manager != false) {
          Manager = other.Manager;
        }
      }
      if (other.descriptiveName_ != null) {
        if (descriptiveName_ == null || other.DescriptiveName != "") {
          DescriptiveName = other.DescriptiveName;
        }
      }
      if (other.currencyCode_ != null) {
        if (currencyCode_ == null || other.CurrencyCode != "") {
          CurrencyCode = other.CurrencyCode;
        }
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            string value = _single_clientCustomer_codec.Read(input);
            if (clientCustomer_ == null || value != "") {
              ClientCustomer = value;
            }
            break;
          }
          case 34: {
            bool? value = _single_hidden_codec.Read(input);
            if (hidden_ == null || value != false) {
              Hidden = value;
            }
            break;
          }
          case 42: {
            long? value = _single_level_codec.Read(input);
            if (level_ == null || value != 0L) {
              Level = value;
            }
            break;
          }
          case 50: {
            string value = _single_timeZone_codec.Read(input);
            if (timeZone_ == null || value != "") {
              TimeZone = value;
            }
            break;
          }
          case 58: {
            bool? value = _single_testAccount_codec.Read(input);
            if (testAccount_ == null || value != false) {
              TestAccount = value;
            }
            break;
          }
          case 66: {
            bool? value = _single_manager_codec.Read(input);
            if (manager_ == null || value != false) {
              Manager = value;
            }
            break;
          }
          case 74: {
            string value = _single_descriptiveName_codec.Read(input);
            if (descriptiveName_ == null || value != "") {
              DescriptiveName = value;
            }
            break;
          }
          case 82: {
            string value = _single_currencyCode_codec.Read(input);
            if (currencyCode_ == null || value != "") {
              CurrencyCode = value;
            }
            break;
          }
          case 90: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            string value = _single_clientCustomer_codec.Read(ref input);
            if (clientCustomer_ == null || value != "") {
              ClientCustomer = value;
            }
            break;
          }
          case 34: {
            bool? value = _single_hidden_codec.Read(ref input);
            if (hidden_ == null || value != false) {
              Hidden = value;
            }
            break;
          }
          case 42: {
            long? value = _single_level_codec.Read(ref input);
            if (level_ == null || value != 0L) {
              Level = value;
            }
            break;
          }
          case 50: {
            string value = _single_timeZone_codec.Read(ref input);
            if (timeZone_ == null || value != "") {
              TimeZone = value;
            }
            break;
          }
          case 58: {
            bool? value = _single_testAccount_codec.Read(ref input);
            if (testAccount_ == null || value != false) {
              TestAccount = value;
            }
            break;
          }
          case 66: {
            bool? value = _single_manager_codec.Read(ref input);
            if (manager_ == null || value != false) {
              Manager = value;
            }
            break;
          }
          case 74: {
            string value = _single_descriptiveName_codec.Read(ref input);
            if (descriptiveName_ == null || value != "") {
              DescriptiveName = value;
            }
            break;
          }
          case 82: {
            string value = _single_currencyCode_codec.Read(ref input);
            if (currencyCode_ == null || value != "") {
              CurrencyCode = value;
            }
            break;
          }
          case 90: {
            long? value = _single_id_codec.Read(ref input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
