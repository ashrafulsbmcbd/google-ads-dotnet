// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/customer_extension_setting_service.proto
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
  /// Service to manage customer extension settings.
  /// </summary>
  public static partial class CustomerExtensionSettingService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.CustomerExtensionSettingService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest> __Marshaller_google_ads_googleads_v5_services_GetCustomerExtensionSettingRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting> __Marshaller_google_ads_googleads_v5_resources_CustomerExtensionSetting = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest> __Marshaller_google_ads_googleads_v5_services_MutateCustomerExtensionSettingsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse> __Marshaller_google_ads_googleads_v5_services_MutateCustomerExtensionSettingsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting> __Method_GetCustomerExtensionSetting = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerExtensionSetting",
        __Marshaller_google_ads_googleads_v5_services_GetCustomerExtensionSettingRequest,
        __Marshaller_google_ads_googleads_v5_resources_CustomerExtensionSetting);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse> __Method_MutateCustomerExtensionSettings = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCustomerExtensionSettings",
        __Marshaller_google_ads_googleads_v5_services_MutateCustomerExtensionSettingsRequest,
        __Marshaller_google_ads_googleads_v5_services_MutateCustomerExtensionSettingsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.CustomerExtensionSettingServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerExtensionSettingService</summary>
    [grpc::BindServiceMethod(typeof(CustomerExtensionSettingService), "BindService")]
    public abstract partial class CustomerExtensionSettingServiceBase
    {
      /// <summary>
      /// Returns the requested customer extension setting in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting> GetCustomerExtensionSetting(global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes customer extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettings(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerExtensionSettingService</summary>
    public partial class CustomerExtensionSettingServiceClient : grpc::ClientBase<CustomerExtensionSettingServiceClient>
    {
      /// <summary>Creates a new client for CustomerExtensionSettingService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerExtensionSettingServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerExtensionSettingService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerExtensionSettingServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerExtensionSettingServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerExtensionSettingServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested customer extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting GetCustomerExtensionSetting(global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerExtensionSetting(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested customer extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting GetCustomerExtensionSetting(global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerExtensionSetting, null, options, request);
      }
      /// <summary>
      /// Returns the requested customer extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting> GetCustomerExtensionSettingAsync(global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerExtensionSettingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested customer extension setting in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting> GetCustomerExtensionSettingAsync(global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerExtensionSetting, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes customer extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse MutateCustomerExtensionSettings(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerExtensionSettings(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes customer extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse MutateCustomerExtensionSettings(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCustomerExtensionSettings, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes customer extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettingsAsync(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerExtensionSettingsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes customer extension settings. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettingsAsync(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCustomerExtensionSettings, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerExtensionSettingServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerExtensionSettingServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerExtensionSettingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerExtensionSetting, serviceImpl.GetCustomerExtensionSetting)
          .AddMethod(__Method_MutateCustomerExtensionSettings, serviceImpl.MutateCustomerExtensionSettings).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerExtensionSettingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerExtensionSetting, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetCustomerExtensionSettingRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerExtensionSetting>(serviceImpl.GetCustomerExtensionSetting));
      serviceBinder.AddMethod(__Method_MutateCustomerExtensionSettings, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerExtensionSettingsResponse>(serviceImpl.MutateCustomerExtensionSettings));
    }

  }
}
#endregion
