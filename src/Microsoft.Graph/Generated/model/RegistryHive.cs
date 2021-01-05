// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RegistryHive.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RegistryHive
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Current Config
        /// </summary>
        CurrentConfig = 1,
	
        /// <summary>
        /// Current User
        /// </summary>
        CurrentUser = 2,
	
        /// <summary>
        /// Local Machine Sam
        /// </summary>
        LocalMachineSam = 3,
	
        /// <summary>
        /// Local Machine Security
        /// </summary>
        LocalMachineSecurity = 4,
	
        /// <summary>
        /// Local Machine Software
        /// </summary>
        LocalMachineSoftware = 5,
	
        /// <summary>
        /// Local Machine System
        /// </summary>
        LocalMachineSystem = 6,
	
        /// <summary>
        /// Users Default
        /// </summary>
        UsersDefault = 7,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
