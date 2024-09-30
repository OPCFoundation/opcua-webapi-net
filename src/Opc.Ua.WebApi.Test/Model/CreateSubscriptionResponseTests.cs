/*
 * OPC UA Web API
 *
 * This API provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Opc.Ua.WebApi.Model;
using Opc.Ua.WebApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Opc.Ua.WebApi.Test.Model
{
    /// <summary>
    ///  Class for testing CreateSubscriptionResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateSubscriptionResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateSubscriptionResponse
        //private CreateSubscriptionResponse instance;

        public CreateSubscriptionResponseTests()
        {
            // TODO uncomment below to create an instance of CreateSubscriptionResponse
            //instance = new CreateSubscriptionResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateSubscriptionResponse
        /// </summary>
        [Fact]
        public void CreateSubscriptionResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateSubscriptionResponse
            //Assert.IsType<CreateSubscriptionResponse>(instance);
        }

        /// <summary>
        /// Test the property 'ResponseHeader'
        /// </summary>
        [Fact]
        public void ResponseHeaderTest()
        {
            // TODO unit test for the property 'ResponseHeader'
        }

        /// <summary>
        /// Test the property 'SubscriptionId'
        /// </summary>
        [Fact]
        public void SubscriptionIdTest()
        {
            // TODO unit test for the property 'SubscriptionId'
        }

        /// <summary>
        /// Test the property 'RevisedPublishingInterval'
        /// </summary>
        [Fact]
        public void RevisedPublishingIntervalTest()
        {
            // TODO unit test for the property 'RevisedPublishingInterval'
        }

        /// <summary>
        /// Test the property 'RevisedLifetimeCount'
        /// </summary>
        [Fact]
        public void RevisedLifetimeCountTest()
        {
            // TODO unit test for the property 'RevisedLifetimeCount'
        }

        /// <summary>
        /// Test the property 'RevisedMaxKeepAliveCount'
        /// </summary>
        [Fact]
        public void RevisedMaxKeepAliveCountTest()
        {
            // TODO unit test for the property 'RevisedMaxKeepAliveCount'
        }
    }
}
