// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/ad_schedule_view_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
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
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V2.Services {
  /// <summary>
  /// Service to fetch ad schedule views.
  /// </summary>
  public static partial class AdScheduleViewService
  {
    static readonly string __ServiceName = "google.ads.googleads.v2.services.AdScheduleViewService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest> __Marshaller_google_ads_googleads_v2_services_GetAdScheduleViewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView> __Marshaller_google_ads_googleads_v2_resources_AdScheduleView = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest, global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView> __Method_GetAdScheduleView = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest, global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdScheduleView",
        __Marshaller_google_ads_googleads_v2_services_GetAdScheduleViewRequest,
        __Marshaller_google_ads_googleads_v2_resources_AdScheduleView);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V2.Services.AdScheduleViewServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdScheduleViewService</summary>
    public abstract partial class AdScheduleViewServiceBase
    {
      /// <summary>
      /// Returns the requested ad schedule view in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView> GetAdScheduleView(global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdScheduleViewService</summary>
    public partial class AdScheduleViewServiceClient : grpc::ClientBase<AdScheduleViewServiceClient>
    {
      /// <summary>Creates a new client for AdScheduleViewService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdScheduleViewServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdScheduleViewService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdScheduleViewServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdScheduleViewServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdScheduleViewServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad schedule view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView GetAdScheduleView(global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdScheduleView(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad schedule view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView GetAdScheduleView(global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdScheduleView, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad schedule view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView> GetAdScheduleViewAsync(global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdScheduleViewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad schedule view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.AdScheduleView> GetAdScheduleViewAsync(global::Google.Ads.GoogleAds.V2.Services.GetAdScheduleViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdScheduleView, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdScheduleViewServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdScheduleViewServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdScheduleViewServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdScheduleView, serviceImpl.GetAdScheduleView).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdScheduleViewServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdScheduleView, serviceImpl.GetAdScheduleView);
    }

  }
}
#endregion
