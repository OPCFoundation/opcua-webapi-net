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
    ///  Class for testing TransferSubscriptionsRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TransferSubscriptionsRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TransferSubscriptionsRequest
        //private TransferSubscriptionsRequest instance;

        public TransferSubscriptionsRequestTests()
        {
            // TODO uncomment below to create an instance of TransferSubscriptionsRequest
            //instance = new TransferSubscriptionsRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransferSubscriptionsRequest
        /// </summary>
        [Fact]
        public void TransferSubscriptionsRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" TransferSubscriptionsRequest
            //Assert.IsType<TransferSubscriptionsRequest>(instance);
        }

        /// <summary>
        /// Test the property 'RequestHeader'
        /// </summary>
        [Fact]
        public void RequestHeaderTest()
        {
            // TODO unit test for the property 'RequestHeader'
        }

        /// <summary>
        /// Test the property 'SubscriptionIds'
        /// </summary>
        [Fact]
        public void SubscriptionIdsTest()
        {
            // TODO unit test for the property 'SubscriptionIds'
        }

        /// <summary>
        /// Test the property 'SendInitialValues'
        /// </summary>
        [Fact]
        public void SendInitialValuesTest()
        {
            // TODO unit test for the property 'SendInitialValues'
        }
    }
}
