// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/ad_group_ad_label_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V5.Services {
  /// <summary>
  /// Service to manage labels on ad group ads.
  /// </summary>
  public static partial class AdGroupAdLabelService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.AdGroupAdLabelService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest> __Marshaller_google_ads_googleads_v5_services_GetAdGroupAdLabelRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel> __Marshaller_google_ads_googleads_v5_resources_AdGroupAdLabel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest> __Marshaller_google_ads_googleads_v5_services_MutateAdGroupAdLabelsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse> __Marshaller_google_ads_googleads_v5_services_MutateAdGroupAdLabelsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest, global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel> __Method_GetAdGroupAdLabel = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest, global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroupAdLabel",
        __Marshaller_google_ads_googleads_v5_services_GetAdGroupAdLabelRequest,
        __Marshaller_google_ads_googleads_v5_resources_AdGroupAdLabel);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse> __Method_MutateAdGroupAdLabels = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroupAdLabels",
        __Marshaller_google_ads_googleads_v5_services_MutateAdGroupAdLabelsRequest,
        __Marshaller_google_ads_googleads_v5_services_MutateAdGroupAdLabelsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.AdGroupAdLabelServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupAdLabelService</summary>
    [grpc::BindServiceMethod(typeof(AdGroupAdLabelService), "BindService")]
    public abstract partial class AdGroupAdLabelServiceBase
    {
      /// <summary>
      /// Returns the requested ad group ad label in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel> GetAdGroupAdLabel(global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates and removes ad group ad labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabels(global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupAdLabelService</summary>
    public partial class AdGroupAdLabelServiceClient : grpc::ClientBase<AdGroupAdLabelServiceClient>
    {
      /// <summary>Creates a new client for AdGroupAdLabelService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupAdLabelServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupAdLabelService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupAdLabelServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupAdLabelServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupAdLabelServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad group ad label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel GetAdGroupAdLabel(global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupAdLabel(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group ad label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel GetAdGroupAdLabel(global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroupAdLabel, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad group ad label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel> GetAdGroupAdLabelAsync(global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupAdLabelAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group ad label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel> GetAdGroupAdLabelAsync(global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroupAdLabel, null, options, request);
      }
      /// <summary>
      /// Creates and removes ad group ad labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupAdLabels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes ad group ad labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroupAdLabels, null, options, request);
      }
      /// <summary>
      /// Creates and removes ad group ad labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupAdLabelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes ad group ad labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroupAdLabels, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupAdLabelServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupAdLabelServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupAdLabelServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroupAdLabel, serviceImpl.GetAdGroupAdLabel)
          .AddMethod(__Method_MutateAdGroupAdLabels, serviceImpl.MutateAdGroupAdLabels).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupAdLabelServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroupAdLabel, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetAdGroupAdLabelRequest, global::Google.Ads.GoogleAds.V5.Resources.AdGroupAdLabel>(serviceImpl.GetAdGroupAdLabel));
      serviceBinder.AddMethod(__Method_MutateAdGroupAdLabels, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateAdGroupAdLabelsResponse>(serviceImpl.MutateAdGroupAdLabels));
    }

  }
}
#endregion
