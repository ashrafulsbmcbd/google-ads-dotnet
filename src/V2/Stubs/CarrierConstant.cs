// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/carrier_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/carrier_constant.proto</summary>
  public static partial class CarrierConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/carrier_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CarrierConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvY2Fycmllcl9j",
            "b25zdGFudC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3Vy",
            "Y2VzGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9h",
            "cGkvYW5ub3RhdGlvbnMucHJvdG8isQEKD0NhcnJpZXJDb25zdGFudBIVCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJEicKAmlkGAIgASgLMhsuZ29vZ2xlLnByb3Rv",
            "YnVmLkludDY0VmFsdWUSKgoEbmFtZRgDIAEoCzIcLmdvb2dsZS5wcm90b2J1",
            "Zi5TdHJpbmdWYWx1ZRIyCgxjb3VudHJ5X2NvZGUYBCABKAsyHC5nb29nbGUu",
            "cHJvdG9idWYuU3RyaW5nVmFsdWVCgQIKJWNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Mi5yZXNvdXJjZXNCFENhcnJpZXJDb25zdGFudFByb3RvUAFaSmdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92Mi9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjIuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjJcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6",
            "OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.CarrierConstant), global::Google.Ads.GoogleAds.V2.Resources.CarrierConstant.Parser, new[]{ "ResourceName", "Id", "Name", "CountryCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A carrier criterion that can be used in campaign targeting.
  /// </summary>
  public sealed partial class CarrierConstant : pb::IMessage<CarrierConstant> {
    private static readonly pb::MessageParser<CarrierConstant> _parser = new pb::MessageParser<CarrierConstant>(() => new CarrierConstant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CarrierConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.CarrierConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrierConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrierConstant(CarrierConstant other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      Name = other.Name;
      CountryCode = other.CountryCode;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CarrierConstant Clone() {
      return new CarrierConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the carrier criterion.
    /// Carrier criterion resource names have the form:
    ///
    /// `carrierConstants/{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? id_;
    /// <summary>
    /// The ID of the carrier criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string name_;
    /// <summary>
    /// The full name of the carrier in English.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_countryCode_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string countryCode_;
    /// <summary>
    /// The country code of the country where the carrier is located, e.g., "AR",
    /// "FR", etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CountryCode {
      get { return countryCode_; }
      set {
        countryCode_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CarrierConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CarrierConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (CountryCode != other.CountryCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (countryCode_ != null) hash ^= CountryCode.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (countryCode_ != null) {
        _single_countryCode_codec.WriteTagAndValue(output, CountryCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (countryCode_ != null) {
        size += _single_countryCode_codec.CalculateSizeWithTag(CountryCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CarrierConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.countryCode_ != null) {
        if (countryCode_ == null || other.CountryCode != "") {
          CountryCode = other.CountryCode;
        }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 26: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 34: {
            string value = _single_countryCode_codec.Read(input);
            if (countryCode_ == null || value != "") {
              CountryCode = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
