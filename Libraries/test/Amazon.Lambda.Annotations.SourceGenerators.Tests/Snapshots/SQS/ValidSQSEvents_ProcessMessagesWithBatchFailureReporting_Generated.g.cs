// <auto-generated/>

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Amazon.Lambda.Core;

namespace TestServerlessApp.SQSEventExamples
{
    public class ValidSQSEvents_ProcessMessagesWithBatchFailureReporting_Generated
    {
        private readonly ValidSQSEvents validSQSEvents;
        private readonly Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer serializer;

        /// <summary>
        /// Default constructor. This constructor is used by Lambda to construct the instance. When invoked in a Lambda environment
        /// the AWS credentials will come from the IAM role associated with the function and the AWS region will be set to the
        /// region the Lambda function is executed in.
        /// </summary>
        public ValidSQSEvents_ProcessMessagesWithBatchFailureReporting_Generated()
        {
            SetExecutionEnvironment();
            validSQSEvents = new ValidSQSEvents();
            serializer = new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer();
        }

        /// <summary>
        /// The generated Lambda function handler for <see cref="ProcessMessagesWithBatchFailureReporting(Amazon.Lambda.SQSEvents.SQSEvent)"/>
        /// </summary>
        /// <param name="evnt">The request object that will be processed by the Lambda function handler.</param>
        /// <returns>Result of the Lambda function execution</returns>
        public async System.Threading.Tasks.Task<Amazon.Lambda.SQSEvents.SQSBatchResponse> ProcessMessagesWithBatchFailureReporting(Amazon.Lambda.SQSEvents.SQSEvent evnt)
        {
            return await validSQSEvents.ProcessMessagesWithBatchFailureReporting(evnt);
        }

        private static void SetExecutionEnvironment()
        {
            const string envName = "AWS_EXECUTION_ENV";

            var envValue = new StringBuilder();

            // If there is an existing execution environment variable add the annotations package as a suffix.
            if(!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(envName)))
            {
                envValue.Append($"{Environment.GetEnvironmentVariable(envName)}_");
            }

            envValue.Append("lib/amazon-lambda-annotations#{ANNOTATIONS_ASSEMBLY_VERSION}");

            Environment.SetEnvironmentVariable(envName, envValue.ToString());
        }
    }
}