// <auto-generated/>

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Amazon.Lambda.Core;

namespace TestServerlessApp
{
    public class DynamicExample_DynamicReturn_Generated
    {
        private readonly DynamicExample dynamicExample;
        private readonly Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer serializer;

        /// <summary>
        /// Default constructor. This constructor is used by Lambda to construct the instance. When invoked in a Lambda environment
        /// the AWS credentials will come from the IAM role associated with the function and the AWS region will be set to the
        /// region the Lambda function is executed in.
        /// </summary>
        public DynamicExample_DynamicReturn_Generated()
        {
            SetExecutionEnvironment();
            dynamicExample = new DynamicExample();
            serializer = new Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer();
        }

        /// <summary>
        /// The generated Lambda function handler for <see cref="DynamicReturn(string, Amazon.Lambda.Core.ILambdaContext)"/>
        /// </summary>
        /// <param name="text">The request object that will be processed by the Lambda function handler.</param>
        /// <param name="__context__">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
        /// <returns>Result of the Lambda function execution</returns>
        public dynamic DynamicReturn(string text, Amazon.Lambda.Core.ILambdaContext __context__)
        {
            return dynamicExample.DynamicReturn(text, __context__);
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