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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    // [START dialogflow_v2_generated_ConversationModels_CreateConversationModelEvaluation_sync]
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedConversationModelsClientSnippets
    {
        /// <summary>Snippet for CreateConversationModelEvaluation</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateConversationModelEvaluationRequestObject()
        {
            // Create client
            ConversationModelsClient conversationModelsClient = ConversationModelsClient.Create();
            // Initialize request argument(s)
            CreateConversationModelEvaluationRequest request = new CreateConversationModelEvaluationRequest
            {
                ParentAsConversationModelName = ConversationModelName.FromProjectLocationConversationModel("[PROJECT]", "[LOCATION]", "[CONVERSATION_MODEL]"),
                ConversationModelEvaluation = new ConversationModelEvaluation(),
            };
            // Make the request
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> response = conversationModelsClient.CreateConversationModelEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationModelEvaluation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationModelEvaluation, CreateConversationModelEvaluationOperationMetadata> retrievedResponse = conversationModelsClient.PollOnceCreateConversationModelEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationModelEvaluation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v2_generated_ConversationModels_CreateConversationModelEvaluation_sync]
}