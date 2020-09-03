// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/hotel_group_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/hotel_group_view.proto</summary>
  public static partial class HotelGroupViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/hotel_group_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelGroupViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvaG90ZWxfZ3Jv",
            "dXBfdmlldy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3Vy",
            "Y2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvIr8BCg5Ib3RlbEdyb3VwVmlldxJGCg1yZXNvdXJjZV9uYW1lGAEgASgJ",
            "Qi/gQQP6QSkKJ2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Ib3RlbEdyb3Vw",
            "Vmlldzpl6kFiCidnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vSG90ZWxHcm91",
            "cFZpZXcSN2N1c3RvbWVycy97Y3VzdG9tZXJ9L2hvdGVsR3JvdXBWaWV3cy97",
            "aG90ZWxfZ3JvdXBfdmlld31CgAIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52Mi5yZXNvdXJjZXNCE0hvdGVsR3JvdXBWaWV3UHJvdG9QAVpKZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YyL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMi5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MlxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6UmVz",
            "b3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.HotelGroupView), global::Google.Ads.GoogleAds.V2.Resources.HotelGroupView.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A hotel group view.
  /// </summary>
  public sealed partial class HotelGroupView : pb::IMessage<HotelGroupView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HotelGroupView> _parser = new pb::MessageParser<HotelGroupView>(() => new HotelGroupView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HotelGroupView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.HotelGroupViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HotelGroupView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HotelGroupView(HotelGroupView other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HotelGroupView Clone() {
      return new HotelGroupView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the hotel group view.
    /// Hotel Group view resource names have the form:
    ///
    /// `customers/{customer_id}/hotelGroupViews/{ad_group_id}~{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HotelGroupView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HotelGroupView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HotelGroupView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
