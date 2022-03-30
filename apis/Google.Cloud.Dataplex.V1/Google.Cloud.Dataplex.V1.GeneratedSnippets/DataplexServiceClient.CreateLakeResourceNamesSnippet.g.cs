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

namespace Google.Cloud.Dataplex.V1.Snippets
{
    // [START dataplex_v1_generated_DataplexService_CreateLake_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Dataplex.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedDataplexServiceClientSnippets
    {
        /// <summary>Snippet for CreateLake</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateLakeResourceNames()
        {
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Lake lake = new Lake();
            string lakeId = "";
            // Make the request
            Operation<Lake, OperationMetadata> response = dataplexServiceClient.CreateLake(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataplex_v1_generated_DataplexService_CreateLake_sync_flattened_resourceNames]
}