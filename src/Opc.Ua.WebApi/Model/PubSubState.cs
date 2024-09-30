/*
 * OPC UA Web API
 *
 * Provides simple HTTPS based access to an OPC UA server.
 *
 * The version of the OpenAPI document: 1.05.4
 * Contact: office@opcfoundation.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Opc.Ua.WebApi.Client.OpenAPIDateConverter;

namespace Opc.Ua.WebApi.Model
{
    /// <summary>
    /// Defines PubSubState
    /// </summary>
    public enum PubSubState
    {
        /// <summary>
        /// Enum Disabled for value: 0
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Enum Paused for value: 1
        /// </summary>
        Paused = 1,

        /// <summary>
        /// Enum Operational for value: 2
        /// </summary>
        Operational = 2,

        /// <summary>
        /// Enum Error for value: 3
        /// </summary>
        Error = 3,

        /// <summary>
        /// Enum PreOperational for value: 4
        /// </summary>
        PreOperational = 4
    }

}
