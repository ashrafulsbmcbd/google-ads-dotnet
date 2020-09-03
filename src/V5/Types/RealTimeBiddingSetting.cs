// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/common/real_time_bidding_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/common/real_time_bidding_setting.proto</summary>
  public static partial class RealTimeBiddingSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/common/real_time_bidding_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RealTimeBiddingSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92NS9jb21tb24vcmVhbF90aW1lX2Jp",
            "ZGRpbmdfc2V0dGluZy5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUu",
            "Y29tbW9uGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIjgKFlJlYWxU",
            "aW1lQmlkZGluZ1NldHRpbmcSEwoGb3B0X2luGAIgASgISACIAQFCCQoHX29w",
            "dF9pbkL2AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY1LmNvbW1vbkIb",
            "UmVhbFRpbWVCaWRkaW5nU2V0dGluZ1Byb3RvUAFaRGdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NS9jb21t",
            "b247Y29tbW9uogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjUuQ29t",
            "bW9uygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjVcQ29tbW9u6gIiR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6VjU6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Common.RealTimeBiddingSetting), global::Google.Ads.GoogleAds.V5.Common.RealTimeBiddingSetting.Parser, new[]{ "OptIn" }, new[]{ "OptIn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Settings for Real-Time Bidding, a feature only available for campaigns
  /// targeting the Ad Exchange network.
  /// </summary>
  public sealed partial class RealTimeBiddingSetting : pb::IMessage<RealTimeBiddingSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RealTimeBiddingSetting> _parser = new pb::MessageParser<RealTimeBiddingSetting>(() => new RealTimeBiddingSetting());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RealTimeBiddingSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Common.RealTimeBiddingSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealTimeBiddingSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealTimeBiddingSetting(RealTimeBiddingSetting other) : this() {
      _hasBits0 = other._hasBits0;
      optIn_ = other.optIn_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealTimeBiddingSetting Clone() {
      return new RealTimeBiddingSetting(this);
    }

    /// <summary>Field number for the "opt_in" field.</summary>
    public const int OptInFieldNumber = 2;
    private bool optIn_;
    /// <summary>
    /// Whether the campaign is opted in to real-time bidding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool OptIn {
      get { if ((_hasBits0 & 1) != 0) { return optIn_; } else { return false; } }
      set {
        _hasBits0 |= 1;
        optIn_ = value;
      }
    }
    /// <summary>Gets whether the "opt_in" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasOptIn {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "opt_in" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOptIn() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RealTimeBiddingSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RealTimeBiddingSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OptIn != other.OptIn) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasOptIn) hash ^= OptIn.GetHashCode();
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
      if (HasOptIn) {
        output.WriteRawTag(16);
        output.WriteBool(OptIn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasOptIn) {
        output.WriteRawTag(16);
        output.WriteBool(OptIn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasOptIn) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RealTimeBiddingSetting other) {
      if (other == null) {
        return;
      }
      if (other.HasOptIn) {
        OptIn = other.OptIn;
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
          case 16: {
            OptIn = input.ReadBool();
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
          case 16: {
            OptIn = input.ReadBool();
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
