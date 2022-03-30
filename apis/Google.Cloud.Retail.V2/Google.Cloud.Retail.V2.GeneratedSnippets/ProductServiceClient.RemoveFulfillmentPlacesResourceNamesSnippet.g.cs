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

namespace Google.Cloud.Retail.V2.Snippets
{
    // [START retail_v2_generated_ProductService_RemoveFulfillmentPlaces_sync_flattened_resourceNames]
    using Google.Cloud.Retail.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedProductServiceClientSnippets
    {
        /// <summary>Snippet for RemoveFulfillmentPlaces</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void RemoveFulfillmentPlacesResourceNames()
        {
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> response = productServiceClient.RemoveFulfillmentPlaces(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveFulfillmentPlaces(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END retail_v2_generated_ProductService_RemoveFulfillmentPlaces_sync_flattened_resourceNames]
}