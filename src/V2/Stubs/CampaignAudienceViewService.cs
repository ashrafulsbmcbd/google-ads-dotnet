// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/campaign_audience_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/services/campaign_audience_view_service.proto</summary>
  public static partial class CampaignAudienceViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/services/campaign_audience_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignAudienceViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9zZXJ2aWNlcy9jYW1wYWlnbl9h",
            "dWRpZW5jZV92aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYyLnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNv",
            "dXJjZXMvY2FtcGFpZ25fYXVkaWVuY2Vfdmlldy5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8i",
            "NwoeR2V0Q2FtcGFpZ25BdWRpZW5jZVZpZXdSZXF1ZXN0EhUKDXJlc291cmNl",
            "X25hbWUYASABKAkykgIKG0NhbXBhaWduQXVkaWVuY2VWaWV3U2VydmljZRLV",
            "AQoXR2V0Q2FtcGFpZ25BdWRpZW5jZVZpZXcSQC5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Mi5zZXJ2aWNlcy5HZXRDYW1wYWlnbkF1ZGllbmNlVmlld1JlcXVl",
            "c3QaNy5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5yZXNvdXJjZXMuQ2FtcGFp",
            "Z25BdWRpZW5jZVZpZXciP4LT5JMCORI3L3YyL3tyZXNvdXJjZV9uYW1lPWN1",
            "c3RvbWVycy8qL2NhbXBhaWduQXVkaWVuY2VWaWV3cy8qfRobykEYZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tQocCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjIuc2VydmljZXNCIENhbXBhaWduQXVkaWVuY2VWaWV3U2VydmljZVBy",
            "b3RvUAFaSGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92Mi9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYyLlNlcnZpY2VzygIgR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjJcU2VydmljZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMjo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Resources.CampaignAudienceViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.GetCampaignAudienceViewRequest), global::Google.Ads.GoogleAds.V2.Services.GetCampaignAudienceViewRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [CampaignAudienceViewService.GetCampaignAudienceView][google.ads.googleads.v2.services.CampaignAudienceViewService.GetCampaignAudienceView].
  /// </summary>
  public sealed partial class GetCampaignAudienceViewRequest : pb::IMessage<GetCampaignAudienceViewRequest> {
    private static readonly pb::MessageParser<GetCampaignAudienceViewRequest> _parser = new pb::MessageParser<GetCampaignAudienceViewRequest>(() => new GetCampaignAudienceViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCampaignAudienceViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.CampaignAudienceViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignAudienceViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignAudienceViewRequest(GetCampaignAudienceViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignAudienceViewRequest Clone() {
      return new GetCampaignAudienceViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the campaign audience view to fetch.
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
      return Equals(other as GetCampaignAudienceViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCampaignAudienceViewRequest other) {
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCampaignAudienceViewRequest other) {
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
    }

  }

  #endregion

}

#endregion Designer generated code
