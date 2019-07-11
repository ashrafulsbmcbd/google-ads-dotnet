// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/common/feed_common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/common/feed_common.proto</summary>
  public static partial class FeedCommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/common/feed_common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedCommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9jb21tb24vZmVlZF9jb21tb24u",
            "cHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmNvbW1vbhoeZ29vZ2xl",
            "L3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvInAKBU1vbmV5EjMKDWN1cnJlbmN5X2NvZGUYASABKAsyHC5n",
            "b29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSMgoNYW1vdW50X21pY3JvcxgC",
            "IAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQuoBCiJjb20uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjIuY29tbW9uQg9GZWVkQ29tbW9uUHJvdG9Q",
            "AVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YyL2NvbW1vbjtjb21tb26iAgNHQUGqAh5Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMi5Db21tb27KAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MlxDb21tb27qAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6Q29tbW9u",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Common.Money), global::Google.Ads.GoogleAds.V2.Common.Money.Parser, new[]{ "CurrencyCode", "AmountMicros" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a price in a particular currency.
  /// </summary>
  public sealed partial class Money : pb::IMessage<Money> {
    private static readonly pb::MessageParser<Money> _parser = new pb::MessageParser<Money>(() => new Money());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Money> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Common.FeedCommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Money() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Money(Money other) : this() {
      CurrencyCode = other.CurrencyCode;
      AmountMicros = other.AmountMicros;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Money Clone() {
      return new Money(this);
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_currencyCode_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string currencyCode_;
    /// <summary>
    /// Three-character ISO 4217 currency code.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = value;
      }
    }


    /// <summary>Field number for the "amount_micros" field.</summary>
    public const int AmountMicrosFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_amountMicros_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? amountMicros_;
    /// <summary>
    /// Amount in micros. One million is equivalent to one unit.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? AmountMicros {
      get { return amountMicros_; }
      set {
        amountMicros_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Money);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Money other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrencyCode != other.CurrencyCode) return false;
      if (AmountMicros != other.AmountMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (currencyCode_ != null) hash ^= CurrencyCode.GetHashCode();
      if (amountMicros_ != null) hash ^= AmountMicros.GetHashCode();
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
      if (currencyCode_ != null) {
        _single_currencyCode_codec.WriteTagAndValue(output, CurrencyCode);
      }
      if (amountMicros_ != null) {
        _single_amountMicros_codec.WriteTagAndValue(output, AmountMicros);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (currencyCode_ != null) {
        size += _single_currencyCode_codec.CalculateSizeWithTag(CurrencyCode);
      }
      if (amountMicros_ != null) {
        size += _single_amountMicros_codec.CalculateSizeWithTag(AmountMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Money other) {
      if (other == null) {
        return;
      }
      if (other.currencyCode_ != null) {
        if (currencyCode_ == null || other.CurrencyCode != "") {
          CurrencyCode = other.CurrencyCode;
        }
      }
      if (other.amountMicros_ != null) {
        if (amountMicros_ == null || other.AmountMicros != 0L) {
          AmountMicros = other.AmountMicros;
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
            string value = _single_currencyCode_codec.Read(input);
            if (currencyCode_ == null || value != "") {
              CurrencyCode = value;
            }
            break;
          }
          case 18: {
            long? value = _single_amountMicros_codec.Read(input);
            if (amountMicros_ == null || value != 0L) {
              AmountMicros = value;
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
