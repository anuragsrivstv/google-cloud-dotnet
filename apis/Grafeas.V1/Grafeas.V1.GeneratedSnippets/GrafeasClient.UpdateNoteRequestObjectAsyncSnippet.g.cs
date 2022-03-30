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

namespace GrafeasV1.Snippets
{
    // [START containeranalysis_v1_generated_Grafeas_UpdateNote_async]
    using Google.Protobuf.WellKnownTypes;
    using Grafeas.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGrafeasClientSnippets
    {
        /// <summary>Snippet for UpdateNoteAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateNoteRequestObjectAsync()
        {
            string endpoint = "";
            // Create client
            GrafeasClient grafeasClient = new GrafeasClientBuilder { Endpoint = endpoint }.Build();
            // Initialize request argument(s)
            UpdateNoteRequest request = new UpdateNoteRequest
            {
                NoteName = NoteName.FromProjectNote("[PROJECT]", "[NOTE]"),
                Note = new Note(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Note response = await grafeasClient.UpdateNoteAsync(request);
        }
    }
    // [END containeranalysis_v1_generated_Grafeas_UpdateNote_async]
}