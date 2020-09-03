// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/common/final_app_url.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/common/final_app_url.proto</summary>
  public static partial class FinalAppUrlReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/common/final_app_url.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinalAppUrlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9jb21tb24vZmluYWxfYXBwX3Vy",
            "bC5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuY29tbW9uGkFnb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9hcHBfdXJsX29wZXJhdGluZ19z",
            "eXN0ZW1fdHlwZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqEBCgtGaW5hbEFw",
            "cFVybBJnCgdvc190eXBlGAEgASgOMlYuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djQuZW51bXMuQXBwVXJsT3BlcmF0aW5nU3lzdGVtVHlwZUVudW0uQXBwVXJs",
            "T3BlcmF0aW5nU3lzdGVtVHlwZRIpCgN1cmwYAiABKAsyHC5nb29nbGUucHJv",
            "dG9idWYuU3RyaW5nVmFsdWVC6wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52NC5jb21tb25CEEZpbmFsQXBwVXJsUHJvdG9QAVpEZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2Nv",
            "bW1vbjtjb21tb26iAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5D",
            "b21tb27KAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxDb21tb27qAiJHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6Q29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Common.FinalAppUrl), global::Google.Ads.GoogleAds.V4.Common.FinalAppUrl.Parser, new[]{ "OsType", "Url" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A URL for deep linking into an app for the given operating system.
  /// </summary>
  public sealed partial class FinalAppUrl : pb::IMessage<FinalAppUrl>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinalAppUrl> _parser = new pb::MessageParser<FinalAppUrl>(() => new FinalAppUrl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FinalAppUrl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Common.FinalAppUrlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FinalAppUrl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FinalAppUrl(FinalAppUrl other) : this() {
      osType_ = other.osType_;
      Url = other.Url;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FinalAppUrl Clone() {
      return new FinalAppUrl(this);
    }

    /// <summary>Field number for the "os_type" field.</summary>
    public const int OsTypeFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType osType_ = global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified;
    /// <summary>
    /// The operating system targeted by this URL. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType OsType {
      get { return osType_; }
      set {
        osType_ = value;
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_url_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string url_;
    /// <summary>
    /// The app deep link URL. Deep links specify a location in an app that
    /// corresponds to the content you'd like to show, and should be of the form
    /// {scheme}://{host_path}
    /// The scheme identifies which app to open. For your app, you can use a custom
    /// scheme that starts with the app's name. The host and path specify the
    /// unique location in the app where your content exists.
    /// Example: "exampleapp://productid_1234". Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FinalAppUrl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FinalAppUrl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OsType != other.OsType) return false;
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OsType != global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) hash ^= OsType.GetHashCode();
      if (url_ != null) hash ^= Url.GetHashCode();
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
      if (OsType != global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OsType);
      }
      if (url_ != null) {
        _single_url_codec.WriteTagAndValue(output, Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OsType != global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OsType);
      }
      if (url_ != null) {
        _single_url_codec.WriteTagAndValue(ref output, Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OsType != global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OsType);
      }
      if (url_ != null) {
        size += _single_url_codec.CalculateSizeWithTag(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FinalAppUrl other) {
      if (other == null) {
        return;
      }
      if (other.OsType != global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType.Unspecified) {
        OsType = other.OsType;
      }
      if (other.url_ != null) {
        if (url_ == null || other.Url != "") {
          Url = other.Url;
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
          case 8: {
            OsType = (global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType) input.ReadEnum();
            break;
          }
          case 18: {
            string value = _single_url_codec.Read(input);
            if (url_ == null || value != "") {
              Url = value;
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
          case 8: {
            OsType = (global::Google.Ads.GoogleAds.V4.Enums.AppUrlOperatingSystemTypeEnum.Types.AppUrlOperatingSystemType) input.ReadEnum();
            break;
          }
          case 18: {
            string value = _single_url_codec.Read(ref input);
            if (url_ == null || value != "") {
              Url = value;
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
