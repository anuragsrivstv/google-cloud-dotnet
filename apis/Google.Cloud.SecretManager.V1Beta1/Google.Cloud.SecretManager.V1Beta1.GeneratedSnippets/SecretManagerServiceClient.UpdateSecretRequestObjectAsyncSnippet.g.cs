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

namespace Google.Cloud.SecretManager.V1Beta1.Snippets
{
    // [START secretmanager_v1beta1_generated_SecretManagerService_UpdateSecret_async]
    using Google.Cloud.SecretManager.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecretManagerServiceClientSnippets
    {
        /// <summary>Snippet for UpdateSecretAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateSecretRequestObjectAsync()
        {
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Secret response = await secretManagerServiceClient.UpdateSecretAsync(request);
        }
    }
    // [END secretmanager_v1beta1_generated_SecretManagerService_UpdateSecret_async]
}