// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/common/url_collection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/common/url_collection.proto</summary>
  public static partial class UrlCollectionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/common/url_collection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UrlCollectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92My9jb21tb24vdXJsX2NvbGxlY3Rp",
            "b24ucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmNvbW1vbhoeZ29v",
            "Z2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90",
            "YXRpb25zLnByb3RvIvABCg1VcmxDb2xsZWN0aW9uEjcKEXVybF9jb2xsZWN0",
            "aW9uX2lkGAEgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEjAK",
            "CmZpbmFsX3VybHMYAiADKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFs",
            "dWUSNwoRZmluYWxfbW9iaWxlX3VybHMYAyADKAsyHC5nb29nbGUucHJvdG9i",
            "dWYuU3RyaW5nVmFsdWUSOwoVdHJhY2tpbmdfdXJsX3RlbXBsYXRlGAQgASgL",
            "MhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQu0BCiJjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjMuY29tbW9uQhJVcmxDb2xsZWN0aW9uUHJvdG9Q",
            "AVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YzL2NvbW1vbjtjb21tb26iAgNHQUGqAh5Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMy5Db21tb27KAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "M1xDb21tb27qAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6Q29tbW9u",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.UrlCollection), global::Google.Ads.GoogleAds.V3.Common.UrlCollection.Parser, new[]{ "UrlCollectionId", "FinalUrls", "FinalMobileUrls", "TrackingUrlTemplate" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Collection of urls that is tagged with a unique identifier.
  /// </summary>
  public sealed partial class UrlCollection : pb::IMessage<UrlCollection>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UrlCollection> _parser = new pb::MessageParser<UrlCollection>(() => new UrlCollection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UrlCollection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.UrlCollectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UrlCollection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UrlCollection(UrlCollection other) : this() {
      UrlCollectionId = other.UrlCollectionId;
      finalUrls_ = other.finalUrls_.Clone();
      finalMobileUrls_ = other.finalMobileUrls_.Clone();
      TrackingUrlTemplate = other.TrackingUrlTemplate;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UrlCollection Clone() {
      return new UrlCollection(this);
    }

    /// <summary>Field number for the "url_collection_id" field.</summary>
    public const int UrlCollectionIdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_urlCollectionId_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string urlCollectionId_;
    /// <summary>
    /// Unique identifier for this UrlCollection instance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UrlCollectionId {
      get { return urlCollectionId_; }
      set {
        urlCollectionId_ = value;
      }
    }


    /// <summary>Field number for the "final_urls" field.</summary>
    public const int FinalUrlsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_finalUrls_codec
        = pb::FieldCodec.ForClassWrapper<string>(18);
    private readonly pbc::RepeatedField<string> finalUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of possible final URLs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FinalUrls {
      get { return finalUrls_; }
    }

    /// <summary>Field number for the "final_mobile_urls" field.</summary>
    public const int FinalMobileUrlsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_finalMobileUrls_codec
        = pb::FieldCodec.ForClassWrapper<string>(26);
    private readonly pbc::RepeatedField<string> finalMobileUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of possible final mobile URLs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> FinalMobileUrls {
      get { return finalMobileUrls_; }
    }

    /// <summary>Field number for the "tracking_url_template" field.</summary>
    public const int TrackingUrlTemplateFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_trackingUrlTemplate_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string trackingUrlTemplate_;
    /// <summary>
    /// URL template for constructing a tracking URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TrackingUrlTemplate {
      get { return trackingUrlTemplate_; }
      set {
        trackingUrlTemplate_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UrlCollection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UrlCollection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UrlCollectionId != other.UrlCollectionId) return false;
      if(!finalUrls_.Equals(other.finalUrls_)) return false;
      if(!finalMobileUrls_.Equals(other.finalMobileUrls_)) return false;
      if (TrackingUrlTemplate != other.TrackingUrlTemplate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (urlCollectionId_ != null) hash ^= UrlCollectionId.GetHashCode();
      hash ^= finalUrls_.GetHashCode();
      hash ^= finalMobileUrls_.GetHashCode();
      if (trackingUrlTemplate_ != null) hash ^= TrackingUrlTemplate.GetHashCode();
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
      if (urlCollectionId_ != null) {
        _single_urlCollectionId_codec.WriteTagAndValue(output, UrlCollectionId);
      }
      finalUrls_.WriteTo(output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(output, _repeated_finalMobileUrls_codec);
      if (trackingUrlTemplate_ != null) {
        _single_trackingUrlTemplate_codec.WriteTagAndValue(output, TrackingUrlTemplate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (urlCollectionId_ != null) {
        _single_urlCollectionId_codec.WriteTagAndValue(ref output, UrlCollectionId);
      }
      finalUrls_.WriteTo(ref output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(ref output, _repeated_finalMobileUrls_codec);
      if (trackingUrlTemplate_ != null) {
        _single_trackingUrlTemplate_codec.WriteTagAndValue(ref output, TrackingUrlTemplate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (urlCollectionId_ != null) {
        size += _single_urlCollectionId_codec.CalculateSizeWithTag(UrlCollectionId);
      }
      size += finalUrls_.CalculateSize(_repeated_finalUrls_codec);
      size += finalMobileUrls_.CalculateSize(_repeated_finalMobileUrls_codec);
      if (trackingUrlTemplate_ != null) {
        size += _single_trackingUrlTemplate_codec.CalculateSizeWithTag(TrackingUrlTemplate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UrlCollection other) {
      if (other == null) {
        return;
      }
      if (other.urlCollectionId_ != null) {
        if (urlCollectionId_ == null || other.UrlCollectionId != "") {
          UrlCollectionId = other.UrlCollectionId;
        }
      }
      finalUrls_.Add(other.finalUrls_);
      finalMobileUrls_.Add(other.finalMobileUrls_);
      if (other.trackingUrlTemplate_ != null) {
        if (trackingUrlTemplate_ == null || other.TrackingUrlTemplate != "") {
          TrackingUrlTemplate = other.TrackingUrlTemplate;
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
            string value = _single_urlCollectionId_codec.Read(input);
            if (urlCollectionId_ == null || value != "") {
              UrlCollectionId = value;
            }
            break;
          }
          case 18: {
            finalUrls_.AddEntriesFrom(input, _repeated_finalUrls_codec);
            break;
          }
          case 26: {
            finalMobileUrls_.AddEntriesFrom(input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 34: {
            string value = _single_trackingUrlTemplate_codec.Read(input);
            if (trackingUrlTemplate_ == null || value != "") {
              TrackingUrlTemplate = value;
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
            string value = _single_urlCollectionId_codec.Read(ref input);
            if (urlCollectionId_ == null || value != "") {
              UrlCollectionId = value;
            }
            break;
          }
          case 18: {
            finalUrls_.AddEntriesFrom(ref input, _repeated_finalUrls_codec);
            break;
          }
          case 26: {
            finalMobileUrls_.AddEntriesFrom(ref input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 34: {
            string value = _single_trackingUrlTemplate_codec.Read(ref input);
            if (trackingUrlTemplate_ == null || value != "") {
              TrackingUrlTemplate = value;
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
