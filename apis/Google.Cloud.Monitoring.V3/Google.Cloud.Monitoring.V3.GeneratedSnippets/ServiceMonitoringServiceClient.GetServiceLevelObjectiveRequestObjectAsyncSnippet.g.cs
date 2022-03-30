// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Monitoring.V3.Snippets
{
    // [START monitoring_v3_generated_ServiceMonitoringService_GetServiceLevelObjective_async]
    using Google.Cloud.Monitoring.V3;
    using System.Threading.Tasks;

    public sealed partial class GeneratedServiceMonitoringServiceClientSnippets
    {
        /// <summary>Snippet for GetServiceLevelObjectiveAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetServiceLevelObjectiveRequestObjectAsync()
        {
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                View = ServiceLevelObjective.Types.View.Unspecified,
            };
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.GetServiceLevelObjectiveAsync(request);
        }
    }
    // [END monitoring_v3_generated_ServiceMonitoringService_GetServiceLevelObjective_async]
}